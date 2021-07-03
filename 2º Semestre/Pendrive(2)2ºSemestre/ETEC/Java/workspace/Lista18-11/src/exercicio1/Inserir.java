package exercicio1;

public class Inserir extends Baskara {
	public Inserir() {
		
			Inserir a = new Inserir();
			a.setA(0);
			a.setB(0);
			a.setC(0);
			a.setX("X");
	Inserir b = new Inserir();
		b.setA(1);
		b.setB(2);
		b.setC(3);
		b.setX("X");
		
		a.print();
		b.print();
	
		//não entendi o que fazer no resto do exercicio questão complexa de se entender
}

	private void print() {
		System.out.println(A+X+"^2"+B+X+C+"=0");
		
	}
}
