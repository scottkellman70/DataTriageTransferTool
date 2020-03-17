﻿namespace DataTriageTransferTool
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
            this.SuspendLayout();
            // 
            // ButtonNewCase
            // 
            this.ButtonNewCase.Location = new System.Drawing.Point(36, 33);
            this.ButtonNewCase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonNewCase.Name = "ButtonNewCase";
            this.ButtonNewCase.Size = new System.Drawing.Size(112, 31);
            this.ButtonNewCase.TabIndex = 0;
            this.ButtonNewCase.Text = "New Case";
            this.ButtonNewCase.UseVisualStyleBackColor = true;
            this.ButtonNewCase.Click += new System.EventHandler(this.ButtonNewCase_Click);
            // 
            // ButtonNewItem
            // 
            this.ButtonNewItem.Location = new System.Drawing.Point(36, 82);
            this.ButtonNewItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonNewItem.Name = "ButtonNewItem";
            this.ButtonNewItem.Size = new System.Drawing.Size(112, 31);
            this.ButtonNewItem.TabIndex = 1;
            this.ButtonNewItem.Text = "New Item";
            this.ButtonNewItem.UseVisualStyleBackColor = true;
            this.ButtonNewItem.Click += new System.EventHandler(this.ButtonNewItem_Click);
            // 
            // ButtonTriage
            // 
            this.ButtonTriage.Location = new System.Drawing.Point(36, 132);
            this.ButtonTriage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonTriage.Name = "ButtonTriage";
            this.ButtonTriage.Size = new System.Drawing.Size(112, 31);
            this.ButtonTriage.TabIndex = 2;
            this.ButtonTriage.Text = "Triage";
            this.ButtonTriage.UseVisualStyleBackColor = true;
            this.ButtonTriage.Click += new System.EventHandler(this.ButtonTriage_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Location = new System.Drawing.Point(36, 186);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(112, 31);
            this.ButtonSettings.TabIndex = 3;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonInventory
            // 
            this.ButtonInventory.Location = new System.Drawing.Point(36, 241);
            this.ButtonInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonInventory.Name = "ButtonInventory";
            this.ButtonInventory.Size = new System.Drawing.Size(112, 31);
            this.ButtonInventory.TabIndex = 4;
            this.ButtonInventory.Text = "4137";
            this.ButtonInventory.UseVisualStyleBackColor = true;
            this.ButtonInventory.Click += new System.EventHandler(this.ButtonInventory_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(36, 291);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.ButtonSendItem.Location = new System.Drawing.Point(664, 311);
            this.ButtonSendItem.Name = "ButtonSendItem";
            this.ButtonSendItem.Size = new System.Drawing.Size(43, 43);
            this.ButtonSendItem.TabIndex = 19;
            this.ButtonSendItem.TabStop = false;
            this.ButtonSendItem.UseVisualStyleBackColor = false;
            // 
            // ButtonZipItem
            // 
            this.ButtonZipItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonZipItem.Image = ((System.Drawing.Image)(resources.GetObject("ButtonZipItem.Image")));
            this.ButtonZipItem.Location = new System.Drawing.Point(664, 262);
            this.ButtonZipItem.Name = "ButtonZipItem";
            this.ButtonZipItem.Size = new System.Drawing.Size(43, 43);
            this.ButtonZipItem.TabIndex = 18;
            this.ButtonZipItem.TabStop = false;
            this.ButtonZipItem.UseVisualStyleBackColor = true;
            // 
            // ButtonEditCase
            // 
            this.ButtonEditCase.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEditCase.Image")));
            this.ButtonEditCase.Location = new System.Drawing.Point(664, 33);
            this.ButtonEditCase.Name = "ButtonEditCase";
            this.ButtonEditCase.Size = new System.Drawing.Size(43, 43);
            this.ButtonEditCase.TabIndex = 20;
            this.ButtonEditCase.UseVisualStyleBackColor = true;
            // 
            // ButtonEditItem
            // 
            this.ButtonEditItem.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEditItem.Image")));
            this.ButtonEditItem.Location = new System.Drawing.Point(664, 164);
            this.ButtonEditItem.Name = "ButtonEditItem";
            this.ButtonEditItem.Size = new System.Drawing.Size(43, 43);
            this.ButtonEditItem.TabIndex = 21;
            this.ButtonEditItem.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteCase
            // 
            this.ButtonDeleteCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDeleteCase.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteCase.Image")));
            this.ButtonDeleteCase.Location = new System.Drawing.Point(664, 76);
            this.ButtonDeleteCase.Name = "ButtonDeleteCase";
            this.ButtonDeleteCase.Size = new System.Drawing.Size(43, 43);
            this.ButtonDeleteCase.TabIndex = 22;
            this.ButtonDeleteCase.TabStop = false;
            this.ButtonDeleteCase.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.Image")));
            this.ButtonDelete.Location = new System.Drawing.Point(664, 213);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(43, 43);
            this.ButtonDelete.TabIndex = 23;
            this.ButtonDelete.TabStop = false;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 408);
            this.ControlBox = false;
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonNewCase;
        private System.Windows.Forms.Button ButtonNewItem;
        private System.Windows.Forms.Button ButtonTriage;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonInventory;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ListBox ListBoxCases;
        private System.Windows.Forms.ListBox ListBoxItems;
        private System.Windows.Forms.Button ButtonSendItem;
        private System.Windows.Forms.Button ButtonZipItem;
        private System.Windows.Forms.Button ButtonEditCase;
        private System.Windows.Forms.Button ButtonEditItem;
        private System.Windows.Forms.Button ButtonDeleteCase;
        private System.Windows.Forms.Button ButtonDelete;
    }
}

