<?
session_name("MeuLogin");
session_start();

if($_GET['acao'] == "logar") {
    $conexao = mysqli_connect ("localhost", "root", "","webclothing")or die('Erro ao conectar ao banco de dados');

    $nome = $_POST['us_email'];
    $q_user = mysql_query("SELECT * FROM usuarios WHERE us_email='$nome'");

    if(mysql_num_rows($q_user) == 1) {

        $query = mysql_query("SELECT * FROM usuarios WHERE us_email='$nome'");
        $dados = mysql_fetch_array($query);
        if($_POST['us_senha'] == $dados['us_senha']) {
            session_register("qwert");
            $_SESSION["qwert"]=$nome;
            header("Location:?pagina=produtos");
            exit;
        }
         else {
            header("Location: login.php?login=falhou&causa=".urlencode('Senha Errada'));
            exit;
        }
    } else {
        header("Location: login.php?login=falhou&causa=".urlencode('User Inválido'));
        exit;
    }
}

//agora a parte que verifica se o login já foi feito
if(session_is_registered("nome") == false) {
    header("Location: ?pagina=produtos");
}
?>

