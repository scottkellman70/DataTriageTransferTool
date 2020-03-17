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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            GetCases();
        }

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void GetCases()
        {
            DataTable dataTable = Database.Get.Cases();
            if (dataTable.Rows.Count > 1)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    ComboBox4137Cases.Items.Add(item["case_id"].ToString());
                }
            }
        }
    }
}
