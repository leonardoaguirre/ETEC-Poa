algoritmo "Quiz"
// Fun��o :
// Autor :
// Data : 10/6/2016
// Se��o de Declara��es
var

respostas : vetor[1..5] de caracter
respatual, acertos : inteiro

//Grava as respostas
procedimento pudima (indice : inteiro)

var

inicio

escreva("Digite sua resposta: ")
leia(respostas[indice])
se ((respostas[indice] = "a")) entao
   acertos<- acertos+1
fimse
respatual <- respatual + 1
fimprocedimento

procedimento pudimb (indice : inteiro)

var

inicio


escreva("Digite sua resposta: ")
leia(respostas[indice])
se ((respostas[indice] = "b")) entao
   acertos<- acertos+1
fimse
respatual <- respatual + 1
fimprocedimento

procedimento pudimc (indice : inteiro)

var

inicio
escreva("Digite sua resposta: ")
   leia(respostas[indice])
   se ((respostas[indice] = "c")) entao
      acertos<- acertos+1
   fimse
   respatual <- respatual + 1
fimprocedimento

//Programa principal
inicio
respatual <- 1
acertos <- 0
//Quest�o 1
escreval ("Pergunta 1: Resolva: 2 X 10 - 5 + 34 + 128 - 78 X 23 + 0,1 X 4 =?")
escreval("A. 9108,5")
escreval("B. 9108,3")
escreval("C. 9108,4")
pudimc(respatual)
escreval("===============================")
//Quest�o 2

escreval ("Pergunta 2: Quantos estados a regi�o sudeste do brasil possui?")
escreval("A. 6")
escreval("B. 5")
escreval("C. 3")
pudima(respatual)

escreval("===============================")
//Quest�o 3

escreval ("Pergunta 3: Qual � a vegeta��o rasteira que se encontra perto das regi�es polares?")
escreval("A. Coniferas ")
escreval("B. Tundras")
escreval("C. Gram�neas")
pudimb(respatual)

escreval("===============================")
//Quest�o 4

escreval ("Pergunta 4: Qual � o numero que precede uma express�o?")
escreval("A. Numerador")
escreval("B. Multiplicador")
escreval("C. Coeficiente")
pudimc(respatual)

escreval("===============================")
//Quest�o 5

escreval ("Pergunta 5 Quem executa, ou dirige a impress�o de textos?")
escreval("A. Tipografo")
escreval("B. Tipografico")
escreval("C. Cart�grafo")
pudimc(respatual)

Escreval ("Parab�ns! Voc� acertou",acertos," quest�es")

fimalgoritmo
