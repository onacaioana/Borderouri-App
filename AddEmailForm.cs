using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borderouri
{
    public partial class AddEmailForm : MetroFramework.Forms.MetroForm
    {
        Form Form1;
        SqlConnection connDest = new SqlConnection("Data Source=10.15.60.23;Initial Catalog=borderuriDB;Persist Security Info=True;User ID=sa;Password=22043Nicu");

        public AddEmailForm(Form parentForm)
        {
            InitializeComponent();
            this.Form1 = parentForm;
            CenterForm(this);
        }

        private void AddEmailForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'borderuriDBDataSet.Emails' table. You can move, or remove it, as needed.
            this.emailsTableAdapter.Fill(this.borderuriDBDataSet.Emails);

        }

        private void CenterForm(Form yuorForm)
        {
            foreach (var s in Screen.AllScreens)
            {
                if (s.WorkingArea.Contains(this.Location))
                {
                    int screenH = s.WorkingArea.Height / 2;
                    int screenW = s.WorkingArea.Width / 2;

                    int top = (screenH + s.WorkingArea.Top) - 100 / 2;
                    int left = (screenW + s.WorkingArea.Left) - 100 / 2;
                    this.Location = new Point(top, left);
                    break;
                }
            }
        }

        private void emailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.borderuriDBDataSet);

        }

        private void ButtonSalveaza_Click(object sender, EventArgs e)
        {
            emailsTableAdapter.Connection = connDest;
            borderuriDBDataSet.Emails.AddEmailsRow(TextBoxMail.Text, TextBoxDetalii.Text);
            emailsTableAdapter.Update(borderuriDBDataSet.Emails);
            this.Hide();
        }
    }
}
