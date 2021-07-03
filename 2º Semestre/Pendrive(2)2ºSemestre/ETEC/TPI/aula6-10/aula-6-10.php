<?php
$para="doctorin_fo@hotmail.com";
$assunto="Contato pelo Site";
$nome=$_REQUEST['nome'];
$nascimento=$_REQUEST['ano'];
$sexo=$_REQUEST['sexo'];
$mensagem=$_REQUEST['mensagem'];

$corpo="<strong>Mensagem de contato</strong></br>";
$corpo.="<br><strong> Nome: </strong>$nome";
$corpo.="<br><strong> Nascimento: </strong>$nascimento";
$corpo.="<br><strong> Sexo: </strong>$sexo";
$corpo.="<br><strong> Mensagem: </strong>$mensagem";

$header="From:$email Reply-to:$email";
$header.="Content-Type:text/html; charset=utp-8";

mail ($para,$assunto,$corpo,$header);
header ("location:aula-6-10.php? msg=Mensagem enviada com sucesso");
//echo "Mensagem enviada com sucesso"

?>
