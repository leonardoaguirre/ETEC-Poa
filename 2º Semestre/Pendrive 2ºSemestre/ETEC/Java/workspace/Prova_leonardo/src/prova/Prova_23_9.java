package prova;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.*;

public class Prova_23_9 extends JFrame implements ActionListener {
	private static final Object GridLayout = null;
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

		calcular.addActionListener(this);

		nome1 = new JLabel("Nome :");
		nota11 = new JLabel("Nota1 : ");
		nota22 = new JLabel("Nota2 : ");
		media1 = new JLabel("M?dia : ");
		mais = new JLabel("+");

		nome = new JTextField(30);
		nota1 = new JTextField(2);
		nota2 = new JTextField(2);

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

		this.getContentPane().add(p1, GridLayout);
		this.getContentPane().add(p2, GridLayout);
		this.getContentPane().add(p3, GridLayout);
		this.getContentPane().add(p4, GridLayout);
		this.getContentPane().add(p5, GridLayout);
		this.getContentPane().add(p6, GridLayout);
		setSize(700, 300);
		setVisible(true);
	}

	private void calcular(char mais) {
		float n1 = Float.parseFloat(nota1.getText());
		float n2 = Float.parseFloat(nota2.getText());
		float resp = 0;
		switch (mais) {
		case '+':
			resp = 2 / (n1 + n2);
			break;
		}
		media.setText(resp + "");
		if(resp < 3){
			mensagem.setText("Reprovado");
		}else if(resp >= 6){
			mensagem.setText("Aprovado");
		}else{
			mensagem.setText("Recupera??o");
		}
	}

	public void actionPerformed(ActionEvent e) {
		if (e.getSource() == calcular) {
			calcular('+');
		}

	}

	public static void main(String args[]) {
		Prova_23_9 a = new Prova_23_9();
		a.init();
	}
}
