using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTriageTransferTool
{
    public partial class NewCase : Form
    {
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
            DT3Case item = new DT3Case();

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

            Database.Insert.Case(item.CaseNumber, item.MGRS, item.Objective,
                item.SubjectName, item.AOR_ID, item.Classification_ID,
                item.SubmitterName, item.SubmitterEmail, item.Comments);

            ComboBoxAor.SelectedIndex = -1;
            ComboBoxClassification.SelectedIndex = -1;
            TextBoxComments.Text = string.Empty;
            TextBoxMgrs.Text = string.Empty;
            TextBoxObjective.Text = string.Empty;
            TextBoxSubmitterEmail.Text = string.Empty;
            TextBoxSubmitterName.Text = string.Empty;
            textBoxCaseId.Text = string.Empty;
            TextBoxSubjectName.Text = string.Empty;

            Main main = new Main();
            main.ListBoxCases.Items.Add(item.CaseNumber);
            main.Refresh();
            this.Close();
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
