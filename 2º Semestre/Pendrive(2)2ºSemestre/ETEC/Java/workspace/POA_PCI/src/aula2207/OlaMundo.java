package aula2207;
//Comentário
/*Data: 22/07/2016
 *Autor: Luiz & Lucas
 *Objetivo: Aprendendo Java
 * 
 * 
 * 
 * 
 */
import javax.swing.JOptionPane;

public class OlaMundo {
	public static void main (String args[])
	{	
		String f = "Tudo bem?";
		String a = "Oi Cambada";
		int b=3; //imprimir na tela
		
		System.out.println("Olá Mundo!!!");
		JOptionPane.showMessageDialog(null,"Oi!!\n Proxima Linha." );
		JOptionPane.showMessageDialog(null, "O valor da variavel b é " +b);
		JOptionPane.showMessageDialog(null, a+f);
	}
}
