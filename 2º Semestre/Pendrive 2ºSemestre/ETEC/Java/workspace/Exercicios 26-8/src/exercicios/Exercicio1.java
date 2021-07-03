package exercicios;

import javax.swing.*;

public class Exercicio1 {

	public static void main(String[] args) {

		double media = 0, vet = 0;
		int n = 20, n1 = 0, i;
		double vetor[];
		vetor = new double[n];
		for (i = 0; i < 20; i++) {

			vetor[i] = Integer.parseInt(JOptionPane.showInputDialog("Informe o " + (i + 1) + "º numero"));
			vet = vet + vetor[i];
			n1 = n1 + 1;
			if (vetor[i] < 0) {
				media = vet / i;
				Integer.parseInt(JOptionPane.showInputDialog("A media das notas é: " + media));

				System.exit(0);

			}
		}
		if (i==20){
				media = vet / i;
				JOptionPane.showMessageDialog(null, "A media das notas é: " + media);
			i = i+1;
			}
		
	}

}
