algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 17/6/2016
// Se��o de Declara��es


procedimento acao (num : inteiro)
var

inicio
se (num mod 2 = 0) entao
   estado <- ("Par")
senao
   estado <- ("�mpar")
fimse


fimprocedimento

var
num : inteiro
estado : caracter
inicio
// Se��o de Comandos
escreva("Digite um n�mero qualquer: ")
leia(num)
acao(num)
escreval ("O numero digitado � ",estado)

fimalgoritmo
