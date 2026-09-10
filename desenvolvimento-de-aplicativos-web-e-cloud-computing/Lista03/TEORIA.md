1 ) Motivo 1: Segurança. Sanitizar os dados recebidos do cliente antes de inseri-los dentro da lógica de negócio do cliente garante que nenhum input mal-intencionado (SQL Injection, Command Injection etc.) prejudique a confiencialidade, integridade e disponibilidade do sistema.

Motivo 2: Padronização de estruturas de dados. Garantir que todos os dados de determinados tipos sejam formatados e padronizados para não haver inconsistências como CPFs com 12 dígitos, letras em inputs numéricos etc.

Motivo 3: Preservação da lógica de negócio. Garantir que todos os dados inputados, mesmo após tratamento de sintaxe, sejam utilizados nos endpoints corretos, para a finalidade desejada.

2 ) a: i - Nome: Mínimo 3 caracteres, apenas letras.
ii - CPF:  11 dígitos, apenas números, validação pelo dígito verificador.
iii - Data Nascimento: formato DD/MM/YYYY, validar idade, validar se data não é maior que data atual.
iv - Email: regex com A^z@A^z.*
v - Telefone: apenas dígitos, máximo 15 números
vi - Senha: Símbolos, maíusculas, minúsculas, números, mínimo de 8 caracteres.
vii - CEP: apenas números, exatos 8 dígitos
viii - Logradouro: apenas caracteres alfanuméricos, sem símbolos, máximo 20 caracteres
ix - Bairro: apenas letras, sem símbolos e números, máximo 20 caracteres
x - Cidade: apenas letras, sem símbolos e números, máximo 20 caracteres
xi - Estado: Apenas 2 letras.

b: i - Nome: mínimo 3 caracteres, apenas letras
ii - Carga horária: apenas dígitos números, máximo 4 dígitos
iii - Objetivo: letras, números e símbolos, máximo 300 caracteres
iv - Ementa: letras, números e símbolos, máximo 300 caracteres
v - Semestre: apenas 1 dígito, de 1 a 2.
vi - Ano: apenas números
vii - Nome professor: mínimo 3 caracteres, apenas letras

3 ) if-else: é mais direto ao ponto e visual, fica explícito no código a verificação que está sendo executada, entretanto, quando se tem um sistema amplo, esta solução não é escalável.

data annotation: é bem mais escalável, adaptável e flexível conforme a necessidade, mas envolve o uso de uma biblioteca a mais, e a criação de mais arquivos no source-code.