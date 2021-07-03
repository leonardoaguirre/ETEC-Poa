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
using System.Threading;

namespace SOSVidraceiro
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();

            /*Splash splash = new Splash();
            splash.Show();

            Menu main = new Menu();

            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(i);
            }

            splash.Close();

            main.Show();*/

        }

        private void btOrcamento_Click(object sender, RoutedEventArgs e)
        {
            Orcamento orcamento = new Orcamento();
            orcamento.Show();
        }

        private void btSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btProdutos_Click(object sender, RoutedEventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.Show();
        }

        private void btClientes_Click(object sender, RoutedEventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void btAgendamento_Click(object sender, RoutedEventArgs e)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.Show();
        }
    }
}

