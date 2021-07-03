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
	margin-left:200px;
	margin-top:20px;
}
</style>
<?php
      session_start();
	  @$conexao = mysql_connect ("localhost", "root", "") or die 
("Sem conexão com o servidor");
$select_db = mysql_select_db ("webclothing", @$conexao) or die 
("Sem acesso ao DB, entre em contato com o Administrador");
ini_set('display_errors', 0 );
error_reporting(0);
	  if($_SESSION['us_senha'] == false) {
		  

      echo "<font face='Arial' size='5'>Você precisa estar conectado para ver esta área<br>Faça seu</font> <td colspan='5'><button name='btnSair' type='submit'><a href=\"?pagina=login\" class='btn btn-blue'>Login</a></button></td>";
      }
      else {
echo "<font face='Arial' size='5'>Olá&nbsp;". $_SESSION['us_email']."&nbsp&nbsp";
	  echo "<font face='Arial' size='2'>Confira abaixo,os produtos do seu carrinho:</font> <td colspan='5'><button name='btnSair' type='submit'><a href='?pagina=logout' class='btn btn-red'>sair</a></button></td>";
       
	   if (isset($_POST['btnSair'])) {
	    mysql_close($conexao);
	  
	
	   
	   }
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
            if(is_array($_POST['prod'])){
               foreach($_POST['prod'] as $id => $qtd){
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
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>Carrinho de Compras</title>
</head>
 
<body>
<table class="tabela">

    <img src="img/carrinho-logo.png" alt="Carrinho-logo" class="img" />

    <thead>
          <tr>
            <th width="244">Produto</th>
            <th width="79">Quantidade</th>
            <th width="89">Pre&ccedil;o</th>
            <th width="100">SubTotal</th>
            <th width="64">Remover</th>
          </tr>
    </thead>
            <form action="?acao=up" method="post">
    <tfoot>
           <tr>
            <td colspan="5"><a href="?pagina=carrinho" class="btn btn-blue">Atualizar Carrinho</a></td>
            <tr>
            <td colspan="5"><a href="?pagina=produtos" class="btn btn-red">Continuar Comprando</a></td>
			
			<td colspan="5"><a href="?pagina=finalizar" class="btn btn-green"><img src="img/carrinho.png" alt="Carrinho" />Finalizar Compra</a></td>
			
    </tfoot>
       
    <tbody>
               <?php
                     if(count($_SESSION['carrinho']) == 0){
                        echo '<tr><td colspan="5">N&atilde;o h&aacute; nenhum produto no carrinho</td></tr>';
                     }else{
                        require("conexao2.php");
                                                               $total = 0;
                        foreach($_SESSION['carrinho'] as $id => $qtd){
                              $sql   = "SELECT *  FROM produtos WHERE id= '$id'";
                              $qr    = mysql_query($sql) or die(mysql_error());
                              $ln    = mysql_fetch_assoc($qr);
                               
                              $nome  = $ln['nome'];
                              $preco = number_format($ln['preco'], 2, ',', '.');
                              $sub   = number_format($ln['preco'] * $qtd, 2, ',', '.');
                               
                              $total += $ln['preco'] * $qtd;
                            
                           echo '<tr>       
                                 <td>'.$nome.'</td>
                                 <td><input type="text" size="3" name="prod['.$id.']" value="'.$qtd.'" /></td>
                                 <td>R$ '.$preco.'</td>
                                 <td>R$ '.$sub.'</td>
                                 <td><a href="?acao=del&id='.$id.'">Remove</a></td>
                              </tr>';
                        }
                           $total = number_format($total, 2, ',', '.');
                           echo '<tr>
                                    <td colspan="4">Total</td>
                                    <td>R$ '.$total.'</td>
                              </tr>';
                     }
               ?>
    
     </tbody>
        </form>
</table>
 
</body>
</html>
</html>