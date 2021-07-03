<!doctype html>
<html lang="pt-br">
    <head>
        <title>Contato</title>
        <meta charset="utf-8" />
 </head>
   <style type="text/css">
.form-style-2{
    max-width: 500px;
    padding: 10px 12px 10px 250px;
    font: 13px Arial, Helvetica, sans-serif;
}
.form-style-2-heading{
    font-weight: bold;
    font-style: italic;
    border-bottom: 2px solid #ddd;
    margin-bottom: 20px;
    font-size: 15px;
    padding-bottom: 3px;
}
.form-style-2 label{
    display: block;
    margin: 0px 0px 15px 0px;
}
.form-style-2 label > span{
    width: 100px;
    font-weight: bold;
    float: left;
    padding-top: 8px;
    padding-right: 5px;
}
.form-style-2 span.required{
    color:red;
}
.form-style-2 .txtTelefone{
    width: 150px;
    text-align: center;
}
.form-style-2 input.input-field {
    width: 60%;
    
}

.form-style-2 input.input-field, 
.form-style-2 .txtTelefone, 
.form-style-2 .txtMensagem, 
 .form-style-2 .select-field{
    box-sizing: border-box;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    border: 1px solid #C2C2C2;
    box-shadow: 1px 1px 4px #EBEBEB;
    -moz-box-shadow: 1px 1px 4px #EBEBEB;
    -webkit-box-shadow: 1px 1px 4px #EBEBEB;
    border-radius: 3px;
    -webkit-border-radius: 3px;
    -moz-border-radius: 3px;
    padding: 7px;
    outline: none;
}
.form-style-2 .input-field:focus, 
.form-style-2 .txtTelefone:focus, 
.form-style-2 .txtMensagem:focus,  
.form-style-2 .select-field:focus{
    border: 1px solid white;
}
.form-style-2 .txtMensagem{
    height:100px;
    width: 70%;
	margin-top: 10px;
}
.form-style-2 input[type=submit],
.form-style-2 input[type=button]{
    border: none;
    padding: 8px 50px 8px 50px;
    background: red;
    color: #fff;
    box-shadow: 1px 1px 4px #DADADA;
    -moz-box-shadow: 1px 1px 4px #DADADA;
    -webkit-box-shadow: 1px 1px 4px #DADADA;
    border-radius: 3px;
    -webkit-border-radius: 3px;
    -moz-border-radius: 3px;
}
.form-style-2 input[type=submit]:hover,
.form-style-2 input[type=button]:hover{
    background: black;
    color: #fff;
}
#img{
	width:700px;
	left:50%;
    float:center;
	margin-top:30px;
	margin-left:100px;
}
</style>

<body>
<img src="img/contatenos.png" alt="Contate-nos" width="700px" id="img"/>
<div class="form-style-2">
<div class="form-style-2-heading">Contate-nos e o mais breve possível responderemos você!</div>
<form action="" method="post">
<label for="field1"><span>Nome: <span class="required">*</span></span><input type="text" placeholder="(nome / sobrenome)" class="input-field" name="txtNome" value="" /></label>
<label for="field2"><span>Email: <span class="required">*</span></span><input type="text" placeholder="Ex: email@email.com" class="input-field" name="txtEmail" value="" /></label>
<label><span>Telefone:</span><input type="text" placeholder="Ex: (11)912345678" class="txtTelefone" name="txtTelefone" value="" maxlength="11" />

<label for="field5"><span>Menssagem: <span class="required">*</span></span><textarea input type="textarea" name="txtMensagem" class="txtMensagem"></textarea></label>

<label><span>&nbsp;</span><input type="submit" value="Enviar" name="btnSubmit" /></label>
</form>
</div>
<?php
if (isset($_POST['btnSubmit'])) {



//CONEXÂO COM O BANCO DE DADOS
@$conexao = mysql_connect ("localhost", "root", "") or die 
("Sem conexão com o servidor");
$select_db = mysql_select_db ("webclothing", @$conexao) or die 
("Sem acesso ao DB, entre em contato com o Administrador");

 
// RECEBENDO OS DADOS PREENCHIDOS DO FORMULÁRIO !
$nome	= $_POST ["txtNome"];	//atribuição do campo "nome" vindo do formulário para variavel	
$email	= $_POST ["txtEmail"];	//atribuição do campo "email" vindo do formulário para variavel
$tel	= $_POST ["txtTelefone"];	//atribuição do campo "telefone" vindo do formulário para variavel
$mensagem	= $_POST ["txtMensagem"];	//atribuição do campo "endereco" vindo do formulário para variavel
//Gravando no banco de dados !
 
//conectando com o localhost - mysql
 
 

$result=mysql_query("INSERT INTO `contato` ( `con_nome` , `con_email` , `con_telefone` , `con_mensagem` ) 
VALUES ('$nome', '$email', '$tel', '$mensagem')")or die(mysql_error()); //Realiza a consulta
  $result2 = mysql_query ("SELECT * FROM contato WHERE con_mensagem ='$mensagem'")or die(mysql_error());
 
     if (mysql_num_rows ($result2) != 0 )
{ 

	?>
	<a href='?pagina=produtos'>
                    <script type="text/javascript">
                        alert("Menssagem enviada com sucesso! Em breve responderemos você.");
                    </script>
                    <?php

}
     else 
{
	?>
                    <a href='?pagina=login'>
					<script type="text/javascript">
                        alert("Falha ao enviar mensagem! Tente novamente.");
                    </script>
                    <?php
	 unset ($_SESSION ['con_mensagem']);
	 
}
/*if(mysql_affected_rows() == 1){ //verifica se foi afetada alguma linha, nesse caso inserida alguma linha
       ?>
                    <script type="text/javascript">
                        alert("Menssagem enviada com sucesso! Em breve responderemos você.");
                    </script>
                    <?php
    } else {
        ?>
                    <script type="text/javascript">
                        alert("Falha ao enviar mensagem! Tente novamente.");
                    </script>
					<?php
    }*/
     
    mysql_close($conexao); //fecha conexão com banco de dados 
?>
 


                  
					
                    <?php
                }
	
            
        ?>
 
    </body>
</html>