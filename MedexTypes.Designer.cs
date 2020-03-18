namespace DataTriageTransferTool
{
    partial class MedexTypes
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
            this.ButtonNew = new System.Windows.Forms.Button();
            this.TextBoxType = new System.Windows.Forms.TextBox();
            this.listBoxMedexTypes = new System.Windows.Forms.ListBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonNew
            // 
            this.ButtonNew.Location = new System.Drawing.Point(381, 71);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(74, 23);
            this.ButtonNew.TabIndex = 4;
            this.ButtonNew.Text = "Add New";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // TextBoxType
            // 
            this.TextBoxType.Enabled = false;
            this.TextBoxType.Location = new System.Drawing.Point(12, 169);
            this.TextBoxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxType.MaxLength = 50;
            this.TextBoxType.Name = "TextBoxType";
            this.TextBoxType.Size = new System.Drawing.Size(270, 20);
            this.TextBoxType.TabIndex = 3;
            // 
            // listBoxMedexTypes
            // 
            this.listBoxMedexTypes.FormattingEnabled = true;
            this.listBoxMedexTypes.Location = new System.Drawing.Point(12, 13);
            this.listBoxMedexTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxMedexTypes.Name = "listBoxMedexTypes";
            this.listBoxMedexTypes.ScrollAlwaysVisible = true;
            this.listBoxMedexTypes.Size = new System.Drawing.Size(364, 147);
            this.listBoxMedexTypes.TabIndex = 1;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Location = new System.Drawing.Point(289, 169);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(87, 22);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(381, 42);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 5;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(380, 100);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 6;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(381, 13);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 7;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // MedexTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 202);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.TextBoxType);
            this.Controls.Add(this.listBoxMedexTypes);
            this.Controls.Add(this.ButtonSave);
            this.Name = "MedexTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedexTypes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.TextBox TextBoxType;
        private System.Windows.Forms.ListBox listBoxMedexTypes;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonEdit;
    }
}