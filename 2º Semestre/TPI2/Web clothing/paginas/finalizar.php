<html>
<meta charset="UTF-8">
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
  font-size: 2em;
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
  margin-bottom: 200px;
  margin-left: 60px;
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

    </style>
	</head>
	<body>
<div id ="divCenter">
    <form method="post" name="frmEntrega" enctype="multipart/form-data">
	<header>&raquo;Endere&ccedil;o de entrega e Dados do cart&atilde;o</header>
        <table>
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
                <td class="textoComum">Nome do receptor:</td>
                <td><input type="text" name="txtDestinatario" placeholder="Ex: Maria Aparecida" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">Complemento</td>
                <td><input type="text" name="txtComplemento" placeholder="Ex: ao lado da pra&ccedil;a" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">Cep: </td>
                <td><input type="number" name="txtCep" placeholder="Ex: 08557000" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">Numero do cart&atilde;o de credito:</td>
                <td><input type="number" name="txtNumeroCartao" placeholder="1234 5678 9102 3456" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">Nome do titular do cart&atilde;o:</td>
                <td><input type="text" name="txtNomeTitular" placeholder="Maria Aparecida" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">Vencimento</td>
                <td><input type="date" name="txtVencimento" placeholder="00/00" required class="inputFormulario" /></td>
            </tr>        
			<tr>
                <td class="textoComum">Numero de seguran&ccedil;a:</td>
                <td><input type="number" name="txtNumeroSeguranca" placeholder="000" required class="inputFormulario" /></td>
            </tr>       
			<td colspan="5"><a href="?pagina=finalizar" class="btn btn-green"><img src="img/carrinho.png" alt="Carrinho" />Finalizar Pedido</a></td>
			</form>
			
			</div>
			</body>
			</html>
            