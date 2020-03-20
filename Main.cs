using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTriageTransferTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            GetCaseFolder();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void ExitApplication()
        {
            Application.Exit();
        }

        private void ButtonNewCase_Click(object sender, EventArgs e)
        {
            NewCase newCase = new NewCase();
            newCase.ShowDialog();
        }

        private void ButtonNewItem_Click(object sender, EventArgs e)
        {
            NewItem newItem = new NewItem();
            newItem.ShowDialog();
        }

        private void ButtonTriage_Click(object sender, EventArgs e)
        {
            Triage triage = new Triage();
            triage.ShowDialog();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            CaseFolder settings = new CaseFolder();
            settings.ShowDialog();
        }

        private void ButtonInventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.ShowDialog();
        }

        private void GetCaseFolder()
        {
            DataTable dataTable = Database.Get.CaseFolder();

            if (dataTable.Rows.Count > 1)
            {
                GetCases();
            }
            else
            {
                SetCaseFolder();
            }
        }

        public void GetCases()
        {
            DataTable dataTable = Database.Get.Cases();
            if (dataTable.Rows.Count > 0)
            {
                ListBoxCases.Items.Clear();
                foreach (DataRow item in dataTable.Rows)
                {
                    ListBoxCases.Items.Add(item["case_id"].ToString());
                }
            }
        }
        
        private void SetCaseFolder()
        {
            Environment.SpecialFolder desktop = Environment.SpecialFolder.Desktop;
            string desktopPath = Environment.GetFolderPath(desktop) + @"\Cases";
            Database.Insert.CaseFolder(desktopPath, true);
        }

        private void ButtonMedexTypes_Click(object sender, EventArgs e)
        {
            MedexTypes medexTypes = new MedexTypes();
            medexTypes.ShowDialog();
        }

        private void ButtonCellex_Click(object sender, EventArgs e)
        {
            CellexTypes cellexTypes = new CellexTypes();
            cellexTypes.ShowDialog();
        }

        private void ButonAOR_Click(object sender, EventArgs e)
        {
            AOR aor = new AOR();
            aor.ShowDialog();
        }

        private void ButtonClassification_Click(object sender, EventArgs e)
        {
            Classifications classifications = new Classifications();
            classifications.ShowDialog();
        }

        private void ButtonSizes_Click(object sender, EventArgs e)
        {
            Sizes sizes = new Sizes();
            sizes.ShowDialog();
        }

        private void ButtonFlume_Click(object sender, EventArgs e)
        {
            Flume flume = new Flume();
            flume.ShowDialog();
        }

        private void ButtonZipSize_Click(object sender, EventArgs e)
        {
            ZipSize zipSize = new ZipSize();
            zipSize.ShowDialog();
        }

        private void ButtonCaseFolder_Click(object sender, EventArgs e)
        {
            CaseFolder caseFolder = new CaseFolder();
            caseFolder.ShowDialog();
        }

        private void RbOnline_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbOffline_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnRefreshCases_Click(object sender, EventArgs e)
        {
            GetCases();
        }

        private void ButtonRefreshItems_Click(object sender, EventArgs e)
        {
            GetItems();
        }

        private void ListBoxCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetItems();
        }

        private void GetItems()
        {
            if (ListBoxCases.SelectedIndex > -1)
            {
                Database.Get.Items(ListBoxCases.SelectedItem.ToString());
            }
            else
            {
                Messaging.ShowInfoMessageBox("You must select a case to perform this action.");
            }
        }
    }
}
