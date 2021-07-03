package listao_pc1;

import java.util.Scanner;

public class Exercicio4 {

	public static void main(String[] args) {
		
		Scanner ler = new Scanner(System.in);
		int n = 11, simprimo = 0, naoprimo = 0, respSair=1;
		int v[] = new int[n];
		int a;
		while (respSair == 1){
		for (a = 1; a < n; a++) {
			System.out.println("Digite o " + a + "º numero:");
			v[a] = ler.nextInt();
			int primo = 0;
			{
				for (int i = 2; i < v[a]; i++) {
					if (v[a] % i == 0) {
						primo = 1;
					}
				}
				if (primo == 0) {
					simprimo = simprimo + 1;
				} else {
					naoprimo = naoprimo + 1;
				}

			}

		}
		System.out.printf("Foram digitados " + simprimo + " numeros primo(s) e " + naoprimo + " nâo primo(s)");
		System.out.printf("\n");
		System.out.println("Você deseja realizar o programa novamente? 1-Sim 2-Não");
		respSair = ler.nextInt();
	}
}
}