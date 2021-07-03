package Banco;

import Negócios.Logica;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;


public class DAO {
    public void pesquisar (Logica logi) throws SQLException{
     
    Connection 
        con = DriverManager.getConnection("jdbc:mysql://localhost/colegas","root","");
    String sql = "SELECT * FROM amigos WHERE Id = ?";
    PreparedStatement stmt = con.prepareStatement (sql);
    stmt.setInt (1, logi.getId());
    ResultSet rs = stmt.executeQuery();
    while (rs.next()){
        logi.setId(rs.getInt(1));
        logi.setNome(rs.getString(2));
        
        System.out.println (rs.getInt("Id") + ",");
        System.out.println (rs.getString("Nome") + ",");
    }
    }
    public ArrayList BuscarDados (String strSQL) throws SQLException
    {
        ArrayList<Logica> valores = new ArrayList<Logica>();
        Connection con = DriverManager.getConnection ("jdbc:mysql://localhost/colegas","root","");
        String sql = "SELECT * FROM amigos";
        PreparedStatement stmt = con.prepareStatement(sql);
        ResultSet rs = stmt.executeQuery();
         while (rs.next())
             
         {
             Logica logi = new Logica();
             logi.setId(rs.getInt(1));
             logi.setNome(rs.getString(2).trim());
             valores.add(logi);
        }
    
           return valores;
    }
    
    public void Excluir (int idAtual){
        
            try {
               Connection con = DriverManager.getConnection("jdbc:mysql://localhost/colegas","root","");
            
                    String comandoSql = "DELETE FROM amigos WHERE Id = ?";
                    
                    PreparedStatement st = con.prepareStatement(comandoSql);
                    st.setInt(1,idAtual);
                    st.execute();
                    st.close();
                    
                    JOptionPane.showMessageDialog(null, "Pessoa excluída com sucesso de sua agenda!", "Delete sucedido!", JOptionPane.INFORMATION_MESSAGE);
                    } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, "Erro ao deletar estes dados"+ex);
        } 
    }
  
    public void atualizar (Logica logi) throws SQLException  {
try{
    Connection con;
    con = DriverManager.getConnection("jdbc:mysql://localhost/colegas","root","");
        
    String sql = "Update amigos set Nome=? where Id=?";
    PreparedStatement st = con.prepareStatement(sql);
    st.setInt(1,logi.getId());
    st.setString(2,logi.getNome());
    st.execute();
    st.close();
    JOptionPane.showMessageDialog(null,"Atualizado com sucesso no sistema","Insert sucedido!",JOptionPane.INFORMATION_MESSAGE);
}
catch (Exception ex){
  
          JOptionPane.showMessageDialog(null,"Erro ao atualizar dados");

    }}}
 
