package listao_pc1;

import javax.swing.*;

public class Exercicio3 {

	public static void main(String[] args) {
		String m[][] = new String[4][4];
		int i, j;
		
		
		 String saidaMatriz="";
	       
	        for(i=0; i<4;i++){
	            saidaMatriz+=" ";
	            
	            for(j=0;j<4;j++){
	                m[i][j] = "X";
	                m[0][0] = " ";
		    		m[1][0] = "1";
		    		m[2][0] = "2";
		    		m[3][0] = "3";
		    		m[0][1] = "A";
		    		m[0][2] = "B";
		    		m[0][3] = "C";
	                saidaMatriz += m[i][j]+" ";
	            } 
	           
	            saidaMatriz += "\n";
	        	
	        } 
	        
	        JOptionPane.showMessageDialog(null,saidaMatriz);
	   
	    }
		
		        
		       
		
	}

