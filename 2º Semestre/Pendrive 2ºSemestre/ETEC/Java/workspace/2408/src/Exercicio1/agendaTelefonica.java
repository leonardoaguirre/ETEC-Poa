package Exercicio1;

public class agendaTelefonica
{
	private int contatos;
	private String nome;
	protected float enderešo;
	
	
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
	public void setSalario(float novo_enderešo)
	{
		enderešo = novo_enderešo;
	}
	public float getEnderešo()
	{
		return enderešo;
	}

}
