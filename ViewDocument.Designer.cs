namespace TravelerDetailsManagementSystem
{
    partial class ViewDocument
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
            this.tabcontrolViewDocuments = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvHRdocuments = new System.Windows.Forms.DataGridView();
            this.clm_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDownload = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvITdocuments = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvFIdocuments = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvPersondocuments = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabcontrolViewDocuments.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRdocuments)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvITdocuments)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFIdocuments)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersondocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrolViewDocuments
            // 
            this.tabcontrolViewDocuments.Controls.Add(this.tabPage1);
            this.tabcontrolViewDocuments.Controls.Add(this.tabPage2);
            this.tabcontrolViewDocuments.Controls.Add(this.tabPage3);
            this.tabcontrolViewDocuments.Controls.Add(this.tabPage4);
            this.tabcontrolViewDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrolViewDocuments.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontrolViewDocuments.Location = new System.Drawing.Point(0, 0);
            this.tabcontrolViewDocuments.Name = "tabcontrolViewDocuments";
            this.tabcontrolViewDocuments.SelectedIndex = 0;
            this.tabcontrolViewDocuments.Size = new System.Drawing.Size(1450, 573);
            this.tabcontrolViewDocuments.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvHRdocuments);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1442, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HR Documents";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvHRdocuments
            // 
            this.dgvHRdocuments.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvHRdocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHRdocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Name,
            this.clm_Description,
            this.clmDownload,
            this.clmDelete});
            this.dgvHRdocuments.Location = new System.Drawing.Point(61, 44);
            this.dgvHRdocuments.Name = "dgvHRdocuments";
            this.dgvHRdocuments.RowHeadersWidth = 51;
            this.dgvHRdocuments.RowTemplate.Height = 24;
            this.dgvHRdocuments.Size = new System.Drawing.Size(1321, 452);
            this.dgvHRdocuments.TabIndex = 0;
            // 
            // clm_Name
            // 
            this.clm_Name.DataPropertyName = "HrDocumentName";
            this.clm_Name.HeaderText = "Document Name";
            this.clm_Name.MinimumWidth = 6;
            this.clm_Name.Name = "clm_Name";
            this.clm_Name.Width = 350;
            // 
            // clm_Description
            // 
            this.clm_Description.DataPropertyName = "AboutHrDoc";
            this.clm_Description.HeaderText = "Document Description";
            this.clm_Description.MinimumWidth = 6;
            this.clm_Description.Name = "clm_Description";
            this.clm_Description.Width = 550;
            // 
            // clmDownload
            // 
            this.clmDownload.HeaderText = "Download";
            this.clmDownload.MinimumWidth = 6;
            this.clmDownload.Name = "clmDownload";
            this.clmDownload.Width = 125;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "Delete";
            this.clmDelete.MinimumWidth = 6;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.Width = 75;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvITdocuments);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1442, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IT Documents";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvITdocuments
            // 
            this.dgvITdocuments.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvITdocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvITdocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dgvITdocuments.Location = new System.Drawing.Point(61, 44);
            this.dgvITdocuments.Name = "dgvITdocuments";
            this.dgvITdocuments.RowHeadersWidth = 51;
            this.dgvITdocuments.RowTemplate.Height = 24;
            this.dgvITdocuments.Size = new System.Drawing.Size(1321, 452);
            this.dgvITdocuments.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvFIdocuments);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1442, 541);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Finance Documents";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvFIdocuments
            // 
            this.dgvFIdocuments.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvFIdocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFIdocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewButtonColumn3,
            this.dataGridViewButtonColumn4});
            this.dgvFIdocuments.Location = new System.Drawing.Point(61, 44);
            this.dgvFIdocuments.Name = "dgvFIdocuments";
            this.dgvFIdocuments.RowHeadersWidth = 51;
            this.dgvFIdocuments.RowTemplate.Height = 24;
            this.dgvFIdocuments.Size = new System.Drawing.Size(1321, 452);
            this.dgvFIdocuments.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvPersondocuments);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1442, 541);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Personal Documents";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvPersondocuments
            // 
            this.dgvPersondocuments.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPersondocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersondocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn5,
            this.dataGridViewButtonColumn6});
            this.dgvPersondocuments.Location = new System.Drawing.Point(61, 44);
            this.dgvPersondocuments.Name = "dgvPersondocuments";
            this.dgvPersondocuments.RowHeadersWidth = 51;
            this.dgvPersondocuments.RowTemplate.Height = 24;
            this.dgvPersondocuments.Size = new System.Drawing.Size(1321, 452);
            this.dgvPersondocuments.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItDocumentName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Document Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 350;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AboutItDoc";
            this.dataGridViewTextBoxColumn2.HeaderText = "Document Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 550;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Download";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Width = 125;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Delete";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FinanceDocumentName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Document Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 350;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AboutFinanceDoc";
            this.dataGridViewTextBoxColumn4.HeaderText = "Document Description";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 550;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "Download";
            this.dataGridViewButtonColumn3.MinimumWidth = 6;
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Width = 125;
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.HeaderText = "Delete";
            this.dataGridViewButtonColumn4.MinimumWidth = 6;
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            this.dataGridViewButtonColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PersonalDocumentName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Document Name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 350;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AboutPersonalDoc";
            this.dataGridViewTextBoxColumn6.HeaderText = "Document Description";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 550;
            // 
            // dataGridViewButtonColumn5
            // 
            this.dataGridViewButtonColumn5.HeaderText = "Download";
            this.dataGridViewButtonColumn5.MinimumWidth = 6;
            this.dataGridViewButtonColumn5.Name = "dataGridViewButtonColumn5";
            this.dataGridViewButtonColumn5.Width = 125;
            // 
            // dataGridViewButtonColumn6
            // 
            this.dataGridViewButtonColumn6.HeaderText = "Delete";
            this.dataGridViewButtonColumn6.MinimumWidth = 6;
            this.dataGridViewButtonColumn6.Name = "dataGridViewButtonColumn6";
            this.dataGridViewButtonColumn6.Width = 75;
            // 
            // ViewDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 573);
            this.ControlBox = false;
            this.Controls.Add(this.tabcontrolViewDocuments);
            this.Name = "ViewDocument";
            this.Text = "View Document";
            this.Load += new System.EventHandler(this.ViewDocument_Load);
            this.tabcontrolViewDocuments.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRdocuments)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvITdocuments)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFIdocuments)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersondocuments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrolViewDocuments;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvHRdocuments;
        private System.Windows.Forms.DataGridView dgvITdocuments;
        private System.Windows.Forms.DataGridView dgvFIdocuments;
        private System.Windows.Forms.DataGridView dgvPersondocuments;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Description;
        private System.Windows.Forms.DataGridViewButtonColumn clmDownload;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn6;
    }
}