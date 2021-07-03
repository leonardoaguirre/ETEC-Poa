algoritmo "semnome"
// Função :
// Autor :
// Data : 17/6/2016
// Seção de Declarações


procedimento acao (num : inteiro)
var

inicio
se (num mod 2 = 0) entao
   estado <- ("Par")
senao
   estado <- ("ímpar")
fimse


fimprocedimento

var
num, resp : inteiro
estado : caracter
inicio
// Seção de Comandos
repita
   escreva("Digite um número qualquer: ")
   leia(num)
   acao(num)
   escreval ("O numero digitado é ",estado)
   escreval("Deseja realizar a ação novamente? 1-Sim 2-Não")
   leia (resp)
   limpatela
ate resp=2
fimalgoritmo
