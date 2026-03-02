Algoritmo "Somat�rio Vetor"

Var
matriz: vetor[1..5, 1..5] de inteiro
i, j: inteiro
somaPares: inteiro

Inicio
somaPares <- 0

para i de 1 ate 5 passo 1 faca
	para j de 1 ate 5 passo 1 faca
		leia(matriz[i,j])
		se matriz[i,j] % 2 == 0 faca
			somaPares <- somaPares + 1
		fimse
	fimpara
fimpara

escreva(somaPares)		

Fimalgoritmo
