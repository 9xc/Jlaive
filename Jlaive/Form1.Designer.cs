﻿namespace Jlaive
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.bypassAMSI = new System.Windows.Forms.CheckBox();
            this.antiDebug = new System.Windows.Forms.CheckBox();
            this.buildButton = new System.Windows.Forms.Button();
            this.selfDelete = new System.Windows.Forms.CheckBox();
            this.hidden = new System.Windows.Forms.CheckBox();
            this.antiVM = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.optionsPage = new System.Windows.Forms.TabPage();
            this.encryptionPage = new System.Windows.Forms.TabPage();
            this.refreshKeys = new System.Windows.Forms.Button();
            this.iv6 = new System.Windows.Forms.TextBox();
            this.iv1 = new System.Windows.Forms.TextBox();
            this.key2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.key1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xorEncryption = new System.Windows.Forms.CheckBox();
            this.aesEncryption = new System.Windows.Forms.CheckBox();
            this.binderPage = new System.Windows.Forms.TabPage();
            this.removeFile = new System.Windows.Forms.Button();
            this.addFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.outputPage = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.optionsPage.SuspendLayout();
            this.encryptionPage.SuspendLayout();
            this.binderPage.SuspendLayout();
            this.outputPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "File path:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 20);
            this.textBox1.TabIndex = 1;
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(388, 27);
            this.openButton.Margin = new System.Windows.Forms.Padding(2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(60, 20);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // bypassAMSI
            // 
            this.bypassAMSI.AutoSize = true;
            this.bypassAMSI.Checked = true;
            this.bypassAMSI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bypassAMSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bypassAMSI.Location = new System.Drawing.Point(3, 3);
            this.bypassAMSI.Margin = new System.Windows.Forms.Padding(2);
            this.bypassAMSI.Name = "bypassAMSI";
            this.bypassAMSI.Size = new System.Drawing.Size(97, 19);
            this.bypassAMSI.TabIndex = 3;
            this.bypassAMSI.Text = "Bypass AMSI";
            this.bypassAMSI.UseVisualStyleBackColor = true;
            // 
            // antiDebug
            // 
            this.antiDebug.AutoSize = true;
            this.antiDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiDebug.Location = new System.Drawing.Point(3, 24);
            this.antiDebug.Margin = new System.Windows.Forms.Padding(2);
            this.antiDebug.Name = "antiDebug";
            this.antiDebug.Size = new System.Drawing.Size(86, 19);
            this.antiDebug.TabIndex = 6;
            this.antiDebug.Text = "Anti Debug";
            this.antiDebug.UseVisualStyleBackColor = true;
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(9, 287);
            this.buildButton.Margin = new System.Windows.Forms.Padding(2);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(440, 38);
            this.buildButton.TabIndex = 7;
            this.buildButton.Text = "Build";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // selfDelete
            // 
            this.selfDelete.AutoSize = true;
            this.selfDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selfDelete.Location = new System.Drawing.Point(3, 66);
            this.selfDelete.Margin = new System.Windows.Forms.Padding(2);
            this.selfDelete.Name = "selfDelete";
            this.selfDelete.Size = new System.Drawing.Size(84, 19);
            this.selfDelete.TabIndex = 8;
            this.selfDelete.Text = "Self delete";
            this.selfDelete.UseVisualStyleBackColor = true;
            // 
            // hidden
            // 
            this.hidden.AutoSize = true;
            this.hidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidden.Location = new System.Drawing.Point(3, 86);
            this.hidden.Margin = new System.Windows.Forms.Padding(2);
            this.hidden.Name = "hidden";
            this.hidden.Size = new System.Drawing.Size(66, 19);
            this.hidden.TabIndex = 9;
            this.hidden.Text = "Hidden";
            this.hidden.UseVisualStyleBackColor = true;
            // 
            // antiVM
            // 
            this.antiVM.AutoSize = true;
            this.antiVM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiVM.Location = new System.Drawing.Point(3, 45);
            this.antiVM.Margin = new System.Windows.Forms.Padding(2);
            this.antiVM.Name = "antiVM";
            this.antiVM.Size = new System.Drawing.Size(67, 19);
            this.antiVM.TabIndex = 10;
            this.antiVM.Text = "Anti VM";
            this.antiVM.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.optionsPage);
            this.tabControl1.Controls.Add(this.encryptionPage);
            this.tabControl1.Controls.Add(this.binderPage);
            this.tabControl1.Controls.Add(this.outputPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 52);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(438, 232);
            this.tabControl1.TabIndex = 11;
            // 
            // optionsPage
            // 
            this.optionsPage.Controls.Add(this.hidden);
            this.optionsPage.Controls.Add(this.bypassAMSI);
            this.optionsPage.Controls.Add(this.selfDelete);
            this.optionsPage.Controls.Add(this.antiDebug);
            this.optionsPage.Controls.Add(this.antiVM);
            this.optionsPage.Location = new System.Drawing.Point(4, 22);
            this.optionsPage.Margin = new System.Windows.Forms.Padding(2);
            this.optionsPage.Name = "optionsPage";
            this.optionsPage.Padding = new System.Windows.Forms.Padding(2);
            this.optionsPage.Size = new System.Drawing.Size(430, 206);
            this.optionsPage.TabIndex = 0;
            this.optionsPage.Text = "Options";
            this.optionsPage.UseVisualStyleBackColor = true;
            // 
            // encryptionPage
            // 
            this.encryptionPage.Controls.Add(this.refreshKeys);
            this.encryptionPage.Controls.Add(this.iv6);
            this.encryptionPage.Controls.Add(this.iv1);
            this.encryptionPage.Controls.Add(this.key2);
            this.encryptionPage.Controls.Add(this.label3);
            this.encryptionPage.Controls.Add(this.key1);
            this.encryptionPage.Controls.Add(this.label2);
            this.encryptionPage.Controls.Add(this.xorEncryption);
            this.encryptionPage.Controls.Add(this.aesEncryption);
            this.encryptionPage.Location = new System.Drawing.Point(4, 22);
            this.encryptionPage.Margin = new System.Windows.Forms.Padding(2);
            this.encryptionPage.Name = "encryptionPage";
            this.encryptionPage.Padding = new System.Windows.Forms.Padding(2);
            this.encryptionPage.Size = new System.Drawing.Size(430, 206);
            this.encryptionPage.TabIndex = 1;
            this.encryptionPage.Text = "Encryption";
            this.encryptionPage.UseVisualStyleBackColor = true;
            // 
            // refreshKeys
            // 
            this.refreshKeys.Location = new System.Drawing.Point(131, 155);
            this.refreshKeys.Margin = new System.Windows.Forms.Padding(2);
            this.refreshKeys.Name = "refreshKeys";
            this.refreshKeys.Size = new System.Drawing.Size(91, 20);
            this.refreshKeys.TabIndex = 9;
            this.refreshKeys.Text = "Refresh keys";
            this.refreshKeys.UseVisualStyleBackColor = true;
            this.refreshKeys.Click += new System.EventHandler(this.UpdateKeys);
            // 
            // iv6
            // 
            this.iv6.Location = new System.Drawing.Point(42, 125);
            this.iv6.Margin = new System.Windows.Forms.Padding(2);
            this.iv6.Name = "iv6";
            this.iv6.ReadOnly = true;
            this.iv6.Size = new System.Drawing.Size(182, 20);
            this.iv6.TabIndex = 8;
            // 
            // iv1
            // 
            this.iv1.Location = new System.Drawing.Point(42, 102);
            this.iv1.Margin = new System.Windows.Forms.Padding(2);
            this.iv1.Name = "iv1";
            this.iv1.ReadOnly = true;
            this.iv1.Size = new System.Drawing.Size(182, 20);
            this.iv1.TabIndex = 7;
            // 
            // key2
            // 
            this.key2.Location = new System.Drawing.Point(42, 77);
            this.key2.Margin = new System.Windows.Forms.Padding(2);
            this.key2.Name = "key2";
            this.key2.ReadOnly = true;
            this.key2.Size = new System.Drawing.Size(182, 20);
            this.key2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IVs:";
            // 
            // key1
            // 
            this.key1.Location = new System.Drawing.Point(42, 57);
            this.key1.Margin = new System.Windows.Forms.Padding(2);
            this.key1.Name = "key1";
            this.key1.ReadOnly = true;
            this.key1.Size = new System.Drawing.Size(182, 20);
            this.key1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Keys:";
            // 
            // xorEncryption
            // 
            this.xorEncryption.AutoSize = true;
            this.xorEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xorEncryption.Location = new System.Drawing.Point(3, 24);
            this.xorEncryption.Margin = new System.Windows.Forms.Padding(2);
            this.xorEncryption.Name = "xorEncryption";
            this.xorEncryption.Size = new System.Drawing.Size(52, 19);
            this.xorEncryption.TabIndex = 1;
            this.xorEncryption.Text = "XOR";
            this.xorEncryption.UseVisualStyleBackColor = true;
            this.xorEncryption.CheckedChanged += new System.EventHandler(this.xorEncryption_CheckedChanged);
            // 
            // aesEncryption
            // 
            this.aesEncryption.AutoSize = true;
            this.aesEncryption.Checked = true;
            this.aesEncryption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aesEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aesEncryption.Location = new System.Drawing.Point(3, 3);
            this.aesEncryption.Margin = new System.Windows.Forms.Padding(2);
            this.aesEncryption.Name = "aesEncryption";
            this.aesEncryption.Size = new System.Drawing.Size(49, 19);
            this.aesEncryption.TabIndex = 0;
            this.aesEncryption.Text = "AES";
            this.aesEncryption.UseVisualStyleBackColor = true;
            this.aesEncryption.CheckedChanged += new System.EventHandler(this.aesEncryption_CheckedChanged);
            // 
            // binderPage
            // 
            this.binderPage.Controls.Add(this.removeFile);
            this.binderPage.Controls.Add(this.addFile);
            this.binderPage.Controls.Add(this.listBox1);
            this.binderPage.Location = new System.Drawing.Point(4, 22);
            this.binderPage.Margin = new System.Windows.Forms.Padding(2);
            this.binderPage.Name = "binderPage";
            this.binderPage.Padding = new System.Windows.Forms.Padding(2);
            this.binderPage.Size = new System.Drawing.Size(430, 206);
            this.binderPage.TabIndex = 2;
            this.binderPage.Text = "Binder";
            this.binderPage.UseVisualStyleBackColor = true;
            // 
            // removeFile
            // 
            this.removeFile.Location = new System.Drawing.Point(98, 177);
            this.removeFile.Margin = new System.Windows.Forms.Padding(2);
            this.removeFile.Name = "removeFile";
            this.removeFile.Size = new System.Drawing.Size(93, 27);
            this.removeFile.TabIndex = 2;
            this.removeFile.Text = "Remove file";
            this.removeFile.UseVisualStyleBackColor = true;
            this.removeFile.Click += new System.EventHandler(this.removeFile_Click);
            // 
            // addFile
            // 
            this.addFile.Location = new System.Drawing.Point(2, 177);
            this.addFile.Margin = new System.Windows.Forms.Padding(2);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(93, 27);
            this.addFile.TabIndex = 1;
            this.addFile.Text = "Add file";
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 4);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(426, 173);
            this.listBox1.TabIndex = 0;
            // 
            // outputPage
            // 
            this.outputPage.Controls.Add(this.listBox2);
            this.outputPage.Location = new System.Drawing.Point(4, 22);
            this.outputPage.Margin = new System.Windows.Forms.Padding(2);
            this.outputPage.Name = "outputPage";
            this.outputPage.Padding = new System.Windows.Forms.Padding(2);
            this.outputPage.Size = new System.Drawing.Size(430, 206);
            this.outputPage.TabIndex = 3;
            this.outputPage.Text = "Output";
            this.outputPage.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 3);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(426, 199);
            this.listBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(457, 334);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jlaive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.optionsPage.ResumeLayout(false);
            this.optionsPage.PerformLayout();
            this.encryptionPage.ResumeLayout(false);
            this.encryptionPage.PerformLayout();
            this.binderPage.ResumeLayout(false);
            this.outputPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.CheckBox bypassAMSI;
        private System.Windows.Forms.CheckBox antiDebug;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.CheckBox selfDelete;
        private System.Windows.Forms.CheckBox hidden;
        private System.Windows.Forms.CheckBox antiVM;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage optionsPage;
        private System.Windows.Forms.TabPage encryptionPage;
        private System.Windows.Forms.CheckBox aesEncryption;
        private System.Windows.Forms.CheckBox xorEncryption;
        private System.Windows.Forms.TabPage binderPage;
        private System.Windows.Forms.TabPage outputPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox key1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addFile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox iv6;
        private System.Windows.Forms.TextBox iv1;
        private System.Windows.Forms.TextBox key2;
        private System.Windows.Forms.Button refreshKeys;
        private System.Windows.Forms.Button removeFile;
        private System.Windows.Forms.ListBox listBox2;
    }
}
