algoritmo "criptografia"
// Função : Ler uma frase , limitar os caracteres e trocar os elementos
// Autor :
// Data : 20/5/2016
// Seção de Declarações
var

frase, fraseAux : caracter
fatia1, fatia2 :caracter
i : inteiro
tamFrase, contVogais, contSimbolos, contCons : inteiro

vetFrase : vetor[1..30] de caracter

inicio

escreva ("Digite uma frase qualquer (limite 30 caracteres): ")
leia (frase)
//retorna a quantidade de caracteres de uma sequencia
tamFrase <- compr(frase)
//copia determinada quantidade de caracteres de uma sequencia
fraseAux <- copia(frase,1,30)

para i de 1 ate 30 faca

   vetFrase[i] <- copia(fraseAux,i,1)
   //estrutura de decisão Escolha/Caso
   escolha vetFrase [i]

   caso "a","e","i","o","u"
      contVogais <- contVogais + 1
      escolha vetFrase [i]

      caso "a"
         vetFrase [i] <- "4"
      caso "e"
         vetFrase [i] <- "3"
      caso "i"
         vetFrase [i] <- "%"
      caso "o"
         vetFrase [i] <- "*"
      outrocaso
         vetFrase [i] <"
      caso " ", ",","/","\","!","?"
         contSimbolos <- contSimbolos + 1
      outrocaso
         contCons <- contCons + 1
      fimescolha

   fimpara
   para i de 1 ate 30 faca
      escreval (vetFrase[i])
      i <- i + 1
   fimpara


   //fatia1 <- copia(frase,1,3)
   //fatia2 <- copia(frase,11,5)

   //limpatela
   //escreval (frase)
   //escreval (fraseAux)
   //escreval (fatia1)
   //escreval (fatia2)



fimalgoritmo
