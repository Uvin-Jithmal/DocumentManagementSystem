using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelerClasses.OutgoingClasses;
using TravelerDetailsManagementSystem.Common;

namespace TravelerDetailsManagementSystem
{
    public partial class AddUsers : Form
    {

        #region Private Variables

        Users ObjUsers = new Users();
        OutgoingBL ObjoutgoingBL = new OutgoingBL();

        #endregion

        public AddUsers()
        {
            InitializeComponent();
        }

        private void btnHrDocSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    CommonModule.ShowWarningMessage("Please Fill User Name");
                }
                else if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    CommonModule.ShowWarningMessage("Please Give Password");
                }
                else if (string.IsNullOrWhiteSpace(comboDepartment.Text))
                {
                    CommonModule.ShowWarningMessage("Please Select Department");
                }
                else
                {
                    ObjUsers.UserName = txtUserName.Text;
                    ObjUsers.Password = txtPassword.Text;
                    ObjUsers.Department = comboDepartment.Text;
                    ObjUsers.AddedDate = DateTime.Now;
                }

                int recID = ObjoutgoingBL.InsertDMSUsers(ObjUsers);
                if (recID > 0)
                {
                    MessageBox.Show("User " + txtUserName.Text + " Saved Successfully", "Successful");
                    CommonModule.ClearControlsOftheForm(this);
                }

            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }
    }
}
