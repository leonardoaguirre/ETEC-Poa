using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Configuration;
using System.Net;

namespace Telas
{
    public partial class EsqueciSenha : Form
    {
        public EsqueciSenha()
        {
            InitializeComponent();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("developoficial@gmail.com");
            mail.To.Add(email); // para
            mail.Subject = "Email de recuperação de senha"; // assunto
            mail.Body = "Testando mensagem de e-mail"; // mensagem

            using (var smtp = new SmtpClient("smtp.gmail.com"))
            {
                smtp.EnableSsl = true; // GMail requer SSL
                smtp.Port = 587;       // porta para SSL
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

                // seu usuário e senha para autenticação
                smtp.Credentials = new NetworkCredential("developoficial@gmail.com", "develop2017");

                // envia o e-mail
                smtp.Send(mail);
            }
        }


        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
