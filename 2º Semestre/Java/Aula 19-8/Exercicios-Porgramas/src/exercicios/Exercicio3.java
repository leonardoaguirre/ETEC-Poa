package exercicios;

import javax.swing.*;

public class Exercicio3 {

	public static void main(String[] args) {
		Integer num = 1, nummaior = 0, nummenor = 999999;
		while (num != 0) {
			num = Integer.parseInt(JOptionPane.showInputDialog("Digite um numero:"));
			if (num == 0) {
				JOptionPane.showMessageDialog(null,
				"O maior numero digitado foi: " + nummaior + " E o menor numero digitado foi: " + nummenor);

			}else {
				if ((num < nummenor)) {
					nummenor = num;
				}
				if (num > nummaior) {
					nummaior = num;
				}
                
			}
		}
	}
}
