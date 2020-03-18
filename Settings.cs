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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            GetCaseFolder();
            GetZipSize();
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

        private void GetZipSize()
        {
            DataTable dataTable = Database.Get.ZipSize();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    textBoxZipSize.Text = item["size"].ToString();
                }
            }
        }
        
    }
}
