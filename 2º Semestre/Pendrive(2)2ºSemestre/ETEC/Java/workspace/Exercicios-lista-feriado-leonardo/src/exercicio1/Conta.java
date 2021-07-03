package exercicio1;

public class Conta {

	private String nomeCliente;
	private int numConta;
	private double saldoConta;
	private double saldoDolar;

	public void setnomeCliente(String NnomeCliente) {
		nomeCliente = NnomeCliente;
	}

	public String getnomeCliente() {
		return nomeCliente;
	}

	public void setnumConta(int NnumConta) {
		numConta = NnumConta;
	}

	public int getnumConta() {
		return numConta;
	}

	public void setsaldoConta(double numSaldoConta) {
		saldoConta = numSaldoConta;
	}

	public double getsaldoConta() {
		return saldoConta;
	}


	public void vip() {
		if (saldoConta > 50000) {
			System.out.print("\nCLIENTE VIP\n");

		} else {
			System.out.print("\nCLIENTE NORMAL\n");

		}

	}

	public void converteDolar() {
		double cotacaoDolar;
		cotacaoDolar = 3.20;
		saldoDolar = (saldoConta / cotacaoDolar);
	}

	
	public void print() {

		System.out.print("Nome do Cliente: " + nomeCliente + " |Saldo : " + saldoConta + " |Numero da conta: " + numConta+" |Saldo em dólar: "+saldoDolar);

	}

}

