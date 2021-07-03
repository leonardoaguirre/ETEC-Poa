package aula_java;

import javax.swing.*;
import java.text.DecimalFormat;

public class listaExercicios {

	public static void main(String args[])

	{
		double nota1, nota2, nota3, nota4, media;
		nota1 = Double.parseDouble(JOptionPane.showInputDialog("Digite a 1°Nota"));
		nota2 = Double.parseDouble(JOptionPane.showInputDialog("Digite a 2°Nota"));
		nota3 = Double.parseDouble(JOptionPane.showInputDialog("Digite a 3°Nota"));
		nota4 = Double.parseDouble(JOptionPane.showInputDialog("Digite a 4°Nota"));

		media = (nota1 + nota2 * 2 + nota3 * 3 + nota4 * 4) / 10;

		DecimalFormat df = new DecimalFormat("0.#");

		JOptionPane.showMessageDialog(null, "A média ponderada das notas é: " + df.format(media));
	}

}
