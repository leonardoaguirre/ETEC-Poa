package exercicio2;

public class Computador {
	private float clock, HD;
	private String processador;

	public void setClock(float clock1) {
		clock = clock1;
	}

	public float getClock() {
		return clock;
	}

	public void setHD(float HD1) {
		HD = HD1;
	}

	public float getHD() {
		return HD;
	}

	public void setProcessador(String processador1) {
		processador = processador1;
	}

	public String getProcessador() {
		return processador;
	}

	public void main(String args[]) {
		Computador a = new Computador();
		a.setClock(0);
		a.setHD(0);
		a.setProcessador("");

		Computador b = new Computador();
		b.setClock(3);
		b.setHD(500);
		b.setProcessador("Intel i7");

		a.print();
		b.print();
	}

	public void print() {
		System.out.println("Clock: " + clock + "GHz| HD: " + HD + "GB| Processador: " + processador);

	}

	/*public Computador ComparaCom(){
		        float clock1 = ...
				float clock2 = ...
				float HD1 = ...
				float HD2 = ...
				float proce1 = ...
				float proce2 = ...
				 if((clock1 == clock2) && (HD1 == HD2) && (proce1 == proce2)){
					 System.out.println("Os computadores são iguais");
				 }else{
					 System.out.println("Os computadores são diferentes");
				 }
if(HD1 > HD2){
	 System.out.println("O computador A tem mais HD");
}else{
	 System.out.println("Os computador B tem mais HD");
} Não sei pegar os parametros dos objetos A e B*/

	}


