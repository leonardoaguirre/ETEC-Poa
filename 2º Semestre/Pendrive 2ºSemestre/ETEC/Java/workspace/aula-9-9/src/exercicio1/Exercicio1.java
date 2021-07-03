package exercicio1;

import javax.swing.*;
import java.awt.*;

public class Exercicio1 extends JFrame {
	private JButton incluir;
	private JButton alterar;
	private JButton excluir;
	private JButton pesquisar;
	private JPanel p1;
	private JPanel p2;
	private JPanel p3;
	private JLabel nome;
	private JLabel idade;
	private JLabel rg;
	private JTextField nome1;
	private JTextField idade1;
	private JTextField rg1;

	public Exercicio1() {
		super("Exercicio1");
		this.getContentPane().setLayout(new GridLayout(1,1));
	}
	public void init() {
		p1 = new JPanel(new GridLayout(3,2));
		p2 = new JPanel(new GridLayout(3,1));
		p3 = new JPanel(new GridLayout(3,1));

		incluir = new JButton("Incluir");
		excluir = new JButton("Excluir");
		alterar = new JButton("Alterar");
		pesquisar = new JButton("Pesquisar");

		
		
		nome = new JLabel("Nome:");
		idade = new JLabel("Idade:");
		rg = new JLabel("RG:");
		
		nome1 = new JTextField(10);
		idade1 = new JTextField(10);
		rg1 = new JTextField(10);
		
		p1.add(incluir);
		p1.add(alterar);
		p1.add(excluir);
		p1.add(pesquisar);

		p2.add(nome);
		p2.add(idade);
		p2.add(rg);
		
		p3.add(nome1);
		p3.add(idade1);
		p3.add(rg1);
		
		this.getContentPane().add(p1, BorderLayout.WEST);
		this.getContentPane().add(p2, BorderLayout.CENTER);
		this.getContentPane().add(p3, BorderLayout.EAST);

		setSize(700, 130);
		setVisible(true);
	}

	public static void main(String args[]) {
		Exercicio1 a = new Exercicio1();
		a.init();
	}
}
