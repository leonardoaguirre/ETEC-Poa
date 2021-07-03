<html>
<meta charset="UTF-8">
<meta http-equiv="Content-type" content="text/html; charset=utf-8" />
<head>
<?php
		session_start();
		?>
<style type="text/css">
 @charset "utf-8";
#divCenter form {
  background: white;
  width: 90%;
  box-shadow: 0px 0px 20px rgba(0, 0, 0, 0.7);
  font-family: lato;
  position: relative;
  color: #333;
  border-radius: 50px;
  margin-left: 180px;
  margin-top: 30px;
  margin-bottom:30px;
}
#divCenter form header {
  background: #FF3838;
  padding: 10px 10px;
  color: white;
  font-size: 2.2em;
  font-weight: 0px;
  border-radius: 20px 20px 0 0;
}
#divCenter form label {
  margin-left: 20px;
  margin-top: 0px;
  margin-bottom: 5px;
  position: relative;
}
#divCenter form label span {
  color: #FF3838;
  font-size: 1.2em;
  position: absolute;
  left: 2.3em;
  top: -10px;
}
#divCenter form input {
  display: block;
  width: 80%;
  margin-left: 20px;
  padding: 5px 20px;
  font-size: 1em;
  border-radius: 3px;
  outline: none;
  border: 1px solid #ccc;
}
#divCenter form .help {
  margin-left: 20px;
  font-size: 0.8em;
  color: #777;
}
#divCenter form button {
  position: relative;
  margin-top: 10px;
  margin-bottom: 10px;
  left: 45%;
  transform: translate(-50%, 0);
  font-family: inherit;
  color: white;
  background: #FF3838;
  outline: none;
  border: none;
  padding: 5px 10px;
  font-size: 1.3em;
  font-weight: 400;
  border-radius: 0px;
  box-shadow: 0px 0px 10px rgba(51, 51, 51, 0.4);
  cursor: pointer;
  transition: all 0.15s ease-in-out;
}
#divCenter form button:hover {
  background: #ff5252;
}
.btn{
  font-family: arial;
  font-size:30px;
  text-transform: uppercase;
  font-weight:70;
  border:none;
  padding:20px;
  cursor: pointer;
  display:inline-block;
  text-decoration: none;
  outline:none;
  border:none;
  margin-top:20px;
  margin-bottom: 200px;
  margin-left: 80px;
}
.btn-green{
  background:green;
  color:#fff;
  box-shadow:0 5px 0 #006000;
}
.btn-green:hover{
  background:#006000;
  box-shadow:0 5px 0 #003f00;
}
.btn-green:active{
  position:relative;
  top:50px;
  box-shadow:none;
}
h2{
margin-left: 23%;	
font-size: 30px;
margin-top:10px;
}

    </style>
	</head>
	<body>
<div id ="divCenter">
    <form method="post" name="frmEntrega" enctype="multipart/form-data">
	<header>&raquo;Endere&ccedil;o de entrega e Dados do cart&atilde;o</header>
        <table>
		<?php
           echo "<font face='Arial' size='5'>Ol&aacute;&nbsp;". $_SESSION['us_email']."&nbsp&nbsp";
	       echo "</br><font face='Arial' size='2'>Coloque abaixo os seus dados para efetuar o pagamento: </font>" ;		
		   
		   
		?>
		<h2>Endere&ccedil;o de entrega:</h2></br>
		 <tr>
                <td class="textoComum">Nome do receptor:</td>
                <td><input type="text" name="txtDestinatario" placeholder="Ex: Maria Aparecida" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">Estado:</td>
                <td><input type="text" name="txtEstado" placeholder="Ex: S&atilde;o Paulo" required class="inputFormulario" /></td>
           
            <tr>
                <td class="textoComum">Cidade:</td>
                <td><input type="text" name="txtCidade" placeholder="Ex: S&atilde;o Paulo" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">Rua:</td>
                <td><input type="text" name="txtRua" placeholder="Ex: rua 10" required class="inputFormulario" /></td>
            </tr>        <tr>
                <td class="textoComum">Numero:</td>
                <td><input type="text" name="txtNumero" placeholder="Ex: nº106" required class="inputFormulario" /></td>
            </tr>       
           
            <tr>
                <td class="textoComum">Complemento</td>
                <td><input type="text" name="txtComplemento" placeholder="Ex: ao lado da pra&ccedil;a" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">Cep: </td>
                <td><input type="number" name="txtCep" placeholder="Ex: 08557000" required class="inputFormulario" maxlength="8" /></td>
            </tr>
			</table></br>
			<table>
			<h2>Dados do cart&atilde;o:</h2></br>
            <tr>
                <td class="textoComum">Numero do cart&atilde;o:</td>
                <td><input type="number" name="txtNumeroCartao" placeholder="1234 5678 9102 3456" required class="inputFormulario" maxlength="16" /></td>
            </tr>
            <tr>
                <td class="textoComum">Nome do titular do cart&atilde;o:</td>
                <td><input type="text" name="txtNomeTitular" placeholder="Maria Aparecida" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">Vencimento</td>
                <td><input type="date" name="txtVencimento" placeholder="00/00" required class="inputFormulario"/></td>
            </tr>        
			<tr>
                <td class="textoComum">Numero de seguran&ccedil;a:</td>
                <td><input type="number" name="txtNumeroSeguranca" placeholder="000" required class="inputFormulario" maxlength="3"/></td>
            </tr>       
			<td colspan="5"><a href="?pagina=finalizar" class="btn btn-green" name="btnFinal"><img src="img/carrinho.png" alt="Carrinho" />Finalizar Pedido</a></td>
			</form>
			</table>
			<?php
			if (isset($_POST['btnFinal'])) {


//CONEXÂO COM O BANCO DE DADOS
@$conexao = mysql_connect ("localhost", "root", "") or die 
("Sem conexão com o servidor");
$select_db = mysql_select_db ("webclothing", @$conexao) or die 
("Sem acesso ao DB, entre em contato com o Administrador");


 
// RECEBENDO OS DADOS PREENCHIDOS DO FORMULÁRIO !
$cliente = $_SESSION['us_email'];
$endereco	= $_POST ["txtRua"]+" , "+$_POST ["txtNumero"]+" , "+$_POST ["txtCidade"]+" , "+$_POST ["txtEstado"]+" , "+$_POST ["txtComplemento"]+" , "+$_POST ["txtCep"];	//atribuição do campo 
$nome	= $_POST ["txtDestinatario"];
$numero_cartao	= $_POST ["txtNumeroCartao"];	
$nome_cartao	= $_POST ["txtNomeTitular"];	
$vencimento_cartao	= $_POST ["txtVencimento"];	
$numero_seguranca_cartao	= $_POST ["txtNumeroSeguranca"];	

 
//conectando com o localhost - mysql
 
 

$result=mysql_query("INSERT INTO `entrega` ( `cliente` , `endereco` , `nome_destinatario` , `numero_cartao` , `nome_cartao` , `vencimento_cartao` , `numero_seguranca_cartao`)VALUES('$cliente', '$endereco', '$nome', '$numero_cartao', '$nome_cartao', '$vencimento_cartao', '$numero_seguranca_cartao')")or die(mysql_error());; //Realiza a consulta
 $result2 = mysql_query ("SELECT * FROM entrega WHERE nome_destinatario ='$nome' AND nome_cartao ='$nome_cartao'")or die(mysql_error());
 
     if (mysql_num_rows ($result2) != 0 )
{ 

	?>
	<a href='?pagina=inicio'>
                    <script type="text/javascript">
                        alert("Compra efetuada com sucesso, em breve voltaremos com mais informções em seu e-mail, por favor aguarde, Obrigado a Web Clothing agradece a sua compra! ");
                    </script>
                    <?php

}
     else 
{
	?>
                    <a href='?pagina=finalizar'>
					<script type="text/javascript">
                        alert("Erro ao cadatrar informações, por favor tente novamente!");
                    </script>
                    <?php

	 
}
}

     
?>
			</div>
			</body>
			</html>
            