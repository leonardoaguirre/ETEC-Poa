algoritmo "Fun��o 2"
// Fun��o :
// Autor :
// Data : 17/6/2016
// Se��o de Declara��es 
var
frase : caracter


//Local de cria��o de procedimentos e fun��es
procedimento limpar (frase:caracter)
var


inicio

limpatela
escreval

fimprocedimento

//Fun��o
funcao quebraFrase (txt: caracter) : inteiro
var

tamfrase : INTEIRO
i : INTEIRO
contPalavras, contesp : INTEIRO
qdtPalavra : INTEIRO

inicio

tamfrase <- COMPR (txt)  // DETERMINA O TAMANHO DA FRASE

PARA I DE 1 ATE tamfrase FACA   // PASSA POR TODAS AS LETRAS


   fraseaux <- COPIA (txt,I,1)  //COPIA CADA LETRA

   SE (fraseaux = " ") ENTAO     //COPIA ESPA�O EM BRANCO

      contesp <- contesp + 1   //DETERMINA QUANTIDADE DE PALAVRAS

   FIMSE
FIMPARA

qtdPalavra <-  contesp + 1
retorne qtdPalvra
fimfuncao


inicio

escreva("Digite uma frase:")
leia(frase)

contPalavras <- quebraFrase(frase)

fimalgoritmo
