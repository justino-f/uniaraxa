ALgoritmo "Transposta"

Var
transposta: vetor[1..3, 1..3] de inteiro
matriz: vetor[1..3, 1..3] de inteiro
i, j: inteiro

Inicio

para i de 1 ate 10 passo 1 faca
	para j de 1 ate 10 passo 1 faca
		leia(matriz[i, j])
		transposta[i,j] <- matriz[j,i]
	fimpara
fimpara

escreva(transposta)

Fimalgoritmo


