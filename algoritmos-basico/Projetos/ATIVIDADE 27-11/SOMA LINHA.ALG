Algoritmo "Soma Linhas"

Var
matriz: vetor[1..3, 1..3] de inteiro
i, j: inteiro
somatorios: vetor[1..3] de inteiro

Inicio

para i de 1 ate 3 passo 1 faca
	para j de 1 ate 3 passo 1 faca
		leia(matriz[i,j])
		somatorios[i] <- somatorios[i] + matriz[i,j] 
	fimpara
fimpara

escreva(somatorios)

Fimalgoritmo
	
