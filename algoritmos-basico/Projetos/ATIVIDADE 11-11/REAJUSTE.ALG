Algoritmo "Reajuste"

Var
array: vetor[1..10] de inteiro
i: inteiro


Inicio
para i de 1 ate 10 passo 1 faca
	escreval("Insira o valor do Salário[",i,"]: ")
     	leia(array[i])
	array[i] <- array[i] * 1.05
fimpara

para i de 1 ate 10 passo 1 faca
	escreva(array[i])
fimpara

Fimalgoritmo
