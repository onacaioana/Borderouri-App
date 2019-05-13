namespace Borderouri
{
    partial class StergeEmail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonSterge = new MetroFramework.Controls.MetroButton();
            this.emailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borderuriDBDataSet = new Borderouri.borderuriDBDataSet();
            this.emailsTableAdapter = new Borderouri.borderuriDBDataSetTableAdapters.EmailsTableAdapter();
            this.tableAdapterManager = new Borderouri.borderuriDBDataSetTableAdapters.TableAdapterManager();
            this.GridViewEmails = new MetroFramework.Controls.MetroGrid();
            this.iDEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.emailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderuriDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmails)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSterge
            // 
            this.ButtonSterge.Location = new System.Drawing.Point(123, 291);
            this.ButtonSterge.Name = "ButtonSterge";
            this.ButtonSterge.Size = new System.Drawing.Size(84, 33);
            this.ButtonSterge.TabIndex = 3;
            this.ButtonSterge.Text = "Sterge";
            this.ButtonSterge.UseSelectable = true;
            this.ButtonSterge.Click += new System.EventHandler(this.ButtonSterge_Click);
            // 
            // emailsBindingSource
            // 
            this.emailsBindingSource.DataMember = "Emails";
            this.emailsBindingSource.DataSource = this.borderuriDBDataSet;
            // 
            // borderuriDBDataSet
            // 
            this.borderuriDBDataSet.DataSetName = "borderuriDBDataSet";
            this.borderuriDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // GridViewEmails
            // 
            this.GridViewEmails.AllowUserToResizeRows = false;
            this.GridViewEmails.AutoGenerateColumns = false;
            this.GridViewEmails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridViewEmails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewEmails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridViewEmails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewEmails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewEmails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEmailDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.GridViewEmails.DataSource = this.emailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewEmails.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewEmails.EnableHeadersVisualStyles = false;
            this.GridViewEmails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridViewEmails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridViewEmails.Location = new System.Drawing.Point(0, 80);
            this.GridViewEmails.Name = "GridViewEmails";
            this.GridViewEmails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewEmails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewEmails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridViewEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewEmails.Size = new System.Drawing.Size(342, 150);
            this.GridViewEmails.TabIndex = 2;
            // 
            // iDEmailDataGridViewTextBoxColumn
            // 
            this.iDEmailDataGridViewTextBoxColumn.DataPropertyName = "IDEmail";
            this.iDEmailDataGridViewTextBoxColumn.HeaderText = "IDEmail";
            this.iDEmailDataGridViewTextBoxColumn.Name = "iDEmailDataGridViewTextBoxColumn";
            this.iDEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // StergeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 347);
            this.Controls.Add(this.ButtonSterge);
            this.Controls.Add(this.GridViewEmails);
            this.Name = "StergeEmail";
            this.Text = "StergeEmail";
            this.Load += new System.EventHandler(this.StergeEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderuriDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private borderuriDBDataSet borderuriDBDataSet;
        private System.Windows.Forms.BindingSource emailsBindingSource;
        private borderuriDBDataSetTableAdapters.EmailsTableAdapter emailsTableAdapter;
        private borderuriDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton ButtonSterge;
        private MetroFramework.Controls.MetroGrid GridViewEmails;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}