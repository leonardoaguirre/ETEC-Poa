package aula58;

import javax.swing.*;

public class Exercicio1

{
	public static void main(String[] args) {

		int resp, resp2, A, B, C, respdelta, respdelta2, equa1, equa2;

		do {
			resp = Integer.parseInt(JOptionPane.showInputDialog(
					"" + "MENU PRINCIPAL " + " | 1 - Equac�o do : " + " | 2 - Tipo tri�ngulo: " + " | 3 - Sair: "));

			while (resp > 3) {
				resp = Integer.parseInt(JOptionPane.showInputDialog("" + "MENU PRINCIPAL " + " | 1 - Equac�o do 2�: "
						+ " | 2 - Tipo tri�ngulo: " + " | 3 - Sair: "));
			}
			// Equa��o do 2� grau

			if (resp == 1) {
				A = Integer.parseInt(JOptionPane.showInputDialog("Informe o valor de A :"));
				B = Integer.parseInt(JOptionPane.showInputDialog("Informe o valor de B :"));
				C = Integer.parseInt(JOptionPane.showInputDialog("Informe o valor de C :"));
				respdelta = ((B * B) - (4 * A * C));
				respdelta2 = ((B * B) - (4 * A * C));
				if (respdelta >= 0)
					respdelta2 = respdelta;
				equa1 = (int) ((-B + (Math.sqrt(respdelta))) / (2 * A));
				equa2 = (int) ((-B - (Math.sqrt(respdelta2))) / (2 * A));
				JOptionPane.showMessageDialog(null, "Equa��o x1 =" + equa1);
				JOptionPane.showMessageDialog(null, "Equa��o x2 =" + equa2);
			
			}
			
			
			// Tri�ngulos

			if (resp == 2) {

				A = Integer.parseInt(JOptionPane.showInputDialog("Informe o valor do lado A :"));
				B = Integer.parseInt(JOptionPane.showInputDialog("Informe o valor do lado B :"));
				C = Integer.parseInt(JOptionPane.showInputDialog("Informe o valor do lado C :"));
			

				{

					if (((A == B) && (B == C))) {
						JOptionPane.showMessageDialog(null, "O tri�ngulo � Equil�tero");
					}
					if (((A == B) && (B != C) || (A == C) && (C != B) || (C == B) && (B != A))) {
						JOptionPane.showMessageDialog(null, "O tri�ngulo � Is�sceles");
					}
					if (((A != B) && (B != C) && (A != C))) {
						JOptionPane.showMessageDialog(null, "O tri�ngulo � Escaleno");
					}
					else
					{
						JOptionPane.showMessageDialog(null, "N�o corresponde a um tri�ngulo ");
						
					}

					
				} 

				// Sair

				if (resp == 3)
					;
				System.exit(0);
			}
			resp2 = Integer.parseInt(JOptionPane.showInputDialog("1-Voltar ao menu principal / 2-Sair"));
			while ((resp2 > 3) || (resp2 < 1)) {
				resp2 = Integer.parseInt(JOptionPane.showInputDialog("1-Voltar ao menu principal / 2-Sair"));

			}
		} while (resp2 == 1);
		if (resp2 == 2) {
			System.exit(0);
		}

	}
}
