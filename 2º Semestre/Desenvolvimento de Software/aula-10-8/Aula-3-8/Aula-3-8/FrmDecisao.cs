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
            TiposDeVariaveis();
        }


        // IF , THEN , ELSE

        private void btnCores_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                btnCores.Text = "Ligar";

            }
            else
            {
                timer1.Enabled = true;
                btnCores.Text = "Desligar";
            }
            /*
            if (btnCores.Text == "Vermelho")
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
            } */

        }


        //Tipos de variaveis
        private void TiposDeVariaveis()
        {

            // ------> Textos <-------

            //16 Bits
            char charNick = 'a'; //uso de ' para char
            Char charSystem;

            //32 Bits
            string stringNick = "Etec"; //Uso de " para String
            String stringSystem;

            // -------> Inteiro ( - / + ) <-------

            //16 Bits > -32.768 até 32.767
            short shortNick = 12;
            Int16 shortSystem;

            //32 Bits > -2.147.483.648 até 2.147.483.647
            int intNick = -34;
            Int32 intSystem;

            //64 Bits > -9.223.372.036.854.775.808 até 9.223.372.036.854.775.808
            long longNick = 1001;
            Int64 longSystem;

            // -----> Decimais <-----

            //7 digitos - 32 Bits
            float floatNick = 32.2f; // Obrigatório uso de 'f' ou 'F' no final 
            Single floatSystem;

            //16 dígitos - 64 bits 
            double doubleNick = -3.1998d; // Uso de 'd' ou 'D' no final 
            Double doubleSystem;

            //29 dígitos - 128 bits
            decimal decimalNick = 1.50m; // Uso de 'm' ou 'M' no final
            Decimal decimalSystem; 

            // -----> Boolena (V/F) <-----

            bool boolNick = true;
            Boolean boolSystem = false;

            // -----> Data e Hora <-----

            DateTime dataTime = DateTime.Now;
           
             
        }

        private void timer1_Tick(object sender, EventArgs e)
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
