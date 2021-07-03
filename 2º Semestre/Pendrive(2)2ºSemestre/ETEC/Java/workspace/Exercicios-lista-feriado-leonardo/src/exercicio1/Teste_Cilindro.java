package exercicio1;

public class Teste_Cilindro {

	public static void main(String[] args) {
		Cilindro alturaCilindro = new Cilindro();
		Cilindro raioCilindro = new Cilindro();
		Cilindro volumeCilindro = new Cilindro();

		alturaCilindro.setalturaCilindro(20);
		raioCilindro.setraioCilindro(5);
		volumeCilindro.getvolumeCilindro();
		volumeCilindro.print();

	}
}
