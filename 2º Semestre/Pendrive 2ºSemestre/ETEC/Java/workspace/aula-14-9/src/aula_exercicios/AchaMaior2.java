package aula_exercicios;
import java.awt.*;
import javax.swing.*;
public class Ponto2D {
	public Ponto2D AchaMaior (Ponto2D P2)
	{
		float d1 = this.distanciaOrigem();
		
		float d2 = P2.distanciaOrigem();
		
		if (d1 > d2)
			return this;
		else 
			return P2;
	}

	private float distanciaOrigem()
	{
		
		return 0;
	}
	
}
