package aula1908;
import javax.swing.*;
public class DiasDaSemana 
{

	public static void main(String[] args) 
	{
	int dia=0;
	String diaSemana[];
	 diaSemana = new String [7];
	for(int i=0;i<7;i++){
        dia = dia + 1;
		diaSemana[i]=JOptionPane.showInputDialog("Digite o "+ dia + "� da semana:");
	    
	} 
	System.out.println("Os dias da semana s�o: ");
	for(int i=0;i<7;i++){
		System.out.println(diaSemana[i]);
	}
	{
}
	}
}
