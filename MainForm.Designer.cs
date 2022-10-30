
namespace TravelerDetailsManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Town Report");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Purpose Report");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Food Report");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Monthly Reports");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Yearly Reports");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("No of Nights Report");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Vehicle Type Report");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Main Reports", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Other Reports");
            this.LeftMainflowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.Reportpanel = new System.Windows.Forms.Panel();
            this.treeViewReport = new System.Windows.Forms.TreeView();
            this.btnReport = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnViewDoc = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddDocument = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelLoggedData = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MaintabControl = new System.Windows.Forms.TabControl();
            this.tabFrontScreen = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LeftMainflowLayoutPanel1.SuspendLayout();
            this.Reportpanel.SuspendLayout();
            this.panelLoggedData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MaintabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftMainflowLayoutPanel1
            // 
            this.LeftMainflowLayoutPanel1.AutoScroll = true;
            this.LeftMainflowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LeftMainflowLayoutPanel1.Controls.Add(this.button1);
            this.LeftMainflowLayoutPanel1.Controls.Add(this.Reportpanel);
            this.LeftMainflowLayoutPanel1.Controls.Add(this.button3);
            this.LeftMainflowLayoutPanel1.Controls.Add(this.btnViewDoc);
            this.LeftMainflowLayoutPanel1.Controls.Add(this.flowLayoutPanel1);
            this.LeftMainflowLayoutPanel1.Controls.Add(this.btnAddDocument);
            this.LeftMainflowLayoutPanel1.Controls.Add(this.btnAddUser);
            this.LeftMainflowLayoutPanel1.Controls.Add(this.button2);
            this.LeftMainflowLayoutPanel1.Controls.Add(this.panelLoggedData);
            this.LeftMainflowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.LeftMainflowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMainflowLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftMainflowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.LeftMainflowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.LeftMainflowLayoutPanel1.Name = "LeftMainflowLayoutPanel1";
            this.LeftMainflowLayoutPanel1.Size = new System.Drawing.Size(320, 931);
            this.LeftMainflowLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 59);
            this.button1.TabIndex = 3;
            this.button1.Tag = "";
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reportpanel
            // 
            this.Reportpanel.Controls.Add(this.treeViewReport);
            this.Reportpanel.Controls.Add(this.btnReport);
            this.Reportpanel.Location = new System.Drawing.Point(4, 67);
            this.Reportpanel.Margin = new System.Windows.Forms.Padding(4);
            this.Reportpanel.MaximumSize = new System.Drawing.Size(312, 378);
            this.Reportpanel.MinimumSize = new System.Drawing.Size(312, 59);
            this.Reportpanel.Name = "Reportpanel";
            this.Reportpanel.Size = new System.Drawing.Size(312, 59);
            this.Reportpanel.TabIndex = 2;
            this.Reportpanel.Tag = "Module";
            // 
            // treeViewReport
            // 
            this.treeViewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewReport.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewReport.Location = new System.Drawing.Point(0, 59);
            this.treeViewReport.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewReport.Name = "treeViewReport";
            treeNode19.Name = "Node7";
            treeNode19.Text = "Town Report";
            treeNode20.Name = "Node8";
            treeNode20.Text = "Purpose Report";
            treeNode21.Name = "Node9";
            treeNode21.Text = "Food Report";
            treeNode22.Name = "Node10";
            treeNode22.Text = "Monthly Reports";
            treeNode23.Name = "Node11";
            treeNode23.Text = "Yearly Reports";
            treeNode24.Name = "Node12";
            treeNode24.Text = "No of Nights Report";
            treeNode25.Name = "Node13";
            treeNode25.Text = "Vehicle Type Report";
            treeNode26.Name = "Node0";
            treeNode26.Text = "Main Reports";
            treeNode27.Name = "Node14";
            treeNode27.Text = "Other Reports";
            this.treeViewReport.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27});
            this.treeViewReport.Size = new System.Drawing.Size(312, 0);
            this.treeViewReport.TabIndex = 3;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.Location = new System.Drawing.Point(0, 0);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(312, 59);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Reports";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(3, 132);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 59);
            this.button3.TabIndex = 6;
            this.button3.Tag = "AddDocument";
            this.button3.Text = "Add Documents";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnViewDoc
            // 
            this.btnViewDoc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnViewDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewDoc.FlatAppearance.BorderSize = 0;
            this.btnViewDoc.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDoc.ForeColor = System.Drawing.Color.White;
            this.btnViewDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDoc.Image")));
            this.btnViewDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewDoc.Location = new System.Drawing.Point(3, 195);
            this.btnViewDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewDoc.Name = "btnViewDoc";
            this.btnViewDoc.Size = new System.Drawing.Size(312, 59);
            this.btnViewDoc.TabIndex = 8;
            this.btnViewDoc.Tag = "ViewDocument";
            this.btnViewDoc.Text = "View Documents";
            this.btnViewDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDoc.UseVisualStyleBackColor = false;
            this.btnViewDoc.Click += new System.EventHandler(this.btnViewDoc_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 259);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(271, 0);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnAddDocument
            // 
            this.btnAddDocument.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDocument.FlatAppearance.BorderSize = 0;
            this.btnAddDocument.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDocument.ForeColor = System.Drawing.Color.White;
            this.btnAddDocument.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDocument.Image")));
            this.btnAddDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDocument.Location = new System.Drawing.Point(3, 264);
            this.btnAddDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Size = new System.Drawing.Size(312, 59);
            this.btnAddDocument.TabIndex = 11;
            this.btnAddDocument.Tag = "ViewDocument";
            this.btnAddDocument.Text = "Delete Documents";
            this.btnAddDocument.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDocument.UseVisualStyleBackColor = false;
            this.btnAddDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.Location = new System.Drawing.Point(3, 327);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(312, 59);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.Tag = "AddUsers";
            this.btnAddUser.Text = "Add Users";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(3, 390);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 59);
            this.button2.TabIndex = 4;
            this.button2.Tag = "";
            this.button2.Text = "Close All";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelLoggedData
            // 
            this.panelLoggedData.Controls.Add(this.label4);
            this.panelLoggedData.Controls.Add(this.label1);
            this.panelLoggedData.Controls.Add(this.label2);
            this.panelLoggedData.Controls.Add(this.label3);
            this.panelLoggedData.Location = new System.Drawing.Point(3, 454);
            this.panelLoggedData.Name = "panelLoggedData";
            this.panelLoggedData.Size = new System.Drawing.Size(308, 200);
            this.panelLoggedData.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logged User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::TravelerDetailsManagementSystem.Properties.Resources.MainImage;
            this.pictureBox1.Location = new System.Drawing.Point(4, 661);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // MaintabControl
            // 
            this.MaintabControl.Controls.Add(this.tabFrontScreen);
            this.MaintabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaintabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MaintabControl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaintabControl.Location = new System.Drawing.Point(320, 0);
            this.MaintabControl.Margin = new System.Windows.Forms.Padding(4);
            this.MaintabControl.Name = "MaintabControl";
            this.MaintabControl.SelectedIndex = 0;
            this.MaintabControl.Size = new System.Drawing.Size(1035, 931);
            this.MaintabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MaintabControl.TabIndex = 4;
            // 
            // tabFrontScreen
            // 
            this.tabFrontScreen.BackColor = System.Drawing.Color.Transparent;
            this.tabFrontScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabFrontScreen.BackgroundImage")));
            this.tabFrontScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabFrontScreen.ForeColor = System.Drawing.Color.Black;
            this.tabFrontScreen.Location = new System.Drawing.Point(4, 28);
            this.tabFrontScreen.Margin = new System.Windows.Forms.Padding(4);
            this.tabFrontScreen.Name = "tabFrontScreen";
            this.tabFrontScreen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFrontScreen.Size = new System.Drawing.Size(1027, 899);
            this.tabFrontScreen.TabIndex = 0;
            this.tabFrontScreen.Text = "Front Screen";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1355, 931);
            this.Controls.Add(this.MaintabControl);
            this.Controls.Add(this.LeftMainflowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Rapidventure Business Solutions - Document Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LeftMainflowLayoutPanel1.ResumeLayout(false);
            this.Reportpanel.ResumeLayout(false);
            this.panelLoggedData.ResumeLayout(false);
            this.panelLoggedData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MaintabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.FlowLayoutPanel LeftMainflowLayoutPanel1;
        private System.Windows.Forms.Panel Reportpanel;
        private System.Windows.Forms.TreeView treeViewReport;
        private System.Windows.Forms.TabControl MaintabControl;
        private System.Windows.Forms.TabPage tabFrontScreen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnViewDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelLoggedData;
        private System.Windows.Forms.Button btnAddDocument;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

