
namespace TravelerDetailsManagementSystem.MealMasterfile
{
    partial class Meal
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
            this.dgvMeals = new System.Windows.Forms.DataGridView();
            this.txtMealName = new System.Windows.Forms.TextBox();
            this.cbMealType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.clmMealID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMealTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMealType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeals
            // 
            this.dgvMeals.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMealID,
            this.clmMealName,
            this.clmMealTypeID,
            this.clmMealType});
            this.dgvMeals.Location = new System.Drawing.Point(83, 124);
            this.dgvMeals.Name = "dgvMeals";
            this.dgvMeals.RowHeadersWidth = 51;
            this.dgvMeals.RowTemplate.Height = 24;
            this.dgvMeals.Size = new System.Drawing.Size(899, 408);
            this.dgvMeals.TabIndex = 0;
            // 
            // txtMealName
            // 
            this.txtMealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMealName.Location = new System.Drawing.Point(138, 70);
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.Size = new System.Drawing.Size(469, 26);
            this.txtMealName.TabIndex = 1;
            // 
            // cbMealType
            // 
            this.cbMealType.FormattingEnabled = true;
            this.cbMealType.Location = new System.Drawing.Point(743, 73);
            this.cbMealType.Name = "cbMealType";
            this.cbMealType.Size = new System.Drawing.Size(222, 24);
            this.cbMealType.TabIndex = 2;
            this.cbMealType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meal Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(633, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Meal Type";
            // 
            // pbSave
            // 
            this.pbSave.Image = global::TravelerDetailsManagementSystem.Properties.Resources.joyent_90px;
            this.pbSave.Location = new System.Drawing.Point(1004, 58);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(60, 50);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSave.TabIndex = 5;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // clmMealID
            // 
            this.clmMealID.DataPropertyName = "MealID";
            this.clmMealID.HeaderText = "MealID";
            this.clmMealID.MinimumWidth = 6;
            this.clmMealID.Name = "clmMealID";
            this.clmMealID.Visible = false;
            this.clmMealID.Width = 125;
            // 
            // clmMealName
            // 
            this.clmMealName.DataPropertyName = "MealName";
            this.clmMealName.HeaderText = "MealName";
            this.clmMealName.MinimumWidth = 6;
            this.clmMealName.Name = "clmMealName";
            this.clmMealName.Width = 500;
            // 
            // clmMealTypeID
            // 
            this.clmMealTypeID.DataPropertyName = "MealTypeID";
            this.clmMealTypeID.HeaderText = "MealTypeID";
            this.clmMealTypeID.MinimumWidth = 6;
            this.clmMealTypeID.Name = "clmMealTypeID";
            this.clmMealTypeID.Visible = false;
            this.clmMealTypeID.Width = 125;
            // 
            // clmMealType
            // 
            this.clmMealType.DataPropertyName = "MealType";
            this.clmMealType.HeaderText = "MealType";
            this.clmMealType.MinimumWidth = 6;
            this.clmMealType.Name = "clmMealType";
            this.clmMealType.Width = 300;
            // 
            // Meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMealType);
            this.Controls.Add(this.txtMealName);
            this.Controls.Add(this.dgvMeals);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Meal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Meal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeals;
        private System.Windows.Forms.TextBox txtMealName;
        private System.Windows.Forms.ComboBox cbMealType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMealID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMealTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMealType;
    }
}