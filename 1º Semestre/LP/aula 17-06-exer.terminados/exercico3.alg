algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 23/6/2016
// Se��o de Declara��es
var
num, res, resp : inteiro

funcao abc (n : inteiro) : inteiro

var
result : inteiro


inicio
result<- n*n

retorne result
fimfuncao


inicio
repita
   repita
      escreval("Digite um numero entre 0 e 100: ")
      leia(num)
   ate (num>=0)e(num<=100)
   res<-abc(num)
   escreval ("O valor ao quadrado �: ",res)
   escreval
   escreval ("Deseja realizar a opera��o novamente? 1-Sim 2-N�o")
   leia(resp)
   limpatela
ate resp=2

fimalgoritmo

