using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelerClasses;
using static TravelerClasses.Enums;

namespace TravelerDetailsManagementSystem.Common
{
    public partial class frmCommonSearch : Form
    {
        #region Private Variables
        List<Search> objSearchListAll = new List<Search>();
        List<Search> objSearchListFiltered;
        string intSelectedID;
        String strReturnString;
        Search objReturnObject;
        Int16[] intSortToDataType;
        Boolean blnRetValEnable;
        Boolean blnIsAsc = true;
        bool _gotoNextSearch = false;
        #endregion

        #region Public/Private Methods
        public string ReturnID()
        {
            return intSelectedID;
        }

        public String ReturnString()
        {
            return strReturnString;
        }

        public Search ReturnObject()
        {
            return objReturnObject;
        }
        private void Sort(int intColIndex)
        {
            List<Search> objSearchItemList = (List<Search>)gridSearch.DataSource;


            string strFld;
            if (intColIndex == 0)
                strFld = "SearchID";
            else
                strFld = "SearchFld" + intColIndex.ToString();

            if ((intSortToDataType[intColIndex] == Convert.ToInt16(DataTypes.Int16)) || (intSortToDataType[intColIndex] == Convert.ToInt16(DataTypes.Int32)) || (intSortToDataType[intColIndex] == Convert.ToInt16(DataTypes.Int64)))
            {
                if (blnIsAsc)
                    objSearchItemList = objSearchItemList.OrderBy(o => Convert.ToInt64(o.GetType().GetProperty(strFld).GetValue(o, null))).ToList();
                else
                    objSearchItemList = objSearchItemList.OrderByDescending(o => Convert.ToInt64(o.GetType().GetProperty(strFld).GetValue(o, null))).ToList();
            }
            else if (intSortToDataType[intColIndex] == Convert.ToInt16(DataTypes.Date))
            {
                if (blnIsAsc)
                    objSearchItemList = objSearchItemList.OrderBy(o => Convert.ToDateTime(o.GetType().GetProperty(strFld).GetValue(o, null).ToString() == "" ? "01-Jan-1900" : o.GetType().GetProperty(strFld).GetValue(o, null))).ToList();
                else
                    objSearchItemList = objSearchItemList.OrderByDescending(o => Convert.ToDateTime(o.GetType().GetProperty(strFld).GetValue(o, null).ToString() == " " ? "01-Jan-1900" : o.GetType().GetProperty(strFld).GetValue(o, null))).ToList();

            }
            else if (intSortToDataType[intColIndex] == Convert.ToInt16(DataTypes.Decimal))
            {
                if (blnIsAsc)
                    objSearchItemList = objSearchItemList.OrderBy(o => Convert.ToDecimal(o.GetType().GetProperty(strFld).GetValue(o, null))).ToList();
                else
                    objSearchItemList = objSearchItemList.OrderByDescending(o => Convert.ToDecimal(o.GetType().GetProperty(strFld).GetValue(o, null))).ToList();

            }
            else if (intSortToDataType[intColIndex] == Convert.ToInt16(DataTypes.Boolean))
            {
                if (blnIsAsc)
                    objSearchItemList = objSearchItemList.OrderBy(o => Convert.ToBoolean(o.GetType().GetProperty(strFld).GetValue(o, null))).ToList();
                else
                    objSearchItemList = objSearchItemList.OrderByDescending(o => o.GetType().GetProperty(strFld).GetValue(o, null)).ToList();
            }
            else
            {
                if (blnIsAsc)
                    objSearchItemList = objSearchItemList.OrderBy(o => o.GetType().GetProperty(strFld).GetValue(o, null)).ToList();
                else
                    objSearchItemList = objSearchItemList.OrderByDescending(o => o.GetType().GetProperty(strFld).GetValue(o, null)).ToList();
            }

            gridSearch.DataSource = objSearchItemList;
            lblSortedBy.Text = gridSearch.Columns[intColIndex].HeaderText + (blnIsAsc ? " (Ascending)" : " (Descending)");
            lblSortedColID.Text = intColIndex.ToString();
        }

        private void GetNextSearch()
        {
            if (!chkAll.Checked)
            {
                int intIndex = Convert.ToInt16(lblIndex.Text);
                intIndex += 1;

                if (intIndex > gridSearch.ColumnCount - 1)
                    intIndex = 0;

                for (int i = intIndex; i < gridSearch.ColumnCount; i++)
                {
                    DataGridViewColumn dgvC = gridSearch.Columns[i];

                    if (gridSearch.Columns[i].Visible == false || dgvC.GetType() == typeof(DataGridViewImageColumn))
                        intIndex += 1;
                    else
                        break;

                    if (intIndex > gridSearch.ColumnCount - 1)
                    {
                        intIndex = 0;
                        i = -1;
                        continue;
                    }

                    dgvC = gridSearch.Columns[i + 1];
                    if (gridSearch.Columns[i + 1].Visible == true || dgvC.GetType() == typeof(DataGridViewImageColumn))
                        break;
                }

                lblIndex.Text = (intIndex).ToString();
                lblSearchBy.Text = gridSearch.Columns[intIndex].HeaderText;
            }
            else
            {
                lblIndex.Text = (0).ToString();
                lblSearchBy.Text = "*";
            }
        }

        private void SearchGrid()
        {
            
            objSearchListFiltered = new List<Search>();

            if (chkAll.Checked)
            {
                if (!string.IsNullOrEmpty(txtSearchText.Text))
                {
                    var filteredUsersList = objSearchListAll.WhereAtLeastOneProperty((string s) => s != null && s.ToLower().Contains(txtSearchText.Text)).ToList();
                    gridSearch.DataSource = filteredUsersList.ToList();
                }
                else
                {
                    gridSearch.DataSource = objSearchListAll;
                }
            }
            else
            {
                int index = Convert.ToInt16(lblIndex.Text);
                if (index < 0)
                    return;
                string strFld = "";
                if (index == 0)
                    strFld = "SearchID";
                else
                    strFld = "SearchFld" + index.ToString();

                if (!String.IsNullOrEmpty(txtSearchText.Text))
                {
                    objSearchListFiltered = objSearchListAll.FindAll(x => (x.GetType().GetProperty(strFld).GetValue(x, null).ToString().ToUpper().Contains(txtSearchText.Text.ToString().Trim().ToUpper())));

                    gridSearch.DataSource = objSearchListFiltered;
                }
                else
                {
                    gridSearch.DataSource = objSearchListAll;
                }
            }
            Sort(Convert.ToInt16(lblSortedColID.Text));
        }

        private void Return(Int32 intRow)
        {
            intSelectedID = Convert.ToString(gridSearch.Rows[intRow].Cells["clmID"].Value);
            if (gridSearch.Rows[intRow].Cells["clmSearchFld6"].Value != null)
                strReturnString = gridSearch.Rows[intRow].Cells["clmSearchFld6"].Value.ToString();
            else
                strReturnString = "";

            List<Search> lstSearch = (List<Search>)gridSearch.DataSource;
            objReturnObject = lstSearch[intRow];
            this.Close();
        }
        #endregion

        public frmCommonSearch()
        {
            InitializeComponent();            
        }

        public frmCommonSearch(List<Search> lstSearch, Boolean[] blnColVisible, String[] strColName, String strFormHeader, int intSortCol, Boolean blnIsSortAsc, int intAutoFillCol, int[] intColWidth, Int16[] intDataType, String strFilterValue, Int16[] intColumnType, Boolean blnRValEnable, int ColHeaderLine)
        {
            InitializeComponent();

            gridSearch.AutoGenerateColumns = false;
            ShowInTaskbar = false;
            objSearchListAll = lstSearch;
            gridSearch.DataSource = objSearchListAll;
            blnRetValEnable = blnRValEnable;

            for (int i = 0; i < intColumnType.Length; i++)
            {
                if (intColumnType[i] == Convert.ToInt16(ColumnType.CheckBoxColumn))
                {
                    DataGridViewCheckBoxColumn dgvCol = new DataGridViewCheckBoxColumn();
                    dgvCol.ReadOnly = gridSearch.Columns[i].ReadOnly;
                    dgvCol.DataPropertyName = gridSearch.Columns[i].DataPropertyName;
                    gridSearch.Columns.RemoveAt(i);
                    gridSearch.Columns.Insert(i, dgvCol);
                }
                else if (intColumnType[i] == Convert.ToInt16(ColumnType.ImageColumn))
                {
                    DataGridViewImageColumn dgvICol = new DataGridViewImageColumn();
                    dgvICol.ReadOnly = gridSearch.Columns[i].ReadOnly;
                    dgvICol.DataPropertyName = "SearchImage";
                    gridSearch.Columns.RemoveAt(i);
                    gridSearch.Columns.Insert(i, dgvICol);
                }
            }

            for (int i = 0; i < blnColVisible.Length; i++)
            {
                gridSearch.Columns[i].Visible = blnColVisible[i];
            }

            for (int i = 0; i < intColWidth.Length; i++)
            {
                gridSearch.Columns[i].Width = intColWidth[i];
            }

            gridSearch.Columns[intAutoFillCol - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < strColName.Length; i++)
            {
                gridSearch.Columns[i].HeaderText = strColName[i];

            }

            for (int i = 0; i < intDataType.Length; i++)
            {
                if ((intDataType[i] == Convert.ToInt16(DataTypes.Int16)) || (intDataType[i] == Convert.ToInt16(DataTypes.Int32)) || (intDataType[i] == Convert.ToInt16(DataTypes.Int64)) || (intDataType[i] == Convert.ToInt16(DataTypes.Decimal)))
                    gridSearch.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                else if (intDataType[i] == Convert.ToInt16(DataTypes.String))
                    gridSearch.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                else if (intDataType[i] == Convert.ToInt16(DataTypes.Date))
                {
                    objSearchListAll.ForEach(a => { a.GetType().GetProperty("SearchFld" + i.ToString()).SetValue(a, (((Convert.ToDateTime(a.GetType().GetProperty("SearchFld" + i.ToString()).GetValue(a, null)).ToString("dd-MMM-yyyy")) == "01-Jan-1900" || ((Convert.ToDateTime(a.GetType().GetProperty("SearchFld" + i.ToString()).GetValue(a, null)).ToString("dd-MMM-yyyy")) == "01-Jan-2000") ? "" : (Convert.ToDateTime(a.GetType().GetProperty("SearchFld" + i.ToString()).GetValue(a, null)).ToString("dd-MMM-yyyy")))), null); });
                    gridSearch.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else
                    gridSearch.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            intSortToDataType = intDataType;

            this.Text = CommonModule.strSystemCode + " | " + strFormHeader;
            blnIsAsc = blnIsSortAsc;
            Sort(intSortCol);

            txtSearchText.Text = strFilterValue;

            int ColHeaderHeight = 23;
            gridSearch.ColumnHeadersHeight = ColHeaderHeight * ColHeaderLine;

            gridSearch.ClearSelection();
            txtSearchText.Focus();

        }

        public frmCommonSearch(List<Search> lstSearch, Boolean[] blnColVisible, String[] strColName, String strFormHeader, int intSortCol, Boolean blnIsSortAsc, int intAutoFillCol, int[] intColWidth, Int16[] intDataType, String strFilterValue, Int16[] intColumnType, Boolean blnRValEnable, int ColHeaderLine, bool gotoNextSearch)
        {
            InitializeComponent();

            gridSearch.AutoGenerateColumns = false;
            this._gotoNextSearch = gotoNextSearch;
            objSearchListAll = lstSearch;
            gridSearch.DataSource = objSearchListAll;
            blnRetValEnable = blnRValEnable;

            for (int i = 0; i < intColumnType.Length; i++)
            {
                if (intColumnType[i] == Convert.ToInt16(ColumnType.CheckBoxColumn))
                {
                    DataGridViewCheckBoxColumn dgvCol = new DataGridViewCheckBoxColumn();
                    dgvCol.ReadOnly = gridSearch.Columns[i].ReadOnly;
                    dgvCol.DataPropertyName = gridSearch.Columns[i].DataPropertyName;
                    gridSearch.Columns.RemoveAt(i);
                    gridSearch.Columns.Insert(i, dgvCol);
                }
                else if (intColumnType[i] == Convert.ToInt16(ColumnType.ImageColumn))
                {
                    DataGridViewImageColumn dgvICol = new DataGridViewImageColumn();
                    dgvICol.ReadOnly = gridSearch.Columns[i].ReadOnly;
                    dgvICol.DataPropertyName = "SearchImage";
                    gridSearch.Columns.RemoveAt(i);
                    gridSearch.Columns.Insert(i, dgvICol);
                }
            }

            for (int i = 0; i < blnColVisible.Length; i++)
            {
                gridSearch.Columns[i].Visible = blnColVisible[i];
            }

            for (int i = 0; i < intColWidth.Length; i++)
            {
                gridSearch.Columns[i].Width = intColWidth[i];
            }

            gridSearch.Columns[intAutoFillCol - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < strColName.Length; i++)
            {
                gridSearch.Columns[i].HeaderText = strColName[i];

            }

            for (int i = 0; i < intDataType.Length; i++)
            {
                if ((intDataType[i] == Convert.ToInt16(DataTypes.Int16)) || (intDataType[i] == Convert.ToInt16(DataTypes.Int32)) || (intDataType[i] == Convert.ToInt16(DataTypes.Int64)) || (intDataType[i] == Convert.ToInt16(DataTypes.Decimal)))
                    gridSearch.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                else if (intDataType[i] == Convert.ToInt16(DataTypes.String))
                    gridSearch.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                else if (intDataType[i] == Convert.ToInt16(DataTypes.Date))
                {
                    objSearchListAll.ForEach(a => { a.GetType().GetProperty("SearchFld" + i.ToString()).SetValue(a, (((Convert.ToDateTime(a.GetType().GetProperty("SearchFld" + i.ToString()).GetValue(a, null)).ToString("dd-MMM-yyyy")) == "01-Jan-1900" || ((Convert.ToDateTime(a.GetType().GetProperty("SearchFld" + i.ToString()).GetValue(a, null)).ToString("dd-MMM-yyyy")) == "01-Jan-2000") ? "" : (Convert.ToDateTime(a.GetType().GetProperty("SearchFld" + i.ToString()).GetValue(a, null)).ToString("dd-MMM-yyyy")))), null); });
                    gridSearch.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else
                    gridSearch.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            intSortToDataType = intDataType;

            this.Text = CommonModule.strSystemCode + " | " + strFormHeader;
            blnIsAsc = blnIsSortAsc;
            Sort(intSortCol);

            txtSearchText.Text = strFilterValue;

            int ColHeaderHeight = 23;
            gridSearch.ColumnHeadersHeight = ColHeaderHeight * ColHeaderLine;

            gridSearch.ClearSelection();
            txtSearchText.Focus();
        }

        private void frmCommonSearch_Load(object sender, EventArgs e)
        {
            try
            {
                chkAll.Checked = true;
                GetNextSearch();
                SearchGrid();
                gridSearch.ClearSelection();
                txtSearchText.Focus();
                

                if (_gotoNextSearch)
                {
                    GetNextSearch();
                }
            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }

        private void txtSearchText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F2 && !chkAll.Checked)
                {
                    GetNextSearch();
                    SearchGrid();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    Return(gridSearch.CurrentRow.Index);
                }
                else if (e.KeyCode.Equals(Keys.Down))
                {
                    gridSearch.Select();
                    foreach (DataGridViewRow dr in gridSearch.Rows)
                    {
                        dr.Selected = true;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchGrid();
            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }

        private void frmCommonSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                GetNextSearch();
                SearchGrid();
                txtSearchText.Focus();
            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }

        private void gridSearch_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (blnRetValEnable)
                {
                    if (e.RowIndex >= 0)
                        Return(e.RowIndex);
                }
            }

            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }

        private void gridSearch_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (blnRetValEnable)
                {
                    if (e.KeyCode == Keys.Enter)
                        Return(gridSearch.CurrentRow.Index);
                }
            }

            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }

        private void gridSearch_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Convert.ToInt16(lblSortedColID.Text) == e.ColumnIndex)
                    blnIsAsc = !blnIsAsc;
                else
                    blnIsAsc = true;

                Sort(e.ColumnIndex);
            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }

        private void gridSearch_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Convert.ToInt16(lblSortedColID.Text) == e.ColumnIndex)
                    blnIsAsc = !blnIsAsc;
                else
                    blnIsAsc = true;

                Sort(e.ColumnIndex);
            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }

        private void gridSearch_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            txtSearchText.Focus();
        }
    }
}
