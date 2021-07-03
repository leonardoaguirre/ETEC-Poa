package aula_9_9_janela;

import javax.swing.*;
import java.awt.*;

public class MinhaJanela5 extends JFrame {
	private JPanel p1;
	private JPanel p2;
	private JButton salvar;
	private JTextArea texto;
	private JLabel mensagem;
	private JButton cancelar;

	public MinhaJanela5() {
		super("Janela 5.0");
		this.getContentPane().setLayout(new BorderLayout());

	}

	public void init() {
		p1 = new JPanel(new FlowLayout());
		p2 = new JPanel(new FlowLayout());

		salvar = new JButton("Salvar");
		cancelar = new JButton("Cancelar");

		texto = new JTextArea("Entre com seu texto aqui...");
		mensagem = new JLabel("Texto");

		p1.add(salvar);
		p1.add(cancelar);

		p2.add(mensagem);
		p2.add(texto);

		this.getContentPane().add(p1, BorderLayout.NORTH);
		this.getContentPane().add(p2, BorderLayout.CENTER);

		setSize(300, 400);
		setVisible(true);
	}

	public static void main(String args[]) {
		MinhaJanela5 a = new MinhaJanela5();
		a.init();

	}
}
