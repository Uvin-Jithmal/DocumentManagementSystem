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
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHRdocuments = new System.Windows.Forms.DataGridView();
            this.clmHrDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHrDocPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHrOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmHrDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvITdocuments = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmItDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmItDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItDocPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvFIdocuments = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFiOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmFiDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmFinanceDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFinanceDocPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPersondocuments = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPersonalOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmPersonalDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmPersonalDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPersonalDocPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvHRdocuments);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1442, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HR Documents";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(523, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(365, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "You Cannot View HR Department Documents";
            this.label7.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Double Click Open Button to View Document";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1272, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1029, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logged User";
            this.label1.Visible = false;
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
            this.dgvHRdocuments.Location = new System.Drawing.Point(68, 81);
            this.dgvHRdocuments.Name = "dgvHRdocuments";
            this.dgvHRdocuments.RowHeadersWidth = 51;
            this.dgvHRdocuments.RowTemplate.Height = 24;
            this.dgvHRdocuments.Size = new System.Drawing.Size(1321, 452);
            this.dgvHRdocuments.TabIndex = 0;
            this.dgvHRdocuments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHRdocuments_CellDoubleClick);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dgvITdocuments);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1442, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IT Documents";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(523, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(356, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "You Cannot View IT Department Documents";
            this.label8.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Double Click Open Button to View Document";
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
            this.dgvITdocuments.Location = new System.Drawing.Point(68, 81);
            this.dgvITdocuments.Name = "dgvITdocuments";
            this.dgvITdocuments.RowHeadersWidth = 51;
            this.dgvITdocuments.RowTemplate.Height = 24;
            this.dgvITdocuments.Size = new System.Drawing.Size(1321, 452);
            this.dgvITdocuments.TabIndex = 1;
            this.dgvITdocuments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvITdocuments_CellMouseDoubleClick);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dgvFIdocuments);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1442, 541);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Finance Documents";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(523, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(398, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "You Cannot View Finance Department Documents";
            this.label9.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Double Click Open Button to View Document";
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
            this.dgvFIdocuments.Location = new System.Drawing.Point(68, 81);
            this.dgvFIdocuments.Name = "dgvFIdocuments";
            this.dgvFIdocuments.RowHeadersWidth = 51;
            this.dgvFIdocuments.RowTemplate.Height = 24;
            this.dgvFIdocuments.Size = new System.Drawing.Size(1321, 452);
            this.dgvFIdocuments.TabIndex = 1;
            this.dgvFIdocuments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFIdocuments_CellMouseDoubleClick);
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.dgvPersondocuments);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1442, 541);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Personal Documents";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(523, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(405, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "You Cannot View Personal Department Documents";
            this.label10.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(365, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Double Click Open Button to View Document";
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
            this.dgvPersondocuments.Location = new System.Drawing.Point(68, 81);
            this.dgvPersondocuments.Name = "dgvPersondocuments";
            this.dgvPersondocuments.RowHeadersWidth = 51;
            this.dgvPersondocuments.RowTemplate.Height = 24;
            this.dgvPersondocuments.Size = new System.Drawing.Size(1321, 452);
            this.dgvPersondocuments.TabIndex = 1;
            this.dgvPersondocuments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPersondocuments_CellMouseDoubleClick);
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
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRdocuments)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvITdocuments)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFIdocuments)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}