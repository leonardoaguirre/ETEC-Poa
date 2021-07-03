package exercicio;



public class Teste_Fracao {

	public static void main(String[] args) {
		Fracao conta = new Fracao();
		
		conta.setnumerador(14);
		conta.setdenominador(7);
		
		conta.setnumerador2(20);
		conta.setdenominador2(10);
		
		conta.respDecimal();
		conta.respDecimal2();
		
		conta.print();

		conta.achaMaior();
		
		conta.saoEquivalentes();

		conta.multiplicaCom();
		
		
	}
}
