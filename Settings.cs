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
    //Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Cases"
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            GetClassifications();
            GetFlumeData();
            GetMedexTypes();
            GetCellexTypes();
            GetSizes();
            GetAors();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void GetClassifications()
        {
            DataTable dataTable = Database.Get.Classifications();

            if (dataTable.Rows.Count > 0)
            {
                foreach(DataRow item in dataTable.Rows)
                {
                    listBoxClassifications.Items.Add(item["classification"].ToString());
                }
            }
        }

        private void GetFlumeData()
        {
            DataTable dataTable = Database.Get.FlumeData();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    textBoxFlumeIP.Text = item["ip"].ToString();
                    textBoxFlumeDrive.Text = item["drive"].ToString();
                }
                   
            }
        }
        
        private void GetMedexTypes()
        {
            DataTable dataTable = Database.Get.MedexTypes();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    listBoxMedexTypes.Items.Add(item["type"].ToString());
                }

            }
        }
        
        private void GetCellexTypes()
        {
            DataTable dataTable = Database.Get.CellexTypes();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    listBoxMobileTypes.Items.Add(item["type"].ToString());
                }

            }
        }

        private void GetSizes()
        {
            DataTable dataTable = Database.Get.Sizes();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    listBoxSizes.Items.Add(item["type"].ToString());
                }

            }
        }

        private void GetAors()
        {
            DataTable dataTable = Database.Get.AORS();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    listBoxAOR.Items.Add(item["aor"].ToString());
                }

            }
        }
    }
}
