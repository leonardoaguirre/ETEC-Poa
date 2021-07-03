package aula1410;

import java.awt.Color;  
import java.awt.Font;  
import java.awt.event.ActionEvent;  
import java.awt.event.ActionListener;  
import javax.swing.ImageIcon;  
import javax.swing.JButton;  
import javax.swing.JFrame;  
import javax.swing.JLabel;  
import javax.swing.JOptionPane;  
  
public class Jogo extends JFrame {  
   /** 
    *  
    */  
   private static final long serialVersionUID = 1L;  
   /* 
    * tempo de temporiza��o da mensagem 
    */  
   private final int TEMPO = 1;  
   //num � um n�mero alet�rio entre um e 3  
   int num;     
   //As tr�s imagens     
   ImageIcon copo = new ImageIcon("src/aula1410/imagens/copo.gif"); //Copo abaixado  
   ImageIcon copoe = new ImageIcon("src/aula1410/imagens/copoE.gif"); //Copo levantado sem o gato  
   ImageIcon copoc = new ImageIcon("src/aula1410/imagens/copoC.gif");//Copo levantado com o gato  
   JButton btn1;  
   JButton btn2;  
   JButton btn3;  
  
   public Jogo() {  
      super("Encontre o Gato");        
      setSize(640, 480);  
      //Quando fechar, saia do sistema  
      setDefaultCloseOperation(EXIT_ON_CLOSE);  
      //Mudando a cor de fundo do painel  
      getContentPane().setBackground(Color.WHITE);  
        
      //Layout � nulo, significa que temos que configurar a posi��o e o tamanho  
      //de cada elemento que estiver nesse frame  
      setLayout(null);  
  
      //Label com o t�tulo do jogo  
      JLabel lblTitulo = new JLabel("Encontre o gato");  
      //Uma fonte mais chamativa  
      lblTitulo.setFont(new Font("Comic Sans Ms", 1, 50));  
      //Posi��o e tamanho do Label  
      lblTitulo.setBounds(140, 1, 3000, 100);  
      add(lblTitulo);  
        
      //Um bot�o que inicia o jogo  
      JButton btnIniciar = new JButton("Iniciar");  
      btnIniciar.setBounds(270, 100, 100, 30); //configura��es...  
      btnIniciar.setBackground(Color.RED);  
      btnIniciar.setForeground(Color.WHITE);  
      //Adicionamos um listener "an�nimo"  
      btnIniciar.addActionListener(new ActionListener() {  
         //Chamando o m�todo que inicia o jogo  
         @Override  
         public void actionPerformed(ActionEvent arg0) {  
            iniciaJogo();  
         }  
      });  
      //Adicionando o bot�o ao Frame  
      add(btnIniciar);  
  
  
      // Bot�o 1  de 3  
      btn1 = new JButton("Copo 1");  
      btn1.setBackground(getContentPane().getBackground());  
      btn1.addActionListener(new Action_button1());  
      btn1.setBounds(162, 200, 96, 200);  
      add(btn1);  
  
      // Bot�o 2  de 3  
      btn2 = new JButton("Copo 2");  
      btn2.setBackground(getContentPane().getBackground());  
      btn2.addActionListener(new Action_button2());  
      btn2.setBounds(272, 200, 96, 200);  
      add(btn2);  
        
      // Bot�o 3  de 3  
      btn3 = new JButton("Copo 3");  
      btn3.setBackground(getContentPane().getBackground());  
      btn3.addActionListener(new Action_button3());  
      btn3.setBounds(382, 200, 96, 200);  
      add(btn3);  
        
      //Que comece a partida!  
      iniciaJogo();  
   }  
     
   //M�todo main, aqui instanciamos a nossa classe, para testar!  
   public static void main(String[] args) {  
      new Jogo().setVisible(true);  
   }  
     
     
   //Classe interna que implementa Action Listener  
   public class Action_button1 implements ActionListener {  
      public void actionPerformed(ActionEvent e) {  
         if (num == 1) {  
            //Se este for o bot�o certo: Exibe mensagem e...  
            Temporizador.exibirMensagem(TEMPO, "Voc� Acertou",  
                  JOptionPane.INFORMATION_MESSAGE);  
            //... Muda o �cone do bot�o  
            ((JButton) e.getSource()).setIcon(copoc);  
         } else {  
            Temporizador.exibirMensagem(TEMPO, "Voc� errou",  
                  JOptionPane.ERROR_MESSAGE);  
            ((JButton) e.getSource()).setIcon(copoe);  
         }  
      }  
  
   }  
  
   public class Action_button2 implements ActionListener {  
      public void actionPerformed(ActionEvent e) {  
         if (num == 2) {  
            Temporizador.exibirMensagem(TEMPO, "Voc� Acertou",  
                  JOptionPane.INFORMATION_MESSAGE);  
            ((JButton) e.getSource()).setIcon(copoc);  
         } else {  
            Temporizador.exibirMensagem(TEMPO, "Voc� errou",  
                  JOptionPane.ERROR_MESSAGE);  
            ((JButton) e.getSource()).setIcon(copoe);  
         }  
      }  
   }  
  
   public class Action_button3 implements ActionListener {  
      public void actionPerformed(ActionEvent e) {  
         if (num == 3) {  
            Temporizador.exibirMensagem(TEMPO, "Voc� Acertou",  
                  JOptionPane.INFORMATION_MESSAGE);  
            ((JButton) e.getSource()).setIcon(copoc);  
         } else {  
            Temporizador.exibirMensagem(TEMPO, "Voc� errou",  
                  JOptionPane.ERROR_MESSAGE);  
            ((JButton) e.getSource()).setIcon(copoe);  
         }  
      }  
   }  
     
   //Inicia o jogo  
   private void iniciaJogo() {  
      //�cone Default  
      btn1.setIcon(copo);  
      btn2.setIcon(copo);  
      btn3.setIcon(copo);  
      //Gera um n�mero aleat�rio  
      num = Aleatorio.Return_numero();  
   }  
}  

