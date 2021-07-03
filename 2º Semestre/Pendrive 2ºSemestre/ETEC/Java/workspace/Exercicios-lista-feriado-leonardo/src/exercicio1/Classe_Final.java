package exercicio1;

public class Classe_Final {
	public static void main(String[] args) {
		Cilindro alturaCilindro = new Cilindro();
		Cilindro raioCilindro = new Cilindro();
		Conta nomeCliente = new Conta();
		Conta saldoConta = new Conta();
		Fracao numerador = new Fracao();
		Fracao denominador = new Fracao();
		
		alturaCilindro.setalturaCilindro(20);
		raioCilindro.setraioCilindro(5);
		nomeCliente.setnomeCliente("leonardo");
		saldoConta.setsaldoConta(14000);
		numerador.setnumerador(15);
		denominador.setdenominador(7);
		
		alturaCilindro.print();
		raioCilindro.print();
		nomeCliente.print();
		saldoConta.print();
		numerador.print();
		denominador.print();
	}
}
