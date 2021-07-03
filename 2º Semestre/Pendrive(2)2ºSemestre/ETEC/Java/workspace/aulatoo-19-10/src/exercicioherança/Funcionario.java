package exercicioherança;

public class Funcionario extends MembroUniversidade{
	private double salario;
	private String admissao;
	public void setSalario(double salario1)
	{
		salario=salario1;
	}
	public double getSalario()
	{
		return salario;
	}
	public void setAdmissao(String admissao1)
	{
		admissao=admissao1;
	}
	public String getAdmissao()
	{
		return admissao;
	}
}
