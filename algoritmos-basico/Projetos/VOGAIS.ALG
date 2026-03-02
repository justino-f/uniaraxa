algoritmo "vogais"

var
   vogais : vetor[1..5] de caractere
   string: caractere
   i: inteiro
   j: inteiro
   counter: inteiro

inicio
vogais[1] <- "a"
vogais[2] <- "e"
vogais[3] <- "i"
vogais[4] <- "o"
vogais[5] <- "u"

string <- "abacaxi"

para i de 1 ate 7 faca
     para j de 1 ate 5 faca
          se string[i] = vogais[j] entao // erro desconhecido
             counter <- counter + 1
          fimse
     fimpara
fimpara

escreva(counter)



fimalgoritmo
