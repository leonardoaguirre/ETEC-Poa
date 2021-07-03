package exercicios;

import javax.swing.JOptionPane;

public class Exercicio1 {

	public static void main(String[] args) {
		String materia;
		Integer nota = 1;
		while (nota != 0) {

			materia = JOptionPane.showInputDialog("Digite a materia desejada:");
			nota = Integer.parseInt(JOptionPane.showInputDialog("Digite a nota desejada:"));
			if ((nota <= 10) && (nota >= 0)) {
				if (nota == 0) {
					System.exit(0);
				} else {
					if (nota >= 7) {
						JOptionPane.showMessageDialog(null, "O aluno foi aprovado na matéria de :" + materia);

					} else {
						JOptionPane.showMessageDialog(null, "O aluno foi reprovado na matéria de :" + materia);
					}
				}
			}

		}
	}

}
