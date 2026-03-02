Algoritmo "Positivos Vetor"

Var
array: vetor[1..15] de inteiro
positivos: vetor[1..15] de inteiro
i: inteiro
indexPositivo: inteiro

Inicio
indexPositivo <- 15
para i de 1 ate 15 passo 1 faca
	escreva("Insira o valor de Array[",i,"]: ")
	leia(array[i])
	se array[i] >= 0 faca
		positivos[i] <- array[i]
	fimse
fimpara

para i de 1 ate 15 passo 1 faca
	se indexPositivo[i] <> 0 faca
		escreva(",indexPositivo[i],")
	fimse
fimpara
Fimalgoritmo
