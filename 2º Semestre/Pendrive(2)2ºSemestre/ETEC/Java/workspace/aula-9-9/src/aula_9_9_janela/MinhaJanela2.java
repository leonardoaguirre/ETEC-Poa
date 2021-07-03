package aula_9_9_janela;


import javax.swing.*;
import java.awt.*;

public class MinhaJanela2 extends JFrame {
	private JLabel texto;
	private JButton salvar;
	private JButton cancelar;

	public MinhaJanela2() {
		super("Janela2.0");
	this.getContentPane().setLayout(new FlowLayout());
	}

	public void init() {
		texto = new JLabel("Mensagem:");
		salvar = new JButton("Salvar");
		cancelar = new JButton("Cancelar");

		this.getContentPane().add(texto);
		this.getContentPane().add(salvar);
		this.getContentPane().add(cancelar);

		setSize(300, 400);
		setVisible(true);

	}

	public static void main(String args[]) {
		MinhaJanela2 a = new MinhaJanela2();
		a.init();

	}

}