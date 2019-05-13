using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace Borderouri
{
    public partial class TrimitereEmail : MetroFramework.Forms.MetroForm
    {
        Form Form1;

        public TrimitereEmail(Form parentForm, string email, string attachPath, string nrBor)
        {
            InitializeComponent();
            this.Form1 = parentForm;
            TextBoxCatre.Text = email;
            LabelAttachPath.Text = attachPath;
            LabelnrBor.Text += nrBor;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void TrimitereEmail_Load(object sender, EventArgs e)
        {

            LabelEmitator.Text = "daniel.tamas@just.ro";
            TextBoxSubiect.Text = "Tribunalul Cluj - " + LabelnrBor.Text;
            TextBoxBody.Text = "Buna ziua \n V-am atasat " + LabelnrBor.Text.ToLower();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            MailMessage mail = new MailMessage(LabelEmitator.Text, TextBoxCatre.Text);
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "10.1.0.52";
            mail.Subject = TextBoxSubiect.Text;
            mail.Body = TextBoxBody.Text;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
            mail.Attachments.Add(new Attachment(LabelAttachPath.Text));

            client.Send(mail);
            LabelnrBor.Text = "Borderou";
            this.Hide();

        }

        private void ButtonFileExplorer_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                LabelAttachPath.Text = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
        }
    }
}
