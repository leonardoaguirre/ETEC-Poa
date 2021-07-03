algoritmo "semnome"
// Função :
// Autor :
// Data : 24/6/2016
// Seção de Declarações
var
// Variáveis da tela inicial
op1, op2: caracter
// Variáveis da calculadora
a, b, raiz: real
oper, op3, ind, mens: caracter
// Variáveis do Conversor de Unidades
op4, op5, op6, op7, op8, op9, op10, op11, op12, op13, op14, op15: caracter
c, f, r, d, cot, km, m, cm, mm, hec, km2, m2, cm2, dia, h, min, s: real
// Variáveis do jogo
palavra:vetor[0..2] de caractere
elemento:vetor[1..20] de caractere
posicao:vetor[1..3] de inteiro
restante:vetor[1..3] de caractere
qtdrestante:vetor[1..2] de inteiro
acao:vetor[1..2] de caractere
info:caracter
tentativas,chances:inteiro
escolhida,letra:caractere
aleat,qtdcaracteres,i,pontos,pontosperdidos:inteiro

inicio
repita
   limpatela
   escreval("Digite o número correspondente à aplicação que deseja executar:")
   escreval
   escreval("1. Calculadora")
   escreval("2. Conversor de unidades")
   escreval("3. Jogo")
   escreval("4. Sair do Sistema")
   escreval
   leia(op2)
   escolha op2
   caso "1"
      limpatela
      repita
         repita
            limpatela
            escreval("Informe a operação que deseja fazer:")
            escreval("1. Soma")
            escreval("2. Subtração")
            escreval("3. Multiplicação")
            escreval("4. Divisão")
            escreval("5. Potenciação")
            escreval("6. Raiz")
            escreval
            leia(oper)
         ate (oper = "1") ou (oper = "2") ou (oper = "3") ou (oper = "4") ou (oper = "5") ou (oper = "6")
         escreval
         se oper = "6" entao
            repita
               limpatela
               escreval("Informe a raiz que deseja calcular:")
               escreval("1. Raiz quadrada")
               escreval("2. Raiz cúbica")
               escreval
               leia(ind)
            ate (ind = "1") ou (ind = "2")
            escreval
            escreval("Digite um número:")
            escreval
            leia(a)
            se ind = "1" entao
               raiz <- a ^ (1/2)
               mens <- "quadrada"
            senao
               se ind = "2" entao
                  raiz <- a ^ (1/3)
                  mens <- "cúbica"
               fimse
            fimse
            escreval
            escreval(">>> A raiz ", mens, " de", a, " é:", raiz)
         senao
            se oper <> 6 entao
               escreval("Digite o primeiro número:")
               leia(a)
               escreval
               escreval("Digite o segundo número:")
               leia(b)
               escreval
               se oper = "1" entao
                  escreval(">>> O resultado da soma é: ", a + b)
               senao
                  se oper = "2" entao
                     escreval(">>> O resultado da subtração é: ", a - b)
                  senao
                     se oper = "3" entao
                        escreval(">>> O resultado da multiplicação é: ", a * b)
                     senao
                        se oper = "4" entao
                           escreval(">>> O resultado da divisão é: ", a / b)
                        senao
                           se oper = "5" entao
                              escreval(">>> O resultado da potenciação é: ", a ^ b)
                           fimse
                        fimse
                     fimse
                  fimse
               fimse
            fimse
         fimse
         escreval
         escreval("Digite:")
         escreval("0. Sair do sistema")
         escreval("1. Fazer outra operação")
         escreval("2. Retornar ao menu principal")
         escreval
         leia(op3)
         escreval
         se (op3 <> "0") e (op3 <> "1") e (op3 <> "2") entao
            limpatela
            escreval
            escreval (">>> Comando incorreto!")
            escreval(">>> Programa finalizado!")
            escreval
         fimalgoritmo
      senao
         escolha op3
         caso "2"
            limpatela
            interrompa

            fimrepita
         caso "0"
            limpatela
         fimalgoritmo
      caso "1"
         limpatela
      fimescolha
   fimse
   fimrepita
caso "2"
   limpatela
   repita
      repita
         limpatela
         escreval("Digite o número da conversão que deseja executar:")
         escreval
         escreval("1. Temperatura")
         escreval("2. Moeda")
         escreval("3. Distância")
         escreval("4. Área")
         escreval("5. Tempo")
         escreval
         leia (op4)
      ate (op4 = "1") ou (op4 = "2") ou (op4 = "3") ou (op4 = "4") ou (op4 = "5")
      limpatela
      escolha op4
      caso "1"
         escreval("DE:")
         escreval
         escreval("1. Graus Celsius(°C)")
         escreval("2. Graus Fahrenheit(°F)")
         escreval
         leia(op5)
         escreval
         escreval("PARA:")
         escreval
         escreval("1. Graus Celsius(°C)")
         escreval("2. Graus Fahrenheit(°F)")
         escreval
         leia(op6)
         se (op5 = "1") e (op6 = "1") entao
            limpatela
            escreval
            escreva("Temperatura em Graus Celsius(°C):  ")
            leia(c)
            escreval
            escreval("Temperatura em Graus Celsius(°C):  ", c, " °C")
         senao
            se (op5 = "1") e (op6 = "2") entao
               limpatela
               escreval
               escreva("Temperatura em Graus Celsius(°C):  ")
               leia(c)
               f <- (9 * c + 160) / 5
               escreval
               escreval("Temperatura em Graus Fahrenheit(°F):  ", f, " °F")
            senao
               se (op5 = "2") e (op6 = "1") entao
                  limpatela
                  escreval
                  escreva("Temperatura em Graus Fahrenheit(°F):  ")
                  leia(f)
                  c <- (5 * f - 160) / 9
                  escreval
                  escreval("Temperatura em Graus Celsius(°C):  ", c, " °C")
               senao
                  se (op5 = "2") e (op6 = "2") entao
                     limpatela
                     escreval
                     escreva("Temperatura em Graus Fahrenheit(°F):  ")
                     leia(f)
                     escreval
                     escreval("Temperatura em Graus Fahrenheit(°F):  ", f, " °F")
                  senao
                     limpatela
                     escreval
                     escreval(">>> Comando incorreto!!!")
                  fimse
               fimse
            fimse
         fimse
      caso "2"



         escreval("DE:")
         escreval
         escreval("1. Real(R$)")
         escreval("2. Dólar(U$$)")
         escreval
         leia(op7)
         escreval
         escreval("PARA:")
         escreval
         escreval("1. Real(R$)")
         escreval("2. Dólar(U$$)")
         escreval
         leia(op8)
         se (op7 = "1") e (op8 = "1") entao
            limpatela
            escreval
            escreva("Valor em Real(R$):  ")
            leia(r)
            escreval
            escreval("Valor em Real(R$):  ", r, " R$")
         senao
            se (op7 = "1") e (op8 = "2") entao
               limpatela
               escreval
               escreva("Valor em Real(R$):  ")
               leia(r)
               escreval
               escreva("Cotação atual do Dólar:  ")
               leia(cot)
               d <- r / cot
               escreval
               escreval("Valor em Dólar(U$$): ", d, " U$$")
            senao
               se (op7 = "2") e (op8 = "1") entao
                  limpatela
                  escreval
                  escreva("Valor em Dólar(U$$):  ")
                  leia(d)
                  escreval
                  escreva("Cotação atual do Dólar:  ")
                  leia(cot)
                  r <- d * cot
                  escreval
                  escreval("Valor em Real(R$): ", r, " R$")
               senao
                  se (op7 = "2") e (op8 = "2") entao
                     limpatela
                     escreval
                     escreva("Valor em Dólar(U$$):  ")
                     leia(d)
                     escreval
                     escreval("Valor em Dólar(U$$): ", r, " U$$")
                  senao
                     limpatela
                     escreval
                     escreval(">>> Comando incorreto!!!")
                  fimse
               fimse
            fimse
         fimse
      caso "3"
         escreval("DE:")
         escreval
         escreval("1. Quilômetro(km)")
         escreval("2. Metro(m)")
         escreval("3. Centímetro(cm)")
         escreval("4. Milímetro(mm)")
         escreval
         leia(op9)
         escreval
         escreval("PARA:")
         escreval
         escreval("1. Quilômetro(km)")
         escreval("2. Metro(m)")
         escreval("3. Centímetro(cm)")
         escreval("4. Milímetro(mm)")
         escreval
         leia(op10)
         se (op9 = "1") e (op10 = "1") entao
            limpatela
            escreval
            escreva("Distância em Quilômetros(km):  ")
            leia(km)
            escreval
            escreval("Distância em Quilômetros:  ", km, " km")
         senao
            se (op9 = "1") e (op10 = "2") entao
               limpatela
               escreval
               escreva("Distância em Quilômetros(km):  ")
               leia(km)
               m <- km * 1000
               escreval
               escreval("Distância em Metros:  ", m, " m")
            senao
               se (op9 = "1") e (op10 = "3") entao
                  limpatela
                  escreval
                  escreva("Distância em Quilômetros(km):  ")
                  leia(km)
                  cm <- km * 100000
                  escreval
                  escreval("Distância em Centímetros:  ", cm, " cm")
               senao
                  se (op9 = "1") e (op10 = "4") entao
                     limpatela
                     escreval
                     escreva("Distância em Quilômetros(km):  ")
                     leia(km)
                     mm <- km * 1000000
                     escreval
                     escreval("Distância em Milímetros:  ", mm, " mm")
                  senao
                     se (op9 = "2") e (op10 = "1") entao
                        limpatela
                        escreval
                        escreva("Distância em Metros(m):  ")
                        leia(m)
                        km <- m / 1000
                        escreval
                        escreval("Distância em Quilômetros:  ", km, " km")
                     senao
                        se (op9 = "2") e (op10 = "2") entao
                           limpatela
                           escreval
                           escreva("Distância em Metros(m):  ")
                           leia(m)
                           escreval
                           escreval("Distância em Metros:  ", m, " m")
                        senao
                           se (op9 = "2") e (op10 = "3") entao
                              limpatela
                              escreval
                              escreva("Distância em Metros(m):  ")
                              leia(m)
                              cm <- m * 100
                              escreval
                              escreval("Distância em Centímetros:  ", cm, " cm")
                           senao
                              se (op9 = "2") e (op10 = "4") entao
                                 limpatela
                                 escreval
                                 escreva("Distância em Metros(m):  ")
                                 leia(m)
                                 mm <- m * 1000
                                 escreval
                                 escreval("Distância em Milímetros:  ", mm, " mm")
                              senao
                                 se (op9 = "3") e (op10 = "1") entao
                                    limpatela
                                    escreval
                                    escreva("Distância em Centímetros(cm):  ")
                                    leia(cm)
                                    km <- cm / 100000
                                    escreval
                                    escreval("Distância em Quilômetros:  ", km, " km")
                                 senao
                                    se (op9 = "3") e (op10 = "2") entao
                                       limpatela
                                       escreval
                                       escreva("Distância em Centímetros(cm):  ")
                                       leia(cm)
                                       m <- cm / 100
                                       escreval
                                       escreval("Distância em Metros:  ", m, " m")
                                    senao
                                       se (op9 = "3") e (op10 = "3") entao
                                          limpatela
                                          escreval
                                          escreva("Distância em Centímetros(cm):  ")
                                          leia(cm)
                                          escreval
                                          escreval("Distância em Centíetros:  ", cm, " cm")
                                       senao
                                          se (op9 = "3") e (op10 = "4") entao
                                             limpatela
                                             escreval
                                             escreva("Distância em Centímetros(cm):  ")
                                             leia(cm)
                                             mm <- cm * 10
                                             escreval
                                             escreval("Distância em Milímetros:  ", mm, " mm")
                                          senao
                                             se (op9 = "4") e (op10 = "1") entao
                                                limpatela
                                                escreval
                                                escreva("Distância em Milímetros(mm):  ")
                                                leia(mm)
                                                km <- mm / 1000000
                                                escreval
                                                escreval("Distância em Quilômetros:  ", km, " km")
                                             senao
                                                se (op9 = "4") e (op10 = "2") entao
                                                   limpatela
                                                   escreval
                                                   escreva("Distância em Milímetros(mm):  ")
                                                   leia(mm)
                                                   m <- mm / 1000
                                                   escreval
                                                   escreval("Distância em Metros:  ", m, " m")
                                                senao
                                                   se (op9 = "4") e (op10 = "3") entao
                                                      limpatela
                                                      escreval
                                                      escreva("Distância em Milímetros(mm):  ")
                                                      leia(mm)
                                                      cm <- mm / 10
                                                      escreval
                                                      escreval("Distância em Centímetros:  ", cm, " cm")
                                                   senao
                                                      se (op9 = "4") e (op10 = "4") entao
                                                         limpatela
                                                         escreval
                                                         escreva("Distância em Milímetros(mm):  ")
                                                         leia(mm)
                                                         escreval
                                                         escreval("Distância em Milímetros:  ", mm, " mm")
                                                      senao
                                                         limpatela
                                                         escreval
                                                         escreval(">>> Comando incorreto!!!")
                                                      fimse
                                                   fimse
                                                fimse
                                             fimse
                                          fimse
                                       fimse
                                    fimse
                                 fimse
                              fimse
                           fimse
                        fimse
                     fimse
                  fimse
               fimse
            fimse
         fimse

      caso "4"
         escreval("DE:")
         escreval
         escreval("1. Hectare(hec)")
         escreval("2. Quilômetro quadrado(km2)")
         escreval("3. Metro quadrado(m2)")
         escreval("4. Centímetro quadrado(cm2)")
         escreval
         leia(op11)
         escreval
         escreval("PARA:")
         escreval
         escreval("1. Hectare(hec)")
         escreval("2. Quilômetro quadrado(km2)")
         escreval("3. Metro quadrado(m2)")
         escreval("4. Centímetro quadrado(cm2)")
         escreval
         leia(op12)
         se (op11 = "1") e (op12 = "1") entao
            limpatela
            escreval
            escreva("Área em Hectare(hec):  ")
            leia(hec)
            escreval
            escreval("Área em Hectare:  ", hec, " hec")
         senao
            se (op11 = "1") e (op12 = "2") entao
               limpatela
               escreval
               escreva("Área em Hectare(hec):  ")
               leia(hec)
               km2 <- hec / 100
               escreval
               escreval("Área em Quilômetro quadrado: ", km2, " km2")
            senao
               se (op11 = "1") e (op12 = "3") entao
                  limpatela
                  escreval
                  escreva("Área em Hectare(hec):  ")
                  leia(hec)
                  m2 <- hec * 10000
                  escreval
                  escreval("Área em Metro quadrado: ", m2, " m2")
               senao
                  se (op11 = "1") e (op12 = "4") entao
                     limpatela
                     escreval
                     escreva("Área em Hectare(hec):  ")
                     leia(hec)
                     cm2 <- hec * 100000000
                     escreval
                     escreval("Área em Centímetro quadrado: ", cm2, " cm2")
                  senao
                     se (op11 = "2") e (op12 = "1") entao
                        limpatela
                        escreval
                        escreva("Área em Quilômetro quadrado(km2):  ")
                        leia(km2)
                        hec <- km2 * 100
                        escreval
                        escreval("Área em Hectare: ", hec, " hec")
                     senao
                        se (op11 = "2") e (op12 = "2") entao
                           limpatela
                           escreval
                           escreva("Área em Quilômetro quadrado(km2):  ")
                           leia(km2)
                           escreval
                           escreval("Área em Quilômetro quadrado: ", km2, " km2")
                        senao
                           se (op11 = "2") e (op12 = "3") entao
                              limpatela
                              escreval
                              escreva("Área em Quilômetro quadrado(km2):  ")
                              leia(km2)
                              m2 <- km2 * 1000000
                              escreval
                              escreval("Área em Metro quadrado: ", m2, " m2")
                           senao
                              se (op11 = "2") e (op12 = "4") entao
                                 limpatela
                                 escreval
                                 escreva("Área em Quilômetro quadrado(km2):  ")
                                 leia(km2)
                                 cm2 <- km2 * 10000000000
                                 escreval
                                 escreval("Área em Centímetro quadrado: ", cm2, " cm2")
                              senao
                                 se (op11 = "3") e (op12 = "1") entao
                                    limpatela
                                    escreval
                                    escreva("Área em Metro quadrado(m2):  ")
                                    leia(m2)
                                    hec <- m2 / 10000
                                    escreval
                                    escreval("Área em Hectare: ", hec, " hec")
                                 senao
                                    se (op11 = "3") e (op12 = "2") entao
                                       limpatela
                                       escreval
                                       escreva("Área em Metro quadrado(m2):  ")
                                       leia(m2)
                                       km2 <- m2 / 1000000
                                       escreval
                                       escreval("Área em Quilômetro quadrado: ", km2, " km2")
                                    senao
                                       se (op11 = "3") e (op12 = "3") entao
                                          limpatela
                                          escreval
                                          escreva("Área em Metro quadrado(m2):  ")
                                          leia(m2)
                                          escreval
                                          escreval("Área em Metro quadrado: ", m2, " m2")
                                       senao
                                          se (op11 = "3") e (op12 = "4") entao
                                             limpatela
                                             escreval
                                             escreva("Área em Metro quadrado(m2):  ")
                                             leia(m2)
                                             cm2 <- m2 * 10000
                                             escreval
                                             escreval("Área em Centímetro quadrado: ", cm2, " cm2")
                                          senao
                                             se (op11 = "4") e (op12 = "1") entao
                                                limpatela
                                                escreval
                                                escreva("Área em Centímetro quadrado(cm2):  ")
                                                leia(cm2)
                                                hec <- cm2 / 100000000
                                                escreval
                                                escreval("Área em Hectare: ", hec, " hec")
                                             senao
                                                se (op11 = "4") e (op12 = "2") entao
                                                   limpatela
                                                   escreval
                                                   escreva("Área em Centímetro quadrado(cm2):  ")
                                                   leia(cm2)
                                                   km2 <- cm2 / 10000000000
                                                   escreval
                                                   escreval("Área em Quilômetro quadrado: ", km2, " km2")
                                                senao
                                                   se (op11 = "4") e (op12 = "3") entao
                                                      limpatela
                                                      escreval
                                                      escreva("Área em Centímetro quadrado(cm2):  ")
                                                      leia(cm2)
                                                      m2 <- cm2 / 10000
                                                      escreval
                                                      escreval("Área em Metro quadrado: ", m2, " m2")
                                                   senao
                                                      se (op11 = "4") e (op12 = "4") entao
                                                         limpatela
                                                         escreval
                                                         escreva("Área em Centímetro quadrado(cm2):  ")
                                                         leia(cm2)
                                                         escreval
                                                         escreval("Área em Centímetro quadrado: ", cm2, " cm2")
                                                      senao
                                                         limpatela
                                                         escreval
                                                         escreval(">>> Comando incorreto!!!")
                                                      fimse
                                                   fimse
                                                fimse
                                             fimse
                                          fimse
                                       fimse
                                    fimse
                                 fimse
                              fimse
                           fimse
                        fimse
                     fimse
                  fimse
               fimse
            fimse
         fimse


      caso "5"
         escreval("DE:")
         escreval
         escreval("1. Dia")
         escreval("2. Hora(h)")
         escreval("3. Minuto(min)")
         escreval("4. Segundo(s)")
         escreval
         leia(op13)
         escreval
         escreval("PARA:")
         escreval
         escreval("1. Dia")
         escreval("2. Hora(h)")
         escreval("3. Minuto(min)")
         escreval("4. Segundo(s)")
         escreval
         leia(op14)
         se (op13 = "1") e (op14 = "1") entao
            limpatela
            escreval
            escreva("Tempo em Dia(s):  ")
            leia(dia)
            escreval
            escreval("Tempo em Dia(s):  ", dia, " dia(s)")
         senao
            se (op13 = "1") e (op14 = "2") entao
               limpatela
               escreval
               escreva("Tempo em Dia(s):  ")
               leia(dia)
               escreval
               h <- dia * 24
               escreval
               escreval("Tempo em Hora(s): ", h, " hora(s)")
            senao
               se (op13 = "1") e (op14 = "3") entao
                  limpatela
                  escreval
                  escreva("Tempo em Dia(s):  ")
                  leia(dia)
                  escreval
                  min <- dia * 1440
                  escreval
                  escreval("Tempo em Minuto(s): ", min, " min")
               senao
                  se (op13 = "1") e (op14 = "4") entao
                     limpatela
                     escreval
                     escreva("Tempo em Dia(s):  ")
                     leia(dia)
                     escreval
                     s <- dia * 86400
                     escreval
                     escreval("Tempo em Segundo(s): ", s, " s")
                  senao
                     se (op13 = "2") e (op14 = "1") entao
                        limpatela
                        escreval
                        escreva("Tempo em Hora(s):  ")
                        leia(h)
                        escreval
                        dia <- h / 24
                        escreval
                        escreval("Tempo em Dia(s): ", dia, " dia(s)")
                     senao
                        se (op13 = "2") e (op14 = "2") entao
                           limpatela
                           escreval
                           escreva("Tempo em Hora(s):  ")
                           leia(h)
                           escreval
                           escreval("Tempo em Hora(s): ", h, " hora(s)")
                        senao
                           se (op13 = "2") e (op14 = "3") entao
                              limpatela
                              escreval
                              escreva("Tempo em Hora(s):  ")
                              leia(h)
                              escreval
                              min <- h * 60
                              escreval
                              escreval("Tempo em Minuto(s): ", min, " min")
                           senao
                              se (op13 = "2") e (op14 = "4") entao
                                 limpatela
                                 escreval
                                 escreva("Tempo em Hora(s):  ")
                                 leia(h)
                                 escreval
                                 s <- h * 3600
                                 escreval
                                 escreval("Tempo em Segundo(s): ", s, " s")
                              senao
                                 se (op13 = "3") e (op14 = "1") entao
                                    limpatela
                                    escreval
                                    escreva("Tempo em Minuto(s):  ")
                                    leia(min)
                                    escreval
                                    dia <- min / 1440
                                    escreval
                                    escreval("Tempo em Dia(s): ", dia, " dia(s)")
                                 senao
                                    se (op13 = "3") e (op14 = "2") entao
                                       limpatela
                                       escreval
                                       escreva("Tempo em Minuto(s):  ")
                                       leia(min)
                                       escreval
                                       h <- min / 60
                                       escreval
                                       escreval("Tempo em Hora(s): ", h, " hora(s)")
                                    senao
                                       se (op13 = "3") e (op14 = "3") entao
                                          limpatela
                                          escreval
                                          escreva("Tempo em Minuto(s):  ")
                                          leia(min)
                                          escreval
                                          escreval("Tempo em Minuto(s): ", min, " min")
                                       senao
                                          se (op13 = "3") e (op14 = "4") entao
                                             limpatela
                                             escreval
                                             escreva("Tempo em Minuto(s):  ")
                                             leia(min)
                                             escreval
                                             s <- min * 60
                                             escreval
                                             escreval("Tempo em Segundo(s): ", s, " s")
                                          senao
                                             se (op13 = "4") e (op14 = "1") entao
                                                limpatela
                                                escreval
                                                escreva("Tempo em Segundo(s):  ")
                                                leia(s)
                                                escreval
                                                dia <- s / 86400
                                                escreval
                                                escreval("Tempo em Dia(s): ", dia, " dia(s)")
                                             senao
                                                se (op13 = "4") e (op14 = "2") entao
                                                   limpatela
                                                   escreval
                                                   escreva("Tempo em Segundo(s):  ")
                                                   leia(s)
                                                   escreval
                                                   h <- s / 3600
                                                   escreval
                                                   escreval("Tempo em Hora(s): ", h, " hora(s)")
                                                senao
                                                   se (op13 = "4") e (op14 = "3") entao
                                                      limpatela
                                                      escreval
                                                      escreva("Tempo em Segundo(s):  ")
                                                      leia(s)
                                                      escreval
                                                      min <- s / 60
                                                      escreval
                                                      escreval("Tempo em Minuto(s): ", min, " min")
                                                   senao
                                                      se (op13 = "4") e (op14 = "4") entao
                                                         limpatela
                                                         escreval
                                                         escreva("Tempo em Segundo(s):  ")
                                                         leia(s)
                                                         escreval
                                                         escreval("Tempo em Segundo(s): ", s, " s")
                                                      senao
                                                         limpatela
                                                         escreval
                                                         escreval(">>> Comando incorreto!!!")
                                                      fimse
                                                   fimse
                                                fimse
                                             fimse
                                          fimse
                                       fimse
                                    fimse
                                 fimse
                              fimse
                           fimse
                        fimse
                     fimse
                  fimse
               fimse
            fimse
         fimse
      fimescolha
      escreval
      escreval("Digite:")
      escreval("0. Sair do sistema")
      escreval("1. Outra conversão")
      escreval("2. Retornar ao menu principal")
      escreval
      leia(op15)
      se (op15 <> "0") e (op15 <> "1") e (op15 <> "2") entao
         limpatela
         escreval
         escreval(">>> Comando incorreto!!!")
         escreval(">>> Programa Finalizado!!!")
         escreval
      fimalgoritmo
   senao
      escolha op15
      caso "2"
         interrompa
      caso "0"
         limpatela
      fimalgoritmo
   caso "1"
      limpatela
   fimescolha
fimse
fimrepita
caso "3"
repita
   palavra[0]<-"programacao"
   palavra[1]<-"logica"
   palavra[2]<-"etecpoa"
   aleat<- RandI(3)
   escolhida<-palavra[aleat]
   qtdcaracteres<-compr (escolhida)
   chances<-15
   para i de 1 ate qtdcaracteres faca
      elemento[i]<-"_ "
   fimpara
   enquanto (pontos<qtdcaracteres) e (tentativas<chances) faca
      limpatela
      escreval("":35,"A FORCA")
      escreval("")
      escreva("Palavra: ")
      para i de 1 ate qtdcaracteres faca
         escreva("":1,Maiusc (elemento[i]) )
      fimpara
      escreval("")
      escreva("Tente uma letra: ")
      tentativas<-tentativas+1
      leia(letra)
      letra<-Minusc (letra)
      acao[1]<-"on"
      acao[2]<-"on"
      para i de 1 ate qtdcaracteres faca
         se (letra = (Copia (escolhida ; i, 1))) e (acao[1]="on") entao
            acao[1]<-"off"
            posicao[1]<-(Pos (letra, escolhida))
            se (elemento[posicao[1]]="_ ") entao
               elemento[posicao[1]]<-letra
               pontos<-pontos+1
            fimse
            restante[1]<-(Copia (escolhida ; posicao[1]+1, qtdcaracteres-posicao[1]) )
            qtdrestante[1]<-compr (restante[1])
            para i de 1 ate qtdrestante[1] faca
               se (letra = (Copia (restante[1] ; i, 1) )) e (acao[2]="on") entao
                  acao[2]<-"off"
                  posicao[2]<-(Pos (letra, restante[1]))
                  se (elemento[posicao[1]+posicao[2]]="_ ") entao
                     elemento[posicao[1]+posicao[2]]<-letra
                     pontos<-pontos+1
                  fimse
               fimse
            fimpara
            restante[2]<-(Copia (escolhida ; posicao[1]+posicao[2]+1, qtdcaracteres-posicao[2]) )
            qtdrestante[2]<-compr (restante[2])
            para i de 1 ate qtdrestante[2] faca
               se letra = (Copia (restante[2] ; i, 1) ) entao
                  posicao[3]<-(Pos (letra, restante[2]))
                  se (elemento[posicao[1]+posicao[2]+posicao[3]]="_ ") entao
                     elemento[posicao[1]+posicao[2]+posicao[3]]<-letra
                     pontos<-pontos+1
                  fimse
               fimse
            fimpara
         fimse
      fimpara
   fimenquanto
   limpatela
   escrevaL("":35,"A FORCA")
   escreval("")
   escreva("Palavra: ")
   para i de 1 ate qtdcaracteres faca
      escreva("":1,Maiusc (elemento[i]) )
   fimpara
   se tentativas<chances entao
      escreval("")
      escreval("Parabens!Você acertou!")

   senao
      escreval("")
      escreval("")
      escreval("Você excedeu o número de tentativas! =(")
   fimse
   escreval("")
   escrevaL("FIM DO JOGO")
   escreval("")
   escreval
   escreval
fimescolha
escreval
escreval("Digite:")
escreval("0. Sair do Sistema Visualg")
escreval("1. Jogar novamente")
escreval("2. Retornar ao menu principal")
escreval
leia(op15)
escolha op15
caso "2"
interrompa
caso "0"
limpatela
fimalgoritmo
caso "1"
limpatela

outrocaso
limpatela
escreval
escreval(">>> Comando incorreto!")





escreval(">>> Programa finalizado!")
escreval
fimalgoritmo
fimescolha

fimrepita
caso "4"
limpatela
fimalgoritmo
outrocaso
limpatela
escreval
escreval(">>> Comando incorreto!!!")
escreval(">>> Programa finalizado!!!")
escreval
fimescolha
fimrepita
fimalgoritmo
