namespace TravelerDetailsManagementSystem.Common
{
    partial class frmCommonSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNoti = new System.Windows.Forms.Label();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.lblSearchByDesc = new System.Windows.Forms.Label();
            this.gridSearch = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSearchFld1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSearchFld2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSearchFld3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSearchFld4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSearchFld5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSearchFld6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSearchFld7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSearchFld8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSearchFld9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSearchFld10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblSortedColID = new System.Windows.Forms.Label();
            this.lblSortedBy = new System.Windows.Forms.Label();
            this.lblSortedByDesc = new System.Windows.Forms.Label();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoti
            // 
            this.lblNoti.AutoSize = true;
            this.lblNoti.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoti.Location = new System.Drawing.Point(458, 9);
            this.lblNoti.Name = "lblNoti";
            this.lblNoti.Size = new System.Drawing.Size(233, 15);
            this.lblNoti.TabIndex = 25;
            this.lblNoti.Text = "Press F2 Button to Change Search Column";
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(90, 9);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(13, 15);
            this.lblSearchBy.TabIndex = 24;
            this.lblSearchBy.Text = "*";
            // 
            // lblSearchByDesc
            // 
            this.lblSearchByDesc.AutoSize = true;
            this.lblSearchByDesc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByDesc.Location = new System.Drawing.Point(12, 9);
            this.lblSearchByDesc.Name = "lblSearchByDesc";
            this.lblSearchByDesc.Size = new System.Drawing.Size(68, 15);
            this.lblSearchByDesc.TabIndex = 23;
            this.lblSearchByDesc.Text = "Search By :";
            // 
            // gridSearch
            // 
            this.gridSearch.AllowUserToAddRows = false;
            this.gridSearch.AllowUserToDeleteRows = false;
            this.gridSearch.AllowUserToOrderColumns = true;
            this.gridSearch.AllowUserToResizeColumns = false;
            this.gridSearch.AllowUserToResizeRows = false;
            this.gridSearch.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridSearch.ColumnHeadersHeight = 29;
            this.gridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmSearchFld1,
            this.clmSearchFld2,
            this.clmSearchFld3,
            this.clmSearchFld4,
            this.clmSearchFld5,
            this.clmSearchFld6,
            this.clmSearchFld7,
            this.clmSearchFld8,
            this.clmSearchFld9,
            this.clmSearchFld10,
            this.clm11,
            this.Column1,
            this.Column2});
            this.gridSearch.Location = new System.Drawing.Point(12, 62);
            this.gridSearch.Name = "gridSearch";
            this.gridSearch.RowHeadersVisible = false;
            this.gridSearch.RowHeadersWidth = 51;
            this.gridSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSearch.Size = new System.Drawing.Size(676, 321);
            this.gridSearch.TabIndex = 41;
            this.gridSearch.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridSearch_CellMouseDoubleClick);
            this.gridSearch.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridSearch_ColumnHeaderMouseClick);
            this.gridSearch.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridSearch_ColumnHeaderMouseDoubleClick);
            this.gridSearch.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridSearch_DataBindingComplete);
            this.gridSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridSearch_KeyDown);
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "SearchID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmID.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmID.HeaderText = "ID";
            this.clmID.MinimumWidth = 6;
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
            this.clmID.Width = 125;
            // 
            // clmSearchFld1
            // 
            this.clmSearchFld1.DataPropertyName = "SearchFld1";
            this.clmSearchFld1.HeaderText = "Search Fld 1";
            this.clmSearchFld1.MinimumWidth = 6;
            this.clmSearchFld1.Name = "clmSearchFld1";
            this.clmSearchFld1.ReadOnly = true;
            this.clmSearchFld1.Visible = false;
            this.clmSearchFld1.Width = 125;
            // 
            // clmSearchFld2
            // 
            this.clmSearchFld2.DataPropertyName = "SearchFld2";
            this.clmSearchFld2.HeaderText = "Search Fld 2";
            this.clmSearchFld2.MinimumWidth = 6;
            this.clmSearchFld2.Name = "clmSearchFld2";
            this.clmSearchFld2.ReadOnly = true;
            this.clmSearchFld2.Visible = false;
            this.clmSearchFld2.Width = 125;
            // 
            // clmSearchFld3
            // 
            this.clmSearchFld3.DataPropertyName = "SearchFld3";
            this.clmSearchFld3.HeaderText = "Search Fld 3";
            this.clmSearchFld3.MinimumWidth = 6;
            this.clmSearchFld3.Name = "clmSearchFld3";
            this.clmSearchFld3.ReadOnly = true;
            this.clmSearchFld3.Visible = false;
            this.clmSearchFld3.Width = 125;
            // 
            // clmSearchFld4
            // 
            this.clmSearchFld4.DataPropertyName = "SearchFld4";
            this.clmSearchFld4.HeaderText = "Search Fld 4";
            this.clmSearchFld4.MinimumWidth = 6;
            this.clmSearchFld4.Name = "clmSearchFld4";
            this.clmSearchFld4.ReadOnly = true;
            this.clmSearchFld4.Visible = false;
            this.clmSearchFld4.Width = 125;
            // 
            // clmSearchFld5
            // 
            this.clmSearchFld5.DataPropertyName = "SearchFld5";
            this.clmSearchFld5.HeaderText = "Search Fld 5";
            this.clmSearchFld5.MinimumWidth = 6;
            this.clmSearchFld5.Name = "clmSearchFld5";
            this.clmSearchFld5.ReadOnly = true;
            this.clmSearchFld5.Visible = false;
            this.clmSearchFld5.Width = 125;
            // 
            // clmSearchFld6
            // 
            this.clmSearchFld6.DataPropertyName = "SearchFld6";
            this.clmSearchFld6.HeaderText = "Search Fld 6";
            this.clmSearchFld6.MinimumWidth = 6;
            this.clmSearchFld6.Name = "clmSearchFld6";
            this.clmSearchFld6.ReadOnly = true;
            this.clmSearchFld6.Visible = false;
            this.clmSearchFld6.Width = 125;
            // 
            // clmSearchFld7
            // 
            this.clmSearchFld7.DataPropertyName = "SearchFld7";
            this.clmSearchFld7.HeaderText = "Search Fld 7";
            this.clmSearchFld7.MinimumWidth = 6;
            this.clmSearchFld7.Name = "clmSearchFld7";
            this.clmSearchFld7.ReadOnly = true;
            this.clmSearchFld7.Visible = false;
            this.clmSearchFld7.Width = 125;
            // 
            // clmSearchFld8
            // 
            this.clmSearchFld8.DataPropertyName = "SearchFld8";
            this.clmSearchFld8.HeaderText = "Search Fld 8";
            this.clmSearchFld8.MinimumWidth = 6;
            this.clmSearchFld8.Name = "clmSearchFld8";
            this.clmSearchFld8.ReadOnly = true;
            this.clmSearchFld8.Visible = false;
            this.clmSearchFld8.Width = 125;
            // 
            // clmSearchFld9
            // 
            this.clmSearchFld9.DataPropertyName = "SearchFld9";
            this.clmSearchFld9.HeaderText = "Search Fld 9";
            this.clmSearchFld9.MinimumWidth = 6;
            this.clmSearchFld9.Name = "clmSearchFld9";
            this.clmSearchFld9.ReadOnly = true;
            this.clmSearchFld9.Visible = false;
            this.clmSearchFld9.Width = 125;
            // 
            // clmSearchFld10
            // 
            this.clmSearchFld10.DataPropertyName = "SearchFld10";
            this.clmSearchFld10.HeaderText = "Search Fld 10";
            this.clmSearchFld10.MinimumWidth = 6;
            this.clmSearchFld10.Name = "clmSearchFld10";
            this.clmSearchFld10.ReadOnly = true;
            this.clmSearchFld10.Visible = false;
            this.clmSearchFld10.Width = 125;
            // 
            // clm11
            // 
            this.clm11.DataPropertyName = "SearchFld11";
            this.clm11.HeaderText = "Search Fld 11";
            this.clm11.MinimumWidth = 6;
            this.clm11.Name = "clm11";
            this.clm11.ReadOnly = true;
            this.clm11.Visible = false;
            this.clm11.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SearchFld12";
            this.Column1.HeaderText = "Search Fld 12";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SearchFld13";
            this.Column2.HeaderText = "Search Fld 13";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 125;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(573, 393);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(16, 13);
            this.lblIndex.TabIndex = 40;
            this.lblIndex.Text = "-1";
            this.lblIndex.Visible = false;
            // 
            // lblSortedColID
            // 
            this.lblSortedColID.AutoSize = true;
            this.lblSortedColID.Location = new System.Drawing.Point(526, 393);
            this.lblSortedColID.Name = "lblSortedColID";
            this.lblSortedColID.Size = new System.Drawing.Size(11, 13);
            this.lblSortedColID.TabIndex = 39;
            this.lblSortedColID.Text = "*";
            this.lblSortedColID.Visible = false;
            // 
            // lblSortedBy
            // 
            this.lblSortedBy.AutoSize = true;
            this.lblSortedBy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortedBy.Location = new System.Drawing.Point(90, 394);
            this.lblSortedBy.Name = "lblSortedBy";
            this.lblSortedBy.Size = new System.Drawing.Size(13, 15);
            this.lblSortedBy.TabIndex = 38;
            this.lblSortedBy.Text = "*";
            // 
            // lblSortedByDesc
            // 
            this.lblSortedByDesc.AutoSize = true;
            this.lblSortedByDesc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortedByDesc.Location = new System.Drawing.Point(12, 394);
            this.lblSortedByDesc.Name = "lblSortedByDesc";
            this.lblSortedByDesc.Size = new System.Drawing.Size(68, 15);
            this.lblSortedByDesc.TabIndex = 37;
            this.lblSortedByDesc.Text = "Search By :";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchText.Location = new System.Drawing.Point(12, 31);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(676, 21);
            this.txtSearchText.TabIndex = 36;
            this.txtSearchText.TextChanged += new System.EventHandler(this.txtSearchText_TextChanged);
            this.txtSearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchText_KeyDown);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.chkAll.Location = new System.Drawing.Point(364, 7);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(58, 19);
            this.chkAll.TabIndex = 42;
            this.chkAll.Text = "By All";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // frmCommonSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 416);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.gridSearch);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblSortedColID);
            this.Controls.Add(this.lblSortedBy);
            this.Controls.Add(this.lblSortedByDesc);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.lblNoti);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.lblSearchByDesc);
            this.Name = "frmCommonSearch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Common Search";
            this.Load += new System.EventHandler(this.frmCommonSearch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCommonSearch_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoti;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Label lblSearchByDesc;
        private System.Windows.Forms.DataGridView gridSearch;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblSortedColID;
        private System.Windows.Forms.Label lblSortedBy;
        private System.Windows.Forms.Label lblSortedByDesc;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSearchFld1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSearchFld2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSearchFld3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSearchFld4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSearchFld5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSearchFld6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSearchFld7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSearchFld8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSearchFld9;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSearchFld10;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.CheckBox chkAll;
    }
}