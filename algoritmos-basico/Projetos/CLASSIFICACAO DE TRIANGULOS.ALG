Algoritmo "semnome"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 8/21/2025
Var
// Seção de Declarações das variáveis 
a: inteiro
b: inteiro
c: inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
leia(a)
leia(b)
leia(c)

se (a = b) e (b = c) entao
   escreva("Equilátero!")
senao
     se (a = b) ou (b = c) entao
           escreva("Isósceles!")
     senao
          escreva("Escaleno!")
     fimse
fimse


Fimalgoritmo