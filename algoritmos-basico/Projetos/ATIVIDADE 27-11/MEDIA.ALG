Algoritmo "Media"

Var
matriz: vetor[1..5, 1..2] de inteiro
i, j: inteiro
somatorio: inteiro

Inicio
somatorio <- 0

para i de 1 ate 5 passo 1 faca
	para j de 1 ate 2 passo 1 faca
		leia(vetor[i, j])
		somatorio <- somatorio + vetor[i,j]
	fimpara
fimpara

escreva(somatorio/(5 * 2))

Fimalgoritmo 
