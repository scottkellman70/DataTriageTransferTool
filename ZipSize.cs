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
    public partial class ZipSize : Form
    {
        public ZipSize()
        {
            InitializeComponent();
            GetZipSize();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxZipSize.Text.Trim()))
            {
                Database.Update.ZipSize(textBoxZipSize.Text.Trim());
            }
        }

        private void GetZipSize()
        {
            DataTable dataTable = Database.Get.ZipSize();

            if (dataTable.Rows.Count > 0)
            {
                string zip_size = dataTable.Rows[0].Field<string>("size");
                textBoxZipSize.Text = zip_size;
            }
        }
    }
}
