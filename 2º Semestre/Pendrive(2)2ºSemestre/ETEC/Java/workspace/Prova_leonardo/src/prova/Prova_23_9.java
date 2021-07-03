package prova;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.*;

public class Prova_23_9 extends JFrame implements ActionListener {
	private JButton sair;
	private JButton calcular;
	private JButton salvar;
	private JButton pesquisar;
	private JTextField nome;
	private JTextField nota1;
	private JTextField nota2;
	private JTextField media;
	private JLabel nota11;
	private JLabel nota22;
	private JLabel nome1;
	private JLabel media1;
	private JLabel mensagem;
	private JLabel mais;
	private JPanel p1;
	private JPanel p2;
	private JPanel p3;
	private JPanel p4;
	private JPanel p5;
	private JPanel p6;

	public Prova_23_9() {
		super("Prova");
		this.getContentPane().setLayout(new GridLayout(6, 2));
		init();

	}

	public void init() {
		p1 = new JPanel(new FlowLayout());
		p2 = new JPanel(new FlowLayout());
		p3 = new JPanel(new FlowLayout());
		p4 = new JPanel(new FlowLayout());
		p5 = new JPanel(new FlowLayout());
		p6 = new JPanel(new FlowLayout());

		pesquisar = new JButton("Pesquisar");
		salvar = new JButton("Salvar");
		calcular = new JButton("Calcular");
		sair = new JButton("Sair");

		salvar.addActionListener(this);
		pesquisar.addActionListener(this);
		calcular.addActionListener(this);
		sair.addActionListener(this);

		nome1 = new JLabel("Nome :");
		nota11 = new JLabel("Nota1 : ");
		nota22 = new JLabel("Nota2 : ");
		media1 = new JLabel("Média : ");
		mais = new JLabel("+");
		mensagem = new JLabel("");

		nome = new JTextField(30);
		nota1 = new JTextField(5);
		nota2 = new JTextField(5);
		media = new JTextField(5);
		media.setEnabled(false);

		p1.add(nome1);
		p1.add(nome);

		p2.add(nota11);
		p2.add(nota1);

		p3.add(nota22);
		p3.add(nota2);

		p4.add(media1);
		p4.add(media);

		p5.add(mensagem);

		p6.add(pesquisar);
		p6.add(salvar);
		p6.add(calcular);
		p6.add(sair);

		this.getContentPane().add(p1);
		this.getContentPane().add(p2);
		this.getContentPane().add(p3);
		this.getContentPane().add(p4);
		this.getContentPane().add(p5);
		this.getContentPane().add(p6);
		setSize(700, 300);
		setVisible(true);
	}

	private void calcular(char mais) {
		float n1 = Float.parseFloat(nota1.getText());
		float n2 = Float.parseFloat(nota2.getText());
		float resp = 0;
		switch (mais) {
		case '+':
			resp =(n1 + n2)/2;
			break;
		}
		media.setText(resp + "");
		if (resp < 3) {
			mensagem.setText("Reprovado");
		} else if (resp >= 6) {
			mensagem.setText("Aprovado");
		} else {
			mensagem.setText("Recuperação");
		}
	}


	public void actionPerformed(ActionEvent e) {
		if (e.getSource() == calcular) {
			calcular('+');
		}
		if (e.getSource() == sair) {
			System.exit(0);
		}

	}

	public static void main(String args[]) {
		Prova_23_9 a = new Prova_23_9();

	}
}
