Algoritmo "semnome"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 8/21/2025
Var
// Seção de Declarações das variáveis 
x: inteiro
contador: inteiro
i: inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
leia(x)

para i de 1 ate x faca
     se (x % i = 0) entao
        contador <- contador + 1
     fimse
fimpara

se (contador = 2) entao
        escreva("Primo!")
fimse



Fimalgoritmo