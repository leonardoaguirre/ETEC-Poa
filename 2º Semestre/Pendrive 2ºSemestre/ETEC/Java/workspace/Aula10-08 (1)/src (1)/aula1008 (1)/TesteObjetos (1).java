package aula1708;

public class TesteObjetos 
{
	public static void main(String args[])
	{
		Pessoa maria=new Pessoa();
		Pessoa joao=new Pessoa();
		
		maria.setIdade(30);
		joao.setIdade(45);
		
		System.out.println("Maria="+maria.getIdade());
		System.out.println("João="+joao.getIdade());
	}

}
