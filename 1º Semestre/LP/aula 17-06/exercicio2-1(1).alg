algoritmo "semnome"
// Função :
// Autor :
// Data : 17/6/2016
// Seção de Declarações 

procedimento padrao (num : inteiro)(matriz : caracter)
var

inicio
para i de 1 ate num faca
   para j de 1 ate num faca
      matriz[i,j] <- "#"
   fimpara
fimpara
fimprocedimento
var
 num, i, j : inteiro
 matriz : vetor [1..10,1..10] de caracter
inicio
escreva("Digite o numero do padrão desejado entre 5 e 10 :")
leia (num)
padrao(num)

escreva(matriz[i,j])

fimalgoritmo
