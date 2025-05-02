# Documentação Detalhada - Exercício 4: Conversor de Temperaturas com Menu

##  Passo a Passo Lógico

Para montar o conversor de temperaturas, fizemos assim:

1. Apresentamos um menu com três opções:
   - `1` para converter de Celsius para Fahrenheit.
   - `2` para converter de Fahrenheit para Celsius.
   - `3` para sair do programa.

2. Pedimos ao usuário para escolher uma opção.

3. Criamos um `switch` para tratar cada opção separadamente:
   - Se escolher a **opção 1**, pedimos a temperatura em Celsius, fazemos a conversão e mostramos o resultado.
   - Se escolher a **opção 2**, pedimos a temperatura em Fahrenheit, fazemos a conversão para Celsius e mostramos.
   - Se escolher a **opção 3**, apenas mostramos uma mensagem de encerramento.
   - Se for qualquer outro número, informamos que a opção é inválida.

4. Mantivemos o menu em execução usando um `do-while`, para que o usuário pudesse fazer várias conversões sem precisar reiniciar o programa.

---

##  Estruturas e Comandos Utilizados

- Estrutura `do-while` para manter o menu ativo até que o usuário decida sair.
- Estrutura `switch-case` para lidar com a escolha do usuário de forma organizada.
- Comandos básicos de entrada e saída:
  - `Console.WriteLine`
  - `Console.ReadLine`
- Cálculos matemáticos simples para conversão de temperatura:
  - **Celsius → Fahrenheit**: `(C × 9/5) + 32`
  - **Fahrenheit → Celsius**: `(F - 32) × 5/9`

---

##  Justificativa do Método

- Utilizamos `do-while` porque queríamos garantir que o menu fosse mostrado ao menos uma vez, mesmo que o usuário decidisse sair imediatamente.
- O `switch` deixou o código mais limpo e organizado do que usar múltiplos `if-else`, além de facilitar a manutenção e a leitura.
- As fórmulas matemáticas foram aplicadas diretamente dentro do código, pois são simples e não exigem o uso de funções externas.

Dessa forma, conseguimos construir uma solução prática, interativa e de fácil entendimento para quem utilizar o programa.
