package exercicio;

public class Fracao {
	// Fração 1*
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

	// Fração 2*
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
		System.out.print("Fração 1: " + numerador + "/" + denominador + " = " + respDecimal);
		System.out.print("\nFração 2: " + numerador2 + "/" + denominador2 + " = " + respDecimal2);
	}

	public void achaMaior() {
		if (respDecimal == respDecimal2) {
			System.out.print("\nAmbas as Frações são iguais!");
		}
			if (respDecimal > respDecimal2) {
			System.out.print("\nA maior Fração é: " + numerador + "/" + denominador + " = " + respDecimal);
		} else {
			System.out.print("\nA maior Fração é: " + numerador2 + "/" + denominador2 + " = " + respDecimal2);
		}
		}
	
	
public void saoEquivalentes(){
	
	if (respDecimal == respDecimal2){
		System.out.print("\nAs Frações 1 e 2 são equivalentes! ");
	}else{
		System.out.print("\nAs Frações 1 e 2 não são equivalentes! ");
	}
	
}


	public void multiplicaCom(){
		numerador = numerador * numerador2;
		denominador = denominador * denominador2;
		respDecimal = numerador / denominador;
		System.out.print("\nFração Multiplicada: " + numerador + "/" + denominador + " = " + respDecimal);
	}
	

}
