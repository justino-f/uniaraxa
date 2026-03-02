Algoritmo "Somat�rio Indices"

Var
array1: vetor[1..10] de inteiro
array2: vetor[1..10] de inteiro
somatorio: vetor[1..10] de inteiro
i: inteiro

Inicio
para i de 1 ate 10 passo 1 faca
	escreva("Insira o valor de Array1[",i,"]: ")
	leia(array1[i])
	escreva("Insira o valor de Array2[",i,"]: ")
	leia(array2[i])
	somatorio[i] <- array1[i] + array2[i]
fimpara

para i de 1 ate 10 passo 1 faca
	escreva(",somatorio[]i,")
fimpara

Fimalgoritmo
