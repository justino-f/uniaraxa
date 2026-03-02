Algoritmo "Troca"

Var
array: vetor[1..10] de inteiro
left, right: inteiro
buffer: inteiro
i: inteiro

Inicio

para i de 1 ate 10 passo 1 faca
     escreval("Insira o valor de Array[",i,"]: ")
     leia(array[i])
fimpara

left <- array[1]
right <- array[10]

para i de 1 ate 5 passo 1 faca
	array[right] <- buffer
	array[right] <- array[left]
	array[left] <- buffer
	right <- right - 1
	left <- left + 1
fimpara

escreva(array)
	
Fimalgoritmo
