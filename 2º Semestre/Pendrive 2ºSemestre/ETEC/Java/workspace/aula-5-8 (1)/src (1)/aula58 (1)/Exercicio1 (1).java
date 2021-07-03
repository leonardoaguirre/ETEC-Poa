package aula58;

import javax.swing.*;

public class Exercicio1

{
	public static void main(String[] args) {

		int resp, resp2, A, B, C, respdelta, respdelta2, equa1, equa2;

		do {
			resp = Integer.parseInt(JOptionPane.showInputDialog(
					"" + "MENU PRINCIPAL " + " | 1 - Equacão do : " + " | 2 - Tipo triângulo: " + " | 3 - Sair: "));

			while (resp > 3) {
				resp = Integer.parseInt(JOptionPane.showInputDialog("" + "MENU PRINCIPAL " + " | 1 - Equacão do 2º: "
						+ " | 2 - Tipo triângulo: " + " | 3 - Sair: "));
			}
			// Equação do 2° grau

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
				JOptionPane.showMessageDialog(null, "Equação x1 =" + equa1);
				JOptionPane.showMessageDialog(null, "Equação x2 =" + equa2);
			
			}
			
			
			// TriÂngulos

			if (resp == 2) {

				A = Integer.parseInt(JOptionPane.showInputDialog("Informe o valor do lado A :"));
				B = Integer.parseInt(JOptionPane.showInputDialog("Informe o valor do lado B :"));
				C = Integer.parseInt(JOptionPane.showInputDialog("Informe o valor do lado C :"));
			

				{

					if (((A == B) && (B == C))) {
						JOptionPane.showMessageDialog(null, "O triângulo é Equilátero");
					}
					if (((A == B) && (B != C) || (A == C) && (C != B) || (C == B) && (B != A))) {
						JOptionPane.showMessageDialog(null, "O triângulo é Isósceles");
					}
					if (((A != B) && (B != C) && (A != C))) {
						JOptionPane.showMessageDialog(null, "O triângulo é Escaleno");
					}
					else
					{
						JOptionPane.showMessageDialog(null, "Não corresponde a um triângulo ");
						
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
