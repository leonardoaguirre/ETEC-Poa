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
     
    Connection con = DriverManager.getConnection("jdbc:mysql://localhost/petshop","root","");
    String sql = "SELECT * FROM cliente WHERE IdCliente = ?";
    PreparedStatement stmt = con.prepareStatement (sql);
    stmt.setInt (1, logi.getIdCliente());
    ResultSet rs = stmt.executeQuery();
    while (rs.next()){
        logi.setIdCliente(rs.getInt(1));
        logi.setNomeCliente(rs.getString(2));
        
        System.out.println (rs.getInt("Id") + ",");
        System.out.println (rs.getString("Nome") + ",");
    }
    }
    public ArrayList BuscarDados (String strSQL) throws SQLException
    {
        ArrayList<Logica> valoresCliente = new ArrayList<Logica>();
        Connection con = DriverManager.getConnection ("jdbc:mysql://localhost/petshop","root","");
        String sql = "SELECT * FROM cliente";
        PreparedStatement stmt = con.prepareStatement(sql);
        ResultSet rs = stmt.executeQuery();
         while (rs.next())
             
         {
             Logica logi = new Logica();
             logi.setIdCliente(rs.getInt(1));
             logi.setNomeCliente(rs.getString(2).trim());
             logi.setTelefoneCliente(rs.getString(3).trim());
             valoresCliente.add(logi);
        }
    
           return valoresCliente;
    }
     public ArrayList BuscarDados2 (String strSQL) throws SQLException
    {
           ArrayList<Logica> valoresAnimal = new ArrayList<Logica>();
           Connection con = DriverManager.getConnection ("jdbc:mysql://localhost/petshop","root","");
        String sql2 = "SELECT * FROM animal";
        PreparedStatement stmt2 = con.prepareStatement(sql2);
        ResultSet rs2 = stmt2.executeQuery();
         while (rs2.next())
             
         {
             Logica logi = new Logica();
             logi.setIdPet(rs2.getInt(1));
             logi.setNomePet(rs2.getString(2).trim());
             logi.setEspecie(rs2.getString(3).trim());
             valoresAnimal.add(logi);
        }
    
           return valoresAnimal;
           
    }
     public ArrayList BuscarDados3 (String strSQL) throws SQLException
    {
           ArrayList<Logica> valoresServico = new ArrayList<Logica>();
           Connection con = DriverManager.getConnection ("jdbc:mysql://localhost/petshop","root","");
        String sql3 = "SELECT * FROM servico";
        PreparedStatement stmt3 = con.prepareStatement(sql3);
        ResultSet rs3 = stmt3.executeQuery();
         while (rs3.next())
             
         {
             Logica logi = new Logica();
             logi.setIdServico(rs3.getInt(1));
             logi.setServico(rs3.getString(2).trim());
             logi.setTosa(rs3.getString(3).trim());
             valoresServico.add(logi);
        }
    
           return valoresServico;
}
}
