package aula_java;
import javax.swing.*;
public class exercicio2
{

	
public static void main (String args[])
	{
	Integer result , conta ;
JOptionPane.showMessageDialog (null, "Pense um número");
JOptionPane.showMessageDialog (null, "Multiplique por 2");
JOptionPane.showMessageDialog (null, "Some 6 ao resultado");
JOptionPane.showMessageDialog (null, "Divida o resultado por 2");
result = Integer.parseInt (JOptionPane.showInputDialog ("Quanto deu?"));

conta = (result - 3);

JOptionPane.showMessageDialog (null, "O número que você pensou é:" + conta);
	
	
	
	
	
	}
}
