package exercicioherança;

public class Professor extends Funcionario{
	private String regime;
	private String titulacao;
	public void setRegime(String regime1)
	{
		regime=regime1;
	}
	public String getRegime()
	{
		return regime;
	}
	public void setTitulacao(String titulacao1)
	{
		titulacao=titulacao1;
	}
	public String getTitulacao()
	{
		return titulacao;
	}
}
