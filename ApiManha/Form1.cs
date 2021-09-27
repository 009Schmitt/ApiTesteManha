using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiManha
{
    public partial class Form1 : Form
    {
        private List<string> Emails = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// Cria o email
            //MailMessage eMail = new MailMessage();

            //// define os endereços
            //eMail.From = new MailAddress("testeentra21@gmail.com");
            //eMail.To.Add("testeentra21@gmail.com");

            //// define a mensagem
            //eMail.Subject = "Titulo";
            //eMail.Body = "Mensgem";

            //// Enviar o Email
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //smtp.EnableSsl = true;
            //NetworkCredential cred = new NetworkCredential("testeentra21@gmail.com", "@Senac2021");
            //smtp.Credentials = cred;
            //smtp.Send(eMail);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Emails.Add(txtMail.Text);
            txtMail.Clear();
        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            // Cria o email
            MailMessage eMail = new MailMessage();

            // define os endereços
            eMail.From = new MailAddress("testeentra21@gmail.com");

            foreach (var item in Emails)
            {
                eMail.To.Add(item);
            }

            // define a mensagem
            eMail.Subject = "Titulo";
            eMail.Body = "Mensgem";

            // Enviar o Email
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            NetworkCredential cred = new NetworkCredential("testeentra21@gmail.com", "@Senac2021");
            smtp.Credentials = cred;
            smtp.Send(eMail);
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {

        }
    }
}
