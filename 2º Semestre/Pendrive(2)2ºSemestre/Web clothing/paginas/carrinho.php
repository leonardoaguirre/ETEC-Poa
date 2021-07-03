<?php
session_start();
?>
<style type="text/css">
.btn:focus, .btn::-moz-focus-inner{
  outline:none;
  border:none;
}
.btn{
  font-family: arial;
  font-size:14px;
  text-transform: uppercase;
  font-weight:700;
  border:none;
  padding:10px;
  cursor: pointer;
  display:inline-block;
  text-decoration: none;
}
.btn-red{
  background:red;
  color:#fff;
  box-shadow:0 5px 0 #d20000;
}
.btn-red:hover{
  background:#d20000;
  box-shadow:0 5px 0 #b00000;
}
.btn-blue{
  background:blue;
  color:#fff;
  box-shadow:0 5px 0 #180094;
}
.btn-blue:hover{
  background:#012880;
  box-shadow:0 5px 0 #001c5c;
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
.btn-green:active, .btn-red:active{
  position:relative;
  top:5px;
  box-shadow:none;
}
.img{
	weight:400px;
	width:400px;
	align:center;
	margin-left:250px;
	margin-top:20px;
}
.tabela{
	margin-left:60px;
	margin-top:20px;
}
.text{
	margin-left:200px;
	margin-top:300px;
}
table {
  border: 1px solid #ccc;
  width: 100%;
  margin: 4;
  padding: 4;
  border-collapse: collapse;
  border-spacing: 0;
  margin-left:150px;
  margin-bottom:30px;
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

	  <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>Carrinho de Compras</title>
</head>
 
<body>
<?php 


@$conexao = mysql_connect ("localhost", "root", "") or die 
("Sem conexão com o servidor");
$select_db = mysql_select_db ("webclothing", @$conexao) or die 
("Sem acesso ao DB, entre em contato com o Administrador");


	  if($_SESSION['us_senha'] == false) {
		  

      echo "<font face='Arial' size='6'>Você precisa estar conectado para ver esta área<br>Faça seu</font> <td colspan='5'><button name='btnSair' type='submit'><a href=\"?pagina=login\" class='btn btn-blue'>Login</a></button></td>";
      }
      else {
echo "<font face='Arial' size='5'>Ol&aacute;&nbsp". $_SESSION['us_email']."&nbsp&nbsp";
	  echo "</br><font face='Arial' size='2'>Confira abaixo,os produtos do seu carrinho:</font> </br><td colspan='5'><button name='btnSair' type='submit'><a href='?pagina=logout' class='btn btn-red'>Sair</a></button></td>";
	  ?>
<table class="tabela">

    <img src="img/carrinho-logo.png" alt="Carrinho-logo" class="img" />

    <thead>
          <tr>
		  <th width="200">Imagem</th>
            <th width="200">Produto</th>
            <th width="80">Quantidade</th>
            <th width="100">Pre&ccedil;o</th>
            <th width="100">SubTotal</th>
            <th width="100">Remover</th>
          </tr>
    </thead>
            
    <tfoot>
           <tr>
            <td colspan="1"><a href="?acao=up&pagina=carrinho" class="btn btn-blue">Atualizar Carrinho</a></td>
			
            <td colspan="2"><a href="?pagina=produtos&form=ja" class="btn btn-red">Continuar Comprando</a></td>
			 <form method="post" name="frmFinalizar" enctype="multipart/form-data" action="?pagina=finalizar">
		
			<td colspan="3"><button input style=" margin:15px;" type="submit" name="btnFinalizar" class="btn btn-green"><img src="img/carrinho.png" />Finalizar Compra</button></td>

			</form>
    </tfoot>
       
    <tbody>
	  <?php
	 
		  
		  
	  
	  
       
      if(!isset($_SESSION['carrinho'])){
         $_SESSION['carrinho'] = array();
      }
       
      //adiciona produto
       
      if(isset($_GET['acao'])){
          
         //ADICIONAR CARRINHO
         if($_GET['acao'] == 'add'){
            $id = intval($_GET['id']);
            if(!isset($_SESSION['carrinho'][$id])){
               $_SESSION['carrinho'][$id] = 1;
            }else{
               $_SESSION['carrinho'][$id] += 1;
            }
         }
          
         //REMOVER CARRINHO
         if($_GET['acao'] == 'del'){
            $id = intval($_GET['id']);
            if(isset($_SESSION['carrinho'][$id])){
               unset($_SESSION['carrinho'][$id]);
            }
         }
          
         //ALTERAR QUANTIDADE
         if($_GET['acao'] == 'up'){
            if(is_array($_POST['produto'])){
               foreach($_POST['produto'] as $id => $qtd){
                  $id  = intval($id);
                  $qtd = intval($qtd);
                  if(!empty($qtd) || $qtd <> 0){
                     $_SESSION['carrinho'][$id] = $qtd;
                  }else{
                     unset($_SESSION['carrinho'][$id]);
                  }
               }
            }
         }
       
      }
	  }
       
?>

               <?php
			   
                     if(count($_SESSION['carrinho']) == 0){
                        echo '<tr><td colspan="5">N&atilde;o h&aacute; nenhum produto no carrinho</td></tr>';
                     }else{
                           $total = 0;
						   $produtos ="";
			   $ids = "";
                        foreach($_SESSION['carrinho'] as $id => $qtd){
                              $sql   = "SELECT *  FROM produtos WHERE id= '$id'";
                              $qr    = mysql_query($sql) or die(mysql_error());
                              $ln    = mysql_fetch_assoc($qr);
                               
							  $imagem = $ln['imagem'];
                              $nome  = $ln['nome'];
                              $preco = number_format($ln['preco'], 2, ',', '.');
                              $sub   = number_format($ln['preco'] * $qtd, 2, ',', '.');
                               
                              $total += $ln['preco'] * $qtd;
                            
							$produtos+= $ln['nome'] + " | " ;
							$ids+= $ln['id'] + " | ";
                           echo '<tr>
                                 <td><img src="imgProdutos/'.$imagem.'.jpg"/></td>						   
                                 <td>'.$nome.'</td>
                                 <td><input type="number" size="3" name="produto['.$id.']" value="'.$qtd.'" /></td>
                                 <td>R$ '.$preco.'</td>
                                 <td>R$ '.$sub.'</td>
                                 <td><a href="?pagina=carrinho&acao=del&id='.$id.'" class="btn btn-red">Remover</a></td>
                              </tr>';
                        }
                           $total = number_format($total, 2, ',', '.');
                           echo '<tr>
                                    <td colspan="1">Total</td>
                                    <td colspan="5">R$ '.$total.'</td>
                              </tr>';
                     }
					 if (isset($_POST['btnFinalizar'])) {
					 @$conexao = mysql_connect ("localhost", "root", "") or die 
(mysql_error());
$select_db = mysql_select_db ("webclothing", @$conexao) or die(mysql_error());
			 $cliente = $_POST($_SESSION['us_email']);
		  mysql_query("INSERT INTO `pedido` ( `cliente` , `itens` , `codigo_itens` , `valor`)VALUES('$cliente', '$produtos', '$ids', '$total')")or die(mysql_error()); //Realiza a inserção de dados do pedido
				 }
					
               ?>
    
     </tbody>
        
</table>
 
</body>
</html>
</html>