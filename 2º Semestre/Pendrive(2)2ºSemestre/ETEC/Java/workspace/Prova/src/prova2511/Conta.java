package prova2511;

public class Conta {
	private String nome;
	private int numero;
	protected float saldo;
	public void setNome(String nome1)
	{
		nome=nome1;
	}
	public String getNome()
	{
		return nome;
	}
	public void setNumero(int numero1)
	{
		numero=numero1;
	}
	public int getNumero()
	{
		return numero;
	}
	public void setSaldo(float saldo1)
	{
		saldo=saldo1;
	}
	public float getSaldo()
	{
		return saldo;
	}
	public void main(String args[]){
		Conta A = new Conta();
		A.setNome("Leonardo");
		A.setNumero(2016);
		A.setSaldo(500);
	}
	public void Depositar(float sa1){
		this.saldo +=sa1; 
	}
	public void Sacar(float sac1){
		this.saldo -=sac1;
	}
	public void AtualizaMes(int meses){
		float porcentagem;
		porcentagem = meses*(saldo/100);
		this.saldo += porcentagem;
	}
	public void depositar(float sa1) {
		// TODO Auto-generated method stub
		
	}
	public void atualizaMes(int mes) {
		// TODO Auto-generated method stub
		
	}
	public void sacar(float sa1) {
		// TODO Auto-generated method stub
		
	}
}
