package calculadora;

import java.awt.*;
import javax.swing.*;


public class Calculadora extends JFrame {
    private final String names[] = {"CL","B", "+", "-", "1", "2", "3", "X", "4", "5", "6", "/", "7", "8", "9", "=", ".", "0"};
    public Calculadora() {
      
        add(new JTextField(), BorderLayout.NORTH);
        
        JPanel painel = new JPanel(new GridLayout(5, 5, 5, 10));
        for (byte i = 0; i < 18; i++) {
           
            painel.add(new JButton(names[i]));
        }
        JMenuBar M1 = new JMenuBar();
      
        
        JMenu menuExibir = new JMenu("Exibir");
        JMenu menuAjuda = new JMenu("Ajuda");
        
        JMenuItem miSimples = new JMenuItem("Simples");
		JMenuItem miCientifica = new JMenuItem("Cientifica");
		JMenuItem miSair = new JMenuItem("Sair");
		JMenuItem miSobre = new JMenuItem("Sobre");
		 
		menuExibir.add(miSimples);
		menuExibir.add(miCientifica);
		menuExibir.addSeparator();
		menuExibir.add(miSair);
		menuAjuda.add(miSobre);
		
		M1.add(menuExibir);
		M1.add(menuAjuda);
		setJMenuBar(M1);
		setSize(250, 150);
		setVisible(true);
		
        add(painel);
        setTitle("ExercicioCalculadora");
        setSize(300, 300);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setResizable(false);
        setLocationRelativeTo(null);
    }
    public static void main(String[] args) {
        new Calculadora().setVisible(true);
    }
}

