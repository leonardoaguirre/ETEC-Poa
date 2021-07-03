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
    /// Interaction logic for IncluirOrcamento.xaml
    /// </summary>
    public partial class IncluirOrcamento : Window
    {
        public IncluirOrcamento()
        {
            InitializeComponent();
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            Orcamento orcamento = new Orcamento();
            orcamento.Show();
            this.Close();
        }
    }
}
