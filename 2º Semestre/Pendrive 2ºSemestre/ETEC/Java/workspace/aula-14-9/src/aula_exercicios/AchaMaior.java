package aula_exercicios;
import java.awt.*;
import javax.swing.*;
public class AchaMaior 
{
	int X;

	
	public Ponto2D dobroPonto()
	{
		Ponto2D novo = new Ponto2D();
		novo.setX(this.getX() * 2);
		novo.setY(this.getY() * 2);
		
		return novo;
		
	}
	
	public boolean comparaCom (Ponto2D P2)
	{
		if (this.getX() == P2.getX() && this.getY() == P2.getY())
			return true;
		else
			return false;
		
	}
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
	
	public static void main (String args[])
	{
		Ponto2D P1 =  new Ponto2D();
		Ponto2D P2 =  new Ponto2D();

		P1.setX(100);
		P1.setY(60);
		
		P2.setX(120);
		P2.setY(80);
		
		Ponto2D maior;
		maior = P1.AchaMaior(P2);
		maior.print();
		
		Ponto2D dobro;
		dobro = P1.dobroPonto(P2);
dobro.print();
		
		if(P1.comparaCont(P2))
			System.out.println("São iguais");
		else 
			System.out.println("São diferentes");
	}
			public  int distanciaAte(int distanciaAte)
			{
	distanciaAte = P1.setX - P1.setY;
				
				
			}
		

		
		
		
		
	}
	








}
