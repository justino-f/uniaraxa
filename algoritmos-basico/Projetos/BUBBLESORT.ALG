algoritmo "BubbleSort_VisualG"

var
   numeros : vetor[1..5] de inteiro
   i, j, aux : inteiro
   
inicio
   para i de 1 ate 5 faca
      escreva("Digite o ", i, "o numero: ")
      leia(numeros[i])
   fimpara

   para i de 1 ate 4 faca
      para j de 1 ate 5 - i faca
         se numeros[j] > numeros[j+1] entao
            aux <- numeros[j]
            numeros[j] <- numeros[j+1]
            numeros[j+1] <- aux
         fimse
      fimpara
   fimpara

   escreval("Ordenado:")
   para i de 1 ate 5 faca
      escreval(numeros[i])
   fimpara
fimalgoritmo
