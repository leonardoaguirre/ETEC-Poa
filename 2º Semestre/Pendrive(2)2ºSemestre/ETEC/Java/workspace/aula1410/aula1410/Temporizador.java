package aula1410;

import java.util.Timer;  
  
/* 
 *  
 * Classe com um m�todo est�tico que permite a cria��o de um Timer 
 *  
 * */  
  
public class Temporizador {  
   Timer timer;     
   public static void exibirMensagem(int tempo, String mensagem, int tipo) {  
         Timer timer = new Timer();  
         timer.schedule(new TarefaRepetida(mensagem, tipo), 0, tempo * 1000);  
  
      }     
}