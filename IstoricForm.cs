using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Borderouri
{
    public partial class IstoricForm : MetroFramework.Forms.MetroForm
    {
        Form Form1;
        SqlConnection connDest = new SqlConnection("Data Source=10.15.60.23;Initial Catalog=borderuriDB;Persist Security Info=True;User ID=sa;Password=22043Nicu");

        public IstoricForm(Form parentForm)
        {
            InitializeComponent();
            this.Form1 = parentForm;
        }

        private void IstoricForm_Load(object sender, EventArgs e)
        {
            this.tranzactiiTableAdapter.Connection = connDest;
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void tranzactiiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tranzactiiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.borderuriDBDataSet);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            /* int nrBorderouI = 0;
             if (TextBoxINrBorderou.Text != "" && !Int32.TryParse(TextBoxINrBorderou.Text, out nrBorderouI))
             {
                 MessageBox.Show("ATENTIE! Nr. Borderou trebuie sa contina doar cifre.");
                 return;
             }*/

            connDest.Open();
            if (TextBoxINrBorderou.Text == "" && TextBoxNumePren.Text == "")
            {

                tranzactiiTableAdapter.FillByData(borderuriDBDataSet.Tranzactii, DateTimeFrom.Text, metroDateTime2.Text);

            }
            else if (TextBoxINrBorderou.Text != "")
            {
                tranzactiiTableAdapter.FillByNrBorderou(borderuriDBDataSet.Tranzactii, Int32.Parse(TextBoxINrBorderou.Text));
                TextBoxINrBorderou.Text = "";
            }
            else
            {
                tranzactiiTableAdapter.FillByNume(borderuriDBDataSet.Tranzactii, TextBoxNumePren.Text);
                TextBoxNumePren.Text = "";
            }
            connDest.Close();
        }
    }
}
