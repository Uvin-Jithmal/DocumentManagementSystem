using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerClasses
{
    public class Enums
    {
        public enum ReturnType
        {
            DataTable = 1,
            DataRow = 2,
            DataSet = 3
        };

        public enum DataTypes
        {
            Int16 = 1,
            Int32 = 2,
            Int64 = 3,
            String = 4,
            Date = 5,
            Decimal = 6,
            Boolean = 7,
            Image = 8,
            DateTime = 9,
        };

        public enum ColumnType
        {
            TextBoxColumn = 1,
            CheckBoxColumn = 2,
            ImageColumn = 3
        };

        public enum Months
        {
            January = 1,

        }

        public enum PaymentMethods
        {
            Cash = 1,
            Cheque = 2,
            CreditCard = 3,
            DirectDeposit = 4
        };

        public enum TransactionActivity
        {
            Save = 1,
            Update = 2,
            Delete = 3
        }

        public enum StockAdjustmentType
        {
            Add = 1,
            Deduct = 2
        }
    }
}
