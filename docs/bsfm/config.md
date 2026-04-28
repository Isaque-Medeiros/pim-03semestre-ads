# Configuracao do Projeto

Esta pagina centraliza os parametros basicos para executar e manter o BSFM.

## 🗄️ Configuracao do Banco de Dados

### Estrutura do Banco
O BSFM utiliza PostgreSQL com 7 tabelas principais:
- **Usuarios**: Dados dos usuários e métricas nutricionais
- **Refeicoes**: Catálogo de refeições completas
- **Comidas**: Alimentos individuais e seus valores nutricionais
- **CronogramaAlimentar**: Planos alimentares dos usuários
- **Hospitais**: Instituições de saúde parceiras
- **AnaliseIA**: Análises de alimentos realizadas por IA
- **HistoricoProgresso**: Evolução temporal dos usuários

### Configuracao de Desenvolvimento

Crie `appsettings.Development.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=bsfm_dev;Username=bsfm_user;Password=senha_segura"
  },
  "Database": {
    "Provider": "PostgreSQL",
    "Version": "15.0",
    "Timeout": 30,
    "Pooling": true,
    "MaxPoolSize": 100
  },
  "ApiKeys": {
    "UsdaApiKey": "SUA_CHAVE_USDA",
    "BrevoApiKey": "SUA_CHAVE_BREVO"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.EntityFrameworkCore.Database.Command": "Warning"
    }
  }
}
```

### Variaveis de Ambiente Recomendadas

```bash
# Banco de dados
DATABASE_URL=Host=localhost;Database=bsfm_dev;Username=bsfm_user;Password=senha_segura
DB_PROVIDER=PostgreSQL
DB_TIMEOUT=30

# APIs Externas
USDA_API_KEY=sua_chave_usda_aqui
BREVO_API_KEY=sua_chave_brevo_aqui

# Ambiente
ASPNETCORE_ENVIRONMENT=Development
ASPNETCORE_URLS=http://localhost:5000

# Logging
LOG_LEVEL=Information
DB_LOG_LEVEL=Warning
```

### Configuracao de Producao

Para produção, utilize variáveis de ambiente no Vercel/Railway:
- `DATABASE_URL`: Connection string do PostgreSQL
- `USDA_API_KEY`: Chave da API USDA FoodData Central
- `BREVO_API_KEY`: Chave da API Brevo (Sendinblue)
- `ASPNETCORE_ENVIRONMENT`: Production

## Configuracao de tema/documentacao

A documentacao MkDocs esta com:

- Tema escuro como padrao
- Tema claro opcional via toggle
- Paleta personalizada em vermelho, verde e laranja
- CSS principal em `docs/stylesheets/custom.css`
- Script de tema em `docs/js/custom.js`

## Configuracao de deploy

### Planejado inicialmente

- Railway para experimentos de infraestrutura.

### Definido como oficial

- Vercel para hospedagem final da camada web/documentacao.

## Boas praticas

- Nao commitar chaves reais.
- Usar `.env`/secrets no ambiente de deploy.
- Revisar configuracoes antes de cada release.
