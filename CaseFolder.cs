using System;
using System.Data;
using System.Windows.Forms;

namespace DataTriageTransferTool
{
    public partial class CaseFolder : Form
    {
        public CaseFolder()
        {
            InitializeComponent();
            GetCaseFolder();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            this.Close();
        }
        
        
        private void GetCaseFolder()
        {
            DataTable dataTable = Database.Get.CaseFolder();

            if (dataTable.Rows.Count > 0)
            {
                foreach(DataRow item in dataTable.Rows)
                {
                    textBoxCaseFolder.Text = item["location"].ToString();
                }
            }
        }

        private void ButtonSaveCaseFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCaseFolder.Text))
            {
                Messaging.ShowInfoMessageBox("You mus select a folder to save case files.");
            }
            else
            {
                Database.Update.CaseFolder(textBoxCaseFolder.Text);
            }
        }

        private void ButtonSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = fbdCases.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                textBoxCaseFolder.Text = fbdCases.SelectedPath;
            }
            
        }
    }
}
