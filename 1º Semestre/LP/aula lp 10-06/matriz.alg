algoritmo "semnome"
// Função :
// Autor :
// Data : 10/6/2016
// Seção de Declarações
var
vetnomes : vetor[1..5] de caracter
//declaração de matriz {primeiro linha depois coluna[1..2,1..3]}
matriz : vetor[1..2,1..3] de inteiro
i, j : inteiro

inicio
// leitura dos valores da matriz
para i de 1 ate 2 faca //representa linha
   para j de 1 ate 3 faca //representa coluna
      leia (matriz[i,j])
   fimpara
fimpara

limpatela
 //exibição dos valores da matriz
para i de 1 ate 2 faca
   para j de 1 ate 3 faca
      escreva(matriz[i,j])
   fimpara
   escreval
fimpara


fimalgoritmo
