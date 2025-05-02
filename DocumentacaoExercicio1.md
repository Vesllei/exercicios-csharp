# Documentação Detalhada - Exercício 1: Validador de Senhas Fortes

##  Passo a Passo Lógico

Para resolver o validador de senha, seguimos os seguintes passos:

1. Primeiro, pedimos para o usuário digitar a senha.

2. Criamos três variáveis booleanas:
   - Uma para verificar se existe pelo menos **uma letra maiúscula**.
   - Uma para verificar se existe pelo menos **um número**.
   - E outra para verificar se existe pelo menos **um caractere especial**.

3. Depois, percorremos a senha **letra por letra** usando um `foreach`.

4. Durante esse percurso:
   - Se acharmos uma **letra maiúscula**, marcamos a variável correspondente como verdadeira.
   - Se acharmos um **número**, marcamos a variável de número como verdadeira.
   - Se acharmos um **caractere especial** (ou seja, algo que **não é letra nem número**), também marcamos.

5. No final, fazemos uma verificação geral:
   - A senha precisa ter no mínimo **8 caracteres**.
   - E precisa atender aos **três critérios anteriores**.

6. Dependendo do resultado, mostramos se a senha é válida ou inválida para o usuário.

---

##  Estruturas e Comandos Utilizados

- `Console.ReadLine()` para receber a senha do usuário.
- Laço `foreach` para percorrer cada caractere da senha.
- Funções prontas do C#:
  - `char.IsUpper()` → identifica letras maiúsculas.
  - `char.IsDigit()` → identifica números.
  - `char.IsLetterOrDigit()` → ajuda a identificar caracteres especiais (por exclusão).
- Variáveis booleanas para marcar os requisitos.
- Operadores lógicos `&&` para verificar todas as condições juntas.

---

##  Justificativa do Método

- Escolhemos usar o `foreach` porque é mais prático quando queremos analisar cada caractere separadamente, sem precisar trabalhar com índices manualmente.
- Separar os requisitos em variáveis torna o código mais **claro**, facilitando **futuras alterações** ou **manutenções**.
- O uso de funções nativas (`IsUpper`, `IsDigit`, etc.) deixou a solução **simples**, **enxuta** e **eficiente**, evitando a necessidade de criar verificações manuais para cada tipo de caractere.
