namespace DataTriageTransferTool
{
    partial class Triage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Triage));
            this.ButtonCloseForm = new System.Windows.Forms.Button();
            this.textBoxRipLocation = new System.Windows.Forms.TextBox();
            this.listBoxRipFolders = new System.Windows.Forms.ListBox();
            this.textBoxCaseLocation = new System.Windows.Forms.TextBox();
            this.buttonBrowseRips = new System.Windows.Forms.Button();
            this.listBoxCaseFolders = new System.Windows.Forms.ListBox();
            this.ButtonBrowseCase = new System.Windows.Forms.Button();
            this.webBrowserViewer = new System.Windows.Forms.WebBrowser();
            this.richTextBoxFilePreview = new System.Windows.Forms.RichTextBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCloseForm
            // 
            this.ButtonCloseForm.Location = new System.Drawing.Point(1164, 778);
            this.ButtonCloseForm.Name = "ButtonCloseForm";
            this.ButtonCloseForm.Size = new System.Drawing.Size(75, 23);
            this.ButtonCloseForm.TabIndex = 0;
            this.ButtonCloseForm.Text = "Exit";
            this.ButtonCloseForm.UseVisualStyleBackColor = true;
            this.ButtonCloseForm.Click += new System.EventHandler(this.ButtonCloseForm_Click);
            // 
            // textBoxRipLocation
            // 
            this.textBoxRipLocation.Location = new System.Drawing.Point(61, 217);
            this.textBoxRipLocation.Name = "textBoxRipLocation";
            this.textBoxRipLocation.Size = new System.Drawing.Size(655, 20);
            this.textBoxRipLocation.TabIndex = 46;
            // 
            // listBoxRipFolders
            // 
            this.listBoxRipFolders.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRipFolders.FormattingEnabled = true;
            this.listBoxRipFolders.ItemHeight = 15;
            this.listBoxRipFolders.Location = new System.Drawing.Point(12, 248);
            this.listBoxRipFolders.Name = "listBoxRipFolders";
            this.listBoxRipFolders.ScrollAlwaysVisible = true;
            this.listBoxRipFolders.Size = new System.Drawing.Size(887, 154);
            this.listBoxRipFolders.TabIndex = 45;
            // 
            // textBoxCaseLocation
            // 
            this.textBoxCaseLocation.Location = new System.Drawing.Point(61, 15);
            this.textBoxCaseLocation.Name = "textBoxCaseLocation";
            this.textBoxCaseLocation.Size = new System.Drawing.Size(655, 20);
            this.textBoxCaseLocation.TabIndex = 44;
            // 
            // buttonBrowseRips
            // 
            this.buttonBrowseRips.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBrowseRips.Image = ((System.Drawing.Image)(resources.GetObject("buttonBrowseRips.Image")));
            this.buttonBrowseRips.Location = new System.Drawing.Point(12, 210);
            this.buttonBrowseRips.Name = "buttonBrowseRips";
            this.buttonBrowseRips.Size = new System.Drawing.Size(43, 34);
            this.buttonBrowseRips.TabIndex = 43;
            this.buttonBrowseRips.UseVisualStyleBackColor = true;
            // 
            // listBoxCaseFolders
            // 
            this.listBoxCaseFolders.AllowDrop = true;
            this.listBoxCaseFolders.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCaseFolders.FormattingEnabled = true;
            this.listBoxCaseFolders.ItemHeight = 15;
            this.listBoxCaseFolders.Location = new System.Drawing.Point(12, 44);
            this.listBoxCaseFolders.Name = "listBoxCaseFolders";
            this.listBoxCaseFolders.ScrollAlwaysVisible = true;
            this.listBoxCaseFolders.Size = new System.Drawing.Size(887, 154);
            this.listBoxCaseFolders.TabIndex = 42;
            // 
            // ButtonBrowseCase
            // 
            this.ButtonBrowseCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonBrowseCase.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBrowseCase.Image")));
            this.ButtonBrowseCase.Location = new System.Drawing.Point(12, 8);
            this.ButtonBrowseCase.Name = "ButtonBrowseCase";
            this.ButtonBrowseCase.Size = new System.Drawing.Size(43, 34);
            this.ButtonBrowseCase.TabIndex = 41;
            this.ButtonBrowseCase.UseVisualStyleBackColor = true;
            // 
            // webBrowserViewer
            // 
            this.webBrowserViewer.CausesValidation = false;
            this.webBrowserViewer.Location = new System.Drawing.Point(905, 44);
            this.webBrowserViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserViewer.Name = "webBrowserViewer";
            this.webBrowserViewer.Size = new System.Drawing.Size(857, 663);
            this.webBrowserViewer.TabIndex = 47;
            this.webBrowserViewer.Visible = false;
            // 
            // richTextBoxFilePreview
            // 
            this.richTextBoxFilePreview.CausesValidation = false;
            this.richTextBoxFilePreview.Location = new System.Drawing.Point(905, 44);
            this.richTextBoxFilePreview.Name = "richTextBoxFilePreview";
            this.richTextBoxFilePreview.Size = new System.Drawing.Size(857, 663);
            this.richTextBoxFilePreview.TabIndex = 49;
            this.richTextBoxFilePreview.Text = "";
            this.richTextBoxFilePreview.Visible = false;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPreview.Location = new System.Drawing.Point(905, 44);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(857, 663);
            this.pictureBoxPreview.TabIndex = 48;
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.Visible = false;
            // 
            // Triage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 813);
            this.ControlBox = false;
            this.Controls.Add(this.webBrowserViewer);
            this.Controls.Add(this.richTextBoxFilePreview);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.textBoxRipLocation);
            this.Controls.Add(this.listBoxRipFolders);
            this.Controls.Add(this.textBoxCaseLocation);
            this.Controls.Add(this.buttonBrowseRips);
            this.Controls.Add(this.listBoxCaseFolders);
            this.Controls.Add(this.ButtonBrowseCase);
            this.Controls.Add(this.ButtonCloseForm);
            this.Name = "Triage";
            this.Text = "Triage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseForm;
        private System.Windows.Forms.TextBox textBoxRipLocation;
        private System.Windows.Forms.ListBox listBoxRipFolders;
        private System.Windows.Forms.TextBox textBoxCaseLocation;
        private System.Windows.Forms.Button buttonBrowseRips;
        private System.Windows.Forms.ListBox listBoxCaseFolders;
        private System.Windows.Forms.Button ButtonBrowseCase;
        private System.Windows.Forms.WebBrowser webBrowserViewer;
        private System.Windows.Forms.RichTextBox richTextBoxFilePreview;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
    }
}