algoritmo "semnome"
// Função :  ler 3 nomes e endereços,armazenando em vetores
// Autor :
// Data : 6/5/2016
// Seção de Declarações
var
ANOMES : VETOR[0..2] DE CARACTER
AEND : VETOR[0..2] DE CARACTER
I : INTEIRO
inicio

PARA I DE 0 ATE 2 FACA
LIMPATELA
ESCREVAL ("POR FAVOR, DIGITE O NOME E O ENDEREÇO DA",I+1,"ª PESSOA!")
ESCREVA("DIGITE UM NOME: ")
LEIA (ANOMES[I])
ESCREVAL
ESCREVA("DIGITE O ENDEREÇO: ")
LEIA(AEND[I])
FIMPARA


fimalgoritmo
