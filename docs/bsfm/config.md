# Configuracao do Projeto

Esta pagina centraliza os parametros basicos para executar e manter o BSFM.

## Ambiente

Crie um arquivo de configuracao de desenvolvimento (ex.: `appsettings.Development.json`) com:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=bsfm_dev;Username=postgres;Password=postgres"
  },
  "ApiKeys": {
    "UsdaApiKey": "SUA_CHAVE_USDA",
    "BrevoApiKey": "SUA_CHAVE_BREVO"
  }
}
```

## Variaveis recomendadas

```bash
DATABASE_URL=Host=localhost;Database=bsfm_dev;Username=postgres;Password=postgres
USDA_API_KEY=...
BREVO_API_KEY=...
ASPNETCORE_ENVIRONMENT=Development
```

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
