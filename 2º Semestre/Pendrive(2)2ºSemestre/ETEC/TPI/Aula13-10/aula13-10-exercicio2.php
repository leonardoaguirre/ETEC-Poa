<?php
$quantidade=$_GET["quantidade"];
$valor=$_GET["valor"];


$total=$quantidade*$valor;

$ncomissao=$total*0.10;
echo "A comissão é $ncomissao"


?>