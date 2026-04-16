# Guia do Usuário BSFM

Bem-vindo ao **BSFM (Brazilian System of Food Metric)**! Este guia irá ajudá-lo a começar a usar nossa plataforma revolucionária de nutrição inteligente.

---

## 🎯 O que é o BSFM?

O BSFM é uma plataforma completa de análise nutricional que utiliza **inteligência artificial** para ajudar você a:

- **📸 Analisar alimentos** através de fotos do seu prato
- **📊 Acompanhar suas métricas de saúde** como IMC, TMB e gasto calórico
- **🎯 Definir e alcançar metas pessoais** de saúde e nutrição
- **🏥 Conectar-se com serviços de saúde** e profissionais especializados
- **📅 Planejar suas refeições** com cronogramas personalizados

!!! success "Tecnologia de Ponta"
    Utilizamos **YOLO Object Detection** com 452 alimentos reconhecidos e **tradução automática EN→PT** para fornecer análises precisas em português.

---

## 🚀 Primeiros Passos

### 1. Crie sua Conta

1. Acesse [bsfm.com.br](https://bsfm.com.br)
2. Clique em **"Cadastrar"** no canto superior direito
3. Preencha seus dados:
   - Nome completo
   - Email válido
   - Senha segura (mínimo 8 caracteres)
4. Verifique seu email e insira o código de 6 dígitos
5. Aceite os termos de uso e política de privacidade

!!! tip "Dica de Segurança"
    Use uma senha forte com letras maiúsculas, minúsculas, números e símbolos.

### 2. Complete seu Perfil

Após o cadastro, complete seu perfil para análises personalizadas:

```yaml
Informações necessárias:
  - Peso (kg)
  - Altura (cm)
  - Idade
  - Sexo biológico
  - Nível de atividade física:
    * Sedentário (pouco ou nenhum exercício)
    * Levemente ativo (1-3 dias/semana)
    * Ativo (3-5 dias/semana)
    * Muito ativo (6-7 dias/semana)
```

### 3. Explore o Dashboard

Seu dashboard pessoal mostra:

- **📈 IMC Atual** e evolução histórica
- **⚡ Taxa Metabólica Basal (TMB)**
- **🔥 Gasto Calórico Total**
- **🎯 Metas definidas**
- **📊 Gráficos de progresso**

---

## 🤖 Como Funciona a Análise por IA

### Passo a Passo para Analisar um Alimento

1. **Acesse o Analisador IA**
   - No menu principal, clique em **"Analisar Alimento"**
   - Ou use o botão rápido no dashboard

2. **Tire uma Foto**
   - Use a câmera do seu dispositivo
   - Certifique-se de que o alimento esteja bem iluminado
   - Mantenha o alimento centralizado na imagem

3. **Selecione o Tamanho da Porção**
   - Pequeno (≈100g)
   - Médio (≈200g)
   - Grande (≈300g)

4. **Veja os Resultados**
   - Identificação do alimento
   - Valores nutricionais por 100g
   - Cálculo para a porção selecionada
   - Histórico salvo automaticamente

### Alimentos Reconhecidos

Nossa IA reconhece **452 alimentos** incluindo:

| Categoria | Exemplos |
|-----------|----------|
| **Frutas** | Maçã, banana, laranja, uva, morango |
| **Vegetais** | Alface, tomate, cenoura, brócolis, batata |
| **Proteínas** | Frango, carne bovina, peixe, ovo, tofu |
| **Carboidratos** | Arroz, feijão, pão, macarrão, batata-doce |
| **Laticínios** | Leite, queijo, iogurte, manteiga |
| **Outros** | Nozes, chocolate, azeite, mel |

---

## 📊 Dashboard e Métricas

### Entendendo suas Métricas

#### Índice de Massa Corporal (IMC)
```math
IMC = \frac{Peso (kg)}{Altura (m)^2}
```

| Classificação | IMC |
|--------------|-----|
| Abaixo do peso | < 18.5 |
| Peso normal | 18.5 - 24.9 |
| Sobrepeso | 25 - 29.9 |
| Obesidade Grau I | 30 - 34.9 |
| Obesidade Grau II | 35 - 39.9 |
| Obesidade Grau III | ≥ 40 |

#### Taxa Metabólica Basal (TMB)
Sua taxa metabólica basal é a quantidade de calorias que seu corpo queima em repouso.

**Fórmula para homens:**
```
TMB = 88.362 + (13.397 × peso em kg) + (4.799 × altura em cm) - (5.677 × idade em anos)
```

**Fórmula para mulheres:**
```
TMB = 447.593 + (9.247 × peso em kg) + (3.098 × altura em cm) - (4.330 × idade em anos)
```

#### Gasto Calórico Total
Baseado no seu nível de atividade:

| Nível de Atividade | Multiplicador |
|-------------------|---------------|
| Sedentário | TMB × 1.2 |
| Levemente ativo | TMB × 1.375 |
| Ativo | TMB × 1.55 |
| Muito ativo | TMB × 1.725 |
| Extremamente ativo | TMB × 1.9 |

### Configurando Metas

1. **Acesse "Minhas Metas"** no dashboard
2. **Escolha seu objetivo:**
   - Perder peso
   - Ganhar massa muscular
   - Manter peso
   - Melhorar hábitos alimentares

3. **Defina parâmetros:**
   - Peso alvo
   - Prazo (semanas)
   - Déficit/superávit calórico diário
   - Foco nutricional (proteínas, carboidratos, etc.)

4. **Acompanhe o progresso:**
   - Gráficos semanais
   - Alertas de progresso
   - Ajustes automáticos

---

## 🏥 Integração Hospitalar

### Diretório de Hospitais Parceiros

1. **Acesse "Hospitais"** no menu principal
2. **Use os filtros:**
   - Por especialidade (nutrição, endocrinologia, etc.)
   - Por localização (cidade, bairro)
   - Por tipo de serviço (consultas, exames, emergência)

3. **Informações disponíveis:**
   - Endereço completo
   - Telefones de contato
   - Horários de funcionamento
   - Especialidades disponíveis
   - Convênios aceitos

### Agendamento de Consultas

!!! note "Em breve"
    Estamos desenvolvendo integração direta para agendamento online. Por enquanto, use as informações de contato fornecidas.

---

## 📅 Cronograma Alimentar

### Criando um Plano Alimentar

1. **Acesse "Planos Alimentares"**
2. **Clique em "Criar Novo Plano"**
3. **Configure:**
   - Período (semana, quinzena, mês)
   - Número de refeições por dia
   - Restrições alimentares (vegetariano, sem glúten, etc.)
   - Orçamento aproximado

4. **Adicione Refeições:**
   - Café da manhã
   - Lanche da manhã
   - Almoço
   - Lanche da tarde
   - Jantar
   - Ceia (opcional)

5. **Use o Gerador Automático:**
   - Baseado nas suas preferências
   - Considerando suas metas
   - Variedade nutricional garantida

### Acompanhamento Diário

- **Marcar refeições consumidas**
- **Registrar desvios do plano**
- **Ajustar porções conforme necessidade**
- **Receber lembretes de horários**

---

## 🔧 Configurações e Personalização

### Notificações

Configure quais notificações deseja receber:

- **Lembretes de refeições**
- **Alertas de hidratação**
- **Atualizações de metas**
- **Novidades da plataforma**
- **Dicas nutricionais**

### Privacidade

Controle quem vê seus dados:

- **Perfil público/privado**
- **Compartilhamento de progresso**
- **Dados anonimizados para pesquisa**
- **Exportação de dados pessoais**

### Acessibilidade

Recursos disponíveis:

- **Modo alto contraste**
- **Tamanho de fonte ajustável**
- **Navegação por teclado**
- **Descrições de imagens**

---

## ❓ FAQ - Perguntas Frequentes

### Análise por IA

**Q: A precisão da análise é confiável?**
A: Nosso modelo tem **85% de precisão** em testes com 452 alimentos. Para máxima precisão, fotografe o alimento isolado em boa iluminação.

**Q: E se a IA não reconhecer meu alimento?**
A: Você pode:
1. Tentar outra foto com melhor ângulo/iluminação
2. Buscar manualmente na base de dados
3. Reportar o alimento para nossa equipe

**Q: Como funciona a tradução dos alimentos?**
A: Temos um dicionário com 452 alimentos traduzidos manualmente de inglês para português.

### Conta e Perfil

**Q: Posso mudar meu email?**
A: Sim, em "Configurações" > "Conta" > "Alterar Email". Será necessária verificação.

**Q: Esqueci minha senha, o que fazer?**
A: Clique em "Esqueci minha senha" na tela de login e siga as instruções enviadas por email.

**Q: Posso excluir minha conta?**
A: Sim, em "Configurações" > "Conta" > "Excluir Conta". Todos os dados serão removidos permanentemente.

### Métricas e Saúde

**Q: Como o IMC é calculado?**
A: Usamos a fórmula padrão: peso (kg) ÷ altura (m)². Os resultados são apenas referenciais.

**Q: O BSFM substitui um nutricionista?**
A: **Não**. O BSFM é uma ferramenta de apoio. Sempre consulte um profissional de saúde para orientações personalizadas.

**Q: Meus dados de saúde são seguros?**
A: Sim, usamos criptografia BCrypt para senhas e seguimos a LGPD. Seus dados nunca são compartilhados sem consentimento.

### Problemas Técnicos

**Q: O site está lento, o que fazer?**
A: Tente:
1. Limpar cache do navegador
2. Usar uma conexão de internet mais estável
3. Atualizar seu navegador
4. Contatar nosso suporte

**Q: Não consigo fazer upload de fotos**
A: Verifique:
1. Tamanho da imagem (máximo 10MB)
2. Formato (JPG, PNG)
3. Permissões da câmera no navegador

**Q: O dashboard não está atualizando**
A: Tente recarregar a página (F5) ou limpar o cache do navegador.

---

## 🆘 Suporte e Contato

### Canais de Suporte

- **Email:** suporte@bsfm.com.br
- **Chat online:** Disponível no site das 9h às 18h (BRT)
- **Telefone:** (11) 99999-9999
- **WhatsApp:** (11) 99999-9999

### Horário de Atendimento

- **Segunda a Sexta:** 9h às 18h (BRT)
- **Sábado:** 9h às 13h (BRT)
- **Plantão:** 24/7 para emergências técnicas

### Reportando Problemas

Ao reportar um problema, inclua:

1. **Descrição detalhada** do que aconteceu
2. **Passos para reproduzir** o problema
3. **Screenshots** ou vídeos
4. **Dispositivo e navegador** usado
5. **Hora exata** do ocorrido

---

## 📱 App Mobile

!!! info "Em breve"
    Nosso app mobile para iOS e Android está em desenvolvimento. Será lançado em **maio de 2026** com:
    - Análise em tempo real pela câmera
    - Notificações push para lembretes
    - Sincronização offline
    - Integração com Apple Health/Google Fit

**Cadastre-se em nossa newsletter** para ser notificado sobre o lançamento!

---

## 🔄 Atualizações e Novidades

### Como Ficar por Dentro

1. **Newsletter:** Cadastre-se em nosso site
2. **Blog:** Acesse blog.bsfm.com.br
3. **Redes sociais:**
   - Twitter: [@bsfm_br](https://twitter.com/bsfm_br)
   - Instagram: [@bsfm_brasil](https://instagram.com/bsfm_brasil)
   - LinkedIn: [BSFM](https://linkedin.com/company/bsfm)

### Sugestões de Melhoria

Tem uma ideia para melhorar o BSFM?

1. **Portal de ideias:** ideias.bsfm.com.br
2. **Pesquisas de usuário:** Participe quando convidado
3. **Grupos focais:** Inscreva-se para testes de novas features

---

## 📚 Recursos Adicionais

### Artigos Recomendados

- [Como interpretar rótulos nutricionais](https://blog.bsfm.com.br/rotulos-nutricionais)
- [10 hábitos para uma alimentação saudável](https://blog.bsfm.com.br/habitos-saudaveis)
- [Entendendo os macronutrientes](https://blog.bsfm.com.br/macronutrientes)
- [Planejamento alimentar para famílias](https://blog.bsfm.com.br/familias)

### Ferramentas Úteis

- **Calculadora de IMC** avançada
- **Planejador de compras** semanal
- **Conversor de medidas** culinárias
- **Tabela de substituição** de alimentos

### Parceiros e Colaboradores

- **Ministério da Saúde**
- **Sociedade Brasileira de Nutrição**
- **Universidades parceiras** (USP, UNICAMP, UFMG)
- **Hospitais de referência** em todo o Brasil

---

## 🏆 Dicas para Melhor Uso

### Para Melhores Análises

1. **Fotografe em boa luz** natural
2. **Use fundo neutro** (branco ou preto)
3. **Mostre o alimento inteiro**
4. **Evite pratos muito cheios**
5. **Use a porção correta** na configuração

### Para Acompanhamento Eficaz

1. **Atualize seu peso** semanalmente
2. **Registre todas as refeições**
3. **Revise suas metas** mensalmente
4. **Use os lembretes** do cronograma
5. **Compartilhe progresso** com profissionais

### Para Saúde e Segurança

1. **Consulte um profissional** regularmente
2. **Não use como diagnóstico**
3. **Respeite suas limitações**
4. **Mantenha hidratação** adequada
5. **Combine com atividade física**

---

!!! success "Pronto para Começar?"
    **Agora você tem todas as informações para usar o BSFM com eficiência.** Lembre-se: pequenas mudanças diárias levam a grandes transformações na saúde a longo prazo.

    **Equipe BSFM** - Transformando sua saúde, um alimento de cada vez. 🍎