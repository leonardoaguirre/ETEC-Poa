package aula;

public class Produto implements Imprimivel {
	protected String descricao;
	protected int quantidade;

	public Produto(String d, int q) {
		descricao = d;
		quantidade = q;
	}

	public String toString() {
		String resp = "Descri??o" + descricao;
		resp += nlin + "Qtde: " + quantidade;
		return resp;
	}

	public void toSystemOut() {
		String resp = "Descri??o: " + descricao;
		resp += nlin + "Qtde: " + quantidade;
		System.out.print(resp);
	}

	@Override
	public void toStringOut() {

	}
}
