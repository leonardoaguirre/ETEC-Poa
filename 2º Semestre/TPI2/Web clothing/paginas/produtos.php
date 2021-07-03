 <link href="https://fonts.googleapis.com/css?family=Montserrat" rel="stylesheet">
 <meta charset="UTF-8">
 <style type="text/css">
.container{
	width:800px; margin:40px auto; 
	margin-left:100px;
	}
.galeria{
	padding:0;
	}
.galeria{
	overflow:hidden; margin-left:-40px;
	}
.texto{
	font-family: 'Montserrat', sans-serif;
	margin-left:150px;
}
.btn-green{
  background:green;
  color:#fff;
  box-shadow:0 5px 0 #006000;
  margin-left: 190px;
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
.image{
	margin-left:100px;
	weight:300px;
	width:250px;
}
</style>
<div class="container">
<ul class="galeria">
<?php
    @$conexao = mysql_connect ("localhost", "root", "") or die 
("Sem conexão com o servidor");
$select_db = mysql_select_db ("webclothing", $conexao) or die 
("Sem acesso ao DB, entre em contato com o Administrador");
      $sql = "SELECT * FROM produtos";
      $qr = mysql_query($sql) or die(mysql_error());
      while($ln = mysql_fetch_assoc($qr)){
         echo '<h2 class="texto" size="4">'.$ln['nome'].'</h2> <br />';
		 echo '<h4 class="texto">'.$ln['descricao'].'</h4> <br />';
         echo '<img class="image"src="imgProdutos/'.$ln['imagem'].'" /> <br />';
		 echo '<h4 class="texto">Pre&ccedil;o : R$ '.number_format($ln['preco'], 2, ',', '.').'</h4><br />';
         echo '<h2><a class="btn-green" href="carrinho.php?acao=add&id= '.$ln['id'].'"><img src="img/carrinho.png" alt="Carrinho" />Comprar</a></h2>';
         echo '<br /><hr />';
      } 
?>
</ul>
</div>
<?php
    //conexão com o banco de dados
  /*  @$conexao = mysql_connect ("localhost", "root", "") or die 
("Sem conexão com o servidor");
$select_db = mysql_select_db ("webclothing", $conexao) or die 
("Sem acesso ao DB, entre em contato com o Administrador");
 
    //verifica a página atual caso seja informada na URL, senão atribui como 1ª página
    $pagina = (isset($_GET['pagina']))? $_GET['pagina'] : 1;
 
    //seleciona todos os itens da tabela
    $cmd = ("select * from produtos");
    $produtos = mysql_query($cmd);
   
    //conta o total de itens
    $total = mysql_num_rows($produtos);
   
    //seta a quantidade de itens por página, neste caso, 50 itens
    $registros = 50;
   
    //calcula o número de páginas arredondando o resultado para cima
    $numPaginas = ceil($total/$registros);
   
    //variavel para calcular o início da visualização com base na página atual
    $inicio = ($registros*$pagina)-$registros;
 
    //seleciona os itens por página
    $cmd = ("select * from produtos limit $inicio,$registros");
    $produtos = mysql_query($cmd);
    $total = mysql_num_rows($produtos);
 
    //exibe os produtos selecionados
    while ($produto = mysql_fetch_array($produtos)) {
        echo $produto['id']." - ";
		echo $produto['imagem']."jpg'";
        echo $produto['nome']." - ";
        echo $produto['descricao']." - ";
        echo "R$ ".$produto['valor']."<br />";
    }
 
    //exibe a paginação
    for($i = 1; $i < $numPaginas + 1; $i++) {
        echo "<a href='produtos.php?pagina=$i'>".$i."</a> ";
    } */
?>