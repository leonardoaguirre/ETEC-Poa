package aula_9_9_janela;

import javax.swing.JFrame;
import javax.swing.JTextArea;
import java.awt.Color;

public class MinhaJanela extends JFrame {
    
	private JTextArea texto = new JTextArea();
	
    public MinhaJanela(){
		super("Minha primeira janela");
	}

	public void init() {
	//setForeground(Color.black);
		//setBackgorund(new Color(192,192));
		//serSize (200,200);
		//serLocation(300,200);
		//setVisible(true);
		setSize(200, 200);
		this.getContentPane().add(texto);
		setVisible(true);
	}

	public static void main(String args[]) {
		MinhaJanela a = new MinhaJanela();
		a.init();
	}
}
