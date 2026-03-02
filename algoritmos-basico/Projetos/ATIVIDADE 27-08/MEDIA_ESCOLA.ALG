Algoritmo "MEDIA_ESCOLA"

Var
soma: inteiro
x: inteiro
i: inteiro
media: real

Inicio

para i de 0 até 2 faca
     leia(x)
     soma <- soma + x
fimpara

media <- soma / 3

se media >= 7 entao
   escreval("Aprovado!")
senao
     se media >= 5 entao
              escreval("Recuperação!")
      senao
           escreval("Reprovado!")
     fimse
fimse

Fimalgoritmo