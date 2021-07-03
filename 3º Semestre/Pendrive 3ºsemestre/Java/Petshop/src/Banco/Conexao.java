package Banco;

import Negócios.Logica;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;


public class Conexao {
    public Connection conexao;
    public Conexao(){
        try{
            
            conexao = DriverManager.getConnection("jdbc:mysql://localhost/petshop","root","");
            
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
        String sql,sql2,sql3;
        try{
        conexao = DriverManager.getConnection("jdbc:mysql://localhost/petshop","root","");
        }catch(SQLException ex){
               Logger.getLogger(Conexao.class.getName()).log(Level.SEVERE, null , ex);
        }
        
        try{
        sql = "Insert into cliente(nome,telefone)values(?,?)";
                //PreparedStatement Faz com que o INSERT receba os parametros externos
                PreparedStatement st = conexao.prepareStatement(sql);
                //Insertamos os paametros em ordem dos (?) e usamos os get da classe
                st.setString(1, logi.getNomeCliente());
                st.setString(2, logi.getTelefoneCliente());
                
                 //Executamos o Statement
                
                sql2 = "Insert into animal(nome,especie)values(?,?)";
                PreparedStatement st2 = conexao.prepareStatement(sql2);
                
                st2.setString(1, logi.getNomePet());
                st2.setString(2, logi.getEspecie());
                
                
                sql3 = "Insert into servico(servico,tosa)values(?,?)";
                PreparedStatement st3 = conexao.prepareStatement(sql3);
                
                st3.setString(1, logi.getServico());
                st3.setString(2, logi.getTosa());
                
                st.execute();
                st2.execute();
                st3.execute();
                st.close(); //Fechamos a conexão
                
                JOptionPane.showMessageDialog(null, "Dados registrados com sucesso!!", "Insert sucedido!" , JOptionPane.INFORMATION_MESSAGE);
        }catch(Exception ex){
                JOptionPane.showMessageDialog(null, "Erro ao inserir os dados");
                System.out.print(ex);
                
    }
                
    }

        }
    