algoritmo "semnome"
// Função :
// Autor :
// Data : 17/6/2016
// Seção de Declarações

var
num, i, j, resp : inteiro
matriz : vetor [1..10,1..10] de caracter
procedimento padrao (num : inteiro)(matriz : caracter)
var

inicio
para i de 1 ate num faca
   para j de 1 ate num faca
      matriz[i,j] <- "#"
   fimpara
fimpara
fimprocedimento

inicio
repita
   repita
      escreva("Digite o numero do padrão desejado entre 5 e 10 :")
      leia (num)
   ate (num>=5)e(num<=10)
   padrao(num)
   para i de 1 ate num faca
      escreva(matriz[i,j])
   fimpara
   para j de 1 ate num faca
         escreval(matriz[i,j])
      fimpara
   escreval
   escreval ("Deseja realizar o programa novamente? 1-Sim 2-Não")
   leia (resp)
ate resp=2
fimalgoritmo
