using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Borderouri
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string filename = "";
        public Form1()
        {
            InitializeComponent();

        }
        OleDbConnection connSursa = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =X:\\DATABASE\\7\\salarii.mdb");
        SqlConnection connDest = new SqlConnection("Data Source=10.15.60.23;Initial Catalog=borderuriDB;Persist Security Info=True;User ID=sa;Password=22043Nicu");
        SqlConnection connDestforImport = new SqlConnection("Data Source=10.15.60.23;Initial Catalog=borderuriDB;Persist Security Info=True;User ID=sa;Password=22043Nicu");

        private void Form1_Load(object sender, EventArgs e)
        {

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "D:\\mapDrive.bat";
            proc.Start();


            this.pERSTableAdapter.Connection = connSursa;
            this.personalTableAdapter.Connection = connDest;
            this.tranzactiiTableAdapter.Connection = connDest;
            this.getExcelTableTableAdapter.Connection = connDest;
            this.emailsTableAdapter.Connection = connDest;

            //initializari progress bar
            ProgressBarImport.Visible = false;
            labelImport2.Visible = false;
            LabelImport.Visible = false;


            //initializari
            borderuriDBDataSet.Tranzactii.DataTranzColumn.DefaultValue = DateTimeBorderou.Value;
            metroGrid1.Enabled = false;

            CultureInfo ci = new CultureInfo("ro-RO");
            metroTextBoxExplicatii.Text = "BORDEROU Drepturi Salariale " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DateTime.Now.ToString("MMMM", ci)) + " " + DateTime.Now.ToString("yyyy");
            TextBoxTotal.Enabled = false;
            TextBoxNrBorderou.Enabled = false;


            //autofit combo box

        }

        //////////IMPORTAREA DATELOR pe thread separat
        private void ThreadImport()
        {
            ImportData();
        }

        public delegate void updatebar();

        private void UpdateProgress()
        {
            if (ProgressBarImport.Maximum - 1 == ProgressBarImport.Value)
            {
                ProgressBarImport.Visible = false;
                LabelImport.Visible = false;
                labelImport2.Visible = false;
                metroGrid1.Enabled = true;

            }
            else
            {
                ProgressBarImport.Value += 1;

                // Here we are just updating a label to show the progressbar value
                LabelImport.Text = Convert.ToString(Convert.ToInt64(LabelImport.Text) + 1);
            }


        }

        public delegate void updatebar2(int max);

        private void SetMax(int maxValue)
        {
            ProgressBarImport.Maximum = maxValue;
        }
        ////////////////////////////////////////////////


        private void TextBoxNrBorderou_Leave(object sender, EventArgs e)
        {
            //verificare nr borderou sa fie int
            int nrBorderou = 0;
            if (TextBoxNrBorderou.Text != "" && !Int32.TryParse(TextBoxNrBorderou.Text, out nrBorderou))
            {
                MessageBox.Show("ATENTIE! Nr borderou trebuie sa contine doar cifre!");
                return;
            }

            //pune nr borderou  = textbox nr borderou pentru liniile noi
            if (TextBoxNrBorderou.Text != "")
            {
                borderuriDBDataSet.Tranzactii.NrBorderouColumn.DefaultValue = TextBoxNrBorderou.Text;
                if (tranzactiiBindingSource.Position < 0)
                    return;

                //incarca in gridView coloana cu NrBorderou
                foreach (DataRowView item in tranzactiiBindingSource)
                {
                    borderuriDBDataSet.TranzactiiRow tr = (item).Row as borderuriDBDataSet.TranzactiiRow;
                    tr.NrBorderou = Int32.Parse(nrBorderou.ToString());
                }
            }
        }

        private void metroGrid1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            double total = 0;
            foreach (DataRowView item in tranzactiiBindingSource)
            {
                borderuriDBDataSet.TranzactiiRow tr = (item).Row as borderuriDBDataSet.TranzactiiRow;
                if (!tr.IsSumaNull())
                    total += tr.Suma;

            }
            TextBoxTotal.Text = total.ToString();
        }

        private void metroButtonCreaza_Click(object sender, EventArgs e)
        {
            //creare director
            string date = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
            CreateDirectory(date);
            filename = "D:\\Borderouri\\" + date + "\\" + TextBoxNrBorderou.Text + labelBanca.Text;

            connDest.Open();

            //ADAUGARE DATE IN BAZA de date si in FISIER
            tranzactiiTableAdapter.Update(borderuriDBDataSet.Tranzactii);
            this.getExcelTableTableAdapter.Fill(borderuriDBDataSet.getExcelTable, TextBoxNrBorderou.Text);
            if (labelBanca.Text == "BancPost")
            {
                filename += ".txt";
                ExportTxt(metroTextBoxExplicatii.Text, filename);

            }

            else
            {
                if (labelBanca.Text == "Banca Transilvania")
                    ExportExcel(metroTextBoxExplicatii.Text, filename);
                else ExportExcelBCR(metroTextBoxExplicatii.Text, filename);

            }

            //inchide conn
            connDest.Close();
        }

        private void ExportTxt(string titlu, string path)
        {
            string txtFile = "";
            int j = 0;


            foreach (DataRowView item in getExcelTableBindingSource)
            {
                borderuriDBDataSet.getExcelTableRow row = (item).Row as borderuriDBDataSet.getExcelTableRow;
                if (row.SALARIAT.Length > 19)
                {
                    txtFile += "\"" + row.SALARIAT.Substring(0, 19) + "\" ";
                }
                else
                {
                    txtFile += "\"" + row.SALARIAT.PadRight(19) + "\" ";
                }

                txtFile += "\"" + row.CNP.PadRight(16) + "\" ";
                txtFile += "\"" + row.IBAN.PadRight(24) + "\" ";
                txtFile += "\"" + row.SUMA.ToString().PadLeft(12).Replace('.', ',') + "\"";
                txtFile += Environment.NewLine;
                j++;
            }
            txtFile += "\"Nr.inregistrari    " + "\" \"" + j.ToString().PadRight(16) + "\" ";
            txtFile += "\"TOTAL                   \" " + "\"" + TextBoxTotal.Text.PadLeft(12).Replace('.', ',') + "\"";
            txtFile += Environment.NewLine;
            txtFile += Environment.NewLine;
            txtFile += "\t\t\t\tManager Economic";
            txtFile += Environment.NewLine;
            txtFile += "\t\t\t      Marginean Alexandru";

            File.WriteAllText(path, txtFile);

            // Open the file to read from. 
            Process.Start("notepad.exe", path);

        }
        private void ExportExcel(string titlu, string filename)
        {

            Microsoft.Office.Interop.Excel.Application oXL = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
            Microsoft.Office.Interop.Excel._Worksheet oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

            oSheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;

            //diable alerts
            oXL.DisplayAlerts = false;

            //antet
            oSheet.Cells[1, 1] = "TRIBUNALUL CLUJ";
            oSheet.Cells[1, 1].EntireRow.Font.Bold = true;
            oSheet.Cells[2, 1] = "NR." + TextBoxNrBorderou.Text + "/" + DateTimeBorderou.Value.Day + '.' + DateTimeBorderou.Value.Month + '.' + DateTimeBorderou.Value.Year;
            oSheet.Cells[2, 1].EntireRow.Font.Bold = true;
            //titlu
            Microsoft.Office.Interop.Excel.Range title = oSheet.get_Range("A4", "E4");
            title.EntireColumn.AutoFit();
            title.Value2 = titlu;
            title.Font.Bold = true;
            title.MergeCells = true;
            title.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            //adaugare header tabel
            oSheet.Cells[6, 1] = "SALARIAT";
            oSheet.Cells[6, 2] = "IBAN";
            oSheet.Cells[6, 3] = "CNP";
            oSheet.Cells[6, 4] = "SUMA";
            oSheet.Cells[6, 5] = "EXPL";

            //adaugare date in tabel
            int j = 7;

            foreach (DataRowView item in getExcelTableBindingSource)
            {
                borderuriDBDataSet.getExcelTableRow row = (item).Row as borderuriDBDataSet.getExcelTableRow;
                oSheet.Cells[j, 1] = row.SALARIAT;
                oSheet.Cells[j, 2] = row.IBAN;
                oSheet.Cells[j, 3] = row.CNP;
                oSheet.Cells[j, 4] = row.SUMA;
                oSheet.Cells[j, 5] = titlu.Replace("BORDEROU ", "");
                j++;
            }

            //celula suma
            oSheet.Cells[j, 4] = TextBoxTotal.Text;
            oSheet.Cells[j, 4].EntireRow.Font.Bold = true;
            oSheet.Cells[j + 2, 3] = " Manager Economic";
            oSheet.Cells[j + 2, 3].EntireRow.Font.Bold = true;
            oSheet.Cells[j + 3, 3] = "Marginean Alexandru";
            oSheet.Cells[j + 3, 3].EntireRow.Font.Bold = true;

            //formatare coloana cnp
            Microsoft.Office.Interop.Excel.Range cnpRange = oSheet.get_Range("C7", "C" + (j - 1));
            cnpRange.NumberFormat = "#";


            //adaugare borders in tabelul excel
            Microsoft.Office.Interop.Excel.Range tabelRange = oSheet.get_Range("A6", "E" + (j - 1));
            AllBorders(tabelRange.Borders);

            //autofit columns
            oSheet.Columns.AutoFit();

            //formatare coloana suma
            Microsoft.Office.Interop.Excel.Range sumaRange = oSheet.get_Range("D7", "D" + (j));
            sumaRange.NumberFormat = "#,##0.00";
            sumaRange.ColumnWidth = 18;


            //formatare coloana SALARIAT
            Microsoft.Office.Interop.Excel.Range salariatRange = oSheet.get_Range("A7", "A" + (j - 1));
            salariatRange.ColumnWidth = 30;

            //salvare excel
            oWB.SaveAs(filename + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //oWB.Close(false, Type.Missing, Type.Missing);
            oXL.Visible = true;


        }

        private void ExportExcelBCR(string titlu, string filename)
        {

            Microsoft.Office.Interop.Excel.Application oXL = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
            Microsoft.Office.Interop.Excel._Worksheet oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

            oSheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;

            //diable alerts
            oXL.DisplayAlerts = false;

            //adaugare header tabel
            oSheet.Cells[1, 1] = "Numa";
            oSheet.Cells[1, 2] = "Prenume";
            oSheet.Cells[1, 3] = "CNP";
            oSheet.Cells[1, 4] = "IBAN";
            oSheet.Cells[1, 5] = "suma";
            oSheet.Cells[1, 6] = "explicatii";

            //adaugare date in tabel
            int j = 2;

            foreach (DataRowView item in getExcelTableBindingSource)
            {
                borderuriDBDataSet.getExcelTableRow row = (item).Row as borderuriDBDataSet.getExcelTableRow;
                oSheet.Cells[j, 1] = row.SALARIAT.Split(' ')[0];
                oSheet.Cells[j, 2] = row.SALARIAT.Substring(row.SALARIAT.IndexOf(' ') + 1, row.SALARIAT.Length - row.SALARIAT.IndexOf(' ') - 1);
                oSheet.Cells[j, 4] = row.IBAN;
                oSheet.Cells[j, 3] = row.CNP;
                oSheet.Cells[j, 5] = row.SUMA;
                oSheet.Cells[j, 6] = titlu.Replace("BORDEROU ", "");
                j++;
            }

            //formatare coloana cnp
            Microsoft.Office.Interop.Excel.Range cnpRange = oSheet.get_Range("C2", "C" + (j - 1));
            cnpRange.NumberFormat = "#";


            //adaugare borders in tabelul excel
            Microsoft.Office.Interop.Excel.Range tabelRange = oSheet.get_Range("A1", "F" + (j - 1));
            AllBorders(tabelRange.Borders);

            //autofit columns
            oSheet.Columns.AutoFit();

            //formatare coloana suma
            Microsoft.Office.Interop.Excel.Range sumaRange = oSheet.get_Range("E2", "E" + (j));
            sumaRange.NumberFormat = "#,##0.00";
            sumaRange.ColumnWidth = 13;


            //formatare coloana SALARIAT
            Microsoft.Office.Interop.Excel.Range salariatRange = oSheet.get_Range("A2", "A" + (j - 1));
            salariatRange.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range salariatRange1 = oSheet.get_Range("B2", "B" + (j - 1));
            salariatRange1.ColumnWidth = 20;

            //salvare excel
            oWB.SaveAs(filename + ".xls", oWB, oWB, oWB, oWB, oWB, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, oWB, oWB, oWB, oWB);
            oXL.Visible = true;


        }
        private void AllBorders(Microsoft.Office.Interop.Excel.Borders _borders)
        {
            _borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            _borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            _borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            _borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            _borders.Color = Color.Black;
        }

        //creaza directorul cu data de azi daca acesta nu este creat
        public void CreateDirectory(string dirName)
        {
            string path = @"D:\Borderouri\" + dirName;
            if (Directory.Exists(path))
                return;

            DirectoryInfo di = Directory.CreateDirectory(path);
        }
        private void DateTimeBorderou_Leave(object sender, EventArgs e)
        {
            borderuriDBDataSet.Tranzactii.DataTranzColumn.DefaultValue = DateTimeBorderou.Value;
            if (tranzactiiBindingSource.Position < 0)
                return;

            foreach (DataRowView item in tranzactiiBindingSource)
            {
                borderuriDBDataSet.TranzactiiRow tr = (item).Row as borderuriDBDataSet.TranzactiiRow;
                tr.DataTranz = DateTimeBorderou.Value;
            }


        }

        private void transilvaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connDest.State == ConnectionState.Closed)
                connDest.Open();
            labelBanca.Text = "Banca Transilvania";
            TextBoxNrBorderou.Enabled = true;
            personalTableAdapter.FillByBT(borderuriDBDataSet.Personal);


            //NrBorderou default  = ultimul nr +1
            if (tranzactiiTableAdapter.GetMaxBorderou() == null)
                TextBoxNrBorderou.Text = "1";
            else TextBoxNrBorderou.Text = tranzactiiTableAdapter.GetMaxBorderou().ToString();
            //incarca tabelul tranzactii cu tranzactiile care au nr borderou x si sund din anul y
            this.tranzactiiTableAdapter.FillByNrBorderouYear(borderuriDBDataSet.Tranzactii, Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year);
            //pune nr borderou  = textbox nr borderou pentru liniile noi
            borderuriDBDataSet.Tranzactii.NrBorderouColumn.DefaultValue = TextBoxNrBorderou.Text;

            //gridView editabil
            metroGrid1.Enabled = true;
            TextBoxTotal.Text = "";

            connDest.Close();
        }

        private void bancPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connDest.State == ConnectionState.Closed)
                connDest.Open();
            labelBanca.Text = "BancPost";
            TextBoxNrBorderou.Enabled = true;
            personalTableAdapter.FillByBancPost(borderuriDBDataSet.Personal);

            //NrBorderou default  = ultimul nr +1
            if (tranzactiiTableAdapter.GetMaxBorderou() == null)
                TextBoxNrBorderou.Text = "1";
            else TextBoxNrBorderou.Text = tranzactiiTableAdapter.GetMaxBorderou().ToString();


            //incarca tabelul tranzactii cu tranzactiile care au nr borderou x si sund din anul y
            this.tranzactiiTableAdapter.FillByNrBorderouYear(borderuriDBDataSet.Tranzactii, Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year);
            //pune nr borderou  = textbox nr borderou pentru liniile noi
            borderuriDBDataSet.Tranzactii.NrBorderouColumn.DefaultValue = TextBoxNrBorderou.Text;

            //gridview editabil
            metroGrid1.Enabled = true;
            TextBoxTotal.Text = "";

            connDest.Close();
        }

        private void ImportData()
        {

            //deschide conexiunea si incarca datele in tabelul local personal 
            connDestforImport.Open();
            this.personalTableAdapter.Connection = connDestforImport;
            this.personalTableAdapter.FillByNumePrenume(this.borderuriDBDataSet.Personal);



            //deschide conexiunea si incarca datele in PERS + inchide conn
            if (connSursa.State == ConnectionState.Closed)
                connSursa.Open();
            pERSTableAdapter.FillLatest(salariiDataSet.PERS);
            connSursa.Close();

            //seteaza valuarea maxima a progressBar-ului
            ProgressBarImport.Invoke(new updatebar2(SetMax), new object[] { salariiDataSet.PERS.Count });

            DataRow[] foundRows;
            foreach (DataRowView item in pERSBindingSource)
            {

                salariiDataSet.PERSRow tr = (item).Row as salariiDataSet.PERSRow;

                foundRows = borderuriDBDataSet.Personal.Select("IBAN = '" + tr.CONT_BANCA + "'");
                if (foundRows.Length != 0)
                {
                    if (Int32.Parse(foundRows[0][3].ToString()) == Int32.Parse(tr.MARCA))
                    {
                        if (foundRows[0][1].ToString() != tr.CNP)
                        {

                            personalTableAdapter.Delete(foundRows[0][0].ToString(), foundRows[0][1].ToString(), foundRows[0][2].ToString(), Int32.Parse(foundRows[0][3].ToString()));
                            borderuriDBDataSet.Personal.RemovePersonalRow(foundRows[0] as borderuriDBDataSet.PersonalRow);
                            borderuriDBDataSet.Personal.AddPersonalRow(tr.NUME + ' ' + tr.PRENUME, tr.CNP, tr.CONT_BANCA, Int32.Parse(tr.MARCA));
                        }
                        else if (foundRows[0][0].ToString() != (tr.NUME + " " + tr.PRENUME))
                        {
                            personalTableAdapter.Delete(foundRows[0][0].ToString(), foundRows[0][1].ToString(), foundRows[0][2].ToString(), Int32.Parse(foundRows[0][3].ToString()));
                            borderuriDBDataSet.Personal.RemovePersonalRow(foundRows[0] as borderuriDBDataSet.PersonalRow);
                            borderuriDBDataSet.Personal.AddPersonalRow(tr.NUME + ' ' + tr.PRENUME, tr.CNP, tr.CONT_BANCA, Int32.Parse(tr.MARCA));

                        }
                    }
                    else
                    {
                        personalTableAdapter.Delete(foundRows[0][0].ToString(), foundRows[0][1].ToString(), foundRows[0][2].ToString(), Int32.Parse(foundRows[0][3].ToString()));
                        borderuriDBDataSet.Personal.RemovePersonalRow(foundRows[0] as borderuriDBDataSet.PersonalRow);
                        borderuriDBDataSet.Personal.AddPersonalRow(tr.NUME + ' ' + tr.PRENUME, tr.CNP, tr.CONT_BANCA, Int32.Parse(tr.MARCA));
                    }

                }
                else
                    borderuriDBDataSet.Personal.AddPersonalRow(tr.NUME + ' ' + tr.PRENUME, tr.CNP, tr.CONT_BANCA, Int32.Parse(tr.MARCA));

                ProgressBarImport.Invoke(new updatebar(this.UpdateProgress));
            }
            // updateaza tabelul + inchide conn

            personalTableAdapter.Update(borderuriDBDataSet.Personal);
            connDestforImport.Close();

            connDest.Open();
            if (labelBanca.Text == "Banca Transilvania")
                personalTableAdapter.FillByBT(borderuriDBDataSet.Personal);
            else if (labelBanca.Text == "BancPost")
                personalTableAdapter.FillByBancPost(borderuriDBDataSet.Personal);
            else if (labelBanca.Text == "BCR")
                personalTableAdapter.FillByBCR(borderuriDBDataSet.Personal);
            connDest.Close();

        }

        private void adaugaEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmailForm mailForm = new AddEmailForm(this);
            mailForm.WindowState = FormWindowState.Normal;
            mailForm.Show();
        }


        private void ComboBoxEmailAdresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxEmailAdresses.SelectedItem != null)
            {
                TrimitereEmail trEmail = new TrimitereEmail(this, ComboBoxEmailAdresses.SelectedItem.ToString(), filename, TextBoxNrBorderou.Text + "/" + DateTimeBorderou.Value.Day.ToString() + '-' + DateTimeBorderou.Value.Month.ToString() + '-' + DateTimeBorderou.Value.Year.ToString());
                trEmail.WindowState = FormWindowState.Normal;
                trEmail.Show();
            }

        }


        private void metroTextBoxExplicatii_TextChanged(object sender, EventArgs e)
        {
            metroTextBoxExplicatii.ForeColor = Color.Blue;
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IstoricForm istoricForm = new IstoricForm(this);
            istoricForm.WindowState = FormWindowState.Normal;
            istoricForm.Show();
        }

        private void bCRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connDest.State == ConnectionState.Closed)
                connDest.Open();
            labelBanca.Text = "BCR";
            TextBoxNrBorderou.Enabled = true;
            personalTableAdapter.FillByBCR(borderuriDBDataSet.Personal);

            //NrBorderou default  = ultimul nr +1
            if (tranzactiiTableAdapter.GetMaxBorderou() == null)
                TextBoxNrBorderou.Text = "1";
            else TextBoxNrBorderou.Text = tranzactiiTableAdapter.GetMaxBorderou().ToString();

            //incarca tabelul tranzactii cu tranzactiile care au nr borderou x si sund din anul y
            this.tranzactiiTableAdapter.FillByNrBorderouYear(borderuriDBDataSet.Tranzactii, Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year);
            //pune nr borderou  = textbox nr borderou pentru liniile noi
            borderuriDBDataSet.Tranzactii.NrBorderouColumn.DefaultValue = TextBoxNrBorderou.Text;

            //gridview editabil
            metroGrid1.Enabled = true;
            TextBoxTotal.Text = "";

            connDest.Close();
        }

        private void bANCAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //initializari progress bar
            ProgressBarImport.Visible = true;
            labelImport2.Visible = true;
            LabelImport.Visible = true;
            metroGrid1.Enabled = false;


            ///////////importa datele din access to sql///////
            ThreadStart tid1 = new ThreadStart(ThreadImport);
            Thread startprogress = new Thread(tid1);

            // Start the execution
            startprogress.Start();
            /////////////////////////////////////////////////
        }

        private void trimiteLaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            ComboBoxEmailAdresses.Items.Clear();
            //combobox Menu - NETERMINATA
            connDest.Open();
            emailsTableAdapter.Fill(borderuriDBDataSet.Emails);
            connDest.Close();
            foreach (DataRowView item in emailsBindingSource)
            {
                borderuriDBDataSet.EmailsRow tr = (item).Row as borderuriDBDataSet.EmailsRow;
                ComboBoxEmailAdresses.Items.Add(tr.EmailAddress);
            }
        }

        private void stergeEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StergeEmail delmailForm = new StergeEmail(this);
            delmailForm.WindowState = FormWindowState.Normal;
            delmailForm.Show();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void TextBoxNrBorderou_KeyUp(object sender, KeyEventArgs e)
        {
            string banca = "";
            if (labelBanca.Text == "Banca Transilvania")
                banca = "BTRL";
            else if (labelBanca.Text == "BancPost")
                banca = "BPOS";
            else banca = "RNCB";

            connDest.Open();
            //incarca tabelul tranzactii cu tranzactiile care au nr borderou x si sund din anul y
            if (TextBoxNrBorderou.Text != "")
            {
                if (this.tranzactiiTableAdapter.GetBanca(Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year) != null && this.tranzactiiTableAdapter.GetBanca(Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year).Equals(banca))
                {
                    this.tranzactiiTableAdapter.FillByNrBorderouYear(borderuriDBDataSet.Tranzactii, Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year);
                    DateTimeBorderou.Value = (DateTime)tranzactiiTableAdapter.GetDataTranz(Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year);
                }
                else if (this.tranzactiiTableAdapter.GetBanca(Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year) == null)
                {
                    this.tranzactiiTableAdapter.FillByNrBorderouYear(borderuriDBDataSet.Tranzactii, Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year);
                    //DateTimeBorderou.Value = DateTime.Now;

                }

            }
            connDest.Close();
        }

        private void metroGrid1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void metroGrid1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Int32 rowToDelete = metroGrid1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                if (rowToDelete != -1)
                {
                    metroGrid1.Rows.RemoveAt(rowToDelete);
                    metroGrid1.ClearSelection();
                }

            }
        }

        private void DateTimeBorderou_MouseDown(object sender, MouseEventArgs e)
        {
            string banca = "";
            if (labelBanca.Text == "Banca Transilvania")
                banca = "BTRL";
            else if (labelBanca.Text == "BancPost")
                banca = "BPOS";
            else banca = "RNCB";

            connDest.Open();
            //incarca tabelul tranzactii cu tranzactiile care au nr borderou x si sund din anul y
            if (DateTimeBorderou.Value.Year != DateTime.Now.Year && TextBoxNrBorderou.Text != "")
            {
                if (this.tranzactiiTableAdapter.GetBanca(Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year) != null && this.tranzactiiTableAdapter.GetBanca(Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year).Equals(banca))
                {
                    this.tranzactiiTableAdapter.FillByNrBorderouYear(borderuriDBDataSet.Tranzactii, Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year);
                    DateTimeBorderou.Value = (DateTime)tranzactiiTableAdapter.GetDataTranz(Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year);
                }
                else if (this.tranzactiiTableAdapter.GetBanca(Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year) == null)
                {
                    this.tranzactiiTableAdapter.FillByNrBorderouYear(borderuriDBDataSet.Tranzactii, Int32.Parse(TextBoxNrBorderou.Text), DateTimeBorderou.Value.Year);
                    DateTimeBorderou.Value = DateTime.Now;

                }

            }
            connDest.Close();
        }
    }
}
