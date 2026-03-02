Algoritmo "Maior Menor"

Var
matriz: vetor[1..6, 1..3] de inteiro
i, j: inteiro
maior, menor: inteiro

Inicio
maior, menor <- 0


para i de 1 ate 6 passo 1 faca
	para j de 1 ate 3 passo 1 faca
		leia(matriz[i, j])
	fimpara
fimpara	

maior <- matriz[1,1]
menor <- matriz[1,1]

para i de 1 ate 6 passo 1 faca
	para j de 1 ate 3 passo 1 faca
		se matriz[i,j] < menor faca
			menor <- matriz[i,j]
		fimse
		se matriz[i,j] > maior faca
			maior <- matriz[i,j]
		fimse
	fimpara
fimpara

escreva(maior, menor)

Fimalgoritmo
