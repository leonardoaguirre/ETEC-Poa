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

namespace SOSVidraceiro
{
    /// <summary>
    /// Interaction logic for Produtos.xaml
    /// </summary>
    public partial class Produtos : Window
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            IncluirProduto incluirProd = new IncluirProduto();
            incluirProd.Show();
            this.Close();
        }

        private void btVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
