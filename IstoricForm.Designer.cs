namespace Borderouri
{
    partial class IstoricForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBoxINrBorderou = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DateTimeFrom = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tranzactiiDataGridView = new System.Windows.Forms.DataGridView();
            this.tranzactiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borderuriDBDataSet = new Borderouri.borderuriDBDataSet();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.LabelNumePrenume = new MetroFramework.Controls.MetroLabel();
            this.TextBoxNumePren = new MetroFramework.Controls.MetroTextBox();
            this.tranzactiiTableAdapter = new Borderouri.borderuriDBDataSetTableAdapters.TranzactiiTableAdapter();
            this.tableAdapterManager = new Borderouri.borderuriDBDataSetTableAdapters.TableAdapterManager();
            this.borderuriDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTranzactieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrBorderouDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numePrenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTranzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tranzactiiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tranzactiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderuriDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderuriDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxINrBorderou
            // 
            // 
            // 
            // 
            this.TextBoxINrBorderou.CustomButton.Image = null;
            this.TextBoxINrBorderou.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.TextBoxINrBorderou.CustomButton.Name = "";
            this.TextBoxINrBorderou.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxINrBorderou.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxINrBorderou.CustomButton.TabIndex = 1;
            this.TextBoxINrBorderou.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxINrBorderou.CustomButton.UseSelectable = true;
            this.TextBoxINrBorderou.CustomButton.Visible = false;
            this.TextBoxINrBorderou.Lines = new string[0];
            this.TextBoxINrBorderou.Location = new System.Drawing.Point(188, 62);
            this.TextBoxINrBorderou.MaxLength = 32767;
            this.TextBoxINrBorderou.Name = "TextBoxINrBorderou";
            this.TextBoxINrBorderou.PasswordChar = '\0';
            this.TextBoxINrBorderou.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxINrBorderou.SelectedText = "";
            this.TextBoxINrBorderou.SelectionLength = 0;
            this.TextBoxINrBorderou.SelectionStart = 0;
            this.TextBoxINrBorderou.Size = new System.Drawing.Size(98, 23);
            this.TextBoxINrBorderou.TabIndex = 1;
            this.TextBoxINrBorderou.UseSelectable = true;
            this.TextBoxINrBorderou.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxINrBorderou.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxINrBorderou.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(97, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nr. Borderou";
            // 
            // DateTimeFrom
            // 
            this.DateTimeFrom.Location = new System.Drawing.Point(188, 114);
            this.DateTimeFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimeFrom.Name = "DateTimeFrom";
            this.DateTimeFrom.Size = new System.Drawing.Size(223, 29);
            this.DateTimeFrom.TabIndex = 3;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(432, 114);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(238, 29);
            this.metroDateTime2.TabIndex = 4;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(75, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Alegeti perioada";
            // 
            // tranzactiiDataGridView
            // 
            this.tranzactiiDataGridView.AllowUserToAddRows = false;
            this.tranzactiiDataGridView.AllowUserToDeleteRows = false;
            this.tranzactiiDataGridView.AutoGenerateColumns = false;
            this.tranzactiiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tranzactiiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTranzactieDataGridViewTextBoxColumn,
            this.nrBorderouDataGridViewTextBoxColumn,
            this.numePrenumeDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn,
            this.dataTranzDataGridViewTextBoxColumn,
            this.iBANDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn});
            this.tranzactiiDataGridView.DataSource = this.tranzactiiBindingSource;
            this.tranzactiiDataGridView.Location = new System.Drawing.Point(0, 196);
            this.tranzactiiDataGridView.Name = "tranzactiiDataGridView";
            this.tranzactiiDataGridView.ReadOnly = true;
            this.tranzactiiDataGridView.Size = new System.Drawing.Size(706, 322);
            this.tranzactiiDataGridView.TabIndex = 7;
            // 
            // tranzactiiBindingSource
            // 
            this.tranzactiiBindingSource.DataMember = "Tranzactii";
            this.tranzactiiBindingSource.DataSource = this.borderuriDBDataSet;
            // 
            // borderuriDBDataSet
            // 
            this.borderuriDBDataSet.DataSetName = "borderuriDBDataSet";
            this.borderuriDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroButton1
            // 
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroButton1.Location = new System.Drawing.Point(291, 149);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 29);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Cauta";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // LabelNumePrenume
            // 
            this.LabelNumePrenume.AutoSize = true;
            this.LabelNumePrenume.Location = new System.Drawing.Point(323, 66);
            this.LabelNumePrenume.Name = "LabelNumePrenume";
            this.LabelNumePrenume.Size = new System.Drawing.Size(102, 19);
            this.LabelNumePrenume.TabIndex = 9;
            this.LabelNumePrenume.Text = "Nume Prenume";
            // 
            // TextBoxNumePren
            // 
            // 
            // 
            // 
            this.TextBoxNumePren.CustomButton.Image = null;
            this.TextBoxNumePren.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.TextBoxNumePren.CustomButton.Name = "";
            this.TextBoxNumePren.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxNumePren.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxNumePren.CustomButton.TabIndex = 1;
            this.TextBoxNumePren.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxNumePren.CustomButton.UseSelectable = true;
            this.TextBoxNumePren.CustomButton.Visible = false;
            this.TextBoxNumePren.Lines = new string[0];
            this.TextBoxNumePren.Location = new System.Drawing.Point(432, 61);
            this.TextBoxNumePren.MaxLength = 32767;
            this.TextBoxNumePren.Name = "TextBoxNumePren";
            this.TextBoxNumePren.PasswordChar = '\0';
            this.TextBoxNumePren.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxNumePren.SelectedText = "";
            this.TextBoxNumePren.SelectionLength = 0;
            this.TextBoxNumePren.SelectionStart = 0;
            this.TextBoxNumePren.Size = new System.Drawing.Size(238, 23);
            this.TextBoxNumePren.TabIndex = 10;
            this.TextBoxNumePren.UseSelectable = true;
            this.TextBoxNumePren.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxNumePren.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tranzactiiTableAdapter
            // 
            this.tranzactiiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmailsTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = null;
            this.tableAdapterManager.TranzactiiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Borderouri.borderuriDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // borderuriDBDataSetBindingSource
            // 
            this.borderuriDBDataSetBindingSource.DataSource = this.borderuriDBDataSet;
            this.borderuriDBDataSetBindingSource.Position = 0;
            // 
            // idTranzactieDataGridViewTextBoxColumn
            // 
            this.idTranzactieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idTranzactieDataGridViewTextBoxColumn.DataPropertyName = "IdTranzactie";
            this.idTranzactieDataGridViewTextBoxColumn.HeaderText = "IdTranzactie";
            this.idTranzactieDataGridViewTextBoxColumn.Name = "idTranzactieDataGridViewTextBoxColumn";
            this.idTranzactieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTranzactieDataGridViewTextBoxColumn.Visible = false;
            this.idTranzactieDataGridViewTextBoxColumn.Width = 91;
            // 
            // nrBorderouDataGridViewTextBoxColumn
            // 
            this.nrBorderouDataGridViewTextBoxColumn.DataPropertyName = "NrBorderou";
            this.nrBorderouDataGridViewTextBoxColumn.HeaderText = "NrBorderou";
            this.nrBorderouDataGridViewTextBoxColumn.Name = "nrBorderouDataGridViewTextBoxColumn";
            this.nrBorderouDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numePrenumeDataGridViewTextBoxColumn
            // 
            this.numePrenumeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numePrenumeDataGridViewTextBoxColumn.DataPropertyName = "NumePrenume";
            this.numePrenumeDataGridViewTextBoxColumn.HeaderText = "NumePrenume";
            this.numePrenumeDataGridViewTextBoxColumn.Name = "numePrenumeDataGridViewTextBoxColumn";
            this.numePrenumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numePrenumeDataGridViewTextBoxColumn.Width = 102;
            // 
            // sumaDataGridViewTextBoxColumn
            // 
            this.sumaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sumaDataGridViewTextBoxColumn.DataPropertyName = "Suma";
            this.sumaDataGridViewTextBoxColumn.HeaderText = "Suma";
            this.sumaDataGridViewTextBoxColumn.Name = "sumaDataGridViewTextBoxColumn";
            this.sumaDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumaDataGridViewTextBoxColumn.Width = 59;
            // 
            // dataTranzDataGridViewTextBoxColumn
            // 
            this.dataTranzDataGridViewTextBoxColumn.DataPropertyName = "DataTranz";
            this.dataTranzDataGridViewTextBoxColumn.HeaderText = "DataTranz";
            this.dataTranzDataGridViewTextBoxColumn.Name = "dataTranzDataGridViewTextBoxColumn";
            this.dataTranzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iBANDataGridViewTextBoxColumn
            // 
            this.iBANDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iBANDataGridViewTextBoxColumn.DataPropertyName = "IBAN";
            this.iBANDataGridViewTextBoxColumn.HeaderText = "IBAN";
            this.iBANDataGridViewTextBoxColumn.Name = "iBANDataGridViewTextBoxColumn";
            this.iBANDataGridViewTextBoxColumn.ReadOnly = true;
            this.iBANDataGridViewTextBoxColumn.Width = 57;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNPDataGridViewTextBoxColumn.Width = 54;
            // 
            // IstoricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 520);
            this.Controls.Add(this.TextBoxNumePren);
            this.Controls.Add(this.LabelNumePrenume);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tranzactiiDataGridView);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.DateTimeFrom);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TextBoxINrBorderou);
            this.Name = "IstoricForm";
            this.Text = "IstoricForm";
            this.Load += new System.EventHandler(this.IstoricForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tranzactiiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tranzactiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderuriDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderuriDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TextBoxINrBorderou;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime DateTimeFrom;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private borderuriDBDataSet borderuriDBDataSet;
        private System.Windows.Forms.BindingSource tranzactiiBindingSource;
        private borderuriDBDataSetTableAdapters.TranzactiiTableAdapter tranzactiiTableAdapter;
        private borderuriDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tranzactiiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel LabelNumePrenume;
        private MetroFramework.Controls.MetroTextBox TextBoxNumePren;
        private System.Windows.Forms.BindingSource borderuriDBDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTranzactieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrBorderouDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePrenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTranzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
    }
}