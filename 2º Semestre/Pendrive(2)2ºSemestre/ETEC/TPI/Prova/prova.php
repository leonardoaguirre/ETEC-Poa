<html>
<head>
<title>Prova de PHP</title>
 <meta charset = "UTF - 8"/>
</head>
<body>
<?php
$idade;
$nome;
$anoNascimento;


     $nome = isset ($_GET["nome"])?$_GET ["nome"] : ["n�o informado"];
	 $anoNascimento = date ($_GET ["anoNascimento"])?$_GET ["anoNascimento"]: 0;
	 $idade = 2016 - $anoNascimento;

if 
	($idade < 16)
	echo "$nome voce nasceu em $anoNascimento e tem $idade anos, n�o pode votar, e nem dirigir!. </br>";

if
(($idade >= 16) & ($idade<=18)) 
 echo "$nome voce nasceu em $anoNascimento e tem $idade anos, seu voto � opcional, mas n�o pode dirigir. </br>";

if ($idade > 18)
	echo "$nome voce nasceu em $anoNascimento e tem $idade anos, seu voto � obrigat�rio, e tamb�m pode 
dirigir. </br>";

if ($idade >= 65)  
echo "$nome voce nasceu em $anoNascimento e tem $idade anos, seu voto � opcional, e tamb�m pode 
dirigir. </br>";

?>

</body>
</html>
