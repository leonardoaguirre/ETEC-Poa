package calculadora;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Eventos_calc extends JFrame implements ActionListener {
	private JTextField txtValor1, txtValor2, txtResp;
	private JButton botSoma, botSubtracao, botMultiplicacao, botDivisao, bot1, bot2, bot3, bot4, bot5, bot6, bot7, bot8,
			bot9, bot0, botCl, botigual, botPonto, botBaskara;
	private JPanel p1, p2;
	private JLabel sinal;

	public Eventos_calc() {
		super("Trabalhando com Eventos");
		this.getContentPane().setLayout(new BorderLayout());
	}

	public void init() {
		p1 = new JPanel(new FlowLayout());
		p2 = new JPanel(new GridLayout(5, 5, 10, 9));
		txtValor1 = new JTextField(10);
		txtValor2 = new JTextField(10);
		txtResp = new JTextField(10);
		sinal = new JLabel(" = ");

		botCl = new JButton("CL");
		bot1 = new JButton("1");
		bot2 = new JButton("2");
		bot3 = new JButton("3");
		bot4 = new JButton("4");
		bot5 = new JButton("5");
		bot6 = new JButton("6");
		bot7 = new JButton("7");
		bot8 = new JButton("8");
		bot9 = new JButton("9");
		bot0 = new JButton("0");
		botigual = new JButton("=");
		botPonto = new JButton(".");
		botBaskara = new JButton("B");
		botSoma = new JButton("+");
		botSubtracao = new JButton("-");
		botMultiplicacao = new JButton("*");
		botDivisao = new JButton("/");

		p2.add(botCl);
		p2.add(botSubtracao);
		p2.add(botDivisao);
		p2.add(botMultiplicacao);
		p2.add(bot7);
		p2.add(bot8);
		p2.add(bot9);
		p2.add(botSoma);
		p2.add(bot4);
		p2.add(bot5);
		p2.add(bot6);
		p2.add(botBaskara);
		p2.add(bot1);
		p2.add(bot2);
		p2.add(bot3);
		p2.add(botigual);
		p2.add(botPonto);
		p2.add(bot0);

		p1.add(txtValor1);
		p1.add(txtValor2);
		p1.add(sinal);
		p1.add(txtResp);

		add(p2);
		add(p1);

		botSoma.addActionListener(this);
		botSubtracao.addActionListener(this);
		botMultiplicacao.addActionListener(this);
		botDivisao.addActionListener(this);
		bot0.addActionListener(this);
		bot1.addActionListener(this);
		bot2.addActionListener(this);
		bot3.addActionListener(this);
		bot4.addActionListener(this);
		bot5.addActionListener(this);
		bot6.addActionListener(this);
		bot7.addActionListener(this);
		bot8.addActionListener(this);
		bot9.addActionListener(this);

		this.getContentPane().add(p1, BorderLayout.NORTH);
		this.getContentPane().add(p2, BorderLayout.CENTER);

		setTitle("Calculadora");
		setSize(500, 300);
		setVisible(true);

	}

	private void calcular(char sinal) {
		float v1 = Float.parseFloat(txtValor1.getText());
		float v2 = Float.parseFloat(txtValor2.getText());
		float resp = 0;
		switch (sinal) {
		case '+':
			resp = v1 + v2;
			break;
		case '-':
			resp = v1 - v2;
			break;
		case '*':
			resp = v1 * v2;
			break;
		case '/':
			resp = v1 / v2;
			break;

		}
		txtResp.setText(resp + "");
	}

	private void inserir_numeros(char num) {
		switch (num) {
		case '0':
			txtValor1.setText("0");
			break;
		}

	}

	public void actionPerformed(ActionEvent e) {
		if (e.getSource() == botSoma) {
			calcular('+');
		}
		if (e.getSource() == botSubtracao) {
			calcular('-');
		}
		if (e.getSource() == botMultiplicacao) {
			calcular('*');
		}
		if (e.getSource() == botDivisao) {
			calcular('/');
		}
		if (e.getSource() == bot0) {
			inserir_numeros('0');
		}
	}

	public static void main(String args[]) {
		Eventos_calc a = new Eventos_calc();
		a.init();
	}
}