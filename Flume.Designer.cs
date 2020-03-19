namespace DataTriageTransferTool
{
    partial class Flume
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
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxFlumeDrive = new System.Windows.Forms.TextBox();
            this.textBoxFlumeIP = new System.Windows.Forms.TextBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonSaveIP = new System.Windows.Forms.Button();
            this.ButtonSaveDrive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Drive";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Flume IP Address";
            // 
            // textBoxFlumeDrive
            // 
            this.textBoxFlumeDrive.Location = new System.Drawing.Point(12, 107);
            this.textBoxFlumeDrive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFlumeDrive.MaxLength = 50;
            this.textBoxFlumeDrive.Name = "textBoxFlumeDrive";
            this.textBoxFlumeDrive.Size = new System.Drawing.Size(236, 20);
            this.textBoxFlumeDrive.TabIndex = 16;
            // 
            // textBoxFlumeIP
            // 
            this.textBoxFlumeIP.Location = new System.Drawing.Point(12, 32);
            this.textBoxFlumeIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFlumeIP.MaxLength = 16;
            this.textBoxFlumeIP.Name = "textBoxFlumeIP";
            this.textBoxFlumeIP.Size = new System.Drawing.Size(236, 20);
            this.textBoxFlumeIP.TabIndex = 15;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(127, 147);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(87, 23);
            this.ButtonExit.TabIndex = 29;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonSaveIP
            // 
            this.ButtonSaveIP.Location = new System.Drawing.Point(254, 32);
            this.ButtonSaveIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSaveIP.Name = "ButtonSaveIP";
            this.ButtonSaveIP.Size = new System.Drawing.Size(87, 22);
            this.ButtonSaveIP.TabIndex = 26;
            this.ButtonSaveIP.Text = "Save";
            this.ButtonSaveIP.UseVisualStyleBackColor = true;
            this.ButtonSaveIP.Click += new System.EventHandler(this.ButtonSaveIP_Click);
            // 
            // ButtonSaveDrive
            // 
            this.ButtonSaveDrive.Location = new System.Drawing.Point(254, 105);
            this.ButtonSaveDrive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSaveDrive.Name = "ButtonSaveDrive";
            this.ButtonSaveDrive.Size = new System.Drawing.Size(87, 22);
            this.ButtonSaveDrive.TabIndex = 30;
            this.ButtonSaveDrive.Text = "Save";
            this.ButtonSaveDrive.UseVisualStyleBackColor = true;
            this.ButtonSaveDrive.Click += new System.EventHandler(this.ButtonSaveDrive_Click);
            // 
            // Flume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 194);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonSaveDrive);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSaveIP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxFlumeDrive);
            this.Controls.Add(this.textBoxFlumeIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Flume";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxFlumeDrive;
        private System.Windows.Forms.TextBox textBoxFlumeIP;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonSaveIP;
        private System.Windows.Forms.Button ButtonSaveDrive;
    }
}