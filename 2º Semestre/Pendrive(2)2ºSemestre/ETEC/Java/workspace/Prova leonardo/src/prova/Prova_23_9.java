package prova;

import java.awt.*;
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

	public Prova_23_9() {
		super("Exercicio1");
		this.getContentPane().setLayout(new GridLayout(6,2));
	}

	public void init() {
		JPanel p1 = new JPanel(new FlowLayout());
		JPanel p2 = new JPanel(new FlowLayout());
		JPanel p3 = new JPanel(new FlowLayout());
		JPanel p4 = new JPanel(new FlowLayout());
		JPanel p5 = new JPanel(new FlowLayout());
		JPanel p6 = new JPanel(new FlowLayout());

		pesquisar = new JButton("Pesquisar");
		salvar = new JButton("Salvar");
		calcular = new JButton("Calcular");
		sair = new JButton("Sair");

		nome1 = new JLabel("Nome :");
		nota11 = new JLabel("Nota1 : ");
		nota22 = new JLabel("Nota2 : ");
		media1 = new JLabel("M?dia : ");

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

		this.getContentPane().add(p1, BorderLayout.WEST);
		this.getContentPane().add(p2, BorderLayout.WEST);
		this.getContentPane().add(p3, BorderLayout.WEST);
		this.getContentPane().add(p4, BorderLayout.WEST);
		this.getContentPane().add(p5, BorderLayout.CENTER);
		this.getContentPane().add(p6, BorderLayout.WEST);
		setSize(700, 130);
		setVisible(true);
	}
	private void calcular() {
		float n1 = Float.parseFloat(nota1.getText());
		float n2 = Float.parseFloat(nota2.getText());
		float resp = 0;
		resp = 2/(n1 + n2); 
		media.setText(resp+"");
	}
	public void actionPerformed(ActionEvent e) {
		if (e.getSource() == calcular) {
			calcular;
		}
	public static void main(String args[]) {
		Prova_23_9 a = new Prova_23_9();
		a.init();
	}
}