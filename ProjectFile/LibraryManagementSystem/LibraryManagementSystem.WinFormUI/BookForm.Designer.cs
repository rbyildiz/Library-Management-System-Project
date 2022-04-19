namespace LibraryManagementSystem.WinFormUI
{
    partial class BookForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.rbtnPassive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.btnImagePath = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbxAuthor = new System.Windows.Forms.ComboBox();
            this.dtpPublicationYear = new System.Windows.Forms.DateTimePicker();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.opFile = new System.Windows.Forms.OpenFileDialog();
            this.panelTop.SuspendLayout();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(176)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(960, 55);
            this.panelTop.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(905, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Library Management System | Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(87, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(11, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Publication Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(62, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(47, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Image Path";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(79, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Active";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(79, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Author";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(61, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Category";
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.txtLanguage);
            this.pnlForm.Controls.Add(this.lblLanguage);
            this.pnlForm.Controls.Add(this.rbtnPassive);
            this.pnlForm.Controls.Add(this.rbtnActive);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.pbxImage);
            this.pnlForm.Controls.Add(this.btnSave);
            this.pnlForm.Controls.Add(this.label7);
            this.pnlForm.Controls.Add(this.label8);
            this.pnlForm.Controls.Add(this.lblImagePath);
            this.pnlForm.Controls.Add(this.btnImagePath);
            this.pnlForm.Controls.Add(this.label9);
            this.pnlForm.Controls.Add(this.label6);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.txtName);
            this.pnlForm.Controls.Add(this.cbxAuthor);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.dtpPublicationYear);
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Controls.Add(this.cbxCategory);
            this.pnlForm.Controls.Add(this.txtSummary);
            this.pnlForm.Location = new System.Drawing.Point(240, 61);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(480, 480);
            this.pnlForm.TabIndex = 11;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanguage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLanguage.Location = new System.Drawing.Point(165, 333);
            this.txtLanguage.MaxLength = 30;
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(217, 27);
            this.txtLanguage.TabIndex = 40;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLanguage.Location = new System.Drawing.Point(47, 340);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(79, 18);
            this.lblLanguage.TabIndex = 39;
            this.lblLanguage.Text = "Language";
            // 
            // rbtnPassive
            // 
            this.rbtnPassive.AutoSize = true;
            this.rbtnPassive.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPassive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnPassive.Location = new System.Drawing.Point(237, 389);
            this.rbtnPassive.Name = "rbtnPassive";
            this.rbtnPassive.Size = new System.Drawing.Size(78, 22);
            this.rbtnPassive.TabIndex = 38;
            this.rbtnPassive.TabStop = true;
            this.rbtnPassive.Text = "Passive";
            this.rbtnPassive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnActive.Location = new System.Drawing.Point(160, 391);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(71, 22);
            this.rbtnActive.TabIndex = 37;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(14, 440);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(336, 440);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(165, 5);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(150, 150);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 12;
            this.pbxImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(183, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagePath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblImagePath.Location = new System.Drawing.Point(265, 370);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(50, 16);
            this.lblImagePath.TabIndex = 23;
            this.lblImagePath.Text = "C://....";
            // 
            // btnImagePath
            // 
            this.btnImagePath.Location = new System.Drawing.Point(165, 366);
            this.btnImagePath.Name = "btnImagePath";
            this.btnImagePath.Size = new System.Drawing.Size(84, 24);
            this.btnImagePath.TabIndex = 22;
            this.btnImagePath.Text = "Open Folder..";
            this.btnImagePath.UseVisualStyleBackColor = true;
            this.btnImagePath.Click += new System.EventHandler(this.btnImagePath_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(165, 161);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 27);
            this.txtName.TabIndex = 12;
            // 
            // cbxAuthor
            // 
            this.cbxAuthor.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAuthor.FormattingEnabled = true;
            this.cbxAuthor.Location = new System.Drawing.Point(165, 303);
            this.cbxAuthor.Name = "cbxAuthor";
            this.cbxAuthor.Size = new System.Drawing.Size(217, 24);
            this.cbxAuthor.TabIndex = 21;
            // 
            // dtpPublicationYear
            // 
            this.dtpPublicationYear.CustomFormat = "yyyy";
            this.dtpPublicationYear.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPublicationYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPublicationYear.Location = new System.Drawing.Point(165, 194);
            this.dtpPublicationYear.Name = "dtpPublicationYear";
            this.dtpPublicationYear.Size = new System.Drawing.Size(217, 24);
            this.dtpPublicationYear.TabIndex = 12;
            this.dtpPublicationYear.Value = new System.DateTime(2022, 4, 15, 0, 0, 0, 0);
            // 
            // cbxCategory
            // 
            this.cbxCategory.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(165, 273);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(217, 24);
            this.cbxCategory.TabIndex = 20;
            // 
            // txtSummary
            // 
            this.txtSummary.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummary.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSummary.Location = new System.Drawing.Point(165, 224);
            this.txtSummary.MaxLength = 300;
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(217, 43);
            this.txtSummary.TabIndex = 14;
            // 
            // opFile
            // 
            this.opFile.FileName = "opFile";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(960, 550);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Button btnImagePath;
        private System.Windows.Forms.ComboBox cbxAuthor;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.OpenFileDialog opFile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpPublicationYear;
        private System.Windows.Forms.RadioButton rbtnPassive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label lblLanguage;
    }
}