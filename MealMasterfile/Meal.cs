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
using TravelerClasses.MealClasses;
using TravelerDetailsManagementSystem.Common;

namespace TravelerDetailsManagementSystem.MealMasterfile
{
    public partial class Meal : Form
    {
        #region Private Variables
        MealBL mealBL = new MealBL();
        List<Meals> LstMealType;
        List<Meals> LstMeals;
        Meals meals = new Meals();
        string tempMealName="";


        #endregion

        #region Fill Currency
        private void FillCurrency()
        {
            try
            {
                mealBL = new MealBL();
                LstMealType = mealBL.GetMealType();

                cbMealType.DataSource = LstMealType;
                cbMealType.DisplayMember = "MealType";
                cbMealType.ValueMember = "MealTypeID";
                cbMealType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }
        #endregion
        #region Get Meal List
        private void GetMeals()
        {
            try
            {
                mealBL = new MealBL();
                LstMeals = mealBL.GetMeal();
                dgvMeals.ReadOnly = false;
                dgvMeals.DataSource = LstMeals;
            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }
        #endregion
        public Meal()
        {
            InitializeComponent();
            dgvMeals.AutoGenerateColumns = false;
        }

        private void Meal_Load(object sender, EventArgs e)
        {
            try
            {
                FillCurrency();
                GetMeals();
            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMealName.Text == "")
                {
                    CommonModule.ShowWarningMessage("Please enter a Meal Name !");
                }
                else if (cbMealType.Text == "")
                {
                    CommonModule.ShowWarningMessage("Please select a Meal type !");
                }

                tempMealName = txtMealName.Text + "-" + cbMealType.Text;
                meals.MealName = tempMealName;
                meals.MealType = cbMealType.Text;
                meals.MealTypeID = Convert.ToInt32(cbMealType.SelectedValue);
                int recID = mealBL.InsertMeals(meals);
                if (recID > 0)
                {
                    MessageBox.Show(" Meal " + recID.ToString() + "  Saved Successfully", "Successful");
                    txtMealName.Text = "";
                    cbMealType.Refresh();
                    GetMeals();              }
            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }
    }
}
