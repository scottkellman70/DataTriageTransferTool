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
    public partial class NewItem : Form
    {
        public NewItem()
        {
            InitializeComponent();
        }


        private void CloseForm()
        {
            this.Close();
        }

        private void ButtonCancelNewItem_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void ButtonSaveItem_Click(object sender, EventArgs e)
        {
            SaveNewItem();
        }

        private void SaveNewItem()
        {

        }
    }
}
