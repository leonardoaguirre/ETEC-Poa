package aula_java;

import javax.swing.JOptionPane;

public class exerccio4 {

	public static void main(String[] args)

	{

		Integer n1, n2;
		n1 = 1;
		n2 = Integer.parseInt(JOptionPane.showInputDialog("Digite um numero, seu corninho"));

		while (n1 <= n2) {
			JOptionPane.showMessageDialog(null, n1);
			n1 = n1 + 1;

		}
	}

}
