algoritmo "exerc2"
// Fun��o : Ler 'n' n�meros e armazenar os 5 primeiros pares
// Autor :
// Data : 13/5/2016
// Se��o de Declara��es
var

vetPares : vetor[1..5] de inteiro
num : inteiro
cont : inteiro

inicio

cont <- 0
//estrutura para os 5 valores
repita
   //bloquear valores menores que 1
   repita
      limpatela
      escreva ("Digite um numero qualquer: ")
      leia (num)
   ate (num > 0)

   //verifica se o numero 'num' � par
   se (num mod 2 = 0) entao
      cont <- cont + 1
      vetPares [cont] <- num

   fimse
ate (cont=5)

 //exibindo os valores armazenados
 para cont de 1 ate 5 faca
 escreval (vetPares[cont])
 
 fimpara


// Se��o de Comandos
fimalgoritmo
