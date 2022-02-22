using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelerDetailsManagementSystem.Common
{
    public static class CommonModule
    {
        #region Private Variables
        public static string strSystemName = "ERP Application";
        public static string strSystemCode = "ERP";
        public static int LocId = 9;
        //public static CommonManager commonManager;
        //private static List<ControllerProperties> UCControllers = new List<ControllerProperties>();
        private static int gap = 5;

        private const int Keysize = 256;
        private const int DerivationIterations = 1000;
        #endregion

        #region Private Methods
        private static void WriteErrorLogToText(Exception ex)
        {
            string strErrorLines = DateTime.Now.ToString() + " | " + SystemInformation.ComputerName.ToString() +
                Environment.NewLine + ex.ToString() + Environment.NewLine + "******************************************************** " +
                "***********************************************************************************************************************";

            String strFilePath = "D:\\SystemErrors";

            if (!Directory.Exists(strFilePath))
                Directory.CreateDirectory(strFilePath);

            String strErrorLogFile = strFilePath + "\\" + " " + "_ErrorLog.txt";
            if (!File.Exists(strErrorLogFile))
                File.Create(strErrorLogFile).Close();

            StreamWriter objStreamWriter = new StreamWriter(strErrorLogFile, true);
            objStreamWriter.WriteLine(strErrorLines);
            objStreamWriter.Close();
        }
        #endregion

        #region Messages Methods

        public static void ShowErrorMessage(Exception ex)
        {
            WriteErrorLogToText(ex);
            MessageBox.Show(ex.Message, strSystemName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarningMessage(String strMessage)
        {
            MessageBox.Show(strMessage + "..!", strSystemName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowSucessMessage(String strMessage)
        {
            MessageBox.Show(strMessage + "..!", strSystemName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static Boolean ShowQuestionMessage(String strMessage)
        {
            if (MessageBox.Show(strMessage + " ?", strSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else
                return false;
        }
        #endregion

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }


        public static List<Control> GetAllControls(Control container, Boolean IsWithLables, List<Control> ControlList)
        {
            foreach (Control c in container.Controls)
            {
                GetAllControls(c, IsWithLables, ControlList);
                if (!IsWithLables && !((c is Label) || (c is Button)))
                    ControlList.Add(c);
                else if (IsWithLables)
                    ControlList.Add(c);
            }
            return ControlList;

        }


        #region Clear Controls
        public static void ClearControlsOftheForm(Control container)
        {
            DateTimePicker dtp = new DateTimePicker();
            TextBox txt = new TextBox();
            RichTextBox rtxt = new RichTextBox();
            CheckBox chk = new CheckBox();
            RadioButton radio = new RadioButton();
            NumericUpDown num = new NumericUpDown();
            ComboBox cmb = new ComboBox();
            DataGridView dgv = new DataGridView();

            MaterialTextBox mtxt = new MaterialTextBox();
            MaterialComboBox mcmb = new MaterialComboBox();
            List<Control> ControlList = new List<Control>();
            MaterialCheckbox mchk = new MaterialCheckbox();
            MaterialMultiLineTextBox mltxt = new MaterialMultiLineTextBox();
            MaterialSwitch mlswt = new MaterialSwitch();


            ControlList = GetAllControls(container, false, ControlList);

            foreach (Control ctrl in ControlList)
            {
                if (ctrl.GetType().Equals(typeof(DateTimePicker)))
                {
                    dtp = (DateTimePicker)ctrl;
                    dtp.Value = DateTime.Now;
                }

                if (ctrl.GetType().Equals(typeof(TextBox)))
                {
                    txt = (TextBox)ctrl;
                    txt.Text = "";
                    txt.Tag = "0";
                }
                if (ctrl.GetType().Equals(typeof(RichTextBox)))
                {
                    rtxt = (RichTextBox)ctrl;
                    rtxt.Text = "";
                    rtxt.Tag = "0";
                }
                if (ctrl.GetType().Equals(typeof(MaterialTextBox)))
                {
                    mtxt = (MaterialTextBox)ctrl;
                    mtxt.Text = "";
                    mtxt.Tag = "0";
                }
                if (ctrl.GetType().Equals(typeof(MaterialMultiLineTextBox)))
                {
                    mltxt = (MaterialMultiLineTextBox)ctrl;
                    mltxt.Text = "";
                    mltxt.Tag = "0";
                }
                else if (ctrl.GetType().Equals(typeof(CheckBox)))
                {
                    chk = (CheckBox)ctrl;
                    chk.Checked = false;
                }
                else if (ctrl.GetType().Equals(typeof(RadioButton)))
                {
                    radio = (RadioButton)ctrl;
                    radio.Checked = false;
                }
                else if (ctrl.GetType().Equals(typeof(MaterialCheckbox)))
                {
                    mchk = (MaterialCheckbox)ctrl;
                    mchk.Checked = false;
                }
                else if (ctrl.GetType().Equals(typeof(NumericUpDown)))
                {
                    num = (NumericUpDown)ctrl;
                    num.Value = 0M;
                }

                else if (ctrl.GetType().Equals(typeof(ComboBox)))
                {
                    cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = -1;
                    cmb.Tag = "0";
                }
                else if (ctrl.GetType().Equals(typeof(MaterialComboBox)))
                {
                    mcmb = (MaterialComboBox)ctrl;
                    mcmb.SelectedIndex = -1;
                    mcmb.Tag = "0";
                }
                else if (ctrl.GetType().Equals(typeof(DataGridView)))
                {
                    dgv = (DataGridView)ctrl;
                    dgv.DataSource = null;
                }

                else if (ctrl.GetType().Name == "NumericEditTextBox")
                {
                    txt = (TextBox)ctrl;
                    txt.Text = "";
                }
                else if (ctrl.GetType().Name == "NumericTextBox")
                {
                    txt = (TextBox)ctrl;
                    txt.Text = "";
                }
                else if (ctrl.GetType().Equals(typeof(MaterialSwitch)))
                {
                    mlswt = (MaterialSwitch)ctrl;
                    mlswt.Checked = true;
                }
            }

        }
        #endregion


        #region Validations
        public static bool ValidateEmailAddress(string value)
        {
            try
            {
                MailAddress m = new MailAddress(value);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool ValidateMobileNo(string value)
        {
            bool res = false;
            if (value.Length.Equals(10))
            {
                res = true;
            }
            return res;
        }

        public static bool ValidateChequeNo(string value)
        {
            bool res = false;
            if (value.Length.Equals(6))
            {
                res = true;
            }
            return res;
        }


        //Avoid Front Space
        public static bool ValidateSpaces(object t, KeyPressEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)t;
            bool res = false;

            if (txt.Text.Length == 0)
            {
                if (e.Handled = (e.KeyChar == (char)Keys.Space))
                {
                    CommonModule.ShowWarningMessage("Cannot Enter front Spaces");
                }
            }
            return res;
        }

        //validate Digits
        public static bool ValidateDigits(object t, KeyPressEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)t;
            bool res = false;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                CommonModule.ShowWarningMessage("Please Enter Digits");
            }
            return res;
        }

        #endregion


        #region Public Methods


        //Save To LogFile Data
        public static string SaveLogData(object str)
        {
            string value = "";

            return value;
        }

        public static void SetTextBoxAutoComplete(TextBox textbox, List<string> itemList)
        {
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(itemList.ToArray());
            //textbox.AutoSize = false;
            textbox.Multiline = false;
            textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textbox.AutoCompleteCustomSource = autoCompleteStringCollection;

        }

        public static string GetName<T>(this T item) where T : class
        {
            if (item == null)
                return string.Empty;

            return typeof(T).GetProperties()[0].Name;
        }

        public static int GetIntValue(object str)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(str); ;
                return value;
            }
            catch
            {
                return value;
                throw;
            }
        }

        public static bool GetBoolValue(object str)
        {
            bool value = false;
            try
            {
                value = Convert.ToBoolean(str);
                return value;
            }
            catch
            {
                return value;
                throw;
            }
        }

        public static decimal GetDecimalValue(object str)
        {
            decimal value = 0;
            try
            {
                value = Convert.ToDecimal(str);
                return value;
            }
            catch
            {
                return value;
                throw;
            }
        }

        public static string GetStringValue(object str)
        {
            string value = "";
            try
            {
                value = Convert.ToString(str);
                return value;
            }
            catch
            {
                return value;
                throw;
            }
        }

        public static double GetDoubleValue(object str)
        {
            double value = 0;
            try
            {
                value = Convert.ToDouble(str);
                return value;
            }
            catch
            {
                return value;
                throw;
            }
        }

        public static bool IsintegerChar(char chr, string str)
        {
            bool status = false;
            if (!char.IsControl(chr) && !char.IsDigit(chr) && (chr != '.') && (chr != '-'))
            {
                status = true;
            }
            //only allow one decimal point
            if ((chr == '.') && ((str.ToString().IndexOf('.') > -1)))
            {
                status = true;
            }
            // only allow one - mark
            if ((chr == '-') && ((str.ToString().IndexOf('-') > -1)))
            {
                status = true;
            }
            return status;
        }

        public static bool IsGreaterThanZero(object value)
        {
            if (value is IConvertible)
            {
                return Convert.ToDouble(value) > 0.0;
            }

            return false;
        }

        public static int GetDecimalPlaces(decimal n)
        {
            n = Math.Abs(n); //make sure it is positive.
            n -= (int)n;     //remove the integer part of the number.
            var decimalPlaces = 0;
            while (n > 0)
            {
                decimalPlaces++;
                n *= 10;
                n -= (int)n;
            }
            return decimalPlaces;
        }


        public static string Encrypt(string plainText, string passPhrase)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(string cipherText, string passPhrase)
        {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }

        #region Auto Check TreeNode Child Nodes
        public static void AutoCheckChildNodes(object t, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
            SelectParents(e.Node, e.Node.Checked);
        }

        private static void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        private static void SelectParents(TreeNode node, Boolean isChecked)
        {
            var parent = node.Parent;

            if (parent == null)
                return;

            if (!isChecked && HasCheckedNode(parent))
                return;

            parent.Checked = isChecked;
            SelectParents(parent, isChecked);
        }

        private static bool HasCheckedNode(TreeNode node)
        {
            return node.Nodes.Cast<TreeNode>().Any(n => n.Checked);
        }

        #endregion

        #endregion

        //public static void SaveLogData(TransactionActivity Activity, int FormID, int ButtonID, string DocumentRefNo, string SQLQuery, string JsonQuery)
        //{
        //    Log objLog = new Log();
        //    objLog.UserID = LogUser.UserID;
        //    objLog.UserGroup = LogUser.UserGroupID;
        //    objLog.MachineName = Environment.MachineName;
        //    objLog.IPAddress = Dns.GetHostAddresses(Dns.GetHostName())[0].ToString();
        //    objLog.Activity = Activity;
        //    objLog.FormID = FormID;
        //    objLog.ButtonID = ButtonID;
        //    objLog.DocumentRefNo = DocumentRefNo;
        //    objLog.SQLQuery = SQLQuery;
        //    objLog.JSonQuery = JsonQuery;

        //    MasterBL objMasterBL = new MasterBL();
        //    objMasterBL.SaveLogData(objLog);

        //}
    }
}
