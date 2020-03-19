namespace DataTriageTransferTool
{
    partial class CaseFolder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseFolder));
            this.ButtonExit = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSaveCaseFolder = new System.Windows.Forms.Button();
            this.textBoxCaseFolder = new System.Windows.Forms.TextBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.fbdCases = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.Location = new System.Drawing.Point(313, 41);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(50, 50);
            this.ButtonExit.TabIndex = 6;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonSaveCaseFolder
            // 
            this.buttonSaveCaseFolder.Location = new System.Drawing.Point(628, 9);
            this.buttonSaveCaseFolder.Name = "buttonSaveCaseFolder";
            this.buttonSaveCaseFolder.Size = new System.Drawing.Size(87, 25);
            this.buttonSaveCaseFolder.TabIndex = 32;
            this.buttonSaveCaseFolder.Text = "Save";
            this.buttonSaveCaseFolder.UseVisualStyleBackColor = true;
            this.buttonSaveCaseFolder.Click += new System.EventHandler(this.ButtonSaveCaseFolder_Click);
            // 
            // textBoxCaseFolder
            // 
            this.textBoxCaseFolder.Enabled = false;
            this.textBoxCaseFolder.Location = new System.Drawing.Point(161, 12);
            this.textBoxCaseFolder.Name = "textBoxCaseFolder";
            this.textBoxCaseFolder.ReadOnly = true;
            this.textBoxCaseFolder.Size = new System.Drawing.Size(459, 22);
            this.textBoxCaseFolder.TabIndex = 31;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(15, 10);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(139, 25);
            this.buttonSelectFolder.TabIndex = 30;
            this.buttonSelectFolder.Text = "Select Folder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.ButtonSelectFolder_Click);
            // 
            // CaseFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 107);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSaveCaseFolder);
            this.Controls.Add(this.textBoxCaseFolder);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.ButtonExit);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CaseFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonSaveCaseFolder;
        private System.Windows.Forms.TextBox textBoxCaseFolder;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdCases;
    }
}