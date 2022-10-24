﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Town Report");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Purpose Report");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Food Report");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Monthly Reports");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Yearly Reports");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("No of Nights Report");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Vehicle Type Report");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Main Reports", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Other Reports");
            this.LeftMainflowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTraveler = new System.Windows.Forms.Button();
            this.btnMeals = new System.Windows.Forms.Button();
            this.Reportpanel = new System.Windows.Forms.Panel();
            this.treeViewReport = new System.Windows.Forms.TreeView();
            this.btnReport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOutgoingDoc = new System.Windows.Forms.Button();
            this.MaintabControl = new System.Windows.Forms.TabControl();
            this.tabFrontScreen = new System.Windows.Forms.TabPage();
            this.LeftMainflowLayoutPanel1.SuspendLayout();
            this.Reportpanel.SuspendLayout();
            this.MaintabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftMainflowLayoutPanel1
            // 
            this.LeftMainflowLayoutPanel1.AutoScroll = true;
            this.LeftMainflowLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.LeftMainflowLayoutPanel1.Controls.Add(this.button1);
            this.LeftMainflowLayoutPanel1.Controls.Add(this.btnTraveler);
            this.LeftMainflowLayoutPanel1.Controls.Add(this.btnMeals);
            this.LeftMainflowLayoutPanel1.Controls.Add(this.Reportpanel);
            this.LeftMainflowLayoutPanel1.Controls.Add(this.button2);
            this.LeftMainflowLayoutPanel1.Controls.Add(this.btnOutgoingDoc);
            this.LeftMainflowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMainflowLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftMainflowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.LeftMainflowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.LeftMainflowLayoutPanel1.Name = "LeftMainflowLayoutPanel1";
            this.LeftMainflowLayoutPanel1.Size = new System.Drawing.Size(301, 734);
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
            this.button1.Size = new System.Drawing.Size(267, 59);
            this.button1.TabIndex = 3;
            this.button1.Tag = "";
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTraveler
            // 
            this.btnTraveler.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTraveler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTraveler.FlatAppearance.BorderSize = 0;
            this.btnTraveler.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraveler.ForeColor = System.Drawing.Color.White;
            this.btnTraveler.Image = ((System.Drawing.Image)(resources.GetObject("btnTraveler.Image")));
            this.btnTraveler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraveler.Location = new System.Drawing.Point(3, 65);
            this.btnTraveler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraveler.Name = "btnTraveler";
            this.btnTraveler.Size = new System.Drawing.Size(267, 59);
            this.btnTraveler.TabIndex = 0;
            this.btnTraveler.Tag = "Traveler";
            this.btnTraveler.Text = "Traveler Details";
            this.btnTraveler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraveler.UseVisualStyleBackColor = false;
            this.btnTraveler.Click += new System.EventHandler(this.btnTraveler_Click);
            // 
            // btnMeals
            // 
            this.btnMeals.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMeals.FlatAppearance.BorderSize = 0;
            this.btnMeals.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeals.ForeColor = System.Drawing.Color.White;
            this.btnMeals.Image = ((System.Drawing.Image)(resources.GetObject("btnMeals.Image")));
            this.btnMeals.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMeals.Location = new System.Drawing.Point(3, 128);
            this.btnMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMeals.Name = "btnMeals";
            this.btnMeals.Size = new System.Drawing.Size(267, 59);
            this.btnMeals.TabIndex = 1;
            this.btnMeals.Tag = "Meal";
            this.btnMeals.Text = "Meals";
            this.btnMeals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeals.UseVisualStyleBackColor = false;
            this.btnMeals.Click += new System.EventHandler(this.btnMeals_Click);
            // 
            // Reportpanel
            // 
            this.Reportpanel.Controls.Add(this.treeViewReport);
            this.Reportpanel.Controls.Add(this.btnReport);
            this.Reportpanel.Location = new System.Drawing.Point(4, 193);
            this.Reportpanel.Margin = new System.Windows.Forms.Padding(4);
            this.Reportpanel.MaximumSize = new System.Drawing.Size(267, 378);
            this.Reportpanel.MinimumSize = new System.Drawing.Size(267, 57);
            this.Reportpanel.Name = "Reportpanel";
            this.Reportpanel.Size = new System.Drawing.Size(267, 57);
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
            treeNode1.Name = "Node7";
            treeNode1.Text = "Town Report";
            treeNode2.Name = "Node8";
            treeNode2.Text = "Purpose Report";
            treeNode3.Name = "Node9";
            treeNode3.Text = "Food Report";
            treeNode4.Name = "Node10";
            treeNode4.Text = "Monthly Reports";
            treeNode5.Name = "Node11";
            treeNode5.Text = "Yearly Reports";
            treeNode6.Name = "Node12";
            treeNode6.Text = "No of Nights Report";
            treeNode7.Name = "Node13";
            treeNode7.Text = "Vehicle Type Report";
            treeNode8.Name = "Node0";
            treeNode8.Text = "Main Reports";
            treeNode9.Name = "Node14";
            treeNode9.Text = "Other Reports";
            this.treeViewReport.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            this.treeViewReport.Size = new System.Drawing.Size(267, 0);
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
            this.btnReport.Size = new System.Drawing.Size(267, 59);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Reports";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(3, 256);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 59);
            this.button2.TabIndex = 4;
            this.button2.Tag = "";
            this.button2.Text = "Close All";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOutgoingDoc
            // 
            this.btnOutgoingDoc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOutgoingDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOutgoingDoc.FlatAppearance.BorderSize = 0;
            this.btnOutgoingDoc.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutgoingDoc.ForeColor = System.Drawing.Color.White;
            this.btnOutgoingDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnOutgoingDoc.Image")));
            this.btnOutgoingDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOutgoingDoc.Location = new System.Drawing.Point(3, 319);
            this.btnOutgoingDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOutgoingDoc.Name = "btnOutgoingDoc";
            this.btnOutgoingDoc.Size = new System.Drawing.Size(267, 59);
            this.btnOutgoingDoc.TabIndex = 5;
            this.btnOutgoingDoc.Tag = "AddDocuments";
            this.btnOutgoingDoc.Text = "Outgoing Documents";
            this.btnOutgoingDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutgoingDoc.UseVisualStyleBackColor = false;
            this.btnOutgoingDoc.Click += new System.EventHandler(this.btnOutgoingDoc_Click);
            // 
            // MaintabControl
            // 
            this.MaintabControl.Controls.Add(this.tabFrontScreen);
            this.MaintabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaintabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MaintabControl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaintabControl.Location = new System.Drawing.Point(301, 0);
            this.MaintabControl.Margin = new System.Windows.Forms.Padding(4);
            this.MaintabControl.Name = "MaintabControl";
            this.MaintabControl.SelectedIndex = 0;
            this.MaintabControl.Size = new System.Drawing.Size(1054, 734);
            this.MaintabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MaintabControl.TabIndex = 4;
            // 
            // tabFrontScreen
            // 
            this.tabFrontScreen.BackColor = System.Drawing.Color.Transparent;
            this.tabFrontScreen.Location = new System.Drawing.Point(4, 28);
            this.tabFrontScreen.Margin = new System.Windows.Forms.Padding(4);
            this.tabFrontScreen.Name = "tabFrontScreen";
            this.tabFrontScreen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFrontScreen.Size = new System.Drawing.Size(1046, 702);
            this.tabFrontScreen.TabIndex = 0;
            this.tabFrontScreen.Text = "Front Screen";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1355, 734);
            this.Controls.Add(this.MaintabControl);
            this.Controls.Add(this.LeftMainflowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LeftMainflowLayoutPanel1.ResumeLayout(false);
            this.Reportpanel.ResumeLayout(false);
            this.MaintabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraveler;
        private System.Windows.Forms.Button btnMeals;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.FlowLayoutPanel LeftMainflowLayoutPanel1;
        private System.Windows.Forms.Panel Reportpanel;
        private System.Windows.Forms.TreeView treeViewReport;
        private System.Windows.Forms.TabControl MaintabControl;
        private System.Windows.Forms.TabPage tabFrontScreen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOutgoingDoc;
    }
}

