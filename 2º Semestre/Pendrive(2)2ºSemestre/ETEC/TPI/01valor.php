<html> 
<head>

 <link rel = "stylesheet" href = "_css/estilo.css"/>
 <meta charset = "UTF - 8"/>
 <title> Curso de PHP - CursoemVideo.com </title>
 
</head>

<body>
<div>
       <?php
	   $valor = $_GET["v"];
	   $rq = sqrt ($valor);
	   echo "A raiz de $valor e igual a $rq";
	   ?>
</div>
</body>
</html>
  