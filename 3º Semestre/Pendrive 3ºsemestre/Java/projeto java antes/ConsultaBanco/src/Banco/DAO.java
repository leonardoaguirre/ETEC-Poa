package Banco;

import Negócios.Logica;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;


public class DAO {
    public void pesquisar (Logica logi) throws SQLException{
     
    Connection 
        con = DriverManager.getConnection("jdbc:mysql://localhost/aula05-05","root","");
    String sql = "SELECT * FROM amigos WHERE ID = ?";
    PreparedStatement stmt = con.prepareStatement (sql);
    stmt.setInt (1, logi.getID());
    ResultSet rs = stmt.executeQuery();
    while (rs.next()){
        logi.setID(rs.getInt(1));
        logi.setNOME(rs.getString(2));
        
        System.out.println (rs.getInt("ID") + ",");
        System.out.println (rs.getString("NOME") + ",");
    }
    }
    public ArrayList BuscarDados (String strSQL) throws SQLException
    {
        ArrayList<Logica> valores = new ArrayList<Logica>();
        Connection con = DriverManager.getConnection ("jdbc:mysql://localhost/aula05-05","root","");
        String sql = "SELECT * FROM amigos";
        PreparedStatement stmt = con.prepareStatement(sql);
        ResultSet rs = stmt.executeQuery();
         while (rs.next())
             
         {
             Logica logi = new Logica();
             logi.setID(rs.getInt(1));
             logi.setNOME(rs.getString(2).trim());
             valores.add(logi);
        }
    
           return valores;
    }
}
