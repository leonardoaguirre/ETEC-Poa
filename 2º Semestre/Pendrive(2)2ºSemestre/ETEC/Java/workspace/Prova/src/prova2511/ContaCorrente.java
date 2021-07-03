package prova2511;

public class ContaCorrente extends Conta{
private int limiteCredito;
public void setCredito(int credito1)
{
	limiteCredito=credito1;
}
public int getCredito()
{
	return limiteCredito;
}
public void main(String args[]){
	ContaCorrente B = new ContaCorrente();
	B.setNome("Julio");
	B.setNumero(24);
	B.setSaldo(0);
	B.setCredito(500);
	
}
}
