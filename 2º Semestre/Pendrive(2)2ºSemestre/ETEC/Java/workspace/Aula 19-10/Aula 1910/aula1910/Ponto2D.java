package aula1910;
import javax.swing.JOptionPane;
public class Ponto2D {
	   private int x;
	   private int y;
	   
	   public void setX(int n_x)
	   {
		    x = n_x;
	   }
	   public int getX()
	   {
		   		return x;
	   }
	   public void setY(int n_y)
	   {
		    y = n_y;
	   }
	   public int getY()
	   
	   {
		   return y;
	   }
	   
	
	   
	   public void print()
	   {
		   			JOptionPane.showMessageDialog(null, "Ponto("+ x +","+ y +")");
	   }
       public float distanciaOrigem(){
      float d;
      d= (float)Math.sqrt(x*x + y*y);
      return d;
       }
       public static void main(String args[]){
        Ponto2D A = new Ponto2D();
        Ponto2D B = new Ponto2D();
        
        A.setX(2);
        A.setY(3);
        
        B.setX(4);
        B.setY(5);
        
        A.print();
        B.print();
        
        System.out.println("Distancia de A:" + A.distanciaOrigem());
        System.out.println("Distancia de B:" + B.distanciaOrigem());
        
        
       			
}
       public void maisDistante(Ponto2D P2){
    	   if (this.distanciaOrigem() > P2.distanciaOrigem())
    		   this.print();
    	   else 
    		   P2.print();
       }
       
    public Ponto2D achaMaior (Ponto2D P2){
       
    float d1 = this.distanciaOrigem();
   	float d2 = P2.distanciaOrigem();
   	
   	if(d1>d2){
   		return this;
   	}
   	else{
   		return P2;
       
   	}  
    }   
   		
   		
   	   public Ponto2D dobroPonto(){
   		
   	   Ponto2D novo = new Ponto2D();
       novo.setX(this.getX()*2);
       novo.setY(this.getY()*2);
       
       return novo;
   		}
       
       
       public boolean ComparaCom(Ponto2D P2)
       {
       
       if(this.getX()==P2.getX()&&this.getY()==P2.getY())
    	   return true;
       else
    	   return false;
       
       
      
        }
            public Ponto2D somaCom(int num)
            {
                Ponto2D resp = new Ponto2D();
                resp.setX(this.getX() + num);
                resp.setY(this.getY() + num);
                return resp;
            
            }
                   public Ponto2D somaCom(Ponto2D P2)
            {
                Ponto2D resp = new Ponto2D();
                resp.setX(this.getX() + P2.getX());
                resp.setY(this.getY() + P2.getY());
                return resp;
            
            }
                   public Ponto2D somaCom(int valorx,int valory)
            {
                Ponto2D resp = new Ponto2D();
                resp.setX(this.getX() + valorx);
                resp.setY(this.getY() + valory);
                return resp;
            
            }
       
            
}

