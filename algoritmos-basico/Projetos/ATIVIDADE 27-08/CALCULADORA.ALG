Algoritmo "MEDIA_ESCOLA"

Var
x: inteiro
y: inteiro
input: inteiro

Inicio

escreval("[1] SOMA")
escreval("[2] SUBTRAÇÃO")
escreval("[3] MULTIPLICAÇÃO")
escreval("[4] DIVISÃO")
leia(input)

escolha input

        caso 1
             leia(x)
             leia(y)
             escreval(x + y)
        caso 2
             leia(x)
             leia(y)
             escreval(x - y)
        caso 3
             leia(x)
             leia(y)
             escreval(x * y)
        caso 4
             leia(x)
             leia(y)
             escreval(x / y)
fimescolha

Fimalgoritmo