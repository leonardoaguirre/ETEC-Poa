algoritmo "semnome"
// Função :
// Autor :
// Data : 23/6/2016
// Seção de Declarações
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
   escreval ("O valor ao quadrado é: ",res)
   escreval
   escreval ("Deseja realizar a operação novamente? 1-Sim 2-Não")
   leia(resp)
   limpatela
ate resp=2

fimalgoritmo

