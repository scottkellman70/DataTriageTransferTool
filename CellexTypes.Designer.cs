namespace DataTriageTransferTool
{
    partial class CellexTypes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxCellexTypes = new System.Windows.Forms.ListBox();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.TextBoxType = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCellexTypes
            // 
            this.listBoxCellexTypes.FormattingEnabled = true;
            this.listBoxCellexTypes.Location = new System.Drawing.Point(12, 13);
            this.listBoxCellexTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxCellexTypes.Name = "listBoxCellexTypes";
            this.listBoxCellexTypes.ScrollAlwaysVisible = true;
            this.listBoxCellexTypes.Size = new System.Drawing.Size(349, 147);
            this.listBoxCellexTypes.TabIndex = 2;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(367, 13);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 13;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(366, 100);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 12;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(367, 42);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 11;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonNew
            // 
            this.ButtonNew.Location = new System.Drawing.Point(367, 71);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(74, 23);
            this.ButtonNew.TabIndex = 10;
            this.ButtonNew.Text = "Add New";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // TextBoxType
            // 
            this.TextBoxType.Enabled = false;
            this.TextBoxType.Location = new System.Drawing.Point(14, 168);
            this.TextBoxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxType.MaxLength = 50;
            this.TextBoxType.Name = "TextBoxType";
            this.TextBoxType.Size = new System.Drawing.Size(270, 20);
            this.TextBoxType.TabIndex = 9;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Location = new System.Drawing.Point(291, 168);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(87, 22);
            this.ButtonSave.TabIndex = 8;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // CellexTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 204);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.TextBoxType);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.listBoxCellexTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CellexTypes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cellex Types";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCellexTypes;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.TextBox TextBoxType;
        private System.Windows.Forms.Button ButtonSave;
    }
}