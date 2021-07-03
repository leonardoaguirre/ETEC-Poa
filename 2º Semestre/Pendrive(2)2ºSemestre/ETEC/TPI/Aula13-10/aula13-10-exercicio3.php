 <html>
<head>
 <meta charset = "UTF-8"/>
</head>
<body>
 <?php

$peso=$_GET["peso"];
$altura=$_GET["altura"];


$imc=$peso/($altura*$altura);

if($imc < 18.5)

echo "O seu IMC é  $imc, você está abaixo do peso!";

if($imc > 18.5 & $imc <24.9)

echo "O seu IMC é  $imc, você está no peso ideal!";

if($imc > 25 & $imc<29.9)

echo "O seu IMC é  $imc, você está um pouco acima do peso!";

if($imc > 30)

echo "O seu IMC é  $imc, você está acima do peso, com obesidade!";

?>

</body>
</html>