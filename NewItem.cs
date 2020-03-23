using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DataTriageTransferTool
{
    public partial class NewItem : Form
    {
        public int _case_number { get; set; }
        public string _case_name { get; set; }
        public string _CasePath
        {
            get
            {
                DataTable dataTable = Database.Get.CaseFolder();
                if (dataTable.Rows.Count > 0)
                {
                    return dataTable.Rows[0].Field<string>("location");
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public NewItem(int case_id, string case_name)
        {
            InitializeComponent();
            _case_number = case_id;
            _case_name = case_name;
            GetItems();
            GetSizes();
            GetMedexTypes();
            GetCellexTypes();
        }


        private void CloseForm()
        {
            this.Close();
        }

        private void ButtonCancelNewItem_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void ButtonSaveItem_Click(object sender, EventArgs e)
        {
            SaveNewItem();
        }

        private void SaveNewItem()
        {
            if (radioButtonCELLEX.Checked == false)
            {
                if (radioButtonMEDEX.Checked == false)
                {
                    Messaging.ShowInfoMessageBox("You must select either MEDEX or CELLEX ");
                    return;
                }
            }

            if (radioButtonCELLEX.Checked == false && radioButtonMEDEX.Checked == false)
            {
                Messaging.ShowInfoMessageBox("You must select either MEDEX or CELLEX ");
                return;
            }
            else
            {
                if (comboBoxCellexTypes.SelectedIndex == -1)
                {
                    if(comboBoxMedexTypes.SelectedIndex == -1)
                    {
                        Messaging.ShowInfoMessageBox("You must select either MEDEX or CELLEX type.");
                        return;
                    }
                }
            }

            if (comboBoxCellexTypes.SelectedIndex > -1)
            {
                if (comboBoxCellexTypes.SelectedItem.ToString() == "Other" && textBoxCellexOther.Text == string.Empty)
                {
                    Messaging.ShowInfoMessageBox("If you select other you must put a value in the other box.");
                    return;
                }
            }

            if (comboBoxMedexTypes.SelectedIndex > -1)
            {
                if (comboBoxMedexTypes.SelectedItem.ToString() == "Other" && textBoxMedexOther.Text == string.Empty)
                {
                    Messaging.ShowInfoMessageBox("If you select other you must put a value in the other box.");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(textBoxSize.Text) && comboBoxSizes.SelectedIndex < 0)
            {
                Messaging.ShowInfoMessageBox("If you enter a size you must select a size type.");
                return;
            }

            if (this.checkBoxSubItem.Checked == true && comboBoxExistingItems.SelectedIndex < 0)
            {
                Messaging.ShowInfoMessageBox("If you enter select sub item you must select a case from the drop down.");
                return;
            }

            Item item = new Item();

            if (comboBoxExistingItems.SelectedIndex > -1)
            {
                item.Parent_ID = GetCaseId();
            }

            if (radioButtonMEDEX.Checked == true)
            {
                item.isMedex = 1;
                if (comboBoxMedexTypes.SelectedIndex > -1)
                {
                    if (comboBoxMedexTypes.SelectedItem.ToString() == "Other")
                    {
                        item.Type = textBoxMedexOther.Text;
                    }
                    else
                    {
                        item.Type = comboBoxMedexTypes.SelectedItem.ToString();
                    }
                }
            }

            if (radioButtonCELLEX.Checked == true)
            {
                item.isMobile = 1;

                if (comboBoxCellexTypes.SelectedIndex > -1)
                {
                    if (comboBoxCellexTypes.SelectedItem.ToString() == "Other")
                    {
                        item.Type = textBoxCellexOther.Text;
                    }
                    else
                    {
                        item.Type = comboBoxCellexTypes.SelectedItem.ToString();
                    }
                }
            }

            if (comboBoxCellexTypes.SelectedIndex > -1)
            {
                if (comboBoxCellexTypes.SelectedItem.ToString() == "SIM")
                {
                    item.Type = "SIM";
                    item.isSim = 1;
                }
            }

            item.CaseNumber = GetCaseId();

            if(comboBoxSizes.SelectedIndex > -1)
            {
                item.SizeType_ID = GetSizeId();
            }
            
            item.Size = textBoxSize.Text.ToString();
            item.Make = textBoxMake.Text.Trim();
            item.Comments = tbComments.Text.Trim();
            item.ICCID = textBoxICCID.Text.Trim();
            item.IMEI = textBoxIMEI.Text.Trim();
            item.IMSI = textBoxIMSI.Text.Trim();
            item.SerialNumber = textBoxSerial.Text.Trim();
            item.SubmittedDate = DateTime.Now.ToShortDateString();
            item.UpdatedDate = DateTime.Now.ToShortDateString();
            item.SubscriberAccount = textBoxSubscriberAccount.Text.Trim();
            item.ClosedDate = "1900-01-01";
            item.Model = textBoxModel.Text.Trim();
            item.isSent = 0;
            item.isOpen = 1;
            item.Zipped = 0;
            item.isSubItem = checkBoxSubItem.Checked == true ? 1 : 0;
            
            if (item.isSubItem == 1)
            {

            }
            
            item.Parent_ID = GetCaseId();

            SaveNewItem(item);
        }

        public void GetItems()
        {
            DataTable dataTable = Database.Get.Items(_case_number);
            if (dataTable.Rows.Count > 0)
            {
                comboBoxExistingItems.Items.Clear();
                foreach (DataRow item in dataTable.Rows)
                {
                    string name = dataTable.Rows[0].Field<string>("folder_name");
                    comboBoxExistingItems.Items.Add(name);
                }
            }
        }

        private int GetCaseId()
        {
            DataTable dataTable = Database.Get.Case(_case_number);
            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0].Field<int>("id");
            }
            else
            {
                return -1;
            }
        }
        private string GetCaseName()
        {
            DataTable dataTable = Database.Get.Case(_case_number);
            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0].Field<string>("case_id");
            }
            else
            {
                return string.Empty;
            }
        }
        private string GetCaseName(int case_id)
        {
            DataTable dataTable = Database.Get.Case(case_id);
            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0].Field<string>("case_id");
            }
            else
            {
                return string.Empty;
            }
        }

        private int GetSizeId()
        {
            DataTable dataTable = Database.Get.Size(comboBoxSizes.SelectedItem.ToString());
            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0].Field<int>("id");
            }
            else
            {
                return -1;
            }
        }
        private void GetSizes()
        {
            comboBoxSizes.Items.Clear();

            DataTable dataTable = Database.Get.Sizes();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    comboBoxSizes.Items.Add(item["type"].ToString());
                }

            }
        }
        private double GetItemNumber(Item item)
        {
            double itemNum = 0;
            string caseFolder;
            
            DataTable dataTable1 = Database.Get.CaseFolder();

            if (dataTable1.Rows.Count < 1)
            {
                Messaging.ShowInfoMessageBox("Case folder not found.");
                return -1;
            }

            caseFolder = dataTable1.Rows[0].Field<string>("location");

            List<double> decimalList = new List<double>();
            GFG gg = new GFG();

            string fullPath = Path.Combine(caseFolder, _case_name, "DOMEX");
            string[] items = Directory.GetDirectories(fullPath);

            if (item.isSubItem == 1)
            {
                if (!string.IsNullOrEmpty(_case_name))
                {
                    CheckParent(item);
                    DataTable dataTable = Database.Get.Items(item.Parent_ID);
                    if (dataTable.Rows.Count < 1)
                    {
                        Messaging.ShowInfoMessageBox("Subitem parent not found");
                        return -1;
                    }

                    string[] splitName = dataTable.Rows[0].Field<string>("folder_name").ToString().Split('_');
                    string primaryNum = splitName[0].Substring(0, 1);

                    itemNum = Convert.ToDouble(splitName[0]);

                    foreach (string folder in items)
                    {
                        string[] path = folder.Split('\\');
                        string dirName = path[path.Length - 1];
                        string[] splitName2 = dirName.Split('_');

                        if (splitName2[0].ToString().Substring(0, 1) == primaryNum)
                        {
                            if (splitName2[0].ToString().Contains("."))
                            {
                                decimalList.Add(Convert.ToDouble(splitName2[0]) + .1);
                            }
                        }
                    }

                    //no sub items were created yet
                    if (decimalList.Count < 1)
                    {
                        decimalList.Add(Convert.ToDouble(primaryNum) + .1);
                    }

                    decimalList.Sort(gg);

                    itemNum = decimalList[decimalList.Count - 1];

                    decimalList.Clear();
                }
            }
            else
            {
                foreach (string folder in items)
                {
                    string[] path = folder.Split('\\');
                    string dirName = path[path.Length - 1];
                    string[] splitName = dirName.Split('_');
                    itemNum = Convert.ToDouble(splitName[0]);

                    if (!splitName[0].Contains("."))
                    {
                        decimalList.Add(itemNum);
                    }
                }
                decimalList.Sort(gg);

                if (decimalList.Count > 0)
                {
                    itemNum = decimalList[decimalList.Count - 1] + 1;
                }
                decimalList.Clear();
            }

            if (itemNum == 0)
            {
                itemNum = 1;
            }

            return itemNum;
        }
        private void CheckParent(Item parent)
        {
            string CaseName;
            DataTable dataTable = Database.Get.Item(parent.Parent_ID);
            if (dataTable.Rows.Count < 1)
            {
                Messaging.ShowInfoMessageBox("Case not found.");
                return;
            }

            CaseName = dataTable.Rows[0].Field<string>("case_id");

            if (CaseName.Contains("."))
            {
                Messaging.ShowInfoMessageBox("You cannot nest a sub-item under another sub-item");
            }
        }
        private string CleanName(string nameIn)
        {
            return Regex.Replace(nameIn, @"[^0-9a-zA-Z_-]+:\/", "");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        private void SaveNewItem(Item item)
        {
            double itemNum = GetItemNumber(item);
            string case_name = GetCaseName();

            if (itemNum > 0)
            {
                string itemMake = CleanName(item.Make.Trim());
                string itemModel = CleanName(item.Model.Trim());
                string itemType = CleanName(item.Type.Trim());
                string itemSize = CleanName(item.Size.Trim());
                string itemSerNo = CleanName(item.SerialNumber.Trim());

                string folderName = itemNum + "_" + itemMake + "_" + itemModel + "_" + itemType + "_" + itemSize + "_" + itemSerNo;
                item.folderName = folderName;
                

                item.SubmittedDate = DateTime.Now.ToString("s");
                string newItemDirectory = _CasePath + @"\" + case_name + @"\DOMEX\" + folderName;

                int case_num = GetCaseId();

                Database.Insert.CaseItem(case_num, item.Make, item.Model, item.Size, item.SizeType_ID, item.SerialNumber, item.IMEI, item.ICCID, item.IMSI
                    , item.SubscriberAccount, item.Comments, 0, 0, 1, item.ClosedDate, item.UpdatedDate, item.SubmittedDate, item.Type
                    , item.isMedex, item.isMobile, item.isSim, item.isSubItem, item.Parent_ID, item.folderName);

                if (Directory.Exists(newItemDirectory))
                {
                    Messaging.ShowInfoMessageBox("Directory already exists, please rename.");
                    return;
                }
                else
                {
                    Directory.CreateDirectory(newItemDirectory);
                }

                if (item.isMedex == 1)
                {
                    CreateMedexFolders(newItemDirectory);
                }

                if (item.isMobile == 1)
                {
                    if (item.isSim == 1)
                    {
                        CreateSimFolders(newItemDirectory);
                    }
                    else
                    {
                        CreateMobileFolders(newItemDirectory);
                    }
                }

                textBoxSize.Text = string.Empty;
                textBoxCellexOther.Text = string.Empty;
                textBoxMedexOther.Text = string.Empty;
                textBoxSerial.Text = string.Empty;
                checkBoxSubItem.Checked = false;
                radioButtonCELLEX.Checked = false;
                radioButtonMEDEX.Checked = false;
                comboBoxCellexTypes.SelectedIndex = -1;
                comboBoxMedexTypes.SelectedIndex = -1;
                comboBoxSizes.SelectedIndex = -1;
            }
        }
        private void CreateMobileFolders(string path)
        {
            Directory.CreateDirectory(path + @"\Audio");
            Directory.CreateDirectory(path + @"\Documents");
            Directory.CreateDirectory(path + @"\Documents\Documents of Interest");
            Directory.CreateDirectory(path + @"\Documents\Identification");
            Directory.CreateDirectory(path + @"\Documents\Financial");
            Directory.CreateDirectory(path + @"\Forensic Image");
            Directory.CreateDirectory(path + @"\Encryption");
            Directory.CreateDirectory(path + @"\Case Data");
            Directory.CreateDirectory(path + @"\Case Data\Cellebrite");
            Directory.CreateDirectory(path + @"\Case Data\XRY");
            Directory.CreateDirectory(path + @"\Case Data\AXIOM");
            Directory.CreateDirectory(path + @"\Pictures");
            Directory.CreateDirectory(path + @"\Pictures\Facial Recognition");
            Directory.CreateDirectory(path + @"\Pictures\Images of Interest");
            Directory.CreateDirectory(path + @"\Pictures\Weapons");
            Directory.CreateDirectory(path + @"\Pictures\IED Components");
            Directory.CreateDirectory(path + @"\Pictures\Identification");
            Directory.CreateDirectory(path + @"\Pictures\Documents");
            Directory.CreateDirectory(path + @"\Reports");
            Directory.CreateDirectory(path + @"\Other");
            Directory.CreateDirectory(path + @"\Videos");
            Directory.CreateDirectory(path + @"\Locational Data");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        private void CreateMedexFolders(string path)
        {
            Directory.CreateDirectory(path + @"\Audio");
            Directory.CreateDirectory(path + @"\Documents");
            Directory.CreateDirectory(path + @"\Documents\Documents of Interest");
            Directory.CreateDirectory(path + @"\Documents\Financial");
            Directory.CreateDirectory(path + @"\Documents\Identification");
            Directory.CreateDirectory(path + @"\Forensic Image");
            Directory.CreateDirectory(path + @"\Encryption");
            Directory.CreateDirectory(path + @"\Case Data");
            Directory.CreateDirectory(path + @"\Case Data\Viking");
            Directory.CreateDirectory(path + @"\Case Data\Smirk");
            Directory.CreateDirectory(path + @"\Case Data\Bulk Extractor");
            Directory.CreateDirectory(path + @"\Case Data\Detego");
            Directory.CreateDirectory(path + @"\Case Data\ADF");
            Directory.CreateDirectory(path + @"\Case Data\AXIOM");
            Directory.CreateDirectory(path + @"\Case Data\Advanced Carver");
            Directory.CreateDirectory(path + @"\Case Data\X-Ways");
            Directory.CreateDirectory(path + @"\Case Data\Encryption Search");
            Directory.CreateDirectory(path + @"\Case Data\EXIF Search");
            Directory.CreateDirectory(path + @"\Case Data\Forensic Explorer");
            Directory.CreateDirectory(path + @"\Case Data\VM Mount");
            Directory.CreateDirectory(path + @"\Pictures");
            Directory.CreateDirectory(path + @"\Pictures\Facial Recognition");
            Directory.CreateDirectory(path + @"\Pictures\Images of Interest");
            Directory.CreateDirectory(path + @"\Pictures\IED Components");
            Directory.CreateDirectory(path + @"\Pictures\Weapons");
            Directory.CreateDirectory(path + @"\Pictures\Identification");
            Directory.CreateDirectory(path + @"\Pictures\Documents");
            Directory.CreateDirectory(path + @"\Reports");
            Directory.CreateDirectory(path + @"\Other");
            Directory.CreateDirectory(path + @"\Unallocated Space");
            Directory.CreateDirectory(path + @"\Videos");
            Directory.CreateDirectory(path + @"\Locational Data");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        private void CreateSimFolders(string path)
        {
            Directory.CreateDirectory(path + @"\SIM Forensic Image");
            Directory.CreateDirectory(path + @"\Exploitation Reports");
        }

        private void GetCellexTypes()
        {
            comboBoxCellexTypes.Items.Clear();

            DataTable dataTable = Database.Get.CellexTypes();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    comboBoxCellexTypes.Items.Add(item["type"].ToString());
                }

            }
        }


        private void GetMedexTypes()
        {
            comboBoxMedexTypes.Items.Clear();

            DataTable dataTable = Database.Get.MedexTypes();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    comboBoxMedexTypes.Items.Add(item["type"].ToString());
                }

            }
        }
    }
}
