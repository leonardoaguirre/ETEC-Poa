<?php
	include("connection.php");
	session_start();
	include("protegerPagina.php");
	protegerPagina();
?>

<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title> USA Army - Painel </title>
		<link rel="stylesheet" href="styles/style-panel.css" type="text/css" media="all" />
	</head>
	<body>
		<div id="div_Container">
			<div id="div_Topo"> 
				<img id="imageTOPO" src="images/logo.png" alt="Imagem Logo" />
			</div>
			<div id="div_Menu"> 
				<ul>
					<li> <a href="index.php"> Início </a> </li>
					<li> <a href="panel.php"> Painel </a> </li>
					<li> <a href="panel.php?func=addPostagem"> Add Postagem </a> </li>
					<li> <a href="panel.php?func=addUsuario"> Add Usuário </a> </li>
					<li> <a href="panel.php?func=Postagens"> Postagens </a> </li>
					<li> <a href="panel.php?func=Usuarios"> Usuários </a> </li>
				</ul>
			</div>
			<div id="div_Conteudo"> 
                <div id="pText">
				<?php
					error_reporting(false);
					$page = $_GET["func"];
					if(isset($page)) {
						include("$page.php");
					} else {
				        $select = $mysqli->query("SELECT * FROM usuarios");
                        $row = $select->num_rows;
                        $users = $row;
                        
                        $select = $mysqli->query("SELECT * FROM postagens");
                        $row = $select->num_rows;
                        $posts = $row;
                ?>
						<h4> Bem vindo ao Painel de Controle <?=$_SESSION["Usuario"]?> </h4> <br /> <br />
						<h3> Informações do Site: </h3>
						<p>
							Usuários Registrados:  <?=$users?> <br />
							Postagens Registradas:  <?=$posts?> <br />
						</p>
						<?php
					}
				?>
                </div>
			</div>
			<div id="div_Rodape"> 
				<span> USA Army 2014 - Todos os direitos reservados. </span>
			</div>
		</div>
	</body>
</html>