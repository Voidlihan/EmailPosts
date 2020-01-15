using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
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

namespace EmailWithFTP
{
    /// <summary>
    /// Interaction logic for SendPost.xaml
    /// </summary>
    public partial class SendPost : Window
    {
        public SendPost()
        {
            InitializeComponent();
        }

        private void Send(object sender, RoutedEventArgs e)
        {
            MailAddress from = new MailAddress(textBoxFrom.Text);
            MailAddress to = new MailAddress(textBoxTo.Text);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Тест";
            m.Body = textBoxValue.Text;
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            smtp.Credentials = new NetworkCredential("a.esentay@mail.ru", "mypassword");
            smtp.EnableSsl = true;
            smtp.Send(m);
            MessageBox.Show("Отправлено");
        }
    }
}
