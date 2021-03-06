package calculadora;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class Calculadora extends JFrame implements ActionListener {
	private JTextField txtValor1, txtValor2, txtResp;
	private JButton botSoma, botSubtracao, botMultiplicacao, botDivisao, bot1, bot2, bot3, bot4, bot5, bot6, bot7, bot8,
			bot9, bot0, botCl, botigual, botPonto, botBaskara;

	public Calculadora() {
		JPanel p1 = new JPanel(new FlowLayout());
		JTextField txtValor1 = new JTextField(10);
		JTextField txtValor2 = new JTextField(10);
		JTextField txtResp = new JTextField(10);
		JLabel sinal = new JLabel(" = ");
		JPanel p2 = new JPanel(new GridLayout(5, 5, 10, 9));

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
		p2.add(bot1);
		p2.add(bot2);
		p2.add(bot3);
		p2.add(bot4);
		p2.add(bot5);
		p2.add(bot6);
		p2.add(bot7);
		p2.add(bot8);
		p2.add(bot9);
		p2.add(bot0);
		p2.add(botSoma);
		p2.add(botSubtracao);
		p2.add(botMultiplicacao);
		p2.add(botDivisao);
		p2.add(botigual);
		p2.add(botPonto);
		p2.add(botBaskara);

		
		p1.add(txtValor1);
		p1.add(txtValor2);
		p1.add(sinal);
		p1.add(txtResp);
		
		add(p1);
		add(p2);
		
		botSoma.addActionListener(this);
		botSubtracao.addActionListener(this);
		botMultiplicacao.addActionListener(this);
		botDivisao.addActionListener(this);
		
		this.getContentPane().add(p1, BorderLayout.NORTH);
		this.getContentPane().add(p2, BorderLayout.CENTER);
		
		setTitle("Calculadora");
		setSize(500, 300);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setResizable(false);
		setLocationRelativeTo(null);
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

	}

	public static void main(String[] args) {
		Eventos_calc a = new Eventos_calc();
		a.init();

	}

}