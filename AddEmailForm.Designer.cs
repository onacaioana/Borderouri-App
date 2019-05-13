namespace Borderouri
{
    partial class AddEmailForm
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
            this.TextBoxMail = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxDetalii = new MetroFramework.Controls.MetroTextBox();
            this.LabelDetalii = new MetroFramework.Controls.MetroLabel();
            this.LabelMail = new MetroFramework.Controls.MetroLabel();
            this.ButtonSalveaza = new MetroFramework.Controls.MetroButton();
            this.borderuriDBDataSet = new Borderouri.borderuriDBDataSet();
            this.emailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailsTableAdapter = new Borderouri.borderuriDBDataSetTableAdapters.EmailsTableAdapter();
            this.tableAdapterManager = new Borderouri.borderuriDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.borderuriDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxMail
            // 
            // 
            // 
            // 
            this.TextBoxMail.CustomButton.Image = null;
            this.TextBoxMail.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TextBoxMail.CustomButton.Name = "";
            this.TextBoxMail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxMail.CustomButton.TabIndex = 1;
            this.TextBoxMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxMail.CustomButton.UseSelectable = true;
            this.TextBoxMail.CustomButton.Visible = false;
            this.TextBoxMail.Lines = new string[0];
            this.TextBoxMail.Location = new System.Drawing.Point(23, 135);
            this.TextBoxMail.MaxLength = 32767;
            this.TextBoxMail.Name = "TextBoxMail";
            this.TextBoxMail.PasswordChar = '\0';
            this.TextBoxMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxMail.SelectedText = "";
            this.TextBoxMail.SelectionLength = 0;
            this.TextBoxMail.SelectionStart = 0;
            this.TextBoxMail.Size = new System.Drawing.Size(212, 23);
            this.TextBoxMail.TabIndex = 0;
            this.TextBoxMail.UseSelectable = true;
            this.TextBoxMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxDetalii
            // 
            // 
            // 
            // 
            this.TextBoxDetalii.CustomButton.Image = null;
            this.TextBoxDetalii.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TextBoxDetalii.CustomButton.Name = "";
            this.TextBoxDetalii.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxDetalii.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxDetalii.CustomButton.TabIndex = 1;
            this.TextBoxDetalii.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxDetalii.CustomButton.UseSelectable = true;
            this.TextBoxDetalii.CustomButton.Visible = false;
            this.TextBoxDetalii.Lines = new string[0];
            this.TextBoxDetalii.Location = new System.Drawing.Point(23, 211);
            this.TextBoxDetalii.MaxLength = 32767;
            this.TextBoxDetalii.Name = "TextBoxDetalii";
            this.TextBoxDetalii.PasswordChar = '\0';
            this.TextBoxDetalii.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxDetalii.SelectedText = "";
            this.TextBoxDetalii.SelectionLength = 0;
            this.TextBoxDetalii.SelectionStart = 0;
            this.TextBoxDetalii.Size = new System.Drawing.Size(212, 23);
            this.TextBoxDetalii.TabIndex = 1;
            this.TextBoxDetalii.UseSelectable = true;
            this.TextBoxDetalii.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxDetalii.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LabelDetalii
            // 
            this.LabelDetalii.AutoSize = true;
            this.LabelDetalii.Location = new System.Drawing.Point(23, 189);
            this.LabelDetalii.Name = "LabelDetalii";
            this.LabelDetalii.Size = new System.Drawing.Size(212, 19);
            this.LabelDetalii.TabIndex = 2;
            this.LabelDetalii.Text = "Detalii adresa (ex: numele bancii) : ";
            // 
            // LabelMail
            // 
            this.LabelMail.AutoSize = true;
            this.LabelMail.Location = new System.Drawing.Point(23, 113);
            this.LabelMail.Name = "LabelMail";
            this.LabelMail.Size = new System.Drawing.Size(112, 19);
            this.LabelMail.TabIndex = 3;
            this.LabelMail.Text = "Adresa de email :";
            // 
            // ButtonSalveaza
            // 
            this.ButtonSalveaza.Location = new System.Drawing.Point(89, 281);
            this.ButtonSalveaza.Name = "ButtonSalveaza";
            this.ButtonSalveaza.Size = new System.Drawing.Size(75, 23);
            this.ButtonSalveaza.TabIndex = 4;
            this.ButtonSalveaza.Text = "Salveaza";
            this.ButtonSalveaza.UseSelectable = true;
            this.ButtonSalveaza.Click += new System.EventHandler(this.ButtonSalveaza_Click);
            // 
            // borderuriDBDataSet
            // 
            this.borderuriDBDataSet.DataSetName = "borderuriDBDataSet";
            this.borderuriDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailsBindingSource
            // 
            this.emailsBindingSource.DataMember = "Emails";
            this.emailsBindingSource.DataSource = this.borderuriDBDataSet;
            // 
            // emailsTableAdapter
            // 
            this.emailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmailsTableAdapter = this.emailsTableAdapter;
            this.tableAdapterManager.PersonalTableAdapter = null;
            this.tableAdapterManager.TranzactiiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Borderouri.borderuriDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AddEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 327);
            this.Controls.Add(this.ButtonSalveaza);
            this.Controls.Add(this.LabelMail);
            this.Controls.Add(this.LabelDetalii);
            this.Controls.Add(this.TextBoxDetalii);
            this.Controls.Add(this.TextBoxMail);
            this.Name = "AddEmailForm";
            this.Text = "Adaugare Email";
            this.TransparencyKey = System.Drawing.Color.AntiqueWhite;
            this.Load += new System.EventHandler(this.AddEmailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borderuriDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TextBoxMail;
        private MetroFramework.Controls.MetroTextBox TextBoxDetalii;
        private MetroFramework.Controls.MetroLabel LabelDetalii;
        private MetroFramework.Controls.MetroLabel LabelMail;
        private MetroFramework.Controls.MetroButton ButtonSalveaza;
        private borderuriDBDataSet borderuriDBDataSet;
        private System.Windows.Forms.BindingSource emailsBindingSource;
        private borderuriDBDataSetTableAdapters.EmailsTableAdapter emailsTableAdapter;
        private borderuriDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}