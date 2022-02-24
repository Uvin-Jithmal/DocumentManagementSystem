using DataAccessLayer.Common;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TravelerClasses.MealClasses;
using static TravelerClasses.Enums;

namespace DataAccessLayer
{
  public  class MealDA
    {
        Execute objExecute;
        MySqlParameter[] param;

        //Retrieve MealType
        public List<Meals> GetMealType()
        {
            List<Meals> lstMealType = new List<Meals>();
            objExecute = new Execute();
            string query = "SELECT * FROM mealtypes";
            DataTable dt = (DataTable)objExecute.Executes(query, ReturnType.DataTable, param, CommandType.Text);

            foreach (DataRow dr in dt.Rows)
            {
                lstMealType.Add(new Meals
                {
                    MealTypeID = Convert.ToInt32(dr["mealTypeID"]),
                    MealType = dr["mealType"].ToString(),
                });
            }

            return lstMealType;
        }
        //Insert Meals
        public int InsertMeals(Meals meals)
        {
            try
            {
                int recID = 0;
                string query = "INSERT INTO meals(mealName, mealTypeID, mealType) " +
                        "VALUES(@MealName, @MealTypeID,@MealType); " +
                        "SELECT LAST_INSERT_ID() AS recID";

                using (TransactionScope scope = new TransactionScope())
                {
                    objExecute = new Execute();
                    param = new MySqlParameter[]
                    {
                    Execute.AddParameter("@MealName",meals.MealName),
                    Execute.AddParameter("@MealTypeID",meals.MealTypeID),
                    Execute.AddParameter("@MealType",meals.MealType),
                   
                    };

                    DataRow dr = (DataRow)objExecute.Executes(query, ReturnType.DataRow, param, CommandType.Text);

                    if (dr != null)
                    {
                        recID = Convert.ToInt32(dr["recID"]);
                    }
                    scope.Complete();
                }
                return recID;
            }
            catch (MySqlException ex)
            {
                if (ex.Number.Equals(1062))
                {
                    throw new Exception("Cost Center " + meals.MealName + "  is Already exist");
                }
                else
                {
                    throw;

                }
            }
        }
        //Retrieve Meal
        public List<Meals> GetMeal()
        {
            List<Meals> lstMealType = new List<Meals>();
            objExecute = new Execute();
            string query = "SELECT * FROM meals";
            DataTable dt = (DataTable)objExecute.Executes(query, ReturnType.DataTable, param, CommandType.Text);

            foreach (DataRow dr in dt.Rows)
            {
                lstMealType.Add(new Meals
                {
                    MealID = Convert.ToInt32(dr["mealID"]),
                    MealName = dr["mealName"].ToString(),
                    MealTypeID = Convert.ToInt32(dr["mealTypeID"]),
                    MealType = dr["mealType"].ToString(),
                });
            }

            return lstMealType;
        }
    }
}
