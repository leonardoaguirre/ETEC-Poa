<html>
<head>
<text> Resultado </text>
<title> Boa noite </title>
</head>
<body>

<?php


   $n1 = 10;
   $n2 = 2;
   $tipo = $_GET["opcao"];
   $result = ($tipo == "d")? $n1 / $n2 : $n1 * $n2;
   Echo $result;
   


?>

</body>
</html>

