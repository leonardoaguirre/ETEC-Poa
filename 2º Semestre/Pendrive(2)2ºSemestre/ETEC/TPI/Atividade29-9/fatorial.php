</html>
<head>
<meta charset="utf-8">
<title>Fatorial</title>
</head>
<body>
<?php
$num = $_GET["n"];
$contador = 1;
$fatorial = 1;
  while ($contador <= $num){
	  $fatorial = $fatorial*$contador;
	  $contador = $contador + 1;
  }


   echo "O valor do fatorial do numero $num é : $fatorial";


?>


</body>
</html>