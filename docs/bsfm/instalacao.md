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

### 3. Configurar variaveis de ambiente

Exemplo de valores minimos:

```powershell
$env:DATABASE_URL = "Host=localhost;Database=bsfm_dev;Username=postgres;Password=postgres"
$env:USDA_API_KEY = "sua-chave-usda"
$env:BREVO_API_KEY = "sua-chave-brevo"
```

### 4. Aplicar banco

```bash
dotnet ef database update
```

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
