package prova2511;

import java.util.Scanner;

public class Poupanca extends Conta implements Rendimento{
private int aniversario;
private int indiceCorrecao;

public void setAniversario(int aniversario1)
{
	aniversario=aniversario1;
}
public int getAniversario()
{
	return aniversario;
}
public void setIndiceCorrecao(int indiceCorrecao1)
{
	indiceCorrecao=indiceCorrecao1;
}
public int getIndiceCorrecao()
{
	return indiceCorrecao;
}
public void main(String args[]){
	Poupanca A = new Poupanca();
	A.setNome("vitor");
	A.setNumero(25);
	A.setSaldo(0);
	A.setIndiceCorrecao(1);
	A.setAniversario(4);
	
}


@Override
public void sacar(float sa1) {
	Poupanca s =new Poupanca();
	Scanner in = new Scanner(System.in);
	System.out.println("Digite o valor do saque da poupan?a: ");
    s.setSaldo(in.nextInt());
    this.saldo +=sa1; 
}
@Override
public void depositar(float sa1) {
	
	Poupanca conta =new Poupanca();
	Scanner in = new Scanner(System.in);
	System.out.println("Digite o valor do seu saldo da poupan?a: ");
    conta.setSaldo(in.nextInt());
    this.saldo +=sa1; 
}
@Override
public void atualizaMes(int mes) {
	Poupanca conta = new Poupanca();
	Scanner in = new Scanner(System.in);
	System.out.println("Digite o valor de meses: ");
    conta.setSaldo(in.nextInt());
    conta.AtualizaMes(mes);
	
}
@Override
public void getSaldo() {
	// TODO Auto-generated method stub
	
}
@Override
public void sacar() {
	// TODO Auto-generated method stub
	
}
@Override
public void depositar() {
	// TODO Auto-generated method stub
	
}
@Override
public void atualizaMes() {
	// TODO Auto-generated method stub
	
}
}
