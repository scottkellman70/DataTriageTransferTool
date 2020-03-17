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
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"\Cases");
            Database.Save.CaseFolder(path, true);
        }
    }
}
