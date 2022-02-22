using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelerDetailsManagementSystem.Common;

namespace TravelerDetailsManagementSystem.Common
{
    public partial class frmReportViewer : Form
    {
        #region Variables
        public Boolean IsPrintButtonClick = false;
        #endregion

        #region Private Methods
        private void PrinterButton()
        {
            ToolStripButton toolStripButton = new ToolStripButton();
            ToolStrip toolStrip = new ToolStrip();

            foreach (ToolStrip ts in crViewer.Controls.OfType<ToolStrip>())
            {
                toolStrip = ts;
                foreach (ToolStripButton tsb in ts.Items.OfType<ToolStripButton>())
                {
                    if (tsb.ToolTipText.ToLower().Contains("print"))
                    {
                        toolStripButton = tsb;
                        tsb.Click += null;
                        tsb.Click += new EventHandler(EventClick);
                    }
                }
            }
        }

        private void EventClick(object sender, EventArgs e)
        {
            IsPrintButtonClick = true;
        }
        #endregion        

        public frmReportViewer()
        {
            InitializeComponent();
        }

        public frmReportViewer(ReportDocument reportDocument)
        {
            InitializeComponent();
            crViewer.ReportSource = reportDocument;
            reportDocument.Refresh();
            PrinterButton();
        }

        private void crViewer_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = CommonModule.strSystemCode + "| Report Viewer";
            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
