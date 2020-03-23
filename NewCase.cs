using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace DataTriageTransferTool
{
    public partial class NewCase : Form
    {
        public string _CasePath { 
            get {
                DataTable dataTable = Database.Get.CaseFolder();
                if(dataTable.Rows.Count > 0)
                {
                    return dataTable.Rows[0].Field<string>("location");
                }
                else
                {
                    return string.Empty;
                }
            } 
        }


        public NewCase()
        {
            InitializeComponent();
            GetAORs();
            GetClassifications();
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void ButtonSaveCase_Click(object sender, EventArgs e)
        {
            SaveCase();
        }

        private void SaveCase()
        {
            if (ComboBoxAor.SelectedIndex < 0)
            {
                Messaging.ShowInfoMessageBox("You must select an AOR.");
                return;
            }

            if (ComboBoxClassification.SelectedIndex < 0)
            {
                Messaging.ShowInfoMessageBox("You must select a classification.");
                return;
            }

            DT3Case item = new DT3Case();

            item.AOR_ID = GetAorId(ComboBoxAor.SelectedItem.ToString().Trim());
            item.CaseNumber = textBoxCaseId.Text.Trim();
            item.Classification_ID = GetClassificationId(ComboBoxClassification.SelectedItem.ToString().Trim());
            item.Comments = TextBoxComments.Text.Trim();
            item.SubmittedDate = DateTime.Now.ToShortDateString().Trim();
            item.MGRS = TextBoxMgrs.Text.Trim();
            item.Objective = TextBoxObjective.Text.Trim();
            item.SubmitterEmail = TextBoxSubmitterEmail.Text.Trim();
            item.SubmitterName = TextBoxSubmitterName.Text.Trim();
            item.UpdatedDate = DateTime.Now.ToShortDateString().Trim();
            item.SubjectName = TextBoxSubjectName.Text.Trim();
            item.Open = 1;
            item.Sent = 0;
            item.Zipped = 0;

            try
            {
                Database.Insert.Case(item.CaseNumber, item.MGRS, item.Objective,
                    item.SubjectName, item.AOR_ID, item.Classification_ID,
                    item.SubmitterName, item.SubmitterEmail, item.Comments);
                
                string folderPath = Path.Combine(_CasePath, item.CaseNumber);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    WriteCaseFolders(folderPath);
                }
                else
                {
                    Messaging.ShowInfoMessageBox("Case already exists, please change the name and try again.");
                }
            }
            catch
            {

            }

            ComboBoxAor.SelectedIndex = -1;
            ComboBoxClassification.SelectedIndex = -1;
            TextBoxComments.Text = string.Empty;
            TextBoxMgrs.Text = string.Empty;
            TextBoxObjective.Text = string.Empty;
            TextBoxSubmitterEmail.Text = string.Empty;
            TextBoxSubmitterName.Text = string.Empty;
            textBoxCaseId.Text = string.Empty;
            TextBoxSubjectName.Text = string.Empty;
            this.Close();
        }

        private void WriteCaseFolders(string NewCaseName)
        {
            try
            {
                Directory.CreateDirectory(NewCaseName + @"\SofexCase Information");
                Directory.CreateDirectory(NewCaseName + @"\SofexCase Information\5Ws");
                Directory.CreateDirectory(NewCaseName + @"\SofexCase Information\SofexCase Photos");
                Directory.CreateDirectory(NewCaseName + @"\SofexCase Information\SOFEX Responses");
                Directory.CreateDirectory(NewCaseName + @"\SofexCase Information\4137");
                Directory.CreateDirectory(NewCaseName + @"\SofexCase Information\Other");
                Directory.CreateDirectory(NewCaseName + @"\SofexCase Information\StoryBoard");
                Directory.CreateDirectory(NewCaseName + @"\SofexCase Information\Inventory");
                Directory.CreateDirectory(NewCaseName + @"\DOMEX");
                Directory.CreateDirectory(NewCaseName + @"\BIO");
                Directory.CreateDirectory(NewCaseName + @"\Chemistry");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private int GetAorId(string aor)
        {
            DataTable dataTable = Database.Get.AOR(ComboBoxAor.SelectedItem.ToString());
            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0].Field<int>("id");
            }
            else
            {
                return -1;
            }
        }
        private int GetClassificationId(string classification)
        {
            DataTable dataTable = Database.Get.Classification(ComboBoxClassification.SelectedItem.ToString());
            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0].Field<int>("id");
            }
            else
            {
                return -1;
            }
        }
        private void GetClassifications()
        {
            ComboBoxClassification.Items.Clear();

            DataTable dataTable = Database.Get.Classifications();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    ComboBoxClassification.Items.Add(item["classification"].ToString());
                }

            }
        }
        private void GetAORs()
        {
            ComboBoxAor.Items.Clear();

            DataTable dataTable = Database.Get.AORS();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    ComboBoxAor.Items.Add(item["aor"].ToString());
                }

            }
        }
    }
}
