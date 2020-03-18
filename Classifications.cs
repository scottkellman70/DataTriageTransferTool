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
    public partial class Classifications : Form
    {
        public Classifications()
        {
            InitializeComponent();
            GetClassifications();
        }

        public bool Edit { get; set; }
        public bool Add { get; set; }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxType.Enabled = true;
            ButtonSave.Enabled = true;
            Edit = true;
            Add = false;

            if (listBoxClassifications.SelectedIndex > -1)
            {
                TextBoxType.Text = listBoxClassifications.SelectedItem.ToString();
            }
            else
            {
                Messaging.ShowInfoMessageBox("You must select an item to edit.");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxClassifications.SelectedIndex > -1)
            {
                Database.Delete.Classification(listBoxClassifications.SelectedItem.ToString());
            }
            else
            {
                Messaging.ShowInfoMessageBox("You must select an item to edit.");
            }
            GetClassifications();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxType.Enabled = true;
            ButtonSave.Enabled = true;
            Edit = false;
            Add = true;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (Add == true)
            {
                if (!string.IsNullOrEmpty(TextBoxType.Text))
                {
                    Database.Insert.Classification(TextBoxType.Text.Trim());
                }
                else
                {
                    Messaging.ShowInfoMessageBox("You must enter something in the text box to save.");
                }
            }

            if (Edit == true)
            {
                DataTable dataTable = Database.Get.CellexItem(listBoxClassifications.SelectedItem.ToString());
                if (dataTable.Rows.Count > 0)
                {
                    int id = dataTable.Rows[0].Field<int>("id");
                    string item = TextBoxType.Text.Trim();
                    Database.Update.Classification(item, id);
                }
            }

            GetClassifications();

            TextBoxType.Enabled = false;
            ButtonSave.Enabled = false;
            Edit = false;
            Add = false;
        }

        private void GetClassifications()
        {
            listBoxClassifications.Items.Clear();

            DataTable dataTable = Database.Get.Classifications();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    listBoxClassifications.Items.Add(item["classification"].ToString());
                }

            }
        }
    }
}
