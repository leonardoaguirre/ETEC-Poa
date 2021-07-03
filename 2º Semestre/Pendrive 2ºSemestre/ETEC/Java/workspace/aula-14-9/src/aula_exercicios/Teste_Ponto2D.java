package aula_exercicios;

public class Teste_Ponto2D {
	public static void main(String[] args) {
		
 	   
		   Ponto2D P1=new Ponto2D();
		   Ponto2D P2=new Ponto2D();
		   
		   P1.setX(100);
		   P1.setY(60);
		   
		   P2.setX(120);
		   P2.setY(80);
		   
		   Ponto2D maior;
		   maior = P1.achaMaior(P2);
		   maior.print();
		   
		  Ponto2D dobro;
		   maior = P1.achaDobro(P2);
		   maior.print();
		   
	   }
 
	}

