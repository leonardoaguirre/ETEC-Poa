package exercicio4;



public class Complexo {
private int A=0, B=0;
private String I ="i";
public void setA(int a) {
	A = a;
}

public int getA() {
	return A;
}
public void setB(int b) {
	B = b;
}

public int getB() {
	return B;
}
public void main(String args[]){
	Complexo a = new Complexo();
	a.setA(0);
	a.setB(0);
	
	a.print();
}
public void print(){
	System.out.println(A+"+"+B+I);
}
public void somaCom(int num){
	
        Complexo a = new Complexo();
       a.setA(this.getA() + num);
        a.setB(this.getB() + num);
       /* return a;*/
    
    
}
public void quadrado(){
	
}
// n?o consegui realizar as opera??es
}
