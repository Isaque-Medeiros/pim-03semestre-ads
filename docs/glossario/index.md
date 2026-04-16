# Glossário do BSFM

Este glossário define os principais termos, conceitos e siglas utilizados no Brazilian System of Food Metric.

---

## 📚 Índice Alfabético

**A** • [Alimento Funcional](#alimento-funcional) • [Análise Nutricional](#análise-nutricional) • [API](#api)  
**B** • [BSFM](#bsfm) • [Banco de Dados Nutricional](#banco-de-dados-nutricional)  
**C** • [Caloria](#caloria) • [Carboidrato](#carboidrato) • [Caso de Uso](#caso-de-uso)  
**D** • [DRI](#dri) • [Dieta Personalizada](#dieta-personalizada) • [Dataset](#dataset)  
**E** • [Endpoint](#endpoint) • [Escala de Medição](#escala-de-medição)  
**F** • [Food Metric](#food-metric) • [Fórmula Nutricional](#fórmula-nutricional)  
**G** • [Glicemia](#glicemia) • [Glossário](#glossário)  
**H** • [Hábito Alimentar](#hábito-alimentar) • [Health Tech](#health-tech)  
**I** • [IA Nutricional](#ia-nutricional) • [Índice Glicêmico](#índice-glicêmico)  
**J** • [JSON](#json) • [JWT](#jwt)  
**K** • [Kcal](#kcal) • [KPI Nutricional](#kpi-nutricional)  
**L** • [Lipídio](#lipídio) • [Log de Alimentação](#log-de-alimentação)  
**M** • [Macronutriente](#macronutriente) • [Micronutriente](#micronutriente)  
**N** • [Nutriente Essencial](#nutriente-essencial) • [Nutrition Facts](#nutrition-facts)  
**O** • [Obesidade](#obesidade) • [Open Source](#open-source)  
**P** • [Proteína](#proteína) • [Plataforma](#plataforma) • [PIR](#pir)  
**Q** • [Qualidade Nutricional](#qualidade-nutricional) • [Quantificação](#quantificação)  
**R** • [RDA](#rda) • [Recomendação Personalizada](#recomendação-personalizada)  
**S** • [SDK](#sdk) • [Sistema de Métricas](#sistema-de-métricas)  
**T** • [Tabela Nutricional](#tabela-nutricional) • [Taxonomia Alimentar](#taxonomia-alimentar)  
**U** • [Unidade de Medida](#unidade-de-medida) • [Usuário Ativo](#usuário-ativo)  
**V** • [Valor Diário](#valor-diário) • [Validação de Dados](#validação-de-dados)  
**W** • [Webhook](#webhook) • [Wearable Integration](#wearable-integration)  
**X** • [XML](#xml) • [XAPI](#xapi)  
**Y** • [YAML](#yaml)  
**Z** • [Z-score Nutricional](#z-score-nutricional)

---

## 🔤 Definições Detalhadas

### A

#### **Alimento Funcional**
Alimento que além de funções nutricionais básicas, produz efeitos metabólicos e/ou fisiológicos benéficos à saúde. No BSFM, alimentos funcionais são categorizados e analisados quanto aos seus compostos bioativos.

**Exemplo no BSFM:**
```json
{
  "food_type": "functional",
  "bioactive_compounds": ["curcumin", "piperine"],
  "health_benefits": ["anti-inflammatory", "antioxidant"],
  "recommended_daily": "1-3g"
}
```

#### **Análise Nutricional**
Processo de avaliação quantitativa e qualitativa do valor nutricional de alimentos, refeições ou dietas. No BSFM, a análise é automatizada usando IA e bancos de dados científicos.

**Componentes:**
- Composição de macronutrientes
- Perfil de micronutrientes
- Densidade energética
- Qualidade nutricional

#### **API** (Application Programming Interface)
Conjunto de protocolos e ferramentas para construção de software. A API do BSFM permite integração com outros sistemas através de endpoints RESTful.

**Endpoints principais:**
- `POST /api/v1/nutrition/analyze`
- `GET /api/v1/foods/search`
- `POST /api/v1/meal-plans/generate`

---

### B

#### **BSFM** (Brazilian System of Food Metric)
Sistema Brasileiro de Métricas Alimentares. Plataforma open source para padronização, análise e otimização de métricas nutricionais no contexto brasileiro.

**Principais características:**
- Foco no contexto alimentar brasileiro
- Dados científicos validados
- Arquitetura escalável
- Comunidade aberta

#### **Banco de Dados Nutricional**
Repositório estruturado de informações sobre composição nutricional de alimentos. O BSFM mantém um banco com +10.000 alimentos brasileiros.

**Estrutura:**
```sql
CREATE TABLE foods (
  id UUID PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  scientific_name VARCHAR(255),
  category VARCHAR(100),
  calories DECIMAL(10,2),
  protein DECIMAL(10,2),
  carbs DECIMAL(10,2),
  fat DECIMAL(10,2),
  region VARCHAR(50),
  seasonality JSONB,
  data_source VARCHAR(100)
);
```

---

### C

#### **Caloria**
Unidade de medida de energia. No contexto nutricional, representa a quantidade de energia fornecida por um alimento. 1 caloria = 4.184 joules.

**Conversões no BSFM:**
- kcal (quilocaloria) = 1000 calorias
- kJ (quilojoule) = kcal × 4.184

#### **Carboidrato**
Macronutriente composto por carbono, hidrogênio e oxigênio. Principal fonte de energia do corpo. Classificado em simples e complexos.

**Tipos no BSFM:**
- **Simples**: glicose, frutose, sacarose
- **Complexos**: amido, fibras
- **Fibra alimentar**: solúvel, insolúvel

#### **Caso de Uso**
Descrição específica de como um usuário interage com o sistema para atingir um objetivo. Documentado na seção [Casos de Uso](../caso-de-uso/).

**Estrutura típica:**
1. Cenário do usuário
2. Objetivos
3. Fluxo de interação
4. Resultados esperados

---

### D

#### **DRI** (Dietary Reference Intakes)
Referências de ingestão dietética estabelecidas pelo Institute of Medicine (EUA). Inclui RDA, AI, UL e EAR.

**Componentes:**
- **RDA**: Ingestão diária recomendada
- **AI**: Ingestão adequada
- **UL**: Limite superior tolerável
- **EAR**: Necessidade média estimada

#### **Dieta Personalizada**
Plano alimentar adaptado às características individuais: idade, sexo, peso, altura, nível de atividade, objetivos e preferências.

**Algoritmo do BSFM:**
```python
def personalize_diet(profile, goals, constraints):
    base_calories = calculate_bmr(profile)
    activity_adjustment = get_activity_factor(profile.activity_level)
    goal_adjustment = get_goal_adjustment(goals.target)
    
    total_calories = base_calories * activity_adjustment * goal_adjustment
    
    macronutrient_split = optimize_macronutrients(
        profile, 
        goals, 
        constraints
    )
    
    return DietPlan(total_calories, macronutrient_split)
```

#### **Dataset**
Conjunto de dados estruturados para análise. O BSFM disponibiliza datasets para pesquisa, incluindo dados anonimizados de consumo alimentar.

**Formato padrão:**
```csv
food_id,consumption_date,user_age,user_gender,region,quantity_g,calories
12345,2025-01-15,35,M,Southeast,150,225.5
12346,2025-01-15,35,M,Southeast,200,310.0
```

---

### E

#### **Endpoint**
URL específica em uma API que aceita requisições e retorna respostas. Cada endpoint do BSFM tem documentação detalhada.

**Exemplo:**
```
GET https://api.bsfm.com.br/v1/foods/12345/nutrition
```

#### **Escala de Medição**
Sistema padronizado para quantificar alimentos. O BSFM suporta múltiplas escalas com conversão automática.

**Escalas suportadas:**
- Gramas (g)
- Mililitros (ml)
- Xícaras (cup)
- Colheres (tbsp, tsp)
- Unidades (un)

---

### F

#### **Food Metric**
Métrica alimentar - medida padronizada para avaliar características nutricionais, qualidade, ou impacto de alimentos.

**Métricas principais no BSFM:**
- Densidade nutricional (nutrientes/caloria)
- Índice de saciedade
- Impacto glicêmico
- Sustentabilidade ambiental

#### **Fórmula Nutricional**
Equação matemática para calcular valores nutricionais com base em ingredientes e quantidades.

**Exemplo:**
```
Calorias_totais = Σ(quantidade_ingrediente × calorias_por_100g ÷ 100)
Proteína_total = Σ(quantidade_ingrediente × proteína_por_100g ÷ 100)
```

---

### G

#### **Glicemia**
Concentração de glicose no sangue. Parâmetro importante para diabetes e saúde metabólica.

**Valores de referência:**
- **Normal**: 70-99 mg/dL (jejum)
- **Pré-diabetes**: 100-125 mg/dL
- **Diabetes**: ≥126 mg/dL

#### **Glossário**
Este documento. Lista organizada de termos técnicos com definições e exemplos.

---

### H

#### **Hábito Alimentar**
Padrão recorrente de consumo alimentar influenciado por fatores culturais, sociais, psicológicos e fisiológicos.

**Análise no BSFM:**
- Frequência de consumo
- Variedade alimentar
- Horários das refeições
- Contexto social

#### **Health Tech**
Tecnologia aplicada à saúde. O BSFM é uma health tech focada em nutrição e bem-estar.

**Tecnologias utilizadas:**
- Machine Learning
- APIs RESTful
- Banco de dados NoSQL
- Microservices

---

### I

#### **IA Nutricional** (Inteligência Artificial Nutricional)
Sistemas de IA que analisam, recomendam e otimizam aspectos nutricionais. O BSFM utiliza IA para:

1. **Recomendações personalizadas**
2. **Análise preditiva de tendências**
3. **Otimização de fórmulas**
4. **Detecção de padrões**

#### **Índice Glicêmico** (IG)
Classificação de carboidratos baseada em seu efeito sobre os níveis de glicose no sangue.

**Categorias:**
- **Baixo IG**: ≤55
- **Médio IG**: 56-69  
- **Alto IG**: ≥70

---

### J

#### **JSON** (JavaScript Object Notation)
Formato leve de intercâmbio de dados. Usado extensivamente nas APIs do BSFM.

**Exemplo de resposta:**
```json
{
  "status": "success",
  "data": {
    "food_id": "12345",
    "name": "Arroz branco cozido",
    "nutrition": {
      "calories": 130,
      "protein": 2.7,
      "carbs": 28.2,
      "fat": 0.3
    }
  },
  "timestamp": "2026-04-16T17:50:30Z"
}
```

#### **JWT** (JSON Web Token)
Padrão para tokens de autenticação. Usado para segurança nas APIs do BSFM.

**Estrutura:**
```
header.payload.signature
```

---

### K

#### **Kcal** (Quilocaloria)
Unidade prática para medir energia em nutrição. Equivale a 1000 calorias.

**Conversão:**
- 1 kcal = 4.184 kJ
- 1 kJ = 0.239 kcal

#### **KPI Nutricional** (Key Performance Indicator)
Indicador-chave de desempenho para avaliar progresso nutricional.

**KPIs comuns:**
- % de metas nutricionais atingidas
- Consistência no registro alimentar
- Melhoria em marcadores de saúde
- Adesão ao plano alimentar

---

### L

#### **Lipídio**
Macronutriente também conhecido como gordura. Inclui triglicerídeos, fosfolipídios e esteróis.

**Classificação no BSFM:**
- **Saturadas**: ácido palmítico, esteárico
- **Insaturadas**: monoinsaturadas, poliinsaturadas
- **Trans**: ácidos graxos trans

#### **Log de Alimentação**
Registro cronológico de consumo alimentar. Base para análise e recomendações personalizadas.

**Estrutura:**
```yaml
meal_log:
  date: 2026-04-16
  meals:
    - type: breakfast
      time: "08:00"
      foods:
        - name: "Ovos mexidos"
          quantity: 2
          unit: "units"
        - name: "Pão integral"
          quantity: 2
          unit: "slices"
```

---

### M

#### **Macronutriente**
Nutriente necessário em grandes quantidades: proteínas, carboidratos e lipídios.

**Proporções recomendadas:**
- **Proteínas**: 10-35% das calorias
- **Carboidratos**: 45-65% das calorias  
- **Lipídios**: 20-35% das calorias

#### **Micronutriente**
Nutriente necessário em pequenas quantidades: vitaminas e minerais.

**Categorias:**
- **Vitaminas hidrossolúveis**: B, C
- **Vitaminas lipossolúveis**: A, D, E, K
- **Minerais principais**: Ca, P, Mg, Na, K
- **Oligoelementos**: Fe, Zn, Cu, Se

---

### N

#### **Nutriente Essencial**
Nutriente que o corpo não pode sintetizar em quantidades suficientes, devendo ser obtido da dieta.

**Lista completa:**
- 9 aminoácidos essenciais
- 2 ácidos graxos essenciais
- 13 vitaminas
- 15 minerais

#### **Nutrition Facts**
Informação nutricional padronizada em rótulos de alimentos. O BSFM gera automaticamente com base na legislação brasileira.

**Elementos obrigatórios:**
- Valor energético
- Carboidratos
- Proteínas
- Gorduras totais
- Gorduras saturadas
- Gorduras trans
- Fibra alimentar
- Sódio

---

### O

#### **Obesidade**
Condição médica caracterizada por acúmulo excessivo de gordura corporal. O BSFM auxilia na prevenção e tratamento.

**Classificação por IMC:**
- **Normal**: 18.5-24.9
- **Sobrepeso**: 25-29.9
- **Obesidade I**: 30-34.9
- **Obesidade II**: 35-39.9
- **Obesidade III**: ≥40

#### **Open Source**
Software com código fonte disponível para modificação e distribuição. O BSFM é open source sob licença MIT.

**Benefícios:**
- Transparência
- Colaboração comunitária
- Inovação acelerada
- Sem vendor lock-in

---

### P

#### **Proteína**
Macronutriente composto por aminoácidos. Essencial para crescimento, reparo e manutenção tecidual.

**Fontes no BSFM:**
- **Animal**: carnes, ovos, laticínios
- **Vegetal**: leguminosas, cereais, oleaginosas
- **Suplementos**: whey, caseína, vegetais

#### **Plataforma**
Conjunto integrado de tecnologias que formam o BSFM. Inclui frontend, backend, APIs, banco de dados e ferramentas.

**Arquitetura:**
```
Frontend (React) → API Gateway → Microservices → Databases
                         ↑
                  Authentication
                         ↑
                  Monitoring & Logging
```

#### **PIR** (Padrão de Ingestão Recomendada)
Valores de referência para ingestão de nutrientes estabelecidos para a população brasileira.

**Base científica:**
- Dados antropométricos brasileiros
- Padrões de consumo nacionais
- Necessidades fisiológicas específicas

---

### Q

#### **Qualidade Nutricional**
Medida abrangente do valor nutricional de um alimento, considerando densidade nutricional, processamento e benefícios à saúde.

**Índice de Qualidade Nutricional (BSFM):**
```
IQN = (nutrientes_essenciais × biodisponibilidade) ÷ (calorias + componentes_negativos)
```

#### **Quantificação**
Processo de medição precisa de quantidades alimentares. O BSFM oferece ferramentas para quantificação padronizada.

**Métodos suportados:**
- Pesagem digital (g)
- Medição volumétrica (ml)
- Estimativa visual (porções)
- Reconhecimento de imagem (AI)

---

### R

#### **RDA** (Recommended Dietary Allowance)
Ingestão diária média suficiente para atender às necessidades de 97-98% dos indivíduos saudáveis em um grupo.

**Exemplo para adulto médio:**
- **Proteína**: 0.8 g/kg de peso corporal
- **Cálcio**: 1000 mg/dia
- **Vitamina C**: 90 mg/dia (homens), 75 mg/dia (mulheres)

#### **Recomendação Personalizada**
Sugestão adaptada às características individuais gerada pelo sistema de IA do BSFM.

**Fatores considerados:**
- Dados demográficos
- Objetivos de saúde
- Preferências alimentares
- Restrições médicas
- Orçamento disponível

---

### S

#### **SDK** (Software Development Kit)
Conjunto de ferramentas para desenvolvedores integrarem o BSFM em suas aplicações.

**SDKs disponíveis:**
- **Python**: `pip install bsfm-sdk`
- **JavaScript**: `npm install @bsfm/sdk`
- **Java**: `implementation 'com.bsfm:sdk:1.0.0'`
- **C#**: `Install-Package BSFM.SDK`

#### **Sistema de Métricas**
Conjunto integrado de medidas para avaliação nutricional no BSFM.

**Métricas principais:**
1. **Nutricionais**: calorias, macronutrientes, micronutrientes
2. **Qualitativas**: densidade nutricional, processamento
3. **Comportamentais**: frequência, variedade, consistência
4. **Impacto**: saúde, ambiental, econômico

---

### T

#### **Tabela Nutricional**
Representação padronizada da composição nutricional de alimentos. Gerada automaticamente pelo BSFM.

**Formato brasileiro:**
```
Informação Nutricional
Porção de 100g

Valor Energético: 150 kcal = 630 kJ
Carboidratos: 30g
Proteínas: 5g
Gorduras Totais: 2g
 Gorduras Saturadas: 0.5g
 Gorduras Trans: 0g
Fibra Alimentar: 3g
Sódio: 200mg
```

#### **Taxonomia Alimentar**
Sistema de classificação hierárquica de alimentos usado no BSFM.

**Níveis:**
1. **Grupo**: Cereais, Leguminosas, Frutas, etc.
2. **Subgrupo**: Cereais integrais, Cereais refinados
3. **Item**: Arroz integral, Arroz branco
4. **Preparação**: Cozido, Frito, Assado

---

### U

#### **Unidade de Medida**
Padrão para expressar quantidades no BSFM. Suporta conversão automática entre sistemas.

**Sistemas suportados:**
- **Métrico**: g, kg, ml, L
- **Imperial**: oz, lb, fl oz, cup
- **Caseiro**: colher, xícara, unidade
- **Porção**: fatia, pedaço, porção

#### **Usuário Ativo**
Usuário que interage com a plataforma pelo menos uma vez por semana.

**Métricas de engajamento:**
- Logs de alimentação registrados
- Metas nutricionais definidas
- Interação com recomendações
- Participação na comunidade

---

### V

#### **Valor Diário** (%VD)
Percentual de nutrientes que uma porção do alimento contribui para uma dieta de 2000 kcal.

**Cálculo:**
```
%VD = (quantidade_nutriente ÷ valor_diário_referência) × 100
```

#### **Validação de Dados**
Processo de verificação da qualidade e precisão dos dados nutricionais no BSFM.

**Etapas:**
1. **Validação de fonte**: origem confiável
2. **Validação técnica**: formato correto
3. **Validação científica**: consistência com literatura
4. **Validação de uso**: aplicabilidade prática

---

### W

#### **Webhook**
Mecanismo para notificações em tempo real quando eventos ocorrem no BSFM.

**Eventos suportados:**
- `nutrition.analysis.completed`
- `meal_plan.generated`
- `goal.achieved`
- `data.updated`

#### **Wearable Integration**
Integração com dispositivos vestíveis para coleta automática de dados.

**Dispositivos suportados:**
- Apple Watch
- Fitbit
- Garmin
- Samsung Galaxy Watch

---

### X

#### **XML** (eXtensible Markup Language)
Formato de marcação para estruturação de dados. Alternativa ao JSON em algumas APIs do BSFM.

**Exemplo:**
```xml
<nutrition>
  <food>
    <name>Arroz branco cozido</name>
    <calories>130</calories>
    <protein>2.7</protein>
    <carbs>28.2</carbs>
    <fat>0.3</fat>
  </food>
</nutrition>
```

#### **XAPI** (Experience API)
Padrão para rastreamento de experiências de aprendizagem. Usado no módulo educativo do BSFM.

**Statement exemplo:**
```json
{
  "actor": {"id": "user_123"},
  "verb": {"id": "http://bsfm.com.br/verbs/completed"},
  "object": {"id": "course_nutrition_basics"},
  "timestamp": "2026-04-16T17:52:23Z"
}
```

---

### Y

#### **YAML** (YAML Ain't Markup Language)
Formato de serialização de dados legível por humanos. Usado para configurações no BSFM.

**Exemplo de configuração:**
```yaml
bsfm:
  api:
    version: "v1"
    timeout: 30
    retries: 3
  
  nutrition:
    default_region: "BR"
    language: "pt-BR"
    units: "metric"
  
  features:
    ai_recommendations: true
    meal_planning: true
    community: true
```

---

### Z

#### **Z-score Nutricional**
Medida estatística que indica quantos desvios padrão um valor está da média populacional.

**Aplicações:**
- Avaliação de crescimento infantil
- Detecção de desvios nutricionais
- Monitoramento de populações em risco

**Interpretação:**
- **Normal**: -2 ≤ Z ≤ 2
- **Risco**: Z < -2 ou Z > 2
- **Severo**: Z < -3 ou Z > 3

---

## 📖 Como Usar Este Glossário

### Para Novatos
1. Comece pelos termos básicos: [Caloria](#caloria), [Macronutriente](#macronutriente)
2. Explore os [Casos de Uso](../caso-de-uso/) para contexto prático
3. Consulte a [Documentação Técnica](../referencia/) para detalhes

### Para Desenvolvedores
1. Foque em: [API](#api), [SDK](#sdk), [Endpoint](#endpoint)
2. Use os exemplos de código como referência
3. Consulte a [Documentação da API](../referencia/api.md)

### Para Pesquisadores
1. Estude: [Dataset](#dataset), [DRI](#dri), [Validação de Dados](#validação-de-dados)
2. Utilize os dados anonimizados disponíveis
3. Contribua com novas definições baseadas em pesquisa

---

## 🔄 Atualizações

Este glossário é atualizado regularmente com:

1. **Novos termos** à medida que a plataforma evolui
2. **Correções** baseadas em feedback da comunidade
3. **Exemplos adicionais** para maior clareza
4. **Links** para documentação relacionada

**Última atualização**: Abril 2026  
**Próxima revisão**: Julho 2026

---

## 🤝 Contribua

Encontrou um termo faltando ou uma definição imprecisa?

1. **Abra uma issue** no [GitHub](https://github.com/BSFM/Brazilian-System-of-Food-Metric)
2. **Envie um PR** com suas melhorias
3. **Participe da discussão** na comunidade

---

## 📚 Recursos Relacionados

- [Documentação Completa](../)
- [Casos de Uso](../caso-de-uso/)
- [Referência da API](../referencia/api.md)
- [Roadmap](../roadmap/)
- [Changelog](../changelog/)

---

## 📞 Contato

- **Email**: glossario@bsfm.com.br
- **GitHub**: [BSFM/Brazilian-System-of-Food-Metric](https://github.com/BSFM/Brazilian-System-of-Food-Metric)
- **Twitter**: [@bsfm_br](https://twitter.com/bsfm_br)

---

*"Conhecimento nutricional compartilhado transforma saúde coletiva."*
