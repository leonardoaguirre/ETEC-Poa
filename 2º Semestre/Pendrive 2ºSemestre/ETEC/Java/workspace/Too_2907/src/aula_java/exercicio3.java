package aula_java;

import javax.swing.JOptionPane;

public class exercicio3 {

	public static void main(String args[]) {
		Integer n1, n2, n3;

		n1 = Integer.parseInt(JOptionPane.showInputDialog("Digite um numero"));
		n2 = Integer.parseInt(JOptionPane.showInputDialog("Digite outro numero"));
		n3 = Integer.parseInt(JOptionPane.showInputDialog("Digite outro numero"));

		if ((n1 > n2) && (n1 > n3)) {
			JOptionPane.showMessageDialog(null, "O maior numero é " + n1);
		}
		if ((n2 > n1) && (n2 > n3)) {
			JOptionPane.showMessageDialog(null, "O maior numero é " + n2);
		}
		if ((n3 > n1) && (n3 > n2)) {
			JOptionPane.showMessageDialog(null, "O maior numero é " + n3);
		}

	}
}
