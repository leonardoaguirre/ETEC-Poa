package exercicioherança;

public class Aluno extends MembroUniversidade{
	private String rgm;
	private String curso;
	public Aluno(String no, String na, String r, String cur){
		super(no, na);
		rgm=r;
		curso=cur;
	}
	public Aluno(){
		super();
		rgm="";
		curso="";
	}
	public void setRgm(String rgm1)
	{
		rgm=rgm1;
	}
	public String getRgm()
	{
		return rgm;
	}
	public void setCurso(String curso1)
	{
		curso=curso1;
	}
	public String getCurso()
	{
		return curso;
	}
}
