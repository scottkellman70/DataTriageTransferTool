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
    public partial class Flume : Form
    {
        public Flume()
        {
            InitializeComponent();
            GetFlumeData();
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

        private void ButtonSaveIP_Click(object sender, EventArgs e)
        {
            Database.Update.FlumeIP(textBoxFlumeIP.Text.Trim());
        }

        private void ButtonSaveDrive_Click(object sender, EventArgs e)
        {
            Database.Update.FlumeDrive(textBoxFlumeDrive.Text.Trim());
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
