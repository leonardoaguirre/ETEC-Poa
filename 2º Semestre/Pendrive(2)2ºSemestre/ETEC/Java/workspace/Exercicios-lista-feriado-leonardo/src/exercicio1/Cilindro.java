package exercicio1;

public class Cilindro {
	private int alturaCilindro;
	private int raioCilindro;
	private double volumeCilindro;


	public void setalturaCilindro(int AalturaCilindro) {
		alturaCilindro = AalturaCilindro;
	}

	public double getalturaCilindro() {
		return alturaCilindro;
	}

	public void setraioCilindro(int RraioCilindro) {
		raioCilindro = RraioCilindro;
	}

	public double getraioCilindro() {
		return raioCilindro;
	}

	public double getvolumeCilindro() {
		volumeCilindro = 3.14*raioCilindro*raioCilindro*alturaCilindro;
		return volumeCilindro;
	}


	public void print() {

		System.out.printf("O volume do cilindro é :"+volumeCilindro);
		
	}
}
