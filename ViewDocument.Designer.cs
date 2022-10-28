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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvITdocuments = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvFIdocuments = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvPersondocuments = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFiOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmFiDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmFinanceDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFinanceDocPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPersonalOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmPersonalDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmPersonalDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPersonalDocPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmItDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmItDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItDocPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHrDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHrDocPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHrOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmHrDelete = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.clmHrDocID,
            this.clm_Name,
            this.clm_Description,
            this.clmHrDocPath,
            this.clmHrOpen,
            this.clmHrDelete});
            this.dgvHRdocuments.Location = new System.Drawing.Point(61, 44);
            this.dgvHRdocuments.Name = "dgvHRdocuments";
            this.dgvHRdocuments.RowHeadersWidth = 51;
            this.dgvHRdocuments.RowTemplate.Height = 24;
            this.dgvHRdocuments.Size = new System.Drawing.Size(1321, 452);
            this.dgvHRdocuments.TabIndex = 0;
            this.dgvHRdocuments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHRdocuments_CellDoubleClick);
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
            this.clmItOpen,
            this.clmItDelete,
            this.clmItDocID,
            this.clmItDocPath});
            this.dgvITdocuments.Location = new System.Drawing.Point(61, 44);
            this.dgvITdocuments.Name = "dgvITdocuments";
            this.dgvITdocuments.RowHeadersWidth = 51;
            this.dgvITdocuments.RowTemplate.Height = 24;
            this.dgvITdocuments.Size = new System.Drawing.Size(1321, 452);
            this.dgvITdocuments.TabIndex = 1;
            this.dgvITdocuments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvITdocuments_CellMouseDoubleClick);
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
            this.clmFiOpen,
            this.clmFiDelete,
            this.clmFinanceDocID,
            this.clmFinanceDocPath});
            this.dgvFIdocuments.Location = new System.Drawing.Point(61, 44);
            this.dgvFIdocuments.Name = "dgvFIdocuments";
            this.dgvFIdocuments.RowHeadersWidth = 51;
            this.dgvFIdocuments.RowTemplate.Height = 24;
            this.dgvFIdocuments.Size = new System.Drawing.Size(1321, 452);
            this.dgvFIdocuments.TabIndex = 1;
            this.dgvFIdocuments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFIdocuments_CellMouseDoubleClick);
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
            this.clmPersonalOpen,
            this.clmPersonalDelete,
            this.clmPersonalDocID,
            this.clmPersonalDocPath});
            this.dgvPersondocuments.Location = new System.Drawing.Point(61, 44);
            this.dgvPersondocuments.Name = "dgvPersondocuments";
            this.dgvPersondocuments.RowHeadersWidth = 51;
            this.dgvPersondocuments.RowTemplate.Height = 24;
            this.dgvPersondocuments.Size = new System.Drawing.Size(1321, 452);
            this.dgvPersondocuments.TabIndex = 1;
            this.dgvPersondocuments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPersondocuments_CellMouseDoubleClick);
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
            // clmFiOpen
            // 
            this.clmFiOpen.HeaderText = "Open";
            this.clmFiOpen.MinimumWidth = 6;
            this.clmFiOpen.Name = "clmFiOpen";
            this.clmFiOpen.Width = 125;
            // 
            // clmFiDelete
            // 
            this.clmFiDelete.HeaderText = "Delete";
            this.clmFiDelete.MinimumWidth = 6;
            this.clmFiDelete.Name = "clmFiDelete";
            this.clmFiDelete.Width = 75;
            // 
            // clmFinanceDocID
            // 
            this.clmFinanceDocID.DataPropertyName = "FinanceDocID";
            this.clmFinanceDocID.HeaderText = "FinanceDocID";
            this.clmFinanceDocID.MinimumWidth = 6;
            this.clmFinanceDocID.Name = "clmFinanceDocID";
            this.clmFinanceDocID.Visible = false;
            this.clmFinanceDocID.Width = 125;
            // 
            // clmFinanceDocPath
            // 
            this.clmFinanceDocPath.DataPropertyName = "FinanceFilePath";
            this.clmFinanceDocPath.HeaderText = "FinanceDocPath";
            this.clmFinanceDocPath.MinimumWidth = 6;
            this.clmFinanceDocPath.Name = "clmFinanceDocPath";
            this.clmFinanceDocPath.Visible = false;
            this.clmFinanceDocPath.Width = 125;
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
            // clmPersonalOpen
            // 
            this.clmPersonalOpen.HeaderText = "Open";
            this.clmPersonalOpen.MinimumWidth = 6;
            this.clmPersonalOpen.Name = "clmPersonalOpen";
            this.clmPersonalOpen.Width = 125;
            // 
            // clmPersonalDelete
            // 
            this.clmPersonalDelete.HeaderText = "Delete";
            this.clmPersonalDelete.MinimumWidth = 6;
            this.clmPersonalDelete.Name = "clmPersonalDelete";
            this.clmPersonalDelete.Width = 75;
            // 
            // clmPersonalDocID
            // 
            this.clmPersonalDocID.DataPropertyName = "PersonalDocID";
            this.clmPersonalDocID.HeaderText = "PersonalDocID";
            this.clmPersonalDocID.MinimumWidth = 6;
            this.clmPersonalDocID.Name = "clmPersonalDocID";
            this.clmPersonalDocID.Visible = false;
            this.clmPersonalDocID.Width = 125;
            // 
            // clmPersonalDocPath
            // 
            this.clmPersonalDocPath.DataPropertyName = "PersonalFilePath";
            this.clmPersonalDocPath.HeaderText = "PersonalDocPath";
            this.clmPersonalDocPath.MinimumWidth = 6;
            this.clmPersonalDocPath.Name = "clmPersonalDocPath";
            this.clmPersonalDocPath.Visible = false;
            this.clmPersonalDocPath.Width = 125;
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
            // clmItOpen
            // 
            this.clmItOpen.HeaderText = "Open";
            this.clmItOpen.MinimumWidth = 6;
            this.clmItOpen.Name = "clmItOpen";
            this.clmItOpen.Width = 125;
            // 
            // clmItDelete
            // 
            this.clmItDelete.HeaderText = "Delete";
            this.clmItDelete.MinimumWidth = 6;
            this.clmItDelete.Name = "clmItDelete";
            this.clmItDelete.Width = 75;
            // 
            // clmItDocID
            // 
            this.clmItDocID.DataPropertyName = "ITDocID";
            this.clmItDocID.HeaderText = "ItDocID";
            this.clmItDocID.MinimumWidth = 6;
            this.clmItDocID.Name = "clmItDocID";
            this.clmItDocID.Visible = false;
            this.clmItDocID.Width = 125;
            // 
            // clmItDocPath
            // 
            this.clmItDocPath.DataPropertyName = "ItFilePath";
            this.clmItDocPath.HeaderText = "ITDocPath";
            this.clmItDocPath.MinimumWidth = 6;
            this.clmItDocPath.Name = "clmItDocPath";
            this.clmItDocPath.Visible = false;
            this.clmItDocPath.Width = 125;
            // 
            // clmHrDocID
            // 
            this.clmHrDocID.DataPropertyName = "HRDocID";
            this.clmHrDocID.HeaderText = "DocID";
            this.clmHrDocID.MinimumWidth = 6;
            this.clmHrDocID.Name = "clmHrDocID";
            this.clmHrDocID.Visible = false;
            this.clmHrDocID.Width = 125;
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
            // clmHrDocPath
            // 
            this.clmHrDocPath.DataPropertyName = "HrFilePath";
            this.clmHrDocPath.HeaderText = "Path";
            this.clmHrDocPath.MinimumWidth = 6;
            this.clmHrDocPath.Name = "clmHrDocPath";
            this.clmHrDocPath.Visible = false;
            this.clmHrDocPath.Width = 125;
            // 
            // clmHrOpen
            // 
            this.clmHrOpen.HeaderText = "Open";
            this.clmHrOpen.MinimumWidth = 6;
            this.clmHrOpen.Name = "clmHrOpen";
            this.clmHrOpen.Width = 125;
            // 
            // clmHrDelete
            // 
            this.clmHrDelete.HeaderText = "Delete";
            this.clmHrDelete.MinimumWidth = 6;
            this.clmHrDelete.Name = "clmHrDelete";
            this.clmHrDelete.Width = 75;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHrDocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHrDocPath;
        private System.Windows.Forms.DataGridViewButtonColumn clmHrOpen;
        private System.Windows.Forms.DataGridViewButtonColumn clmHrDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn clmItOpen;
        private System.Windows.Forms.DataGridViewButtonColumn clmItDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItDocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItDocPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn clmFiOpen;
        private System.Windows.Forms.DataGridViewButtonColumn clmFiDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFinanceDocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFinanceDocPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn clmPersonalOpen;
        private System.Windows.Forms.DataGridViewButtonColumn clmPersonalDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPersonalDocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPersonalDocPath;
    }
}