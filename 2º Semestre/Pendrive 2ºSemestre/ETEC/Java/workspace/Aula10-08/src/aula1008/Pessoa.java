package aula1708;

public class Pessoa 
{
	private int idade;
	private String nome;
	protected float salario;
	
	public void setIdade(int nova_idade)
	{
		idade=nova_idade;
	}
	public int getIdade()
	{
		return idade;
	}
	public void setNome(String novo_nome)
	{
		nome=novo_nome;
	}
	public String getNome()
	{
		return nome;
	}
	public void setSalario(float novo_salario)
	{
		salario=novo_salario;
	}
	public float getSalario()
	{
		return salario;
	}

}
