package exercicio;

public class Fracao {
	// Fra��o 1*
	private double numerador;
	private double denominador;
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

	// Fra��o 2*
	private double numerador2;
	private double denominador2;
	private double respDecimal2;

	public void setnumerador2(int Nnumerador2) {
		numerador2 = Nnumerador2;
	}

	public double getnumerador2() {
		return numerador2;
	}

	public void setdenominador2(int Ndenominador2) {
		denominador2 = Ndenominador2;
	}

	public double getdenominador2() {
		return denominador2;
	}
	public void respDecimal2() {
		respDecimal2 = numerador2 / denominador2;
	}

	public void print() {
		System.out.print("Fra��o 1: " + numerador + "/" + denominador + " = " + respDecimal);
		System.out.print("\nFra��o 2: " + numerador2 + "/" + denominador2 + " = " + respDecimal2);
	}

	public void achaMaior() {
		if (respDecimal == respDecimal2) {
			System.out.print("\nAmbas as Fra��es s�o iguais!");
		}
			if (respDecimal > respDecimal2) {
			System.out.print("\nA maior Fra��o �: " + numerador + "/" + denominador + " = " + respDecimal);
		} else {
			System.out.print("\nA maior Fra��o �: " + numerador2 + "/" + denominador2 + " = " + respDecimal2);
		}
		}
	
	
public void saoEquivalentes(){
	
	if (respDecimal == respDecimal2){
		System.out.print("\nAs Fra��es 1 e 2 s�o equivalentes! ");
	}else{
		System.out.print("\nAs Fra��es 1 e 2 n�o s�o equivalentes! ");
	}
	
}


	public void multiplicaCom(){
		numerador = numerador * numerador2;
		denominador = denominador * denominador2;
		respDecimal = numerador / denominador;
		System.out.print("\nFra��o Multiplicada: " + numerador + "/" + denominador + " = " + respDecimal);
	}
	

}
