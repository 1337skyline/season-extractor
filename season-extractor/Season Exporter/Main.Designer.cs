namespace Season_Extractor
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
            this.PathChooseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.xTract = new System.Windows.Forms.Button();
            this.FilesInsDir = new System.Windows.Forms.CheckedListBox();
            this.SrcButton = new System.Windows.Forms.Button();
            this.DirButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SlctAllBtn = new System.Windows.Forms.Button();
            this.DSlctAllBtn = new System.Windows.Forms.Button();
            this.OpenPathCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // xTract
            // 
            this.xTract.Location = new System.Drawing.Point(645, 20);
            this.xTract.Name = "xTract";
            this.xTract.Size = new System.Drawing.Size(75, 23);
            this.xTract.TabIndex = 2;
            this.xTract.Text = "Extract Files";
            this.xTract.UseVisualStyleBackColor = true;
            this.xTract.Click += new System.EventHandler(this.xTract_Click);
            // 
            // FilesInsDir
            // 
            this.FilesInsDir.FormattingEnabled = true;
            this.FilesInsDir.HorizontalScrollbar = true;
            this.FilesInsDir.Location = new System.Drawing.Point(12, 80);
            this.FilesInsDir.Name = "FilesInsDir";
            this.FilesInsDir.Size = new System.Drawing.Size(724, 349);
            this.FilesInsDir.TabIndex = 3;
            // 
            // SrcButton
            // 
            this.SrcButton.Location = new System.Drawing.Point(130, 20);
            this.SrcButton.Name = "SrcButton";
            this.SrcButton.Size = new System.Drawing.Size(103, 23);
            this.SrcButton.TabIndex = 4;
            this.SrcButton.Text = "Search";
            this.SrcButton.UseVisualStyleBackColor = true;
            this.SrcButton.Click += new System.EventHandler(this.SrcButton_Click);
            // 
            // DirButton
            // 
            this.DirButton.Location = new System.Drawing.Point(30, 20);
            this.DirButton.Name = "DirButton";
            this.DirButton.Size = new System.Drawing.Size(94, 23);
            this.DirButton.TabIndex = 6;
            this.DirButton.Text = "Choose Path";
            this.DirButton.UseVisualStyleBackColor = true;
            this.DirButton.Click += new System.EventHandler(this.DirButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choosen Path:";
            // 
            // SlctAllBtn
            // 
            this.SlctAllBtn.Location = new System.Drawing.Point(274, 20);
            this.SlctAllBtn.Name = "SlctAllBtn";
            this.SlctAllBtn.Size = new System.Drawing.Size(75, 23);
            this.SlctAllBtn.TabIndex = 9;
            this.SlctAllBtn.Text = "Select all";
            this.SlctAllBtn.UseVisualStyleBackColor = true;
            this.SlctAllBtn.Click += new System.EventHandler(this.SlctAllBtn_Click);
            // 
            // DSlctAllBtn
            // 
            this.DSlctAllBtn.Location = new System.Drawing.Point(355, 20);
            this.DSlctAllBtn.Name = "DSlctAllBtn";
            this.DSlctAllBtn.Size = new System.Drawing.Size(75, 23);
            this.DSlctAllBtn.TabIndex = 10;
            this.DSlctAllBtn.Text = "Deselect all";
            this.DSlctAllBtn.UseVisualStyleBackColor = true;
            this.DSlctAllBtn.Click += new System.EventHandler(this.DSlctAllBtn_Click);
            // 
            // OpenPathCheck
            // 
            this.OpenPathCheck.AutoSize = true;
            this.OpenPathCheck.Location = new System.Drawing.Point(490, 24);
            this.OpenPathCheck.Name = "OpenPathCheck";
            this.OpenPathCheck.Size = new System.Drawing.Size(149, 17);
            this.OpenPathCheck.TabIndex = 11;
            this.OpenPathCheck.Text = "Open path after extraction";
            this.OpenPathCheck.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 436);
            this.Controls.Add(this.OpenPathCheck);
            this.Controls.Add(this.DSlctAllBtn);
            this.Controls.Add(this.SlctAllBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DirButton);
            this.Controls.Add(this.SrcButton);
            this.Controls.Add(this.FilesInsDir);
            this.Controls.Add(this.xTract);
            this.Name = "Main";
            this.Text = "Season Extractor - SkullCrusherz - AD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog PathChooseDialog;
        private System.Windows.Forms.Button xTract;
        private System.Windows.Forms.CheckedListBox FilesInsDir;
        private System.Windows.Forms.Button SrcButton;
        private System.Windows.Forms.Button DirButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SlctAllBtn;
        private System.Windows.Forms.Button DSlctAllBtn;
        private System.Windows.Forms.CheckBox OpenPathCheck;
    }
}

