algoritmo "Função 2"
// Função :
// Autor :
// Data : 17/6/2016
// Seção de Declarações 
var
frase : caracter


//Local de criação de procedimentos e funções
procedimento limpar (frase:caracter)
var


inicio

limpatela
escreval

fimprocedimento

//Função
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

   SE (fraseaux = " ") ENTAO     //COPIA ESPAÇO EM BRANCO

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
