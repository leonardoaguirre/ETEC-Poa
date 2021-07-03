<div id="dvCadastro">
    
   


	<style type="text/css">
       #dvRegrasCadastro{
		   width: 100%;
		   position: relative;
	   }
#divCenter form {
  background: white;
  width: 100%;
  box-shadow: 0px 0px 20px rgba(0, 0, 0, 0.7);
  font-family: lato;
  position: relative;
  color: #333;
  border-radius: 50px;
  margin-left: 150px;
  margin-top: 20px;
}
#divCenter form header {
  background: #FF3838;
  padding: 30px 10px;
  color: white;
  font-size: 2.2em;
  font-weight: 600;
  border-radius: 10px 10px 0 0;
}
#divCenter form label {
 
}
#divCenter form label span {
  color: #FF3838;
  font-size: 2em;
  position: absolute;
  left: 2.3em;
  top: -10px;
}
#divCenter form input .inputFormulario {
  display: block;
  width: 78%;
  margin-left: 20px;
  padding: 5px 20px;
  font-size: 1em;
  border-radius: 3px;
  outline: none;
  border: 1px solid #ccc;
}

#divCenter form button {
  position: relative;
  margin-top: 70px;
  margin-bottom: 30px;
  left: 50%;
  transform: translate(-50%, 0);
  font-family: inherit;
  color: white;
  background: #FF3838;
  outline: none;
  border: none;
  padding: 5px 15px;
  font-size: 1.3em;
  font-weight: 400;
  border-radius: 3px;
  box-shadow: 0px 0px 10px rgba(51, 51, 51, 0.4);
  cursor: pointer;
  transition: all 0.15s ease-in-out;
}
#divCenter form button:hover {
  background: #ff5252;
}
</style>
 <div id ="divCenter">
    <form method="post" name="frmCadastro" enctype="multipart/form-data">
	<header>&raquo; Cadastre-se grátis.</header>
        <table>
            <tr>
                <td class="textoComum">Nome:</td>
                <td><input type="text" name="txtNome" placeholder="(nome / sobrenome)" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">E-mail:</td>
                <td><input type="email" name="txtEmail" placeholder="exemplo@exemplo.com" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">Telefone:</td>
                <td><input type="tel" name="txtTelefone" placeholder="(xx)xxxxx-xxxx" required class="inputFormulario" /></td>
            </tr>        <tr>
                <td class="textoComum">Senha:</td>
                <td><input type="password" name="txtSenha" placeholder="*****" required id="senha1" class="inputFormulario" /></td>
            </tr>       
            <tr>
                <td class="textoComum">Confirmar senha:</td>
                <td><input type="password" name="txtSenhaValida" placeholder="*****" required id="senha2" class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">CPF:</td>
                <td><input type="text" name="txtCPF" placeholder="000.000.000-00" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">Data Nascimento:</td>
                <td><input type="date" name="txtDataNascimento" placeholder="00/00/0000" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">Cidade: </td>
                <td><input type="text" name="txtCidade" placeholder="Ex: São Paulo" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">Estado:</td>
                <td>
                    <select name="txtEstado" class="inputFormulario"> 
                        <option value="">Selecione</option> 
                        <option value="ac">Acre</option> 
                        <option value="al">Alagoas</option> 
                        <option value="am">Amazonas</option> 
                        <option value="ap">Amapá</option> 
                        <option value="ba">Bahia</option> 
                        <option value="ce">Ceará</option> 
                        <option value="df">Distrito Federal</option> 
                        <option value="es">Espírito Santo</option> 
                        <option value="go">Goiás</option> 
                        <option value="ma">Maranhão</option> 
                        <option value="mt">Mato Grosso</option> 
                        <option value="ms">Mato Grosso do Sul</option> 
                        <option value="mg">Minas Gerais</option> 
                        <option value="pa">Pará</option> 
                        <option value="pb">Paraíba</option> 
                        <option value="pr">Paraná</option> 
                        <option value="pe">Pernambuco</option> 
                        <option value="pi">Piauí</option> 
                        <option value="rj">Rio de Janeiro</option> 
                        <option value="rn">Rio Grande do Norte</option> 
                        <option value="ro">Rondônia</option> 
                        <option value="rs">Rio Grande do Sul</option> 
                        <option value="rr">Roraima</option> 
                        <option value="sc">Santa Catarina</option> 
                        <option value="se">Sergipe</option> 
                        <option value="sp">São Paulo</option> 
                        <option value="to">Tocantins</option> 
                    </select>
                </td>
            </tr>
            <tr>
                <td class="textoComum">Rua:</td>
                <td><input type="text" name="txtRua" placeholder="Ex: Rua 10 nº 100" required class="inputFormulario" /></td>
            </tr> 
            <tr>
                <td class="textoComum">Bairro:</td>
                <td><input type="text" name="txtBairro" placeholder="Ex : Vila Cedral" required class="inputFormulario" /></td>
            </tr>
            <tr>
                <td class="textoComum">Cep:</td>
                <td><input type="text" name="txtCep" placeholder="00000-000" required class="inputFormulario" /></td>
            </tr>
			    <div id="dvRegrasCadastro">
        
		<div style="overflow:scroll; width:685px; height:300px;">
<p>1. CONSIDERAÇÕES INICIAIS
1.1. O USUÁRIO DECLARA TER CONHECIMENTO QUE CLICAR NO BOTÃO 'CADASTRAR' E COMPLETAR O
PROCESSO DE CADASTRAMENTO AO SITE IMPLICARÁ NA ACEITAÇÃO DE TODOS OS TERMOS DESTE
CONTRATO.
1.2. O webclothing poderá, a qualquer tempo, rever os presentes Termos e Condições para Cadastramento ao
SITE, atualizando e deixando disponível nova cópia aos seus USUÁRIOS.
2. OBJETO
2.1. O objeto deste contrato consiste em regular as relações para: cadastramento, hospedagem,
exposição e divulgação do Currículo cadastrado pelo USUÁRIO no SITE, que será disponibilizado a pessoas
jurídicas que estejam interessadas em alocar recursos humanos para determinada área/segmento do
mercado; envio e recebimento de mensagens eletrônicas (e-mail).
3. CADASTRO DO CURRÍCULO DO USUÁRIO
3.1. Ao se cadastrar, o USUÁRIO compromete-se a fornecer informações verdadeiras, atualizadas e
completas, conforme solicitado nas páginas de registro. Dentre essas informações será solicitado seu
próprio CPF ou, caso não tenha, o CPF de um responsável. O webclothing, se desejar, poderá utilizar um serviço
de verificação da validade do número fornecido.
3.2. Fica expressamente estipulado que somente será permitido o cadastro de um único currículo para
cada número de CPF.
3.3. A inserção, correção, bem como a veracidade de todos os dados e informações fornecidos pelo
USUÁRIO no cadastramento de seu currículo, ou em qualquer outro serviço, serão de sua inteira
responsabilidade.
3.4. Para proceder ao cadastro básico do currículo no SITE o USUÁRIO deverá, além do CPF, prestar as
seguintes informações: nome completo; data de nascimento; sexo; telefone; e-mail; endereço;
escolaridade; curso; além de quaisquer outras exigidas pelo webclothing.
3.5. Após a conclusão do cadastro básico, o USUÁRIO definirá seu LOGIN e SENHA e receberá uma
mensagem de confirmação, no e-mail informado no ato do cadastramento. O LOGIN e a SENHA
permitirão ao USUÁRIO utilizar todos os serviços destinados aos USUÁRIOS CADASTRADOS e,
posteriormente, optar por adquirir ou não qualquer outro serviço ou produto adicional disponibilizado pelo
SITE.
3.6. Os dados pessoais e de contato, constantes do currículo do USUÁRIO, permanecerão visíveis, ficando
disponíveis a todas as empresas cadastradas no SITE.
3.7 O webclothing determina que, a utilização total dos dados de contato do USUÁRIO poderá a ser fornecido a
qualquer tempo para toda e qualquer empresa.
4. EDIÇÃO DOS DADOS DO CURRÍCULO
4.1. O USUÁRIO, após o ato do cadastramento, poderá, a qualquer momento, editar qualquer dado 
constante de seu currículo, com exceção de seu número do CPF, bastando para tanto que efetue seu
LOGIN no SITE.
4.2. O USUÁRIO, tendo efetuado o LOGIN no SITE, poderá inserir dados adicionais ao seu currículo (tais
como, experiência profissional, idiomas, qualificações, etc), modificar e atualizar toda e qualquer
informação contida no seu banco de dados.
4.3. Todas as obrigações relacionadas ao cadastramento aplicam-se também para a edição do currículo
pelo USUÁRIO.
5. SMS, E-MAIL E ARMAZENAMENTO DE E-MAIL
5.1. O USUÁRIO autoriza expressamente o webclothing a enviar e-mail e sms pertinente a toda e qualquer
comunicação proveniente de qualquer uma das empresas cadastradas no SITE ou a proveniente do webclothing,
bem como boletins periódicos ou informativos do SITE, mesmo que estes contenham links de outros sites,
sejam ou não estes parceiros comerciais do webclothing, para o endereço de e-mail informado no cadastro do
USUÁRIO.
6. SENHA, SEGURANÇA E ACESSO AO CURRÍCULO
6.1. O USUÁRIO poderá acessar seu currículo desde que efetue seu LOGIN, digitando sua senha de
acesso.
6.2. O USUÁRIO é completamente responsável pela confidencialidade de sua conta e senha, bem como de
qualquer ato ou fato ocorridos em relação à sua conta, senha e/ou Identificação Positiva.
6.3. O USUÁRIO poderá alterar sua senha a qualquer momento, bastando, para tanto, que acesse
www.webclothing.com.br e informe a sua senha vigente.
7. PREÇO E LIMITE DE ACESSO
7.1. O cadastramento, a edição, a permanência e a utilização dos serviços ora contratados são gratuitos,
não havendo limite de tempo para que o USUÁRIO permaneça hospedado ou conectado ao SITE. Eventual
alteração desta condição deverá ser informada por e-mail ao USUÁRIO, com antecedência de 60
(sessenta) dias, dando ao mesmo a opção de cancelamento do serviço.
7.1.1. O webclothing poderá oferecer serviços adicionais aos aqui contratados, com preços estabelecidos
previamente em contratos a serem optados pelo Usuário.
7.2. O webclothing pode, a seu exclusivo critério, após o transcurso de 60 meses sem acesso, deletar o currículo
do USUARIO de sua base de dados, sem que para isso precise de qualquer autorização.
8. PRIVACIDADE E USO DE INFORMAÇÕES DO USUÁRIO
8.1. É política do webclothing respeitar a privacidade de seus USUÁRIOS. Assim sendo, o webclothing não monitorará,
editará ou revelará nenhuma informação sobre o uso do SITE pelo USUÁRIO, sem sua permissão,
excetuando para o fim deste contrato e nas hipóteses de tal conduta ser necessária para: proteger o
interesse do webclothing ou de terceiros; responder a eventual reclamação de que tal conteúdo viole direitos de
terceiros; identificar e resolver problemas técnicos; cumprir procedimento legal, inclusive determinação
judicial ou de qualquer órgão regulatório competente; fazer cumprir os termos dos serviços ora prestados.
8.2. O USUÁRIO AUTORIZA EXPRESSAMENTE O webclothing, OU TERCEIRO POR ELA INDICADO, A UTILIZAR
SEUS DADOS CADASTRAIS PARA FINS COMERCIAIS E DE MARKETING.
9. OBRIGAÇÕES DO USUÁRIO
9.1. O USUÁRIO compromete-se a não utilizar os serviços prestados pelo webclothing para:
9.1.1. fins ilegais ou para transmitir ou obter material em desacordo com a legislação brasileira; 
9.1.2. transmitir/divulgar material ilegal, difamatório, que viole a privacidade de terceiros, ou que seja
abusivo, ameaçador, obsceno, prejudicial, injurioso, calunioso;
9.1.3. transmitir e/ou divulgar material que viole direitos de terceiros, incluindo, mas sem limitação,
direitos de propriedade intelectual e direitos autorais;
9.1.4. enviar/divulgar quaisquer tipos de vírus ou arquivos contendo quaisquer tipos de vírus ou que
possam causar danos ao seu destinatário ou terceiros;
9.1.5. obter ou tentar obter acesso não autorizado a outros sistemas ou redes de computadores
conectados ao serviço;
9.1.6. criar uma falsa identidade, inclusive utilizando, sem autorização, CPF e outros documentos de
terceiros;
9.2. O USUÁRIO compromete-se, ainda, a nunca inserir seu nome, endereço, telefone, e-mail ou qualquer
outro dado de contato, fora dos campos especificados para tanto.
9.3. Na hipótese do webclothing constatar que o USUÁRIO descumpriu qualquer das obrigações estabelecidas
nas Cláusulas 9.1 e 9.2 acima, fica assegurado o direito do webclothing de SUSPENDER ou EXCLUIR a divulgação
e os dados do USUÁRIO, ou, até mesmo, rescindir imediatamente o presente contrato.
9.4. O USUÁRIO é o único responsável pelo conteúdo das transmissões feitas através do serviço, a partir
de sua senha ou conta.
9.5. O USUÁRIO é também o responsável pelos equipamentos necessários para sua conexão à Internet
(computador, linha telefônica e modem) e pelos custos de conexão.
9.6. O USUÁRIO declara ser o único beneficiário dos serviços objeto do presente instrumento.
10. RESPONSABILIDADE DO webclothing
10.1. O webclothing ENVIDARÁ SEUS MELHORES ESFORÇOS PARA MANTER O SITE ACESSÍVEL 24 (VINTE E
QUATRO) HORAS POR DIA, 7 (SETE DIAS) POR SEMANA, DE FORMA SEGURA, ININTERRUPTA E ISENTA
DE QUAISQUER ERROS. O USUÁRIO RECONHECE, NO ENTANTO, QUE O webclothing NÃO SERÁ RESPONSÁVEL
PELA INVIABILIDADE DE SUBMISSÃO DE INFORMAÇÕES AO SITE DECORRENTE DA IMPOSSIBILIDADE DE
ACESSO OU FALHA DE COMUNICAÇÃO ATRIBUÍVEL OU NÃO AO SITE.
10.2. O webclothing NÃO SE RESPONSABILIZA PELA COLOCAÇÃO OU RECOLOCAÇÃO PROFISSIONAL DE
QUALQUER USUÁRIO, NEM, TÃO POUCO, PELAS CONSEQÜÊNCIAS, AOS USUÁRIOS, ADVINDAS DE SUA
COLOCAÇÃO OU RECOLOCAÇÃO ATRAVÉS DESTE SITE.
10.3. O webclothing NÃO SE RESPONSABILIZA POR DANOS À VIDA PROFISSIONAL DO USUÁRIO, EM VIRTUDE
DA VISUALIZAÇÃO DE SEU CURRÍCULO NO SITE POR SEU ATUAL CONTRATANTE OU POR QUAISQUER
TERCEIROS.
10.4. O webclothing NÃO SE RESPONSABILIZA POR QUALQUER CONTEÚDO, PROPAGANDA, PRODUTO, SERVIÇO
CONTIDO OU OFERECIDO NO SITE, ATRAVÉS DE LINKS OU PUBLICIDADE RELATIVA A TAIS SITES. POR
CONSEGUINTE, QUALQUER NEGOCIAÇÃO HAVIDA ENTRE O USUÁRIO E ANUNCIANTES DO SITE,
INCLUINDO, MAS NÃO SE LIMITANDO A, PARTICIPAÇÃO EM PROMOÇÕES, A ENTREGA E O PAGAMENTO
POR BENS OU SERVIÇOS, QUAISQUER OUTROS TERMOS, CONDIÇÕES, GARANTIAS OU DECLARAÇÕES
ASSOCIADAS A TAIS NEGOCIAÇÕES, COMPROMETERÁ APENAS O ANUNCIANTE E O RESPECTIVO
USUÁRIO.
10.5. EM VISTA DO DISPOSTO NA CLÁUSULA 10.4 ACIMA, O webclothing NÃO TERÁ NENHUMA
RESPONSABILIDADE, PERANTE O USUÁRIO OU QUALQUER TERCEIRO, SEJA CONTRATUAL,
EXTRACONTRATUAL OU OUTRA, BEM COMO POR PERDAS OU DANOS DE QUALQUER ESPÉCIE,
RESULTANTES DE NEGOCIAÇÕES COM TERCEIROS OU DECORRENTES DA PRESENÇA DE ANUNCIANTES
NO SERVIÇO, NÃO SENDO RESPONSÁVEL POR QUALQUER RELAÇÃO ENTRE USUÁRIO E EMPRESAS QUE
FAÇAM USO DAS INFORMAÇÕES DISPONIBILIZADAS. 
10.6. O webclothing NÃO SERÁ RESPONSÁVEL POR EVENTUAIS DANOS DECORRENTES DO ACESSO ILÍCITO POR
TERCEIROS OU HACKERS AO SITE.
11. DIREITOS DE PROPRIEDADE
11.1. O USUÁRIO reconhece que o conteúdo do SITE, incluindo, mas não se limitando a textos, vídeos,
sons, banco de dados e outros materiais contidos em outras propagandas disponíveis no serviço, bem
como as informações divulgadas ao USUÁRIO através do serviço ou de anunciantes, podem estar
protegidos por direitos autorais, marcas, patentes ou outros direitos de propriedade intelectual. O
USUÁRIO RECONHECE QUE SOMENTE PODERÁ UTILIZAR TAIS MATERIAIS E INFORMAÇÕES SE
EXPRESSAMENTE AUTORIZADO PELO webclothing OU PELOS ANUNCIANTES, NÃO PODENDO COPIAR,
REPRODUZIR, TRANSMITIR, DISTRIBUIR OU CRIAR OBRAS DERIVADAS A PARTIR DE TAIS MATERIAIS
OU INFORMAÇÕES SEM A AUTORIZAÇÃO EXPRESSA DO RESPECTIVO PROPRIETÁRIO.
12. MODIFICAÇÕES DOS SERVIÇOS
12.1. O webclothing poderá eventualmente modificar os termos dos serviços ora disponibilizados, notificando o
USUÁRIO através de aviso contido nas páginas do SITE pertinentes, sendo que o USUÁRIO deverá
manifestar sua não concordância notificando o webclothing, por escrito, através de e-mail.
13. RENOVAÇÃO E RESCISÃO DO CONTRATO
13.1. O presente contrato é de duração indeterminada permanecendo válido enquanto o USUÁRIO
mantiver seu currículo cadastrado no SITE.
13.2. O USUÁRIO poderá, a qualquer momento, rescindir o presente contrato, bastando, para tanto,
enviar uma comunicação escrita ao webclothing, informando seu CPF, nome completo e motivo de
cancelamento, acessando www.webclothing.com.br e enviando tais dados, ou via fax para 0xx11 5031-3935,
solicitando o cancelamento.
13.2.1 A rescisão do presente contrato não exime o USUÁRIO, em nenhuma hipótese, de quaisquer de
suas obrigações contraídas em decorrência de eventual aquisição de quaisquer produtos e/ou serviços do
SITE.
13.3. No caso de rescisão deste contrato o USUÁRIO perderá definitivamente todos os direitos presentes
neste contrato.
13.4. Este contrato poderá ser rescindido a qualquer tempo e independentemente de notificação ou
interpelação judicial, havendo violação de quaisquer das cláusulas aqui dispostas.
13.5 Este contrato poderá ser rescindido a qualquer tempo, mediante aviso prévio de 30 (trinta) dias pelo
webclothing, sem justa causa, e sem que isto implique em qualquer indenização ao USUÁRIO.
14. DISPOSIÇÕES GERAIS
14.1. Todas e quaisquer comunicações entre as partes deverão ser realizadas por e-mail, correspondência
ou qualquer meio escrito que possa comprovar o recebimento pela outra parte.
14.2. Os termos dos serviços e o relacionamento entre as partes serão regidos e interpretados de acordo
com as Leis da República Federativa do Brasil. O USUÁRIO e o webclothing concordam expressamente a
submeter-se à competência única e exclusiva dos tribunais brasileiros e, em especial, ao Foro da Comarca
de São Paulo, Estado de São Paulo, para dirimir quaisquer questões oriundas deste instrumento.
14.3. As partes reconhecem que panes ou inoperância do sistema decorrentes de atos de interferência
externa são circunstâncias absolutamente fora do controle das partes, caracterizando-se como caso
fortuito, para todos os efeitos legais.
</p>
</div>
    </div>
            <tr>
                <td colspan="2">
				<input type="checkbox" name="ckTermo" id="ckTermo" /><label for="ckTermo">Eu concordo com os termos de uso acima.</label>
                </td>
            </tr>
            <tr>
                <td colspan="2"><button input style=" margin:5px;" type="submit" name="btnSubmit" class="btnSubmit" />&raquo; Cadastrar</button></td>
            </tr>
        </table>
    </form>
</div>
</div>

<?php

if (isset($_POST['btnSubmit'])) {

    if ($_POST['ckTermo']) {

//CONEXÂO COM O BANCO DE DADOS
@$conexao = mysql_connect ("localhost", "root", "") or die 
("Sem conexão com o servidor");
$select_db = mysql_select_db ("webclothing", @$conexao) or die 
("Sem acesso ao DB, entre em contato com o Administrador");


 
// RECEBENDO OS DADOS PREENCHIDOS DO FORMULÁRIO !
$nome	= $_POST ["txtNome"];	//atribuição do campo "nome" vindo do formulário para variavel	
$email	= $_POST ["txtEmail"];	//atribuição do campo "email" vindo do formulário para variavel
$tel	= $_POST ["txtTelefone"];	//atribuição do campo "telefone" vindo do formulário para variavel
$endereco	= $_POST ["txtRua"];	//atribuição do campo "endereco" vindo do formulário para variavel
$cidade	= $_POST ["txtCidade"];	//atribuição do campo "cidade" vindo do formulário para variavel
$estado	= $_POST ["txtEstado"];	//atribuição do campo "estado" vindo do formulário para variavel
$bairro = $_POST ["txtBairro"];	//atribuição do campo "bairro" vindo do formulário para variavel
$senha	= $_POST ["txtSenhaValida"];	//atribuição do campo "senha" vindo do formulário para variavel
$data = $_POST ["txtDataNascimento"];
$cep = $_POST ["txtCep"];
//Gravando no banco de dados !
 
//conectando com o localhost - mysql
 
 

$result=mysql_query("INSERT INTO `usuario` ( `us_nome` , `us_email` , `us_telefone` , `us_rua` , `us_cidade` , `us_estado` , `us_bairro` , `us_senha` , `us_datanascimento` , `us_cep`)VALUES('$nome', '$email', '$tel', '$endereco', '$cidade', '$estado', '$bairro', '$senha', '$data', '$cep')")or die(mysql_error());; //Realiza a consulta
 $result2 = mysql_query ("SELECT * FROM usuario WHERE us_email ='$email' AND us_senha ='$senha'")or die(mysql_error());
 
     if (mysql_num_rows ($result2) != 0 )
{ 

	?>
	<a href='?pagina=produtos'>
                    <script type="text/javascript">
                        alert("Usuário cadastrado com sucesso! Boas Compras!");
                    </script>
                    <?php

}
     else 
{
	?>
                    <a href='?pagina=login'>
					<script type="text/javascript">
                        alert("Erro ao cadastrar!");
                    </script>
                    <?php
	 unset ($_SESSION ['us_email']);
	 unset ($_SESSION ['us_senha']);
	 
}
}
/*if(mysql_affected_rows($result) == 1){ //verifica se foi afetada alguma linha, nesse caso inserida alguma linha
       ?>
                    <script type="text/javascript">
                        alert("Usuário cadastrado com sucesso! Boas Compras!");
                    </script>
                    <?php
    } else {
        ?>
                    <script type="text/javascript">
                        alert("Erro ao cadastrar Usuário! Tente novamente.");
                    </script>
					<?php
    }*/
     
    mysql_close($conexao); //fecha conexão com banco de dados 
?>
 


                  
					
                    <?php
                }
	
            
        ?>