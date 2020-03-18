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
            Settings settings = new Settings();
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
                //set default case folder
                SetCaseFolder();
            }
        }

        private void GetCases()
        {
            DataTable dataTable = Database.Get.Cases();
            if (dataTable.Rows.Count > 1)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    ListBoxCases.Items.Add(item["case_id"].ToString());
                }
            }
        }

        private void GetItems()
        {

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
    }
}
