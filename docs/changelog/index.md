# Changelog BSFM

Este documento registra todas as mudanças significativas no **BSFM (Brazilian System of Food Metric)**. Seguimos o padrão [Keep a Changelog](https://keepachangelog.com/pt-BR/1.0.0/) e versionamento [Semantic Versioning](https://semver.org/lang/pt-BR/).

---

## [1.1.0] - 2026-04-08

### Versao Remasterizada (metodologia SDD)
**Refatoracao estrutural e melhoria do processo de desenvolvimento.**

### Novas Funcionalidades
- Organizacao da documentacao por secoes e navegacao revisada
- Padronizacao de fluxo de trabalho com metodologia SDD
- Evolucao do design system para tema claro/escuro

### Infraestrutura
- Railway mantido como referencia de planejamento inicial
- Vercel definido como hospedagem definitiva da camada web/documentacao

---

## [1.0.0] - 2026-03-20

### Lancamento da v1
**Primeira versao funcional publicada para validacao do projeto.**

### Base entregue
- Primeira experiencia de analise de alimentos por IA
- Estrutura inicial de dashboard e autenticacao
- Primeira publicacao tecnica da documentacao

---

## [1.0.1] - 2026-04-16

### Lançamento Oficial
**Primeira versão estável do BSFM disponível para o público geral!**

### Novas Funcionalidades
- **Análise de Alimentos por IA**
  - Detecção visual de 452 alimentos usando YOLO Object Detection
  - Tradução automática EN → PT para todos os alimentos
  - Análise nutricional completa por 100g e porções

- **Dashboard Personalizado**
  - Cálculo automático de IMC, TMB e Gasto Calórico
  - Gráficos de evolução histórica de peso/altura
  - Metas personalizadas com acompanhamento visual

- **Sistema de Usuários Completo**
  - Cadastro com verificação por email via Brevo API
  - Autenticação segura com BCrypt hashing
  - Redefinição de senha protegida
  - Aceitação de termos e políticas

- **Integração Hospitalar**
  - Diretório de hospitais parceiros com informações de contato
  - Mapa interativo com localização dos serviços de saúde
  - Filtros por especialidade e região

- **Cronograma Alimentar**
  - Planos alimentares personalizados por perfil metabólico
  - Refeições diárias programadas com lembretes
  - Acompanhamento nutricional semanal

### Melhorias Técnicas
- **Arquitetura .NET 8.0** com Entity Framework Core
- **Banco de dados PostgreSQL** com infraestrutura inicialmente planejada no Railway
- **Camada web/documentacao** direcionada para hospedagem definitiva no Vercel
- **APIs externas integradas:** USDA FoodData Central, Brevo Email
- **Frontend responsivo** com Tailwind CSS 3.0
- **Design system** com glassmorphism e gradientes

### Correções de Bugs
- Corrigido problema de encoding em nomes de alimentos com acentos
- Resolvido timeout em análises de imagens grandes
- Ajustada validação de emails duplicados no cadastro
- Corrigido cálculo de IMC para alturas em metros

### Documentação
- Documentação técnica completa disponível em MkDocs
- Guia do usuário com tutoriais passo a passo
- API reference com exemplos de requests/responses
- Guia do desenvolvedor com setup local e deployment

---

## [0.9.0] - 2026-03-15

### Beta Público
**Versão beta aberta para testes com usuários reais.**

### Novas Funcionalidades
- **Sistema de login e cadastro** básico
- **Análise de alimentos** com modelo YOLO inicial (100 alimentos)
- **Dashboard simples** com métricas básicas
- **Integração USDA API** para dados nutricionais

### Melhorias
- Otimização do modelo YOLO para melhor performance
- Implementação de cache para consultas USDA
- Melhoria na interface do analisador de alimentos

### Bugs Conhecidos
- Alguns alimentos não sendo reconhecidos corretamente
- Performance lenta em dispositivos móveis antigos
- Problemas de timezone em registros de data

---

## [0.8.0] - 2026-02-28

### Alpha Técnico
**Versão interna para testes de integração e performance.**

### Funcionalidades Implementadas
- **Backend .NET 8.0** com estrutura básica de controllers
- **Modelo YOLO customizado** treinado com dataset inicial
- **Integração USDA API** funcionando
- **Banco de dados SQLite** para desenvolvimento

### Infraestrutura
- Setup inicial do projeto no Railway
- Configuração de variáveis de ambiente
- Pipeline de CI/CD básico

---

## [0.7.0] - 2026-01-20

### Protótipo de Pesquisa
**Versão de pesquisa e desenvolvimento do modelo de IA.**

### Desenvolvimentos
- **Treinamento do modelo YOLO** com dataset de 452 alimentos
- **Sistema de tradução** EN → PT implementado
- **Prototipação da interface** do analisador de alimentos
- **Primeiros testes** com dados nutricionais da USDA

### Resultados de Pesquisa
- **85% de precisão** na detecção de alimentos
- **<3 segundos** para análise completa
- **452 alimentos** traduzidos e mapeados

---

## [0.6.0] - 2025-12-10

### Planejamento e Arquitetura
**Fase de design e arquitetura do sistema.**

### Entregáveis
- **Documentação de arquitetura** completa
- **Design system** com paleta de cores e componentes
- **Especificações técnicas** de todas as APIs
- **Modelo de dados** do banco de dados
- **Roadmap** de desenvolvimento 2026-2030

### Design
- Paleta de cores emerald para saúde/nutrição
- Interface mobile-first responsiva
- Componentes com glassmorphism e gradientes
- Ícones Font Awesome e fontes Google

---

## [0.5.0] - 2025-11-05

### Definição do Projeto
**Fase inicial de concepção e validação.**

### Atividades
- **Pesquisa de mercado** sobre soluções de nutrição no Brasil
- **Entrevistas com usuários** potenciais (nutricionistas, pacientes)
- **Análise de tecnologias** disponíveis para IA e nutrição
- **Definição da visão e missão** do BSFM
- **Validação do problema** com profissionais de saúde

### Insights
- Grande demanda por soluções acessíveis de análise nutricional
- Falta de integração entre tecnologia e saúde no Brasil
- Potencial impacto em saúde pública através do SUS
- Necessidade de adaptação ao contexto alimentar brasileiro

---

## Política de Versionamento

### Versões Semânticas
O BSFM segue o versionamento semântico `MAJOR.MINOR.PATCH`:

1. **MAJOR**: Mudanças incompatíveis com versões anteriores
2. **MINOR**: Novas funcionalidades compatíveis com versões anteriores
3. **PATCH**: Correções de bugs compatíveis com versões anteriores

### Categorias de Mudanças
Cada versão é organizada por categorias:

- **Novas Funcionalidades**: Novos recursos para usuários
- **Melhorias**: Aprimoramentos em funcionalidades existentes
- **Correções de Bugs**: Resolução de problemas reportados
- **Documentação**: Atualizações na documentação
- **Performance**: Otimizações de velocidade e eficiência
- **Segurança**: Melhorias na segurança do sistema
- **Experimentais**: Funcionalidades em fase de teste

### Ciclo de Lançamentos

#### Lançamentos Principais (Major)
- **Planejamento:** 3 meses antes do lançamento
- **Desenvolvimento:** 2 meses
- **Testes:** 1 mês
- **Lançamento:** Data marcada com antecedência

#### Lançamentos Menores (Minor)
- **Ciclo:** Mensal ou conforme necessidade
- **Processo:** Feature branches → Code review → QA → Deploy

#### Hotfixes (Patch)
- **Processo:** Correção imediata de bugs críticos
- **Deploy:** Assim que aprovado pela equipe técnica

### Compatibilidade com Versões Anteriores

#### Garantias de Compatibilidade
- **API REST:** Endpoints não serão removidos sem aviso prévio de 6 meses
- **Banco de Dados:** Migrations sempre preservam dados existentes
- **Frontend:** CSS e JavaScript mantêm compatibilidade por 1 versão major

#### Processo de Depreciação
1. **Aviso:** Feature marcada como deprecated na documentação
2. **Período:** 6 meses de aviso antes da remoção
3. **Alternativas:** Nova feature ou caminho de migração documentado
4. **Remoção:** Feature removida na próxima versão major

### Processo de Contribuição para o Changelog

#### Para Desenvolvedores
1. **Crie uma entrada** no PR descrevendo as mudanças
2. **Categorize** corretamente (feature, bugfix, etc.)
3. **Inclua issue numbers** quando aplicável
4. **Mantenha o tom** consistente e profissional

#### Para Product Managers
1. **Revise as entradas** antes de cada release
2. **Consolide mudanças** relacionadas
3. **Adicione contexto** sobre o impacto para usuários
4. **Traduza termos técnicos** para linguagem acessível

### Template para Novas Entradas

```markdown
## [X.Y.Z] - YYYY-MM-DD

### Título do Lançamento
**Breve descrição do que esta versão representa**

### Novas Funcionalidades
- **Nome da Feature:** Descrição detalhada
  - Sub-item com detalhes técnicos ou de UX
  - Benefícios para o usuário final

### Melhorias
- Área melhorada: O que foi aprimorado e por quê

### Correções de Bugs
- Issue #123: Descrição do bug e como foi resolvido

### Documentação
- Seção atualizada: O que foi adicionado ou melhorado

### Performance
- Endpoint otimizado: Redução de X% no tempo de resposta

### Segurança
- Vulnerabilidade corrigida: CVE-XXXX-XXXX
```

### Histórico de Breaking Changes

#### v1.0.0 (2026-04-16)
- **Nenhuma breaking change** - Primeira versão pública

### Próximos Lançamentos Planejados

#### v1.1.0 (Previsto: 2026-05-31)
- **App mobile nativo** para iOS e Android
- **Reconhecimento de porções automático** por IA
- **Integração com wearables** (Apple Watch, Fitbit)
- **Sistema de notificações** push para lembretes

#### v1.2.0 (Previsto: 2026-07-15)
- **Planos alimentares gerados por IA**
- **Análise de receitas completas**
- **Integração com supermercados** para lista de compras
- **Modo offline** para áreas com internet limitada

#### v2.0.0 (Previsto: 2026-12-01)
- **API pública** para desenvolvedores
- **Marketplace de profissionais** de nutrição
- **Análise em tempo real** por câmera
- **Integração com prontuários eletrônicos**

### Como Reportar Bugs

#### Processo de Report
1. **Verifique** se o bug já foi reportado
2. **Use o template** de report no GitHub Issues
3. **Inclua screenshots** e steps para reproduzir
4. **Descreva o ambiente** (navegador, SO, dispositivo)

#### SLA de Resposta
- **Crítico:** 24 horas (segurança, dados perdidos)
- **Alta:** 72 horas (funcionalidade principal quebrada)
- **Média:** 1 semana (funcionalidade secundária)
- **Baixa:** 2 semanas (melhorias e pequenos bugs)

### Contato e Suporte

#### Canais de Suporte
- **GitHub Issues:** [BSFM/Brazilian-System-of-Food-Metric/issues](https://github.com/BSFM/Brazilian-System-of-Food-Metric/issues)
- **Email:** suporte@bsfm.com.br
- **Discord:** Comunidade de desenvolvedores

#### Horário de Suporte
- **Segunda a Sexta:** 9h às 18h (BRT)
- **Plantão:** 24/7 para issues críticas

---

**Última atualização:** 16 de Abril de 2026  
**Próxima revisão:** 16 de Maio de 2026  
**Mantido por:** Equipe Técnica BSFM
