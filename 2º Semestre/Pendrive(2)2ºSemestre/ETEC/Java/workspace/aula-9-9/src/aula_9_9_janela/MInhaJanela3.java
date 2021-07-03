package aula_9_9_janela;

import javax.swing.*;
import java.awt.GridLayout;

public class MInhaJanela3 extends JFrame {
	private JLabel texto;
	private JButton salvar;
	private JButton cancelar;

	public MInhaJanela3() {
		super("Janela3.0");
		this.getContentPane().setLayout(new GridLayout(2,2));
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
		MInhaJanela3 a = new MInhaJanela3();
		a.init();

	}

}
