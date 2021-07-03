package Exercicios;

import javax.swing.JOptionPane;

public class equacao {
	public static void main(String args[]) {

		int a, b, c, delt, x1, x2, rdelt;

		a = Integer.parseInt(JOptionPane.showInputDialog("Digite o coeficiente a"));
		b = Integer.parseInt(JOptionPane.showInputDialog("Digite o coeficiente b"));
		c = Integer.parseInt(JOptionPane.showInputDialog("Digite o coeficiente c"));

		delt = ((b * b) - 4 * a * c);
		rdelt = (int) Math.sqrt(delt);

		if (delt < 0) {

			JOptionPane.showMessageDialog(null, "Não existe solução para essa equação, pois o delta é negativo");

		}

		if (delt == 0) {
			JOptionPane.showMessageDialog(null, "O delta é " + delt);
			x1 = (int) ((-b)  / (2 * a));
			JOptionPane.showMessageDialog(null, "O x' é " + x1);

		}
		if (delt > 0) {
			JOptionPane.showMessageDialog(null, "O delta é " + delt);
			x1 = (int) ((-b + rdelt) / (2 * a));
			x2 = (int) ((-b - rdelt) / (2 * a));

			JOptionPane.showMessageDialog(null, "O x' é " + x1);
			JOptionPane.showMessageDialog(null, "O x'' é " + x2);
		}
	}
}
