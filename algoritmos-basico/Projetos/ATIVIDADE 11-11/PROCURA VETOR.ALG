Algoritmo "Procura Vetor"

Var
array: vetor[1..8] de inteiro
i: inteiro
input: inteiro


Inicio
para i de 1 ate 8 passo 1 faca
	escreva("Insira o valor de Array[,"i",]: ")
	leia(array[i])
fimpara

escreval("Insira o número a ser procurado: ")
leia(input)
para i de 1 ate 8 passo 1 faca
	se array[i] == input faca
		escreval("O número foi encontrado!")
		interrompe
	fimse
fimpara
Fimalgoritmo 
