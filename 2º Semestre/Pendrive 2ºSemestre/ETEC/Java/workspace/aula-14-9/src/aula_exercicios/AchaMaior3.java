package aula_exercicios;
import java.awt.*;
import javax.swing.*;
public class AchaMaior3 
{
	public boolean comparaCom (Ponto2D P2)
	{
		if (this.getX() == P2.getX() && this.getY() == P2.getY())
			return true;
		else
			return false;
		
	}
}
