package aula_exercicios;

import javax.swing.JOptionPane;

public class Ponto2d {
	private int x;
	private int y;

	public void setX(int n_x) {
		x = n_x;
	}

	public int getX() {
		return x;
	}

	public void setY(int n_y) {
		y = n_y;
	}

	public int getY(){
		return y;
	}

	public void print() {
		JOptionPane.showMessageDialog(null, "Ponto(" + x + "," + y + ")");
	}

	public float distanciaOrigem() {
		float d;
		d = (float) Math.sqrt(x * x + y * y);
		return d;
	}

	public static void main(String args[]) {
		Ponto2D A = new Ponto2D();
		Ponto2D B = new Ponto2D();

		A.setX(2);
		A.setY(3);

		B.setX(4);
		B.setY(5);

		A.print();
		B.print();

		System.out.println("Distancia de A:" + A.distanciaOrigem());
		System.out.println("Distancia de B:" + B.distanciaOrigem());

	}

	public void maisDistante(Ponto2D P2) {
		if (this.distanciaOrigem() > P2.distanciaOrigem())
			this.print();
		else
			P2.print();
	}

}
