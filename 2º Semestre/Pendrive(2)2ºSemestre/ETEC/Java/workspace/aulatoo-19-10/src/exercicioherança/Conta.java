package exercicioherança;

import java.util.Scanner;
class Conta{
    protected int saldo;
     public void setSaldo(int saldo) {
        this.saldo = saldo;
    }
    public int getSaldo() {
        return saldo;
    }
    public abstract boolean saca(int saldo);
    public void deposita(int saldo){this.saldo = saldo;}
}
    class ContaPoupanca extends Conta{
    }
public class ProgramaBanco {
    public static void main(String[] args){
        int saldo;
        Scanner in = new Scanner(System.in);
        Conta s = new Conta();
        System.out.println("Digite o valor do seu saldo: ");
        s.setSaldo(in.nextInt());
    }
}