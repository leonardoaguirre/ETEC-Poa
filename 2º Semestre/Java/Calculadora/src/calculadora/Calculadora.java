package calculadora;

import java.awt.BorderLayout;
import java.awt.GridLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class Calculadora extends JFrame {
    private final String names[] = {"CL", "%", "√", "-", "7", "8", "9", "+", "4", "5", "6", "/", "1", "2", "3", "*", "0", ".", "+/-", "="};
    public Calculadora() {
      
        add(new JTextField(), BorderLayout.NORTH);
        
        JPanel painel = new JPanel(new GridLayout(5, 5, 10, 9));
        for (byte i = 0; i < 20; i++) {
           
            painel.add(new JButton(names[i]));
        }
        
        add(painel);
        setTitle("ExercicioCalculadora");
        setSize(400, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setResizable(false);
        setLocationRelativeTo(null);
    }
    public static void main(String[] args) {
        new Calculadora().setVisible(true);
    }
}