package banco;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import Negocio.Logica;


public class Conexao {
    public Connection conexao;
    public Conexao(){
        try{
            
            conexao = DriverManager.getConnection("jdbc:mysql://localhost/petshop2","root","");
            
        }catch(SQLException ex){
            Logger.getLogger(Conexao.class.getName()).log(Level.SEVERE, null , ex);
            
        }
            
        try{
            Class.forName("com.mysql.jdbc");
        }catch (ClassNotFoundException ex)
        {
            Logger.getLogger(Conexao.class.getName()).log(Level.SEVERE, null , ex);
        }
        
            System.out.println("Conectado");
    }

    public void Inserir (Logica logi) throws SQLException{
        String sql;
        try{
        conexao = DriverManager.getConnection("jdbc:mysql://localhost/petshop","root","");
        }catch(SQLException ex){
               Logger.getLogger(Conexao.class.getName()).log(Level.SEVERE, null , ex);
        }
        
        try{
        sql = "Insert into pet(nome,telefone,nomepet,especie,servic,toza)values(?,?,?,?,?,?)";
                //PreparedStatement Faz com que o INSERT receba os parametros externos
                PreparedStatement st = conexao.prepareStatement(sql);
                
                //Insertamos os paametros em ordem dos (?) e usamos os get da classe
                st.setString(1, logi.getNome());
                st.setString(2, logi.getTelefone());
                st.setString(3, logi.getNomepet());
                st.setString(4, logi.getEspecie());
                st.setString(5, logi.getServic());
                st.setString(6, logi.getToza());
                
                st.execute(); //Executamos o Statement
                
                st.close(); //Fechamos a conexão
                
                JOptionPane.showMessageDialog(null, "Dados registrados com sucesso!!", "Insert sucedido!" , JOptionPane.INFORMATION_MESSAGE);
        }catch(Exception ex){
                JOptionPane.showMessageDialog(null, "Erro ao inserir os dados");
                System.out.print(ex);
                
    }
                
    }
        
        
    }





