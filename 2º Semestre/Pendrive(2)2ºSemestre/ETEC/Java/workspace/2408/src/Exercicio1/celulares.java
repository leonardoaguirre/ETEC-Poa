package Exercicio1;

public class celulares 
{
		private int ram;
	    private String marca;
	    protected float modelo;
	
	
	public void setRam(int nova_ram)
	{
	ram = nova_ram;
	}
	public int getRam()
	{
	return ram;
	}
	public void setMarca (String nova_marca)
	{
	marca = nova_marca;
	}
	public String getMarca()
	{
	return marca;
	}
	public void setModelo(float novo_modelo)
	{
	modelo = novo_modelo;
	}
	public float getModelo()
	{
	return modelo;
	}

}
