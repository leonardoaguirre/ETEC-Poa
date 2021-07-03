package exercicio1;

public class Fracao {
	private int numerador;
	int denominador;
	private double respDecimal;

	public void setnumerador(int Nnumerador) {
		numerador = Nnumerador;
	}

	public double getnumerador() {
		return numerador;
	}

	public void setdenominador(int Ndenominador) {
		denominador = Ndenominador;
	}

	public double getdenominador() {
		return denominador;
	}

	public void respDecimal() {
		respDecimal = numerador / denominador;
	}


	public void print() {
		System.out.print("Fração: " + numerador + "/" + denominador + " = " + respDecimal);
	}
}
