namespace DataTriageTransferTool
{
    partial class Sizes
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
            this.listBoxSizes = new System.Windows.Forms.ListBox();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.TextBoxType = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSizes
            // 
            this.listBoxSizes.FormattingEnabled = true;
            this.listBoxSizes.Location = new System.Drawing.Point(12, 13);
            this.listBoxSizes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxSizes.Name = "listBoxSizes";
            this.listBoxSizes.ScrollAlwaysVisible = true;
            this.listBoxSizes.Size = new System.Drawing.Size(364, 121);
            this.listBoxSizes.TabIndex = 2;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(382, 12);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 25;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(381, 99);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 24;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(382, 41);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 23;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonNew
            // 
            this.ButtonNew.Location = new System.Drawing.Point(382, 70);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(74, 23);
            this.ButtonNew.TabIndex = 22;
            this.ButtonNew.Text = "Add New";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // TextBoxType
            // 
            this.TextBoxType.Enabled = false;
            this.TextBoxType.Location = new System.Drawing.Point(12, 142);
            this.TextBoxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxType.MaxLength = 50;
            this.TextBoxType.Name = "TextBoxType";
            this.TextBoxType.Size = new System.Drawing.Size(274, 20);
            this.TextBoxType.TabIndex = 21;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Location = new System.Drawing.Point(292, 140);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(87, 22);
            this.ButtonSave.TabIndex = 20;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Sizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 180);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.TextBoxType);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.listBoxSizes);
            this.Name = "Sizes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sizes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSizes;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.TextBox TextBoxType;
        private System.Windows.Forms.Button ButtonSave;
    }
}