using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Borderouri
{
    public partial class StergeEmail : MetroFramework.Forms.MetroForm
    {
        Form Form1;
        SqlConnection connDest = new SqlConnection("Data Source=10.15.60.23;Initial Catalog=borderuriDB;Persist Security Info=True;User ID=sa;Password=22043Nicu");
        
        public StergeEmail(Form parentForm)
        {
            InitializeComponent();
            this.Form1 = parentForm;
        }

        private void StergeEmail_Load(object sender, EventArgs e)
        {
            emailsTableAdapter.Connection = connDest;
            connDest.Open();
            // TODO: This line of code loads data into the 'borderuriDBDataSet.Emails' table. You can move, or remove it, as needed.
            this.emailsTableAdapter.Fill(this.borderuriDBDataSet.Emails);
            connDest.Close();
        }

        private void emailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.borderuriDBDataSet);

        }

        private void ButtonSterge_Click(object sender, EventArgs e)
        {
            DataRow[] foundRows;
            connDest.Open();
            foundRows = borderuriDBDataSet.Emails.Select("EmailAddress = '" + GridViewEmails.SelectedRows[0].Cells[1].Value.ToString() + "'");
            // borderuriDBDataSet.Emails.RemoveEmailsRow(foundRows[0] as borderuriDBDataSet.EmailsRow);
          
            emailsTableAdapter.Delete(Int32.Parse(foundRows[0][0].ToString()), foundRows[0][1].ToString(), foundRows[0][2].ToString());
            GridViewEmails.Rows.RemoveAt(GridViewEmails.SelectedRows[0].Index);
            connDest.Close();
           
        }
    }
}
