package listao_pc1;

import java.util.Scanner;

public class Exercicio2 {

	public static void main(String[] args) {
		Scanner ler = new Scanner(System.in);
		int i, respSair = 1, somaMatriz, j, m[][] = new int[3][3];
		while (respSair == 1) {
			for (i = 0; i < 3; i++) {
				System.out.printf("Informe os numeros %da. linha:\n", (i + 1));
				for (j = 0; j < 3; j++) {
					System.out.printf("m[%d][%d] = ", i, j);
					m[i][j] = ler.nextInt();
				}
				System.out.printf("\n");
			}

			System.out.printf("\n");
			for (i = 0; i < 3; i++) {
				System.out.printf("%da. linha: ", (i + 1));
				for (j = 0; j < 3; j++) {
					System.out.printf("%d ", m[i][j]);
				}
				System.out.printf("\n");
			}
			somaMatriz = m[0][0] + m[0][1] + m[0][2];
			if ((m[1][0] + m[1][1] + m[1][2] == somaMatriz) && (m[2][0] + m[2][1] + m[2][2] == somaMatriz)
					&& (m[0][0] + m[1][1] + m[2][2] == somaMatriz) && (m[0][2] + m[1][1] + m[2][0] == somaMatriz)
					&& (m[0][0] + m[1][0] + m[2][0] == somaMatriz) && (m[0][1] + m[1][1] + m[2][1] == somaMatriz)
					&& (m[0][2] + m[1][2] + m[2][2] == somaMatriz)) {
			
				System.out.printf("\n");
				System.out.printf("O seu quadrado é um quadrado mágico!!");
			} else {
			
				System.out.printf("\n");
				System.out.printf("O seu quadrado não é um quadrado mágico!!");

			}
			System.out.printf("Desejar realizar o programa novamente? 1-Sim 2-Não");
			System.out.printf("\n");
			respSair = ler.nextInt();

		}
	}
}
