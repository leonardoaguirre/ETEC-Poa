package aula_java;

import javax.swing.JOptionPane;

public class exercicio5 {

	public static void main(String[] args) {
		int n1;

		n1 = Integer.parseInt(JOptionPane.showInputDialog("Digite um numero que corresponde a um dia da semana "));
		while (n1 > 7) {
			n1 = Integer.parseInt(JOptionPane.showInputDialog("Digite um numero entre 1 e 7"));
		}

		if (n1 == 1) {

			JOptionPane.showMessageDialog(null, "O dia correspondente ao número digitado é Domingo =)");

		}

		if (n1 == 2) {

			JOptionPane.showMessageDialog(null, "O dia correspondente ao número digitado é Segunda Feira =)");

		}
		if (n1 == 3) {

			JOptionPane.showMessageDialog(null, "O dia correspondente ao número digitado é Terça-Feira =)");

		}
		if (n1 == 4) {

			JOptionPane.showMessageDialog(null, "O dia correspondente ao número digitado é Quarta-Feira =)");

		}
		if (n1 == 5) {

			JOptionPane.showMessageDialog(null, "O dia correspondente ao número digitado é Quinta-Feira =)");

		}
		if (n1 == 6) {

			JOptionPane.showMessageDialog(null, "O dia correspondente ao número digitado é Sexta-Feira =)");

		}
		if (n1 == 7) {

			JOptionPane.showMessageDialog(null, "O dia correspondente ao número digitado é Sábado =)");

		}

	}
}