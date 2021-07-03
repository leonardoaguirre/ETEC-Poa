<html lang="pt-br">
    <head>
        <meta charset="UTF-8">
        <title>Web Clothing</title>
        <link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
    <link rel="shoortcut icon" href="img/favicon.ico" />
        <link rel="stylesheet" href="css/menu.css">
     
    </head>
    <body>
        <div id="dvBarraTopo">
        </div>

        <div id="dvTopo">
            <div id="dvCentroTopo">
                <div id="dvLogo">
                    <a href='?pagina=empresa'><img src="img/logo.png" alt="Web clothing" /></a>
                </div>
                <div id="dvPesquisa">
                    <form method="post" name="frmPesquisa"  >
                        <input type="text" name="txtPesquisa" id="txtPesquisa" placeholder="Pesquisa" required />
                        <input type="submit" value="" id="btnSubmit" name="btnBuscar" />
                    </form>
                </div>
            </div>
        </div>

        <div id="dvMenu">
            <div id="dvCentroMenu">
                <div id='cssmenu'>
                    <ul>
                        <li><a href='?pagina=inicio'><span><img src="img/inicio.png" alt="Inicio" />Inicio</span></a></li>
						<li><a href='?pagina=produtos'><img src="img/produtos.png" alt="Produtos" /><span>Produtos</span></a></li>
                        <li><a href='?pagina=empresa'><span><img src="img/empresa.png" alt="Empresa" />Empresa</span></a></li>
                        <li><a href='?pagina=contato'><span><img src="img/contato.png" alt="Contato" />Contato</span></a></li>
						<li><a href='?pagina=login'><span><img src="img/cadeado.png" alt="Cadastrar"  />Login</span></a>
						<li><a href='?pagina=carrinho'><span><img src="img/carrinho.png" alt="Carrinho" />Carrinho</span></a></li>
						
                    </ul>
                </div>
            </div>
        </div>
        <div id="dvCentro">
            <div id="dvEsquerda">
                <?php
                if (isset($_GET['pagina'])) {
                    $pagina = $_GET['pagina'];
                    switch ($pagina) {

                        case "inicio":
                            include_once("paginas/inicio.php");
                            break;
							case "produtos":
                            include_once("paginas/produtos.php");
                            break;
							case "empresa":
                            include_once("paginas/empresa.php");
                            break;
							case "contato":
                            include_once("paginas/contato.php");
                            break;
							case "login":
                            include_once ("paginas/login.php");
                            break;
							case "carrinho":
                            include_once("paginas/carrinho.php");
                            break;
							case "cadastro":
							include_once("paginas/cadastro.php");
                            break;
							case "finalizar":
							include_once("paginas/finalizar.php");
                            break;
							case "logout":
							include_once("paginas/logout.php");
                            break;
							case "final":
                            include_once("paginas/final.php");
                            break;
                        default:
                            include_once("paginas/carrinho.php");
                    }
                } else {
                    include_once("paginas/inicio.php");
                }
				if (isset($_GET['acao'])) {
                    $acao = $_GET['acao'];
                    switch ($acao) {

                        case "?acao=add&id=":
                            include_once("paginas/carrinho.php");
                            break;
							default:
							include_once("paginas/carrinho.php");
					}
				}
                ?>
            </div>

            
            <div class="clear"></div>
        </div>
		<style type="text/css">
		.footer {
  position: relative;
  right: 0;
  bottom: 0;
  left: 0;
  padding: 0rem;
  background-color: #353535;
}
.img {
	width: 300px;
	weight:100px;
}
.img2 {
	width: 300px;
	weight:100px;
	margin-left:25%;
}
		</style>
<footer class="footer">
<img src="img/copyright.png" class ='img'/><a href="?pagina=empresa"><img src="img/logo.png" class='img2'/></a>
</footer>
    </body>
</html>