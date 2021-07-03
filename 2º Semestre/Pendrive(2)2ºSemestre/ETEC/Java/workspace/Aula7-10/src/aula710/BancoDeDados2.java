package aula710;


import java.sql.*;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class BancoDeDados2 extends JFrame implements ActionListener
{
	//Atributos privados para conexão
	private Connection con = null;
	private Statement stmt = null;
	private JPanel p1, p2, p3, p4, p5, p6;
	private JTextField txtnota1, txtnota2, txtnome, txtmedia;
	private JLabel lblnota1, lblnota2, lblnome, lblmedia, lblmensagem;
	private JButton btnsalvar, btnpesquisar, btncalcular, btnsair;
		
	
    public BancoDeDados2()
    {
		super("Manipulando Banco de Dados");
		this.getContentPane().setLayout(new GridLayout(6,2));
     	init(); 
    }
    

	public void init()
	{
		p1 = new JPanel(new FlowLayout());
		p2 = new JPanel(new FlowLayout());
		p3 = new JPanel(new FlowLayout());
		p4 = new JPanel(new FlowLayout());
		p5 = new JPanel(new FlowLayout());
		p6 = new JPanel(new FlowLayout());
		
		txtnome = new JTextField(15);
		txtnota1 = new JTextField(5);
		txtnota2 = new JTextField(5);
		txtmedia = new JTextField(5);
		txtmedia.setEnabled(false);
		
		lblnome = new JLabel("Nome:");
		lblnota1 = new JLabel("Nota 1:");
		lblnota2 = new JLabel("Nota 2:");
		lblmedia = new JLabel("Média:");
		lblmensagem = new JLabel("");
		lblmensagem.setForeground(Color.RED);
		
		btnsalvar = new JButton("Salvar");
		btnpesquisar = new JButton("Pesquisar");
		btncalcular = new JButton("Calcular");
		btnsair = new JButton("Sair");
		
		btnsalvar.addActionListener(this);
		btnpesquisar.addActionListener(this);
		btncalcular.addActionListener(this);
		btnsair.addActionListener(this);
		
		p1.add(lblnome);
		p1.add(txtnome);
		
		p2.add(lblnota1);
		p2.add(txtnota1);
		
		p3.add(lblnota2);
		p3.add(txtnota2);
		
		p4.add(lblmedia);
		p4.add(txtmedia);
		
		p5.add(lblmensagem);
		
		p6.add(btnpesquisar);
		p6.add(btnsalvar);
		p6.add(btncalcular);
		p6.add(btnsair);
		
		this.getContentPane().add(p1);
		this.getContentPane().add(p2);
		this.getContentPane().add(p3);
		this.getContentPane().add(p4);
		this.getContentPane().add(p5);
		this.getContentPane().add(p6);
		
		setSize(500,300);
		setVisible(true);	
		
		conecta();	
	}

	public void actionPerformed(ActionEvent e) {
		
		if (e.getSource()==btnsalvar) {
			gravaDados();
		}

		if (e.getSource()==btnpesquisar) {
			consultaNome();
		}

		if (e.getSource()==btncalcular) {
			calculaMedia();
		}

		if (e.getSource()==btnsair) {
			System.exit(0);
		}

	}
    
    //Construtor que recebe o nome do banco em localhost
    public void conecta()
    {
	     try
	     {
            //Banco de Dados
		    String serverName = "localhost:3309";
		    String mydatabase = "dbalunos";

            //Login e senha do banco
      		String username = "root";
	    	String password = "1234";

		    // Carregando o JDBC Driver
		    String driverName = "com.mysql.jdbc.Driver"; // MySQL MM JDBC driver
		    Class.forName(driverName);

		    // Criando a conexão com o Banco de Dados
		    String url = "jdbc:mysql://" + serverName + "/" + mydatabase; // a JDBC url
		    con = DriverManager.getConnection(url, username, password);
		    stmt = con.createStatement();
	     }
	     catch (ClassNotFoundException e)
	     {
		    //Driver não encontrado
		    System.out.println("Driver não encontrado!");
         }
	     catch (SQLException e)
	     {
		    //Não está conseguindo se conectar ao banco
		    System.out.println("Erro ao conectar o Banco de Dados: " + e.toString());
	     }
     }
     
     public void consultaNome()
     {
     	ResultSet rs;
     	String sql;
     	String nome, nota1, nota2;
     	
     	//Captura o nome para a pesquisa
     	nome = txtnome.getText();

     	try
     	{
     		//Monta comando sql para pesquisar registro
     		sql = "SELECT * FROM tbdados WHERE nome='" + nome + "'";
	        
	        //Faz a pesquisa e devolve o resultado para um resultset
	        rs = stmt.executeQuery(sql);
	        
	        //Se tiver algum valor no resultset, mostrar na tela
	        if(rs.next())
	        {
				//Captura os valores das tabelas e joga nas variáveis
				nota1 = rs.getString("nota1");
				nota2 = rs.getString("nota2");
				
	        	//Joga os valores capturados nos campos da tela
	        	txtnota1.setText(nota1);
	        	txtnota2.setText(nota2);
	        	
				//Exibe mensagem
				lblmensagem.setText("Registro encontrado...");
	        		
	        }
	        else
	        {
	        	//Exibe mensagem
				lblmensagem.setText("Registro não encontrado...");

	        	//Limpa campos de notas
	        	txtnota1.setText("");
	        	txtnota2.setText("");
	        }
     	}
     	catch(SQLException e)
     	{
     		System.out.println("Erro ao executar o comando SQL:" + e.toString());
     	}
     	
     }
     
     public void gravaDados()
     {
     	String sql;
     	String nome, nota1, nota2;
     	
     	//Captura os dados digitados
     	nome = txtnome.getText();
     	nota1 = txtnota1.getText();
     	nota2 = txtnota2.getText();
     	
     	try
     	{
     		//Cria comando SQl para inserir na tabela
     		sql = "INSERT INTO tbdados(nome, nota1, nota2) VALUES ('";
     		sql += nome + "'," + nota1 + "," + nota2 + ")";
	        
	        //Executa o comando sql
	        stmt.executeUpdate(sql);
	        
	        //Exibe mensagem
	        lblmensagem.setText("Dados inseridos com sucesso!");

     	}
     	catch(SQLException e)
     	{
     		System.out.println("Erro ao executar o comando SQL:" + e.toString());
     	}
     	
     }

     public void calculaMedia()
     {
     	float nota1, nota2, media;
     	
     	//Captura os dados
     	nota1 = Float.parseFloat( txtnota1.getText() );
     	nota2 = Float.parseFloat( txtnota2.getText() );
     	
     	//Calcula a média e exibe na tela
     	media = (nota1 + nota2) / 2;
     	txtmedia.setText(media + "");
     	
     	if(media<3)
     		lblmensagem.setText("Reprovado");
     	else if(media>=6)
     		lblmensagem.setText("Aprovado");
     	else
     		lblmensagem.setText("Exame");

     }

     public static void main(String args[])
     {
     	BancoDeDados2 bd = new BancoDeDados2();

     }
     
     

}