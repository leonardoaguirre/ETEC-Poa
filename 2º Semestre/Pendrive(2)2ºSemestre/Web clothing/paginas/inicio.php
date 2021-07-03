<html>
<body>
<link href="https://fonts.googleapis.com/css?family=Patua+One" rel="stylesheet">
<style type="text/css">
#divbanner{
	
	margin-left:100px;
	margin-top:20px;
	margin-bottom:10px;
}
.titulo{
	color: #000000;
	margin-left:50%;
	margin-top:10px;
    text-align:center;
	font-family: 'Patua One', cursive;
	font-size:40px;
	margin-bottom:10px;
}
#clique form button, .btnSubmit{
  position: relative;
  margin-top: 0px;
  margin-bottom: 20px;
  left: 45%;
  transform: translate(0%, 0);
  font-family: 'Patua One', cursive;
  color: black;
  background: #c60000;
  outline: none;
  border: none;
  padding: 50px 0px;
  font-size: 1.7em;
  font-weight: 40px;
  border-radius: 20px;
  box-shadow: 0px 0px 100px rgba(51, 51, 51, 0.10);
  cursor: pointer;
  transition: all 0.20s ease-in-out;
  text-align: center;
  width:400px;
}
#clique form button:hover, .btnSubmit {
  background: #ff5252;
  
}
</style>
<head>
<h1 class="titulo">Olá!</h1> 
<h1 class="titulo">Seja bem-vindo!</h1>

<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1"> 
<script language="JavaScript"> 
var ultimo=-1, dBanner;
function carrega(x) {dBanner=x;Banners()}
function Banners()
{ 
var img = new Array();  
img[0]= '<A HREF="?pagina=produtos" target="_blank"><IMG SRC="paginas/imgsbanner/banner.jpg" WIDTH="800" HEIGHT="400" BORDER="0" ALT=""></a>'

img[1]= '<A HREF="?pagina=produtos" target="_blank"><IMG SRC="paginas/imgsbanner/img2.jpg" WIDTH="800" HEIGHT="400" BORDER="0" ALT=""></a>'

img[2]= '<A HREF="?pagina=produtos" target="_blank"><IMG SRC="paginas/imgsbanner/img3.jpg" WIDTH="800" HEIGHT="400" BORDER="0" ALT=""></a>'

img[3]= '<A HREF="?pagina=produtos" target="_blank"><IMG SRC="paginas/imgsbanner/img4.jpg" WIDTH="800" HEIGHT="400" BORDER="0" ALT=""></a>'

img[4]= '<A HREF="?pagina=produtos" target="_blank"><IMG SRC="paginas/imgsbanner/img5.jpg" WIDTH="800" HEIGHT="400" BORDER="0" ALT=""></a>'

img[5]= '<A HREF="?pagina=produtos" target="_blank"><IMG SRC="paginas/imgsbanner/img6.jpg" WIDTH="800" HEIGHT="400" BORDER="0" ALT=""></a>'

img[6]= '<A HREF="?pagina=produtos" target="_blank"><IMG SRC="paginas/imgsbanner/img7.jpg" WIDTH="800" HEIGHT="400" BORDER="0" ALT=""></a>'

img[7]= '<A HREF="?pagina=produtos" target="_blank"><IMG SRC="paginas/imgsbanner/img8.jpg" WIDTH="800" HEIGHT="400" BORDER="0" ALT=""></a>'

img[8]= '<A HREF="?pagina=produtos" target="_blank"><IMG SRC="paginas/imgsbanner/img9.jpg" WIDTH="800" HEIGHT="400" BORDER="0" ALT=""></a>'



while((Numero = parseInt(Math.random()*img.length))==ultimo);
dBanner.innerHTML=img[Numero];

setTimeout("Banners()",3000);
} 
</script></head> 
<body bgcolor="#FFFFFF" topmargin=0 leftmargin=0 text="#000000" onLoad=carrega(this.divBanner)> 
<table width="200" border="0" cellspacing="0" cellpadding="0" height="60" bordercolor="#000000"> 
<tr> 
<td> 
<div align="center" id=divBanner></div> 
</td> 
</tr> 
</table> 
<div id="clique">
<form name="form2" method="post" action="?pagina=produtos">
<input  type="submit" name="confirir" class="btnSubmit" action="paginas/produtos.php" value="Confira os nossos produtos! &raquo;&raquo;&raquo;">
</form> 
</div>
</body>
</html>
