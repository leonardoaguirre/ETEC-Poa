package exercicios;

import javax.swing.JOptionPane;
public class Ponto2D {
	   private int numerador;
	   private int denominador;
	   
	   public void setnumerador(int n_x)
	   {
		    numerador = n_x;
	   }
	   public int getX()
	   {
		   		return numerador;
	   }
	   public void setY(int n_y)
	   {
		    denominador = n_y;
	   }
	   public int getY()
	   
	   {
		   return denominador;
	   }
	   
	
	   
	   public void print()
	   {
		   			JOptionPane.showMessageDialog(null, "Fração("+numerador+" / "+denominador+")");
	   }
       
       public static void main(String args[]){
        Ponto2D A = new Ponto2D();
        Ponto2D B = new Ponto2D();
        
        A.setnumerador(2);
        A.setdenominador(3);
      
        
        
        
       			
       }

   		

            public Ponto2D somaCom(int num)
            {
                Ponto2D resp = new Ponto2D();
                resp.setX(this.getX() + num);
                resp.setY(this.getY() + num);
                return resp;
            
            }
                  
