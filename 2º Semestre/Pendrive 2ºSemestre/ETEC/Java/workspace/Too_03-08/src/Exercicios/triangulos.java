package Exercicios;

import javax.swing.*;

public class triangulos {

	public static void main(String[] args) {

		int d, e, f;

		d = Integer.parseInt(JOptionPane.showInputDialog("Digite o valor do lado a do triangulo"));
		e = Integer.parseInt(JOptionPane.showInputDialog("Digite o valor do lado b do triangulo"));
		f = Integer.parseInt(JOptionPane.showInputDialog("Digite o valor do lado c do triangulo"));

		if (((d > e + f) || (e > d + f) || (f > d + e))) {

			JOptionPane.showMessageDialog(null,
					"N�o existe solu��o para esse problema, pois n�o se trata de um triangulo");
			   System.exit(0);

		}

		// Se for triangulo

		if (((d == e) && (e != f) || (d == f) && (f != e) || (f == e) && (e != d))) {

			JOptionPane.showMessageDialog(null, "Se trata de um triangulo Is�sceles");

		}

		if (((d == e) && (e == f))) {

			JOptionPane.showMessageDialog(null, "Se trata de um triangulo Equil�tero");

		}

		if (((d != e) && (d != f) && (f != e))) {

			JOptionPane.showMessageDialog(null, "Se trata de um triangulo Escaleno");

		}

	}

}
