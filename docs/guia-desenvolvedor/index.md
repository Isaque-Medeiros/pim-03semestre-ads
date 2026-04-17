# Guia do Desenvolvedor BSFM

Bem-vindo ao Guia do Desenvolvedor do **BSFM (Brazilian System of Food Metric)**. Esta documentação fornece informações técnicas detalhadas sobre a arquitetura, tecnologias, APIs e processos de desenvolvimento da plataforma.

---

## Arquitetura do Sistema

### Visão Geral da Arquitetura

O BSFM segue uma arquitetura moderna baseada em **.NET 8.0** com separação clara de responsabilidades:

```mermaid
graph TD
    A[Frontend Web] --> B[Backend .NET 8.0]
    B --> C[PostgreSQL]
    B --> D[YOLO AI Service]
    B --> E[USDA API]
    B --> F[Brevo Email]
    C --> G[Railway Hosting]
```

### Stack Tecnológico Principal

#### Backend (.NET 8.0)
- **Framework:** ASP.NET Core 8.0
- **Banco de Dados:** PostgreSQL (Produção) + SQLite (Desenvolvimento)
- **ORM:** Entity Framework Core 8.0
- **Autenticação:** BCrypt.Net-Next para hash de senhas
- **Email:** MailKit + MimeKit + Brevo API
- **IA:** YoloDotNet + ONNX Runtime

#### Frontend
- **Framework CSS:** Tailwind CSS 3.0
- **Fontes:** Google Fonts (Inter + Outfit)
- **Ícones:** Font Awesome 6.4.0
- **Design System:** Glassmorphism + Gradients

#### APIs Externas Integradas
- **USDA FoodData Central API** - Dados nutricionais
- **Brevo API** - Serviços de email transacional
- **YOLO Object Detection** - Reconhecimento de alimentos

---

## Setup Local

### Pré-requisitos

1. **.NET 8.0 SDK** - [Download oficial](https://dotnet.microsoft.com/download)
2. **PostgreSQL 15+** ou **SQLite** para desenvolvimento
3. **Visual Studio 2022** ou **VS Code** com extensão C#
4. **Git** para controle de versão

### Configuração do Ambiente

```bash
# 1. Clone o repositório
git clone https://github.com/BSFM/Brazilian-System-of-Food-Metric.git
cd Brazilian-System-of-Food-Metric

# 2. Restaure as dependências
dotnet restore

# 3. Configure variáveis de ambiente
# Crie um arquivo .env ou configure no sistema:
set USDA_API_KEY=sua_chave_aqui
set BREVO_API_KEY=sua_chave_aqui
set DATABASE_URL=postgresql://usuario:senha@localhost:5432/bsfm

# 4. Execute as migrations do banco de dados
dotnet ef database update

# 5. Execute a aplicação
dotnet run
```

### Estrutura do Projeto

```
MobileRepositorio/
├── Controllers/
│   ├── PlanoAlimentarController.cs
│   ├── UsuarioController.cs
│   └── AnaliseIAController.cs
├── Models/
│   ├── Usuario.cs
│   ├── AnaliseIA.cs
│   ├── bsfmv1_yolo_final.onnx
│   └── yolov10n.onnx
├── Services/
│   ├── LimpezaAnalisesServices.cs
│   ├── OcrNutricionalService.cs
│   ├── UsdaNutritionService.cs
│   └── YoloInferenceService.cs
├── wwwroot/
│   ├── analisador-ia.html
│   ├── dashboard.html
│   ├── diario.html
│   ├── hospitais.html
│   ├── index.html
│   ├── libras.html
│   ├── login.html
│   ├── metas.html
│   └── planos.html
├── ClassesBSFM.cs
├── PonteDB.cs
├── Program.cs
└── MeusApp.csproj
```

---

## Inteligência Artificial

### Modelo YOLO Customizado

O BSFM utiliza um modelo YOLO (You Only Look Once) customizado para detecção de alimentos:

```csharp
// Configuração do serviço de inferência
public class YoloInferenceService
{
    private readonly Yolo _yolo;
    
    public YoloInferenceService()
    {
        var modelPath = Path.Combine("Models", "bsfmv1_yolo_final.onnx");
        _yolo = new Yolo(modelPath);
    }
    
    public List<DetectionResult> AnalyzeImage(IFormFile image)
    {
        using var stream = image.OpenReadStream();
        var results = _yolo.Predict(stream);
        
        return results.Select(r => new DetectionResult
        {
            Label = r.Label,
            Confidence = r.Confidence,
            BoundingBox = r.BoundingBox
        }).ToList();
    }
}
```

### Sistema de Tradução

```csharp
// Dicionário com 452 alimentos traduzidos
public static readonly Dictionary<string, string> Tradutor = new Dictionary<string, string>
{
    { "almond", "amêndoa" },
    { "apple", "maçã" },
    { "beef", "carne bovina" },
    { "bread", "pão" },
    { "cheese", "queijo" },
    { "chicken", "frango" },
    { "egg", "ovo" },
    { "fish", "peixe" },
    { "milk", "leite" },
    { "rice", "arroz" },
    // ... 442 alimentos adicionais
};
```

### Fluxo de Análise Nutricional

1. **Upload da imagem** do prato pelo usuário
2. **Detecção YOLO** dos alimentos presentes
3. **Tradução EN → PT** dos alimentos identificados
4. **Consulta USDA API** para dados nutricionais
5. **Cálculo por porção** baseado no tamanho selecionado
6. **Persistência** no banco de dados PostgreSQL
7. **Retorno dos resultados** ao usuário

---

## Banco de Dados

### Modelo de Dados Principal

#### Tabela Usuarios
```sql
CREATE TABLE Usuarios (
    ID SERIAL PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Email VARCHAR(255) UNIQUE NOT NULL,
    SenhaHash VARCHAR(255) NOT NULL,
    Peso DECIMAL(5,2),
    Altura DECIMAL(4,2),
    IMC DECIMAL(4,2),
    TMB DECIMAL(7,2),
    GastoTotal DECIMAL(7,2),
    PesoMeta DECIMAL(5,2),
    DataCadastro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UltimoLogin TIMESTAMP,
    TermosAceitos BOOLEAN DEFAULT FALSE,
    VersaoTermos VARCHAR(20)
);
```

#### Tabela AnalisesIA
```sql
CREATE TABLE AnalisesIA (
    ID SERIAL PRIMARY KEY,
    UsuarioID INTEGER REFERENCES Usuarios(ID),
    Alimento VARCHAR(100) NOT NULL,
    Calorias DECIMAL(7,2),
    Proteinas DECIMAL(7,2),
    Carbos DECIMAL(7,2),
    Gorduras DECIMAL(7,2),
    Porcao VARCHAR(20),
    DataAnalise TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    ImagemURL TEXT
);
```

### Migrations com Entity Framework

```csharp
public class PonteDB : DbContext
{
    public PonteDB(DbContextOptions<PonteDB> options) : base(options) { }
    
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<AnaliseIA> AnalisesIA { get; set; }
    public DbSet<Historico> Historicos { get; set; }
    public DbSet<Hospital> Hospitais { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>()
            .HasIndex(u => u.Email)
            .IsUnique();
            
        modelBuilder.Entity<AnaliseIA>()
            .HasOne(a => a.Usuario)
            .WithMany(u => u.Analises)
            .HasForeignKey(a => a.UsuarioID);
    }
}
```

---

## API Reference

### Autenticação

#### `POST /solicitar-codigo`
Solicita código de verificação para cadastro.

**Request:**
```json
{
  "email": "usuario@exemplo.com"
}
```

**Response:**
```json
{
  "sucesso": true,
  "mensagem": "Código enviado para o email"
}
```

#### `POST /cadastrar-usuario-final`
Cadastra um novo usuário.

**Request:**
```json
{
  "nome": "João Silva",
  "email": "joao@exemplo.com",
  "senha": "SenhaSegura123",
  "codigo": "123456",
  "aceitaTermos": true
}
```

**Response:**
```json
{
  "sucesso": true,
  "usuario": {
    "id": 1,
    "nome": "João Silva",
    "email": "joao@exemplo.com"
  }
}
```

### Análise Nutricional

#### `POST /analisar-prato`
Analisa uma imagem de prato usando IA.

**Request (multipart/form-data):**
- `foto`: Arquivo de imagem (jpg, png)
- `porcao`: "pequeno", "medio", "grande"
- `usuarioId`: ID do usuário

**Response:**
```json
{
  "sucesso": true,
  "analise": {
    "id": 123,
    "alimentos": [
      {
        "nome": "arroz",
        "quantidade": "100g",
        "calorias": 130,
        "proteinas": 2.7,
        "carboidratos": 28.2,
        "gorduras": 0.3
      }
    ],
    "total": {
      "calorias": 130,
      "proteinas": 2.7,
      "carboidratos": 28.2,
      "gorduras": 0.3
    }
  }
}
```

#### `GET /historico-analises/{usuarioId}`
Retorna o histórico de análises do usuário.

**Response:**
```json
{
  "sucesso": true,
  "historico": [
    {
      "id": 123,
      "data": "2026-04-16T12:30:00Z",
      "alimentos": ["arroz", "feijão", "frango"],
      "caloriasTotais": 450
    }
  ]
}
```

---

## Segurança

### Hash de Senhas com BCrypt

```csharp
public class SegurancaService
{
    public string HashSenha(string senha)
    {
        return BCrypt.Net.BCrypt.HashPassword(senha);
    }
    
    public bool VerificarSenha(string senha, string hash)
    {
        return BCrypt.Net.BCrypt.Verify(senha, hash);
    }
}
```

### Configuração CORS

```csharp
// Program.cs
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirSite",
        builder => builder
            .WithOrigins("https://bsfm.com.br")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});
```

### Validação de Input

```csharp
public class UsuarioValidator : AbstractValidator<UsuarioDTO>
{
    public UsuarioValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email é obrigatório")
            .EmailAddress().WithMessage("Email inválido");
            
        RuleFor(x => x.Senha)
            .NotEmpty().WithMessage("Senha é obrigatória")
            .MinimumLength(8).WithMessage("Senha deve ter no mínimo 8 caracteres")
            .Matches("[A-Z]").WithMessage("Senha deve conter pelo menos uma letra maiúscula")
            .Matches("[0-9]").WithMessage("Senha deve conter pelo menos um número");
    }
}
```

---

## Deployment

### Plataforma: Railway

O BSFM é implantado na plataforma Railway com a seguinte configuração:

**railway.json:**
```json
{
  "build": {
    "builder": "NIXPACKS",
    "buildCommand": "dotnet publish -c Release -o output"
  },
  "deploy": {
    "startCommand": "dotnet MobileRepositorio.dll",
    "healthcheckPath": "/health",
    "port": 8080
  }
}
```

### Variáveis de Ambiente Necessárias

```bash
# Banco de dados
DATABASE_URL=postgresql://usuario:senha@servidor:5432/bsfm

# APIs externas
USDA_API_KEY=sua_chave_usda
BREVO_API_KEY=sua_chave_brevo

# Configuração da aplicação
ASPNETCORE_ENVIRONMENT=Production
ASPNETCORE_URLS=http://+:8080
```

### Health Check Endpoint

```csharp
[ApiController]
[Route("health")]
public class HealthController : ControllerBase
{
    private readonly PonteDB _db;
    
    public HealthController(PonteDB db)
    {
        _db = db;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            // Verifica conexão com banco
            await _db.Database.CanConnectAsync();
            
            return Ok(new 
            {
                status = "healthy",
                timestamp = DateTime.UtcNow,
                database = "connected"
            });
        }
        catch (Exception ex)
        {
            return StatusCode(503, new 
            {
                status = "unhealthy",
                error = ex.Message
            });
        }
    }
}
```

---

## Testes

### Estratégia de Testes

```csharp
// Testes unitários para serviços
[TestClass]
public class YoloInferenceServiceTests
{
    [TestMethod]
    public void AnalyzeImage_ValidImage_ReturnsDetections()
    {
        // Arrange
        var service = new YoloInferenceService();
        var mockImage = new Mock<IFormFile>();
        
        // Act
        var result = service.AnalyzeImage(mockImage.Object);
        
        // Assert
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Any());
    }
}

// Testes de integração para APIs
[TestClass]
public class AnaliseIAControllerTests
{
    [TestMethod]
    public async Task AnalisarPrato_ValidRequest_ReturnsAnalysis()
    {
        // Arrange
        var controller = new AnaliseIAController();
        var request = new AnaliseRequest { /* ... */ };
        
        // Act
        var result = await controller.AnalisarPrato(request);
        
        // Assert
        Assert.IsTrue(result.Sucesso);
        Assert.IsNotNull(result.Analise);
    }
}
```

### Cobertura de Testes

```bash
# Executar testes
dotnet test

# Gerar relatório de cobertura
dotnet test --collect:"XPlat Code Coverage"

# Ver cobertura no navegador
reportgenerator -reports:TestResults/**/coverage.cobertura.xml -targetdir:coveragereport -reporttypes:Html
```

---

## Contribuindo

### Processo de Contribuição

1. **Fork** o repositório
2. **Crie uma branch** para sua feature
   ```bash
   git checkout -b feature/nova-funcionalidade
   ```
3. **Commit** suas mudanças
   ```bash
   git commit -m "feat: adiciona nova funcionalidade"
   ```
4. **Push** para a branch
   ```bash
   git push origin feature/nova-funcionalidade
   ```
5. **Abra um Pull Request**

### Convenções de Código

#### Commits Semânticos
- `feat:` Nova funcionalidade
- `fix:` Correção de bug
- `docs:` Documentação
- `style:` Formatação de código
- `refactor:` Refatoração de código
- `test:` Testes
- `chore:` Tarefas de manutenção

#### Padrões de Código C#
```csharp
// Use async/await para operações I/O
public async Task<Usuario> GetUsuarioAsync(int id)
{
    return await _db.Usuarios.FindAsync(id);
}

// Use Dependency Injection
public class MeuService : IMeuService
{
    private readonly IOutroService _outroService;
    
    public MeuService(IOutroService outroService)
    {
        _outroService = outroService;
    }
}

// Tratamento de erros apropriado
try
{
    await ProcessarAnaliseAsync();
}
catch (Exception ex) when (ex is HttpRequestException)
{
    _logger.LogError(ex, "Erro na requisição HTTP");
    throw new AnaliseException("Falha na análise", ex);
}
```

---

## Monitoramento e Logs

### Configuração de Logs

```csharp
// Program.cs
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();
builder.Logging.AddEventLog();

// Configuração Serilog para produção
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Console()
    .WriteTo.File("logs/bsfm-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();
```

### Métricas de Performance

```csharp
public class PerformanceMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<PerformanceMiddleware> _logger;
    
   