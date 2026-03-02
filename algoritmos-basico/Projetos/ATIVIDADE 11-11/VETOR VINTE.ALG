Algoritmo "Vetor Vinte"

Var
array: vetor[1..20] de inteiro
pares, impares, maiores_50, menores_7: inteiro


Inicio
pares, impares, maiores_50, menores_7 <- 0

para i de 1 ate 20 passo 1 faca
     	escreval("Insira o valor de Array[",i,"]: ")
     	leia(array[i])
	se array[i] % 2 == 0 faca
		pares <- pares + 1
	fimse
	se array[i] % 2 <> 0 faca
		impares <- impares + 1
	fimse
	se array[i] > 50 faca
		maiores_50 <- maiores_50 + 1
	fimse
	se array[i] < 7 faca
		menores_7 <- menores_7 + 1
	fimse
fimpara
 
escreval(pares, impares, maiores_50, menores_7)

Fimalgoritmo
