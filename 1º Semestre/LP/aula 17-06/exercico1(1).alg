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
num, resp : inteiro
estado : caracter
inicio
// Se��o de Comandos
repita
   escreva("Digite um n�mero qualquer: ")
   leia(num)
   acao(num)
   escreval ("O numero digitado � ",estado)
   escreval("Deseja realizar a a��o novamente? 1-Sim 2-N�o")
   leia (resp)
   limpatela
ate resp=2
fimalgoritmo
