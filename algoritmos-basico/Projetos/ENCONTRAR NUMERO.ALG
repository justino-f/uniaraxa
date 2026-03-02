Algoritmo "semnome"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 8/21/2025
Var
// Seção de Declarações das variáveis 
array: vetor[0..4] de inteiro
x: inteiro
i: inteiro

Inicio
leia(x)

// Não encontrei maneira de atribuir valores ao vetor de forma direta...
array[0] <- 1
array[1] <- 2
array[2] <- 3
array[3] <- 4
array[4] <- 5

para i de 0 ate 4 faca
     se (array[i] = x) entao
        escreva("Achei!")
     fimse
fimpara

Fimalgoritmo