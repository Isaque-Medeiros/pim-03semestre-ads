# Instalacao do BSFM

Este guia mostra como executar o projeto localmente e como publicar em ambiente de producao.

## Visao rapida

- Backend principal em `.NET 8`
- Frontend web servido com a aplicacao
- Banco de dados PostgreSQL
- Planejamento inicial de deploy no Railway
- Hospedagem definitiva no Vercel para a camada web/documentacao

## Pre-requisitos

- .NET SDK 8+
- Git
- PostgreSQL 15+ (ou SQLite em desenvolvimento)
- Node.js 18+ (opcional, para assets)

## Instalacao local

### 1. Clonar repositorio

```bash
git clone <url-do-repositorio>
cd pim-03semestre-ads
```

### 2. Restaurar dependencias

```bash
dotnet restore
```

### 3. Configurar banco de dados PostgreSQL

#### Opção A - Usando Docker (Recomendado)
```bash
# Criar container PostgreSQL
docker run -d --name bsfm-postgres \
  -p 5432:5432 \
  -e POSTGRES_DB=bsfm_dev \
  -e POSTGRES_USER=bsfm_user \
  -e POSTGRES_PASSWORD=senha_segura \
  -v bsfm-data:/var/lib/postgresql/data \
  postgres:15-alpine
```

#### Opção B - Instalação Manual
1. Instalar PostgreSQL 15+
2. Criar database e usuário:
```sql
CREATE DATABASE bsfm_dev;
CREATE USER bsfm_user WITH PASSWORD 'senha_segura';
GRANT ALL PRIVILEGES ON DATABASE bsfm_dev TO bsfm_user;
```

### 4. Configurar variaveis de ambiente

Crie um arquivo `.env` na raiz do projeto:
```ini
DATABASE_URL=Host=localhost;Database=bsfm_dev;Username=bsfm_user;Password=senha_segura
USDA_API_KEY=sua-chave-usda-aqui
BREVO_API_KEY=sua-chave-brevo-aqui
ASPNETCORE_ENVIRONMENT=Development
```

Ou configure via PowerShell:
```powershell
$env:DATABASE_URL = "Host=localhost;Database=bsfm_dev;Username=bsfm_user;Password=senha_segura"
$env:USDA_API_KEY = "sua-chave-usda"
$env:BREVO_API_KEY = "sua-chave-brevo"
$env:ASPNETCORE_ENVIRONMENT = "Development"
```

### 5. Aplicar migrações do banco

```bash
# Criar migração (se necessário)
dotnet ef migrations add InitialCreate

# Aplicar migração ao banco
dotnet ef database update

# Ou executar script SQL manualmente (ver database-schema.md)
psql -U bsfm_user -d bsfm_dev -f scripts/schema.sql
```

### 6. Executar aplicação

```bash
dotnet run
```

A aplicação estará disponível em: http://localhost:5000

### 5. Rodar projeto

```bash
dotnet watch run
```

## Deploy

### Historico de infraestrutura

- Railway foi usado no planejamento inicial e provas de conceito.
- Vercel e o destino definitivo para a publicacao da camada web/documentacao.

### Publicacao no Vercel (resumo)

1. Conectar repositorio ao Vercel.
2. Configurar variaveis de ambiente no painel.
3. Definir comando de build da parte web/documentacao.
4. Publicar em branch principal.

## Checklist

- [ ] Dependencias instaladas
- [ ] Banco conectado
- [ ] Variaveis configuradas
- [ ] Aplicacao local iniciando
- [ ] Pipeline de deploy validada no Vercel
