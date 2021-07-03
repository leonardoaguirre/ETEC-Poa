algoritmo "semnome"
// Função :
// Autor :
// Data : 13/5/2016
// Seção de Declarações
var

vetNum : vetor [0..99] de inteiro
contPares, contImpares : inteiro
i : inteiro

inicio

contPares <- 0
contImpares <- 0

para i de 0 ate 99 faca
   vetNum[i] <- randi (501)
   se (vetNum[i] mod 2 = 0 ) entao
      contPares <- contPares + 1
      senao
      contImpares <- contImpares + 1
   fimse
   timer 200
   escreva (vetNum[i])
   timer 0
   limpatela
fimpara

limpatela
escreva ("Pares: ",  contPares, "impares: ", contImpares)




// Seção de Comandos
fimalgoritmo
