package exercicio2;

public class TestePonto2D {
      public static void main(String args[])
      {
    	  Ponto2D A = new Ponto2D();
    	  Ponto2D B = new Ponto2D();
    	  
    	  A.setX(2);
    	  A.setY(3);
    	  
    	  B.setX(4);
    	  B.setY(5);
    	  
    	  A.print();
    	  B.print();
    	  
    	  System.out.println("Distancia de A:" +A.distanciaOrigem());
    	  System.out.println("Distancia de B:" +B.distanciaOrigem());
    	  
    	  A.maisDistante(B);
    	  
    	  
      }
}
