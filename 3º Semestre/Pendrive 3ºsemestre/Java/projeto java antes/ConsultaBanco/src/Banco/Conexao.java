package Banco;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;


public class Conexao {
    Connection con;
    Conexao(){
}
    public Conexao(Connection con){
         this.con = con;
    }
    public static void conectar () throws SQLException{
        try{
            Class.forName("com.mysql.jdbc.Driver");
        Connection con = DriverManager.getConnection ("jdbc:mysql://localhost/aula05-05","root","");
        System.out.println("Conectado");
        }
        catch (ClassNotFoundException ex){
            System.out.println("Classe não encontrada, adicione o driver nas bibliotecas." + ex);
        }
        catch (SQLException e){
            System.out.println(e);
            throw new RuntimeException(e);
        }    
        }
        }
    