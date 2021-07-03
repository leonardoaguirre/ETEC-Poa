algoritmo "exerc3"
// Função : armazenar 10 nomes e sobrenomes em vetores, sorteio aleatório
// Autor :
// Data : 13/5/2016
// Seção de Declarações
var

vetnomes : vetor[0..9] de caracter
vetsobrenomes : vetor [0..9] de caracter
nomecompleto : caracter
sort1, sort2, max : inteiro
cont : inteiro
sair: caracter
inicio
max<- 3
cont <- 0
//leitura dos 10 nomes e sobrenomes

enquanto (cont<max) faca
   escreva("Digite um nome: ")
   leia(vetnomes[cont])
   escreva("Digite um sobrenome: ")
   leia(vetsobrenomes[cont])
   cont<-cont+1


fimenquanto
repita
   sort1 <- randi(max)
   nomecompleto <- vetnomes[sort1]
   repita
      sort2 <- randi(max)
   ate (sort1 <> sort2)
   nomecompleto <- nomecompleto + " " + vetsobrenomes[sort2]

   limpatela
   Escreva(nomecompleto)
   repita
      Escreval
      escreva ("Você quer que sorteie novamente? [S/N]: ")
      leia (sair)
   ate ((sair = "s") ou (sair = "n"))
ate (sair = "n")



fimalgoritmo

