using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelerDetailsManagementSystem.MealMasterfile;
using TravelerDetailsManagementSystem.TravelerForms;

namespace TravelerDetailsManagementSystem
{
    public partial class MainForm : Form
    {

        #region Private Variables

        //Tabpage close button
        Image CloseImage;
        Point _imageLocation = new Point(20, 4);
        Point imageHitArea = new Point(20, 4);

        //Login Variable
        //Form mf = new MainForm();

        #endregion

        #region Private Methods

        #region Method for tabpage creation and form load From Buttons
        private void OpenForm(Button btn)
        {
            //open 2 tabs same time
            if (btn == null)
            {
                return;
            }

            bool alreadyAdded = false;
            int addedIndex = 0;
            Button tn = btn;
            if (tn.Tag != null)
            {
                Assembly projectA = Assembly.Load("TravelerDetailsManagementSystem");
                //var normalForms = projectA.GetTypes().ToList().FindAll(x => x.BaseType.Equals(typeof(Form)));
                //var baseFromAddForms = projectA.GetTypes().ToList().FindAll(x => x.BaseType.Equals(typeof(BaseForm)));
                //var allForms = normalForms.Concat(baseFromAddForms);
                //var selectedForm = allForms.ToList().Find(y => y.Name.Equals(tn.Tag.ToString())).GetConstructor(Type.EmptyTypes);
                var selectedForm = projectA.GetTypes().ToList().FindAll(x => x.BaseType.Equals(typeof(Form))).Find(y => y.Name.Equals(tn.Tag.ToString())).GetConstructor(Type.EmptyTypes);
                var f = (Form)selectedForm.Invoke(new object[] { });
                Form form = (Form)f;
                form.TopLevel = false;
                if (form != null)
                {
                    //if (MaintabControl.TabPages.Count > 0)
                    //{
                    //    foreach (TabPage tp in MaintabControl.TabPages)
                    //    {
                    //        if (tp.Name.Equals(form.Name))
                    //        {
                    //            alreadyAdded = true;
                    //            addedIndex = MaintabControl.TabPages.IndexOf(tp);
                    //            break;
                    //        }
                    //    }
                    //}

                    if (alreadyAdded)
                    {
                        MaintabControl.SelectedTab = MaintabControl.TabPages[addedIndex];
                    }
                    else
                    {
                        TabPage newTpage0 = new TabPage(form.Text);
                        newTpage0.Name = form.Name;
                        MaintabControl.TabPages.Add(newTpage0);
                        MaintabControl.SelectedTab = newTpage0;

                        newTpage0.Controls.Add(form);
                        form.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                        //form.Size = newTpage0.Size;
                        form.Width = newTpage0.Width;
                        //form.Dock = DockStyle.Fill;
                        form.Parent = newTpage0;
                        form.Show();
                    }
                }
            }

            //open 2 tabs same time
            if (btn != null)
            {
                btn = null;
            }
        }
        #endregion

        #region Method for tabpage creation and form load From Treeview
        private void OpenForm(TreeView treeView)
        {
            //open 2 tabs same time
            if (treeView.SelectedNode == null)
            {
                return;
            }

            bool alreadyAdded = false;
            int addedIndex = 0;
            TreeNode tn = treeView.SelectedNode;
            if (tn.Tag != null)
            {
                Assembly projectA = Assembly.Load("TravelerDetailsManagementSystem");
                //var normalForms = projectA.GetTypes().ToList().FindAll(x => x.BaseType.Equals(typeof(Form)));
                //var baseFromAddForms = projectA.GetTypes().ToList().FindAll(x => x.BaseType.Equals(typeof(BaseForm)));
                //var allForms = normalForms.Concat(baseFromAddForms);
                //var selectedForm = allForms.ToList().Find(y => y.Name.Equals(tn.Tag.ToString())).GetConstructor(Type.EmptyTypes);
                var selectedForm = projectA.GetTypes().ToList().FindAll(x => x.BaseType.Equals(typeof(Form))).Find(y => y.Name.Equals(tn.Tag.ToString())).GetConstructor(Type.EmptyTypes);
                var f = (Form)selectedForm.Invoke(new object[] { });
                Form form = (Form)f;
                form.TopLevel = false;
                if (form != null)
                {

                    if (alreadyAdded)
                    {
                        MaintabControl.SelectedTab = MaintabControl.TabPages[addedIndex];
                    }
                    else
                    {
                        TabPage newTpage0 = new TabPage(form.Text);
                        newTpage0.Name = form.Name;
                        MaintabControl.TabPages.Add(newTpage0);
                        MaintabControl.SelectedTab = newTpage0;

                        newTpage0.Controls.Add(form);
                        form.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                        //form.Size = newTpage0.Size;
                        form.Width = newTpage0.Width;
                        //form.Dock = DockStyle.Fill;
                        form.Parent = newTpage0;
                        form.Show();
                    }
                }
            }

            //open 2 tabs same time
            if (treeView.SelectedNode != null)
            {
                treeView.SelectedNode = null;
            }
        }
        #endregion

        #region TabPage Close Button Method
        private void MaintabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Image img;

            img = new Bitmap(CloseImage);


            Rectangle r = e.Bounds;
            r = this.MaintabControl.GetTabRect(e.Index);
            r.Offset(2, 2);
            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = this.Font;
            string title = this.MaintabControl.TabPages[e.Index].Text;
            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));
            e.Graphics.DrawImage(img, new Point(r.X + (this.MaintabControl.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));

        }

        private void MaintabControl_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.MaintabControl.GetTabRect(tabControl.SelectedIndex).Width - (imageHitArea.X);
            Rectangle r = this.MaintabControl.GetTabRect(tabControl.SelectedIndex);
            r.Offset(_tabWidth, imageHitArea.Y);
            r.Width = 16;
            r.Height = 16;

            if (r.Contains(p))
            {
                int selectePageIndex = tabControl.SelectedIndex;
                TabPage tabPage = (TabPage)tabControl.TabPages[tabControl.SelectedIndex];
                tabControl.TabPages.Remove(tabPage);
                if (selectePageIndex > 0)
                {
                    MaintabControl.SelectedTab = MaintabControl.TabPages[selectePageIndex - 1];
                }
            }

        }

        #endregion

        #region Module Button Expand Method

        private void ExpandModules(Button btn)
        {
            if (btn.Parent != null)
            {
                if (btn.Parent.Tag != null && btn.Parent.Tag.Equals("Module"))
                {
                    Panel pnl = (Panel)btn.Parent;
                    if (pnl.Size.Equals(pnl.MaximumSize))
                    {
                        pnl.Size = pnl.MinimumSize;
                    }
                    else
                    {
                        pnl.Size = pnl.MaximumSize;
                    }
                }
            }
        }
        #endregion

        #endregion

        public MainForm()
        {
            //Thread trd = new Thread(new ThreadStart(formRun));
            //trd.Start();
            //Thread.Sleep(3000);
            InitializeComponent();
            //trd.Abort();
        }

        //private void formRun()
        //{
        //    Application.Run(new SplashScreen());
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {
            //CloseImage = Properties.Resources.Close;
            MaintabControl.Padding = new Point(20, 4);
            this.MaintabControl.TabPages[MaintabControl.TabCount - 1].Text = "Home";
        }

        #region Button Click Events

        //Traveller Button
        private void btnTraveler_Click(object sender, EventArgs e)
        {
            //Traveler frmTravel = new Traveler();
            //frmTravel.Show();

            OpenForm((Button) sender);
        }

        //Meals Button
        private void btnMeals_Click(object sender, EventArgs e)
        {
            //Meal frmMeal = new Meal();
            //frmMeal.Show();

            OpenForm((Button)sender);
        }

        //Reports Button
        private void btnReport_Click(object sender, EventArgs e)
        {
            ExpandModules((Button)sender);
        }

        //Home Button
        private void button1_Click(object sender, EventArgs e)
        {
            MaintabControl.TabPages.Add(tabFrontScreen);
        }

        //Close All Button
        private void button2_Click(object sender, EventArgs e)
        {
            MaintabControl.TabPages.Clear();
        }

        //Outgoing Button
        private void btnOutgoingDoc_Click(object sender, EventArgs e)
        {
            OpenForm((Button)sender);
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm((Button)sender);
        }
    }
}
