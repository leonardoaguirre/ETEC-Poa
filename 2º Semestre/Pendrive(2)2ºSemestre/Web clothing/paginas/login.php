<html>
<head>
<style type="text/css">
#divCenter form {
  background: white;
  width: 90%;
  box-shadow: 0px 0px 20px rgba(0, 0, 0, 0.7);
  font-family: lato;
  position: relative;
  color: #333;
  border-radius: 50px;
  margin-left: 180px;
  margin-top: 80px;
}
#divCenter form header {
  background: #FF3838;
  padding: 30px 10px;
  color: white;
  font-size: 2.2em;
  font-weight: 600;
  border-radius: 20px 20px 0 0;
}
#divCenter form label {
  margin-left: 20px;
  display: inline-block;
  margin-top: 30px;
  margin-bottom: 5px;
  position: relative;
}
#divCenter form label span {
  color: #FF3838;
  font-size: 2em;
  position: absolute;
  left: 2.3em;
  top: -10px;
}
#divCenter form input {
  display: block;
  width: 78%;
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
  border-radius: 40px;
  box-shadow: 0px 0px 10px rgba(51, 51, 51, 0.4);
  cursor: pointer;
  transition: all 0.15s ease-in-out;
}
#divCenter form button:hover {
  background: #ff5252;
}

    </style>
</head>
<body>
<div id="divCenter">
<form name="form1" method="post">
  <header>Login</header>
  <label>Usuario <span>*</span></label>
  <input type="email" name="us_Email" placeholder="exemplo@exemplo.com" required class="inputFormulario" />
  <div class="help">**Seu email de cadastro**</div>
  <label>Senha <span>*</span></label>
  <input type="password" name="us_Senha" placeholder="*****" required class="inputFormulario" />
  <div class="help">**Sua senha de cadastro**</div>
<button input  type="submit" name="btnSubmit" class="btnSubmit">Entrar</button>
</form>
<?php
if (isset($_POST['btnSubmit'])) {

session_start();
session_name("login");

$login = $_POST ['us_Email'];
$senha = $_POST ['us_Senha'];

@$conexao = mysql_connect ("localhost", "root", "") or die 
("Sem conexão com o servidor");
$select_db = mysql_select_db ("webclothing", @$conexao) or die 
("Sem acesso ao DB, entre em contato com o Administrador");


$result = mysql_query ("SELECT * FROM usuario WHERE us_email ='$login' AND us_senha ='$senha'")or die(mysql_error());
 
     if (mysql_num_rows ($result) != 0 )
{ 
	$_SESSION ['us_email'] = $login;
	$_SESSION ['us_senha'] = $senha;
header("Location: ?pagina=produtos");
	?>
	
                    <script type="text/javascript">
                        alert("Usuário logado com sucesso! Boas Compras!");
                    </script>
				
                    <?php

}
     else 
{
	?>
                    
					<script type="text/javascript">
                        alert("Erro ao logar, usuario ou senha estão incorretos! Tente novamente!");
                    </script>
					<a href='?pagina=login'>
                    <?php
	 unset ($_SESSION ['us_email']);
	 unset ($_SESSION ['us_senha']);
	 
}
	
}

?>
<form name="form2" method="post" action="?pagina=cadastro">
<header>Você não possui um cadastro?</header>
<button input  type="submit" name="cadastrar" class="btnSubmit">Cadastre-se</button>

</form> 
</div>
</body>


