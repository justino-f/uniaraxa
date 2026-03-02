Algoritmo "Somatório Vetor"

Var
array: vetor[1..10] de inteiro
i, soma: inteiro


Inicio
soma <- 0
para i de 1 ate 10 passo 1 faca
     escreval("Insira o valor de Array[",i,"]: ")
     leia(array[i])
     soma <- soma + i
fimpara
escreval(soma)

Fimalgoritmo