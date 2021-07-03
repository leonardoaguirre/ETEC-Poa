package listao_pc1;

import javax.swing.*;

public class Exercicio1 {

	public static void main(String[] args) {
		int resp;
		int respSair = 0;

		while (respSair ==1) {
			resp = Integer.parseInt(JOptionPane.showInputDialog("Informe o  numero desejado: "));
			if ((resp >= 8) || (resp <= 0)) {
				JOptionPane.showMessageDialog(null, "ERRO--- O numero informado não corresponde a nenhum dia...");
			}
			if (resp == 1) {
				JOptionPane.showMessageDialog(null, "O numero digitado corresponde ao domingo... ");
			}
			if (resp == 2) {
				JOptionPane.showMessageDialog(null, "O numero digitado corresponde a segunda-feira... ");
			}
			if (resp == 3) {
				JOptionPane.showMessageDialog(null, "O numero digitado corresponde a terça-feira... ");
			}
			if (resp == 4) {
				JOptionPane.showMessageDialog(null, "O numero digitado corresponde a quarta-feira... ");
			}
			if (resp == 5) {
				JOptionPane.showMessageDialog(null, "O numero digitado corresponde a quinta feira... ");
			}
			if (resp == 6) {
				JOptionPane.showMessageDialog(null, "O numero digitado corresponde a sexta-feira... ");
			}
			if (resp == 7) {
				JOptionPane.showMessageDialog(null, "O numero digitado corresponde ao sábado ");
			}
			
				respSair = Integer.parseInt(JOptionPane.showInputDialog("Você deseja fazer o processo novamente? 1-Sim / 2-Não"));
			

		}
		

	}
}
