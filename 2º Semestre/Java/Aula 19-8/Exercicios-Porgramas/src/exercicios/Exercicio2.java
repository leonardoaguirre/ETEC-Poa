package exercicios;

import javax.swing.JOptionPane;

public class Exercicio2 {

	public static void main(String[] args) {
		Integer nota, notasnegativas = 0, numeronotas = 0, media = 0;
		nota = Integer.parseInt(JOptionPane.showInputDialog("Digite a nota desejada:"));
		while (nota != 0)
			if ((nota <= 10) && (nota >= 0)) {
				if (nota < 5) {
					notasnegativas = notasnegativas + 1;
				} else {
					numeronotas = numeronotas + 1;
				}
				media = media + nota;
			}
		if (nota == 0) {
			JOptionPane.showMessageDialog(null, "Foram digitadas: " + numeronotas + "notas, a sua média é: " + media
					+ " e foram digitadas " + notasnegativas + " abaixo de 5");
		}
	}
}
