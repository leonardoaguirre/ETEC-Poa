using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula_3_8
{
    public partial class FrmDecisao : Form
    {
        public FrmDecisao()
        {
            InitializeComponent();
        }



        // IF, THEN, ELSE

        private void btnCores_Click(object sender, EventArgs e)
        {
            if (tmr1.Enabled)
            {
                tmr1.Enabled = false;
                btnCores.Text = "Ligar";
            }
            else
            {
                tmr1.Enabled = true;
                btnCores.Text = "Desligar";
            }
       /*     if (btnCores.Text == "Vermelho")
            {
                this.BackColor = Color.Red;
                btnCores.Text = "Azul";
            }
            else
            {
                if (btnCores.Text == "Azul")
                {
                    this.BackColor = Color.Blue;
                    btnCores.Text = "Verde";
                }
                else
                {
                    if (btnCores.Text == "Verde")
                    {
                        this.BackColor = Color.Green;
                        btnCores.Text = "Foda-se o Padrão";
                    }
                    else
                    {
                        this.BackColor = Color.Empty;

                    }
                }
            }
         */
        }

        // Tipos de variáveis
        private void TiposDeVariaveis()
        {

            // ----> TEXTOS <-----

            //16 bits
            char charNick = 'a'; //Uso de ' para char   Quando se tem somente um caracter usa-se '
            Char charSystem;

            //32 bits
            string stringNick = "Etok"; //Uso da "Para string 
            String stringSystem;


            // ----> Inteiro ( - / + ) <-----

            //16 bits > -32.768 até 32.676
            short shortNick = 12;
            Int16 shortSystem;

            //32 bits > -2.147.483.648 até 2.147.483.647
            int intNick = -34;
            Int32 intSystem;

            //64 bits > -9.223.972.036.854.775.808 até 9.223.372.036.854.775.808
            long longNick = 1001;
            Int64 longSystem;


            // -----> Decimais <-----

            //7 digitos - 32 Bits
            float floatNick = 32.2f; //Obrigatório colocar "f" depois do número
            Single floatSystem;

            //16 digitos - 64 bits
            double doubleNick = -3.19998d; //Uso de 'd' ou 'D' no fial
            Double doubleSystem;

            //29 Digitos - 128 Bits 
            decimal decimalNick = 1.50m; //uso de 'm' ou 'M' no final
                Decimal  decimalSystem;

            // -----> Boolemna (v/f) <------

                bool boolNick = true;
                Boolean BoolSystem = false;

            // -----> Data e Hora <------
                DateTime dataTime = DateTime.Now;











                



        }

        private void tmr1_Tick(object sender, EventArgs e)
        {

            int opcao;
            Random rand = new Random();

            opcao = rand.Next(4);

            switch (opcao)
            {
                case 0:
                    this.BackColor = DefaultBackColor;
                    break;

                case 1:
                    this.BackColor = Color.Red;
                    break;

                case 2:
                    this.BackColor = Color.Blue;
                    break;

                case 3:
                    this.BackColor = Color.Yellow;
                    break;

                default:
                    this.BackColor = Color.Green;
                    break;

            }



        }
    }
}
