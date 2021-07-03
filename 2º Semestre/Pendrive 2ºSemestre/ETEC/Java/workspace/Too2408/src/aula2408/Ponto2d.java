package aula2408;

import javax.swing.*;

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

	public int getY() {
		return y;
	}

	public void print() {
		JOptionPane.showMessageDialog(null, "Ponto(" + x + "," + y + ")");
	}

	public float distanciaOrigem() {
		float d;
		d = (float)Math.sqrt(x * x + y * y);
		return d;
	}
}
