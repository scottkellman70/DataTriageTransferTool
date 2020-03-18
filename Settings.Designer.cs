namespace DataTriageTransferTool
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.ButtonExit = new System.Windows.Forms.Button();
            this.GroupBoxDefaultZipSize = new System.Windows.Forms.GroupBox();
            this.ButtonSaveZipSize = new System.Windows.Forms.Button();
            this.textBoxZipSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxFlumeIP = new System.Windows.Forms.GroupBox();
            this.ButtonSaveDrive = new System.Windows.Forms.Button();
            this.ButtonSaveFlumeIP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSaveCaseFolder = new System.Windows.Forms.Button();
            this.textBoxCaseFolder = new System.Windows.Forms.TextBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.GroupBoxDefaultZipSize.SuspendLayout();
            this.groupBoxFlumeIP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.Location = new System.Drawing.Point(501, 327);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(50, 50);
            this.ButtonExit.TabIndex = 6;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // GroupBoxDefaultZipSize
            // 
            this.GroupBoxDefaultZipSize.Controls.Add(this.ButtonSaveZipSize);
            this.GroupBoxDefaultZipSize.Controls.Add(this.textBoxZipSize);
            this.GroupBoxDefaultZipSize.Controls.Add(this.label10);
            this.GroupBoxDefaultZipSize.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxDefaultZipSize.Location = new System.Drawing.Point(14, 257);
            this.GroupBoxDefaultZipSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxDefaultZipSize.Name = "GroupBoxDefaultZipSize";
            this.GroupBoxDefaultZipSize.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxDefaultZipSize.Size = new System.Drawing.Size(383, 63);
            this.GroupBoxDefaultZipSize.TabIndex = 26;
            this.GroupBoxDefaultZipSize.TabStop = false;
            this.GroupBoxDefaultZipSize.Text = "Zip Size";
            // 
            // ButtonSaveZipSize
            // 
            this.ButtonSaveZipSize.Location = new System.Drawing.Point(140, 16);
            this.ButtonSaveZipSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSaveZipSize.Name = "ButtonSaveZipSize";
            this.ButtonSaveZipSize.Size = new System.Drawing.Size(87, 31);
            this.ButtonSaveZipSize.TabIndex = 19;
            this.ButtonSaveZipSize.Text = "Save";
            this.ButtonSaveZipSize.UseVisualStyleBackColor = true;
            // 
            // textBoxZipSize
            // 
            this.textBoxZipSize.Location = new System.Drawing.Point(65, 25);
            this.textBoxZipSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxZipSize.Name = "textBoxZipSize";
            this.textBoxZipSize.Size = new System.Drawing.Size(44, 22);
            this.textBoxZipSize.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Size";
            // 
            // groupBoxFlumeIP
            // 
            this.groupBoxFlumeIP.Controls.Add(this.ButtonSaveDrive);
            this.groupBoxFlumeIP.Controls.Add(this.ButtonSaveFlumeIP);
            this.groupBoxFlumeIP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFlumeIP.Location = new System.Drawing.Point(433, 22);
            this.groupBoxFlumeIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxFlumeIP.Name = "groupBoxFlumeIP";
            this.groupBoxFlumeIP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxFlumeIP.Size = new System.Drawing.Size(367, 207);
            this.groupBoxFlumeIP.TabIndex = 25;
            this.groupBoxFlumeIP.TabStop = false;
            this.groupBoxFlumeIP.Text = "Flume";
            // 
            // ButtonSaveDrive
            // 
            this.ButtonSaveDrive.Location = new System.Drawing.Point(257, 136);
            this.ButtonSaveDrive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSaveDrive.Name = "ButtonSaveDrive";
            this.ButtonSaveDrive.Size = new System.Drawing.Size(73, 28);
            this.ButtonSaveDrive.TabIndex = 15;
            this.ButtonSaveDrive.Text = "Save";
            this.ButtonSaveDrive.UseVisualStyleBackColor = true;
            // 
            // ButtonSaveFlumeIP
            // 
            this.ButtonSaveFlumeIP.Location = new System.Drawing.Point(257, 64);
            this.ButtonSaveFlumeIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSaveFlumeIP.Name = "ButtonSaveFlumeIP";
            this.ButtonSaveFlumeIP.Size = new System.Drawing.Size(73, 28);
            this.ButtonSaveFlumeIP.TabIndex = 11;
            this.ButtonSaveFlumeIP.Text = "Save";
            this.ButtonSaveFlumeIP.UseVisualStyleBackColor = true;
            this.ButtonSaveFlumeIP.Click += new System.EventHandler(this.ButtonSaveFlumeIP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveCaseFolder);
            this.groupBox1.Controls.Add(this.textBoxCaseFolder);
            this.groupBox1.Controls.Add(this.buttonSelectFolder);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(433, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 63);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Case Folder";
            // 
            // buttonSaveCaseFolder
            // 
            this.buttonSaveCaseFolder.Location = new System.Drawing.Point(628, 22);
            this.buttonSaveCaseFolder.Name = "buttonSaveCaseFolder";
            this.buttonSaveCaseFolder.Size = new System.Drawing.Size(87, 25);
            this.buttonSaveCaseFolder.TabIndex = 11;
            this.buttonSaveCaseFolder.Text = "Save";
            this.buttonSaveCaseFolder.UseVisualStyleBackColor = true;
            // 
            // textBoxCaseFolder
            // 
            this.textBoxCaseFolder.Enabled = false;
            this.textBoxCaseFolder.Location = new System.Drawing.Point(161, 25);
            this.textBoxCaseFolder.Name = "textBoxCaseFolder";
            this.textBoxCaseFolder.ReadOnly = true;
            this.textBoxCaseFolder.Size = new System.Drawing.Size(459, 22);
            this.textBoxCaseFolder.TabIndex = 10;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(15, 23);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(139, 25);
            this.buttonSelectFolder.TabIndex = 9;
            this.buttonSelectFolder.Text = "Select Folder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 402);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBoxDefaultZipSize);
            this.Controls.Add(this.groupBoxFlumeIP);
            this.Controls.Add(this.ButtonExit);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.GroupBoxDefaultZipSize.ResumeLayout(false);
            this.GroupBoxDefaultZipSize.PerformLayout();
            this.groupBoxFlumeIP.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.GroupBox GroupBoxDefaultZipSize;
        private System.Windows.Forms.Button ButtonSaveZipSize;
        private System.Windows.Forms.TextBox textBoxZipSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxFlumeIP;
        private System.Windows.Forms.Button ButtonSaveDrive;
        private System.Windows.Forms.Button ButtonSaveFlumeIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSaveCaseFolder;
        private System.Windows.Forms.TextBox textBoxCaseFolder;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}