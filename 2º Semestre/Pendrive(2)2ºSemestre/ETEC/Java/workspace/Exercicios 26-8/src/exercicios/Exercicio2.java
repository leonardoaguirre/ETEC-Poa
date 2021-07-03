package exercicios;

import javax.swing.*;

public class Exercicio2 {

	public static void main(String[] args) {
		int vetor[];
		int n = 0, NumMenor = 1000000000, NumMaior = 0, PosicaoMaior = 0, PosicaoMenor = 0;
		vetor = new int[n];
		for (int i = 0; i < 100; i++) {
			vetor[i] = Integer.parseInt(JOptionPane.showInputDialog("Informe o " +(i+1)+ "º numero"));
			
			
			if (vetor[i] < NumMenor) {
				NumMenor = vetor[i];
				PosicaoMenor = i;
			}
			if (vetor[i] > NumMaior) {
				NumMaior = vetor[i];
				PosicaoMaior = i;
			}

		}
		JOptionPane.showMessageDialog(null, "O maior numero digitado foi : " + NumMaior + " com a posição : " + PosicaoMaior
				+ " e o menor numero digitado foi: " + NumMenor + " com a posição : " + PosicaoMenor);
	}
}
