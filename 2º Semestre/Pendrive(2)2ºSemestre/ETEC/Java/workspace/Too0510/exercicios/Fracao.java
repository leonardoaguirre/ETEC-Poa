package exercicios;

public class Fracao {
	private int numerador;
	int denominador;
	private double dec;

	public void setnumerador(int novo_numerador) {
		numerador = novo_numerador;
	}

	public double getnumerador() {
		return numerador;
	}

	public void setdenominador(int novo_denominador) {
		denominador = novo_denominador;
	}

	public double getdenominador() {
		return denominador;
	}


                                
       public double getdec() {
           	dec = (numerador / denominador);
		return dec;
	}
               



	public void print() {
		System.out.print("Fração: " + numerador + "/" + denominador + " = " + dec);
	}
}
      

