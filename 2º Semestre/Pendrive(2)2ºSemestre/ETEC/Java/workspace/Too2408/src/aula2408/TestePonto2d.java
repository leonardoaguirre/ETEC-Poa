package aula2408;

public class TestePonto2d 
{

	public static void main(String[] args) 
	{
        Ponto2d A = new Ponto2d();
        Ponto2d B = new Ponto2d();
        
        A.setX(2);
        A.setY(3);
        
        B.setX(4);
        B.setY(5);
        
        A.print();
        B.print();
        
        System.out.println(("Distância de A:" + A.DistanciaOrigem()));
        System.out.println(("Distância de B:" + B.DistanciaOrigem()));
        
        A.maisDistante(B);
        
        

	}

}
