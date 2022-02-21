using DataAccessLayer.Connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static TravelerClasses.Enums;

namespace DataAccessLayer.Common
{
    public class Execute
    {
        #region Private Variables
        private MySqlCommand SqlCmd;
        private MySqlDataAdapter SqlAdp;
        private static MySqlParameter Param;
        #endregion

        #region Private Methods
        private object ReturnType(string SelectQuery, MySqlParameter[] _SqlParameter, CommandType cmdType, ReturnType ReturnType)
        {
            MySqlConnection conn = null;
            Object objValue = new object();
            try
            {
                SqlCmd = new MySqlCommand();
                DataSet ds = new DataSet();
                conn = SqlConn.OpenConnectiion();
                SqlCmd.Connection = conn;
                SqlCmd.CommandText = SelectQuery;
                SqlCmd.CommandType = cmdType;
                SqlCmd.CommandTimeout = 300;

                if (_SqlParameter != null && _SqlParameter.Count() > 0)
                {
                    for (int i = 0; i < _SqlParameter.Length; i++)
                    {
                        SqlCmd.Parameters.Add(_SqlParameter[i]);
                    }
                }

                SqlAdp = new MySqlDataAdapter(SqlCmd);
                SqlAdp.Fill(ds);

                switch (ReturnType)
                {
                    case (ReturnType.DataTable):
                        {
                            objValue = ds.Tables[0];
                        }
                        break;

                    case (ReturnType.DataSet):
                        {
                            objValue = ds;
                        }
                        break;

                    case (ReturnType.DataRow):
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                objValue = ds.Tables[0].Rows[0];
                            }
                            else
                            {
                                DataRow dr = null;
                                objValue = dr;
                            }

                        }
                        break;
                }
                return objValue;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
                SqlCmd = null;
            }
        }
        #endregion

        public static MySqlParameter AddParameter(string Name, object Value)
        {
            Param = new MySqlParameter()
            {
                ParameterName = Name,
                Value = Value
            };
            return Param;
        }

        public object Executes(string SelectQuery, ReturnType ReturnType, MySqlParameter[] _SqlParameter, CommandType cmdType)
        {
            Object objValue = new object();
            objValue = this.ReturnType(SelectQuery, _SqlParameter, cmdType, ReturnType);
            return objValue;
        }

        public int Executes(string cmdText, MySqlParameter[] _SqlParameter, CommandType cmdType)
        {
            int NoOfRowsEffected = 0;
            SqlCmd = new MySqlCommand();
            MySqlConnection conn = null;
            try
            {
                conn = SqlConn.OpenConnectiion();
                SqlCmd.Connection = conn;
                SqlCmd.CommandType = cmdType;
                SqlCmd.CommandText = cmdText;
                SqlCmd.CommandTimeout = 600;
                for (int i = 0; i < _SqlParameter.Length; i++)
                    SqlCmd.Parameters.Add(_SqlParameter[i]);
                NoOfRowsEffected = SqlCmd.ExecuteNonQuery();
                return NoOfRowsEffected;
            }

            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
                SqlCmd = null;
            }
        }

        public int ExecutesWithTransactionScope(string cmdText, MySqlParameter[] _SqlParameter, CommandType cmdType)
        {
            int NoOfRowsEffected = 0;
            SqlCmd = new MySqlCommand();
            MySqlConnection conn = null;
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    conn = SqlConn.OpenConnectiion();
                    SqlCmd.Connection = conn;
                    SqlCmd.CommandType = cmdType;
                    SqlCmd.CommandText = cmdText;
                    SqlCmd.CommandTimeout = 600;
                    for (int i = 0; i < _SqlParameter.Length; i++)
                        SqlCmd.Parameters.Add(_SqlParameter[i]);
                    NoOfRowsEffected = SqlCmd.ExecuteNonQuery();
                    scope.Complete();
                }
                return NoOfRowsEffected;
            }

            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
                SqlCmd = null;
            }
        }

        public bool CheckConnection()
        {
            return SqlConn.CheckConnectionIsAvialable();
        }
    }
}
