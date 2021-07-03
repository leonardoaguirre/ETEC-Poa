package exercicio2;
import javax.swing.*;

public class exercicio2
{

	public static void main(String args[])
	{
	int R, result;
		
	JOptionPane.showInputDialog("Pense em um número");
	JOptionPane.showInputDialog("Multiplique por 2");
	JOptionPane.showInputDialog("Some mais 6 ao resultado");
	JOptionPane.showInputDialog("Divida o resultado por 2");
	R = Integer.parseInt(JOptionPane.showInputDialog("Quanto deu: "));
		
    result = R - 3;
    
    JOptionPane.showInputDialog("O número que voce pensou foi: " +result);
	     
	}
}
