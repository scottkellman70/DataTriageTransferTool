namespace DataTriageTransferTool
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ButtonNewCase = new System.Windows.Forms.Button();
            this.ButtonNewItem = new System.Windows.Forms.Button();
            this.ButtonTriage = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonInventory = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ListBoxCases = new System.Windows.Forms.ListBox();
            this.ListBoxItems = new System.Windows.Forms.ListBox();
            this.ButtonSendItem = new System.Windows.Forms.Button();
            this.ButtonZipItem = new System.Windows.Forms.Button();
            this.ButtonEditCase = new System.Windows.Forms.Button();
            this.ButtonEditItem = new System.Windows.Forms.Button();
            this.ButtonDeleteCase = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonCaseFolder = new System.Windows.Forms.Button();
            this.ButtonZipSize = new System.Windows.Forms.Button();
            this.ButtonFlume = new System.Windows.Forms.Button();
            this.ButtonSizes = new System.Windows.Forms.Button();
            this.ButtonClassification = new System.Windows.Forms.Button();
            this.ButonAOR = new System.Windows.Forms.Button();
            this.ButtonCellex = new System.Windows.Forms.Button();
            this.ButtonMedexTypes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.rbOffline = new System.Windows.Forms.RadioButton();
            this.rbOnline = new System.Windows.Forms.RadioButton();
            this.timerConnectivityCheck = new System.Windows.Forms.Timer(this.components);
            this.BtnRefreshCases = new System.Windows.Forms.Button();
            this.ButtonRefreshItems = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonNewCase
            // 
            this.ButtonNewCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonNewCase.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNewCase.Location = new System.Drawing.Point(72, 33);
            this.ButtonNewCase.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonNewCase.Name = "ButtonNewCase";
            this.ButtonNewCase.Size = new System.Drawing.Size(112, 31);
            this.ButtonNewCase.TabIndex = 0;
            this.ButtonNewCase.Text = "New Case";
            this.ButtonNewCase.UseVisualStyleBackColor = true;
            this.ButtonNewCase.Click += new System.EventHandler(this.ButtonNewCase_Click);
            // 
            // ButtonNewItem
            // 
            this.ButtonNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonNewItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNewItem.Location = new System.Drawing.Point(72, 73);
            this.ButtonNewItem.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonNewItem.Name = "ButtonNewItem";
            this.ButtonNewItem.Size = new System.Drawing.Size(112, 31);
            this.ButtonNewItem.TabIndex = 1;
            this.ButtonNewItem.Text = "New Item";
            this.ButtonNewItem.UseVisualStyleBackColor = true;
            this.ButtonNewItem.Click += new System.EventHandler(this.ButtonNewItem_Click);
            // 
            // ButtonTriage
            // 
            this.ButtonTriage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonTriage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTriage.Location = new System.Drawing.Point(72, 112);
            this.ButtonTriage.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonTriage.Name = "ButtonTriage";
            this.ButtonTriage.Size = new System.Drawing.Size(112, 31);
            this.ButtonTriage.TabIndex = 2;
            this.ButtonTriage.Text = "Triage";
            this.ButtonTriage.UseVisualStyleBackColor = true;
            this.ButtonTriage.Click += new System.EventHandler(this.ButtonTriage_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSettings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSettings.Location = new System.Drawing.Point(72, 151);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(112, 31);
            this.ButtonSettings.TabIndex = 3;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonInventory
            // 
            this.ButtonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonInventory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInventory.Location = new System.Drawing.Point(72, 190);
            this.ButtonInventory.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonInventory.Name = "ButtonInventory";
            this.ButtonInventory.Size = new System.Drawing.Size(112, 31);
            this.ButtonInventory.TabIndex = 4;
            this.ButtonInventory.Text = "4137";
            this.ButtonInventory.UseVisualStyleBackColor = true;
            this.ButtonInventory.Click += new System.EventHandler(this.ButtonInventory_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(72, 229);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(112, 31);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ListBoxCases
            // 
            this.ListBoxCases.FormattingEnabled = true;
            this.ListBoxCases.ItemHeight = 18;
            this.ListBoxCases.Location = new System.Drawing.Point(242, 33);
            this.ListBoxCases.Name = "ListBoxCases";
            this.ListBoxCases.ScrollAlwaysVisible = true;
            this.ListBoxCases.Size = new System.Drawing.Size(416, 94);
            this.ListBoxCases.Sorted = true;
            this.ListBoxCases.TabIndex = 7;
            // 
            // ListBoxItems
            // 
            this.ListBoxItems.FormattingEnabled = true;
            this.ListBoxItems.ItemHeight = 18;
            this.ListBoxItems.Location = new System.Drawing.Point(242, 163);
            this.ListBoxItems.Name = "ListBoxItems";
            this.ListBoxItems.ScrollAlwaysVisible = true;
            this.ListBoxItems.Size = new System.Drawing.Size(416, 202);
            this.ListBoxItems.TabIndex = 8;
            // 
            // ButtonSendItem
            // 
            this.ButtonSendItem.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSendItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSendItem.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSendItem.Image")));
            this.ButtonSendItem.Location = new System.Drawing.Point(664, 327);
            this.ButtonSendItem.Name = "ButtonSendItem";
            this.ButtonSendItem.Size = new System.Drawing.Size(35, 35);
            this.ButtonSendItem.TabIndex = 19;
            this.ButtonSendItem.TabStop = false;
            this.ButtonSendItem.UseVisualStyleBackColor = false;
            // 
            // ButtonZipItem
            // 
            this.ButtonZipItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonZipItem.Image = ((System.Drawing.Image)(resources.GetObject("ButtonZipItem.Image")));
            this.ButtonZipItem.Location = new System.Drawing.Point(664, 286);
            this.ButtonZipItem.Name = "ButtonZipItem";
            this.ButtonZipItem.Size = new System.Drawing.Size(35, 35);
            this.ButtonZipItem.TabIndex = 18;
            this.ButtonZipItem.TabStop = false;
            this.ButtonZipItem.UseVisualStyleBackColor = true;
            // 
            // ButtonEditCase
            // 
            this.ButtonEditCase.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEditCase.Image")));
            this.ButtonEditCase.Location = new System.Drawing.Point(664, 59);
            this.ButtonEditCase.Name = "ButtonEditCase";
            this.ButtonEditCase.Size = new System.Drawing.Size(35, 35);
            this.ButtonEditCase.TabIndex = 20;
            this.ButtonEditCase.UseVisualStyleBackColor = true;
            // 
            // ButtonEditItem
            // 
            this.ButtonEditItem.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEditItem.Image")));
            this.ButtonEditItem.Location = new System.Drawing.Point(664, 204);
            this.ButtonEditItem.Name = "ButtonEditItem";
            this.ButtonEditItem.Size = new System.Drawing.Size(35, 35);
            this.ButtonEditItem.TabIndex = 21;
            this.ButtonEditItem.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteCase
            // 
            this.ButtonDeleteCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDeleteCase.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteCase.Image")));
            this.ButtonDeleteCase.Location = new System.Drawing.Point(664, 100);
            this.ButtonDeleteCase.Name = "ButtonDeleteCase";
            this.ButtonDeleteCase.Size = new System.Drawing.Size(35, 35);
            this.ButtonDeleteCase.TabIndex = 22;
            this.ButtonDeleteCase.TabStop = false;
            this.ButtonDeleteCase.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.Image")));
            this.ButtonDelete.Location = new System.Drawing.Point(664, 245);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(35, 35);
            this.ButtonDelete.TabIndex = 23;
            this.ButtonDelete.TabStop = false;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonCaseFolder);
            this.groupBox1.Controls.Add(this.ButtonZipSize);
            this.groupBox1.Controls.Add(this.ButtonFlume);
            this.groupBox1.Controls.Add(this.ButtonSizes);
            this.groupBox1.Controls.Add(this.ButtonClassification);
            this.groupBox1.Controls.Add(this.ButonAOR);
            this.groupBox1.Controls.Add(this.ButtonCellex);
            this.groupBox1.Controls.Add(this.ButtonMedexTypes);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 69);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // ButtonCaseFolder
            // 
            this.ButtonCaseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCaseFolder.Location = new System.Drawing.Point(620, 25);
            this.ButtonCaseFolder.Name = "ButtonCaseFolder";
            this.ButtonCaseFolder.Size = new System.Drawing.Size(87, 31);
            this.ButtonCaseFolder.TabIndex = 32;
            this.ButtonCaseFolder.Text = "Case Folder";
            this.ButtonCaseFolder.UseVisualStyleBackColor = true;
            this.ButtonCaseFolder.Click += new System.EventHandler(this.ButtonCaseFolder_Click);
            // 
            // ButtonZipSize
            // 
            this.ButtonZipSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonZipSize.Location = new System.Drawing.Point(532, 25);
            this.ButtonZipSize.Name = "ButtonZipSize";
            this.ButtonZipSize.Size = new System.Drawing.Size(78, 31);
            this.ButtonZipSize.TabIndex = 31;
            this.ButtonZipSize.Text = "Zip Size";
            this.ButtonZipSize.UseVisualStyleBackColor = true;
            this.ButtonZipSize.Click += new System.EventHandler(this.ButtonZipSize_Click);
            // 
            // ButtonFlume
            // 
            this.ButtonFlume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonFlume.Location = new System.Drawing.Point(450, 25);
            this.ButtonFlume.Name = "ButtonFlume";
            this.ButtonFlume.Size = new System.Drawing.Size(76, 31);
            this.ButtonFlume.TabIndex = 30;
            this.ButtonFlume.Text = "Flume";
            this.ButtonFlume.UseVisualStyleBackColor = true;
            this.ButtonFlume.Click += new System.EventHandler(this.ButtonFlume_Click);
            // 
            // ButtonSizes
            // 
            this.ButtonSizes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSizes.Location = new System.Drawing.Point(367, 25);
            this.ButtonSizes.Name = "ButtonSizes";
            this.ButtonSizes.Size = new System.Drawing.Size(77, 31);
            this.ButtonSizes.TabIndex = 29;
            this.ButtonSizes.Text = "Sizes";
            this.ButtonSizes.UseVisualStyleBackColor = true;
            this.ButtonSizes.Click += new System.EventHandler(this.ButtonSizes_Click);
            // 
            // ButtonClassification
            // 
            this.ButtonClassification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClassification.Location = new System.Drawing.Point(262, 25);
            this.ButtonClassification.Name = "ButtonClassification";
            this.ButtonClassification.Size = new System.Drawing.Size(99, 31);
            this.ButtonClassification.TabIndex = 28;
            this.ButtonClassification.Text = "Classification";
            this.ButtonClassification.UseVisualStyleBackColor = true;
            this.ButtonClassification.Click += new System.EventHandler(this.ButtonClassification_Click);
            // 
            // ButonAOR
            // 
            this.ButonAOR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButonAOR.Location = new System.Drawing.Point(178, 25);
            this.ButonAOR.Name = "ButonAOR";
            this.ButonAOR.Size = new System.Drawing.Size(78, 31);
            this.ButonAOR.TabIndex = 27;
            this.ButonAOR.Text = "AOR";
            this.ButonAOR.UseVisualStyleBackColor = true;
            this.ButonAOR.Click += new System.EventHandler(this.ButonAOR_Click);
            // 
            // ButtonCellex
            // 
            this.ButtonCellex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCellex.Location = new System.Drawing.Point(94, 25);
            this.ButtonCellex.Name = "ButtonCellex";
            this.ButtonCellex.Size = new System.Drawing.Size(78, 31);
            this.ButtonCellex.TabIndex = 26;
            this.ButtonCellex.Text = "CELLEX";
            this.ButtonCellex.UseVisualStyleBackColor = true;
            this.ButtonCellex.Click += new System.EventHandler(this.ButtonCellex_Click);
            // 
            // ButtonMedexTypes
            // 
            this.ButtonMedexTypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMedexTypes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMedexTypes.Location = new System.Drawing.Point(6, 25);
            this.ButtonMedexTypes.Name = "ButtonMedexTypes";
            this.ButtonMedexTypes.Size = new System.Drawing.Size(79, 31);
            this.ButtonMedexTypes.TabIndex = 25;
            this.ButtonMedexTypes.Text = "MEDEX";
            this.ButtonMedexTypes.UseVisualStyleBackColor = true;
            this.ButtonMedexTypes.Click += new System.EventHandler(this.ButtonMedexTypes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxStatus);
            this.groupBox2.Controls.Add(this.rbOffline);
            this.groupBox2.Controls.Add(this.rbOnline);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(72, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 97);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(7, 63);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(100, 22);
            this.textBoxStatus.TabIndex = 2;
            // 
            // rbOffline
            // 
            this.rbOffline.AutoSize = true;
            this.rbOffline.Location = new System.Drawing.Point(6, 36);
            this.rbOffline.Name = "rbOffline";
            this.rbOffline.Size = new System.Drawing.Size(62, 20);
            this.rbOffline.TabIndex = 1;
            this.rbOffline.TabStop = true;
            this.rbOffline.Text = "Offline";
            this.rbOffline.UseVisualStyleBackColor = true;
            this.rbOffline.CheckedChanged += new System.EventHandler(this.RbOffline_CheckedChanged);
            // 
            // rbOnline
            // 
            this.rbOnline.AutoSize = true;
            this.rbOnline.Location = new System.Drawing.Point(7, 10);
            this.rbOnline.Name = "rbOnline";
            this.rbOnline.Size = new System.Drawing.Size(63, 20);
            this.rbOnline.TabIndex = 0;
            this.rbOnline.TabStop = true;
            this.rbOnline.Text = "Online";
            this.rbOnline.UseVisualStyleBackColor = true;
            this.rbOnline.CheckedChanged += new System.EventHandler(this.RbOnline_CheckedChanged);
            // 
            // BtnRefreshCases
            // 
            this.BtnRefreshCases.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefreshCases.Image")));
            this.BtnRefreshCases.Location = new System.Drawing.Point(664, 20);
            this.BtnRefreshCases.Name = "BtnRefreshCases";
            this.BtnRefreshCases.Size = new System.Drawing.Size(35, 35);
            this.BtnRefreshCases.TabIndex = 27;
            this.BtnRefreshCases.UseVisualStyleBackColor = true;
            this.BtnRefreshCases.Click += new System.EventHandler(this.BtnRefreshCases_Click);
            // 
            // ButtonRefreshItems
            // 
            this.ButtonRefreshItems.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRefreshItems.Image")));
            this.ButtonRefreshItems.Location = new System.Drawing.Point(664, 163);
            this.ButtonRefreshItems.Name = "ButtonRefreshItems";
            this.ButtonRefreshItems.Size = new System.Drawing.Size(35, 35);
            this.ButtonRefreshItems.TabIndex = 28;
            this.ButtonRefreshItems.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 477);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonRefreshItems);
            this.Controls.Add(this.BtnRefreshCases);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonDeleteCase);
            this.Controls.Add(this.ButtonEditItem);
            this.Controls.Add(this.ButtonEditCase);
            this.Controls.Add(this.ButtonSendItem);
            this.Controls.Add(this.ButtonZipItem);
            this.Controls.Add(this.ListBoxItems);
            this.Controls.Add(this.ListBoxCases);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonInventory);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ButtonTriage);
            this.Controls.Add(this.ButtonNewItem);
            this.Controls.Add(this.ButtonNewCase);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonNewCase;
        private System.Windows.Forms.Button ButtonNewItem;
        private System.Windows.Forms.Button ButtonTriage;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonInventory;
        private System.Windows.Forms.Button ButtonExit;
        public System.Windows.Forms.ListBox ListBoxCases;
        public System.Windows.Forms.ListBox ListBoxItems;
        private System.Windows.Forms.Button ButtonSendItem;
        private System.Windows.Forms.Button ButtonZipItem;
        private System.Windows.Forms.Button ButtonEditCase;
        private System.Windows.Forms.Button ButtonEditItem;
        private System.Windows.Forms.Button ButtonDeleteCase;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonMedexTypes;
        private System.Windows.Forms.Button ButtonCellex;
        private System.Windows.Forms.Button ButtonClassification;
        private System.Windows.Forms.Button ButonAOR;
        private System.Windows.Forms.Button ButtonSizes;
        private System.Windows.Forms.Button ButtonFlume;
        private System.Windows.Forms.Button ButtonCaseFolder;
        private System.Windows.Forms.Button ButtonZipSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.RadioButton rbOffline;
        private System.Windows.Forms.RadioButton rbOnline;
        private System.Windows.Forms.Timer timerConnectivityCheck;
        private System.Windows.Forms.Button BtnRefreshCases;
        private System.Windows.Forms.Button ButtonRefreshItems;
    }
}

