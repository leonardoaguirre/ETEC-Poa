package exercicio3;

public class Tempo {
	private int hora, minuto, segundo;
	public void setHora(int h) {
		hora = h;
	}

	public int getHora() {
		return hora;
	}
	public void setMinuto(int m) {
		minuto = m;
	}

	public int getMinuto() {
		return minuto;
	}
	public void setSegundo(int s) {
		segundo = s;
	}

	public int getSegundo() {
		return segundo;
	}
	public void main(String args[]){
		Tempo a = new Tempo();
		a.setHora(00);
		a.setMinuto(00);
		a.setSegundo(00);

		a.print();

		Tempo b = new Tempo();
		b.setHora(12);
		b.setMinuto(21);
		b.setSegundo(12);

		b.print();
	}
	public void print(){
		System.out.println("Tempo: %.1f"+hora+":"+minuto+":"+segundo);
	}
	/*public void pegaMaior(){
		int hora1 = ;
		int hora2 = ;
		int minuto1 = ;
		int minuto2 = ;
		int segundo1 = ;
		int segundo2 = ;

		if ((hora1>hora2) && (minuto1>minuto2) && (segundo1>segundo2)){
			System.out.println("A maior hora ?: %.1f"+hora1+":"+minuto1+":"+segundo1);
			
		}else{
			System.out.println("A maior hora ?: %.1f"+hora2+":"+minuto2+":"+segundo2);
		}
	}//N?o sei pegar os parametros dos objetos A e B*/
}
