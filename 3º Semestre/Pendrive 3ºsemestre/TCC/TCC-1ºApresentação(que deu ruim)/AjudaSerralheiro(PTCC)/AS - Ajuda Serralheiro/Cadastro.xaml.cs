using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace AS___Ajuda_Serralheiro
{
    /// <summary>
    /// Interaction logic for Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void txtddd_KeyUp(object sender, KeyEventArgs e)
        {

            if (txtddd.Text.Length == 2)
            {
                txtddd.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
            }
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {

            //Falta adicionar variaveis para o recebimento de dados casa Pessoa Juridica

            //Aqui as variaveis recebem o texto das textbox e passwordbox
            Variaveis.usuario = txtusuario.Text;
            Variaveis.senha = passwordBox.Password;
            Variaveis.confsenha = passwordBox.Password;
            Variaveis.nome = txtnome.Text;
            Variaveis.ddd = txtddd.Text;
            Variaveis.telefone = txtnumtel.Text;
            Variaveis.email = txtemail.Text;
            string senha, confsenha;
            senha = Variaveis.senha;
            confsenha = Variaveis.confsenha;




            //Aqui a estrutura analisa se as senhas estão diferentes 

            //Usando String.Compare para comparar duas strings 
            bool verificasenha = String.Compare(Variaveis.senha, Variaveis.confsenha, true) == 0;

            //Falta ainda adicionar uma verificaçã se a checkbox da politica de privacidade foi checked 

            if ((verificasenha == false) && (passwordBox.Password.Length >= 8))
            {

                DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\Jonas\Desktop\CADASTRADOS\");

                if (!directoryInfo.Exists)
                {
                    Directory.CreateDirectory(@"C:\Users\Jonas\Desktop\CADASTRADOS\");
                    MessageBox.Show("Cadastrado com sucesso!");

                }
                String meuTexto = txtusuario.Text + " ; " + Variaveis.senha;
                FileInfo arquivo = new FileInfo(@"C:\Users\Jonas\Desktop\CADASTRADOS\seuArquivo.txt");
                //FileInfo arquivo = new File(@"C:\MEUTESTE\" + txtEmail.Text + ".txt");

                if (!arquivo.Exists)
                {

                    StreamWriter escreveArquivo = new StreamWriter(@"C:\Users\Jonas\Desktop\CADASTRADOS\" + Variaveis.nome + ".txt");
                    escreveArquivo.WriteLine(meuTexto);
                    escreveArquivo.Close();

                }
                else
                {
                    StreamWriter escreveArquivo = File.AppendText(@"C:\Users\Jonas\Desktop\CADASTRADOS\seuArquivo.txt");
                    escreveArquivo.WriteLine(meuTexto);
                    escreveArquivo.Close();
                }

                txtusuario.Clear();
                passwordBox.Clear();
                txtusuario.Clear();
                txtdatnasc.Clear();
                txtddd.Clear();
                txtemail.Clear();
                txtnome.Clear();
                txtnumtel.Clear();
                passwordBoxconfirm.Clear();
                txtnome.Clear();

                MessageBox.Show("Cadastrado com sucesso!");
                MainWindow mw = new MainWindow();
                mw.Show();
                Close();
            }
            else
            {
                if ((passwordBox.Password.Length < 8) || (passwordBox.Password.Length == 0))
                {
                    lblmensagem.Content = "As senhas devem conter no minímo 8 caracteres!";
                }
                else
                    lblmensagem.Content = "                 As senhas devem ser idênticas!";
                    txtusuario.Clear();
                    passwordBox.Clear();
                    txtusuario.Clear();
                    txtdatnasc.Clear();
                    txtddd.Clear();
                    txtemail.Clear();
                    txtnome.Clear();
                    txtnumtel.Clear();
                    passwordBoxconfirm.Clear();
                    txtnome.Clear();

                }
            }
        


        //parte de mudança de Pf para Pj
        private void rbJuridica_Checked(object sender, RoutedEventArgs e)
        {
            lblnome.Visibility = Visibility.Hidden;
            lblnomeempresa.Visibility = Visibility.Visible;
            lblgr.Visibility = Visibility.Hidden;
            lblcnpj.Visibility = Visibility.Visible;
            lblcpf.Visibility = Visibility.Hidden;
            txtcpf.Visibility = Visibility.Hidden;
            lblrazao.Visibility = Visibility.Visible;
            txtrazao.Visibility = Visibility.Visible;
            lblnasc.Visibility = Visibility.Hidden;
            txtdatnasc.Visibility = Visibility.Hidden;
            txtrg.Visibility = Visibility.Hidden;
            txtcnpj.Visibility = Visibility.Visible;
        }
        private void rbFisica_Click(object sender, RoutedEventArgs e)
        {
            lblnome.Visibility = Visibility.Visible;
            lblnomeempresa.Visibility = Visibility.Hidden;
            lblgr.Visibility = Visibility.Visible;
            lblcnpj.Visibility = Visibility.Hidden;
            lblcpf.Visibility = Visibility.Visible;
            txtcpf.Visibility = Visibility.Visible;
            lblrazao.Visibility = Visibility.Hidden;
            txtrazao.Visibility = Visibility.Hidden;
            lblnasc.Visibility = Visibility.Visible;
            txtdatnasc.Visibility = Visibility.Visible;
            txtrg.Visibility = Visibility.Visible;
            txtcnpj.Visibility = Visibility.Hidden;
        }

        private void passwordBoxconfirm_MouseLeave(object sender, MouseEventArgs e)
        {
            lblmensagem.Content = "";
        }
    }
}
