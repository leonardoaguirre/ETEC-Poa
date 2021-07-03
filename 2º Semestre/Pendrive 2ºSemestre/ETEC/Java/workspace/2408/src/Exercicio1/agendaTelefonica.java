package Exercicio1;

public class agendaTelefonica
{
	private int contatos;
	private String nome;
	protected float endereço;
	
	
	public void setContato(int novo_contato)
	{
		contatos = novo_contato;
	}
	public int getContato()
	{
		return contatos;
	}
	public void setNome(String novo_nome)
	{
		nome=novo_nome;
	}
	public String getNome()
	{
		return nome;
	}
	public void setSalario(float novo_endereço)
	{
		endereço = novo_endereço;
	}
	public float getEndereço()
	{
		return endereço;
	}

}
