package Exercicios;
import javax.swing.JOptionPane;
public class menu_principal {

	public static void main(String[] args) {
		int n1, a , b, c, delt, x1, x2, rdelt, m1, f, e, d;

		do{
		n1 = Integer.parseInt(JOptionPane.showInputDialog("1-Equa��o do 2� / 2-Tipo Triangulo / 3-Sair "));
		while ((n1 > 3)|| (n1 < 1)) {
			n1 = Integer.parseInt(JOptionPane.showInputDialog("1-Equa��o do 2� / 2-Tipo Triangulo / 3-Sair"));
		}

		if (n1 == 1) {
			
			
			
			a = Integer.parseInt(JOptionPane.showInputDialog("Digite o coeficiente a"));
			b = Integer.parseInt(JOptionPane.showInputDialog("Digite o coeficiente b"));
			c = Integer.parseInt(JOptionPane.showInputDialog("Digite o coeficiente c"));

			delt = ((b * b) - 4 * a * c);
			rdelt = (int) Math.sqrt(delt);

			if (delt < 0) {

				JOptionPane.showMessageDialog(null, "N�o existe solu��o para essa equa��o, pois o delta � negativo");
				a = 0 ;
			}

			if (delt == 0) {
				JOptionPane.showMessageDialog(null, "O delta � " + delt);
				x1 = (int) ((-b)  / (2 * a));
				JOptionPane.showMessageDialog(null, "O x' � " + x1);
				a = 0 ;
			}
			if (delt > 0) {
				JOptionPane.showMessageDialog(null, "O delta � " + delt);
				x1 = (int) ((-b + rdelt) / (2 * a));
				x2 = (int) ((-b - rdelt) / (2 * a));

				JOptionPane.showMessageDialog(null, "O x' � " + x1);
				JOptionPane.showMessageDialog(null, "O x'' � " + x2);
				a = 0 ;
			}
		}
		

		if (n1 == 2) {

			d = Integer.parseInt(JOptionPane.showInputDialog("Digite o valor do lado a do triangulo"));
			e = Integer.parseInt(JOptionPane.showInputDialog("Digite o valor do lado b do triangulo"));
			f = Integer.parseInt(JOptionPane.showInputDialog("Digite o valor do lado c do triangulo"));

			if (((d >= e + f) || (e >= d + f) || (f >= d + e))) {

				JOptionPane.showMessageDialog(null,
						"N�o existe solu��o para esse problema, pois n�o se trata de um triangulo");
				
			
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

		if (n1 == 3) {

	   System.exit(0);

		}
		m1 = Integer.parseInt(JOptionPane.showInputDialog(null,  "1-Voltar para o menu inicial / 2-Encerrar aplica��o "));
		while ((m1 > 2) || (m1 < 1 )) {
			m1 = Integer.parseInt(JOptionPane.showInputDialog(null,  "1-Voltar para o menu inicial / 2-Encerrar aplica��o "));
		}
		
		
		}while  ( m1 == 1);
		if (m1 ==  2){

		}
				}

	}


	


