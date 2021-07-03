 <link href="https://fonts.googleapis.com/css?family=Montserrat" rel="stylesheet">
 <meta charset="UTF-8">
 <meta http-equiv="Content-type" content="text/html; charset=utf-8" />
 <style type="text/css">
 @charset "utf-8";
.container{
	width:800px; margin:40px auto; 
	margin-left:100px;
	display: block;
	padding: 10px;
	}
.galeria{
	padding:0;
	}
.galeria{
	overflow:hidden; margin-left:-40px;
	}
.texto{
	font-family: 'Montserrat', sans-serif;
	margin-left:0px;
}
.btn-green{
  background:green;
  color:#fff;
  box-shadow:0 5px 0 #006000;
  margin-left: 00px;
  margin-top:20px;
}
.btn-green:hover{
  background:#006000;
  box-shadow:0 5px 0 #003f00;
}
.btn-green:active{
  position:relative;
  top:5px;
  box-shadow:none;
}
.img{
	margin-left:50px;
	weight:300px;
	width:300px;
}
table {
  border: 1px solid #ccc;
  width: 95%;
  margin: 4;
  padding: 4;
  border-collapse: collapse;
  border-spacing: 0;
  margin-left:25%;
}
table tr {
  border: 4px solid #ddd;
  padding: 10px;
}
table th,
table td {
  padding: 15px;
  text-align: center;
}
table th {
  text-transform: uppercase;
  font-size: 14px;

  letter-spacing: 1px;
}

</style>

<?php
    @$conexao = mysql_connect ("localhost", "root", "") or die 
("Sem conexão com o servidor");
$select_db = mysql_select_db ("webclothing", $conexao) or die 
("Sem acesso ao DB, entre em contato com o Administrador");
      $sql = "SELECT * FROM produtos";
      $qr = mysql_query($sql) or die(mysql_error());
      while($ln = mysql_fetch_assoc($qr)){
		 	echo'<table width="80%"  border="1" align="center" cellpadding="0" cellspacing="0">';
         echo '<tr>';
		 echo '<td><h2 class="texto" size="4">'.$ln['nome'].'</td></h2>';
		 echo '</tr>';
		   echo '<tr>';
		 echo '<td><h4 class="texto">'.$ln['descricao'].'</td></h4>';
		   echo '</tr>';
		   echo '<tr>';
         echo '<td><img src="imgProdutos/'.$ln['imagem'].'.jpg"/></td>';
		 echo '</tr>';
		   echo '<tr>';
		 echo '<td><h4 class="texto">Pre&ccedil;o : R$ '.number_format($ln['preco'], 2, ',', '.').'</td></h4>';
		 echo '</tr>';
		   echo '<tr>';
         echo '<td><h2><a class="btn-green" href="?pagina=carrinho&acao=add&id='.$ln['id'].'"><img src="img/carrinho.png" alt="Carrinho" />Comprar</a></h2></td>';
		 echo '</tr>';
         echo '</table>';
      } 

?>

<?php
 
?>