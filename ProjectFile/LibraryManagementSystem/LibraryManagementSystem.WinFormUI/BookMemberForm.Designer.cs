namespace LibraryManagementSystem.WinFormUI
{
    partial class BookMemberForm
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
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.rbtnPassive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.dtpLeaseEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRentalDate = new System.Windows.Forms.DateTimePicker();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.btnSelectMember = new System.Windows.Forms.Button();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnSelectBook = new System.Windows.Forms.Button();
            this.lblBookMemberID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.pnlForm.SuspendLayout();
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
            this.panelTop.TabIndex = 6;
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
            this.label1.Size = new System.Drawing.Size(488, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Library Management System | Book && Member";
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.lblMemberID);
            this.pnlForm.Controls.Add(this.lblBookID);
            this.pnlForm.Controls.Add(this.rbtnPassive);
            this.pnlForm.Controls.Add(this.rbtnActive);
            this.pnlForm.Controls.Add(this.dtpLeaseEndDate);
            this.pnlForm.Controls.Add(this.dtpRentalDate);
            this.pnlForm.Controls.Add(this.lblMemberName);
            this.pnlForm.Controls.Add(this.btnSelectMember);
            this.pnlForm.Controls.Add(this.lblBookName);
            this.pnlForm.Controls.Add(this.btnSelectBook);
            this.pnlForm.Controls.Add(this.lblBookMemberID);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.btnSave);
            this.pnlForm.Controls.Add(this.label7);
            this.pnlForm.Controls.Add(this.label8);
            this.pnlForm.Controls.Add(this.label9);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Location = new System.Drawing.Point(240, 61);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(480, 480);
            this.pnlForm.TabIndex = 13;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(145, 266);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(0, 13);
            this.lblMemberID.TabIndex = 38;
            this.lblMemberID.Visible = false;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(145, 208);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(0, 13);
            this.lblBookID.TabIndex = 37;
            this.lblBookID.Visible = false;
            // 
            // rbtnPassive
            // 
            this.rbtnPassive.AutoSize = true;
            this.rbtnPassive.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPassive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnPassive.Location = new System.Drawing.Point(270, 310);
            this.rbtnPassive.Name = "rbtnPassive";
            this.rbtnPassive.Size = new System.Drawing.Size(78, 22);
            this.rbtnPassive.TabIndex = 36;
            this.rbtnPassive.TabStop = true;
            this.rbtnPassive.Text = "Passive";
            this.rbtnPassive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnActive.Location = new System.Drawing.Point(183, 310);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(71, 22);
            this.rbtnActive.TabIndex = 35;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // dtpLeaseEndDate
            // 
            this.dtpLeaseEndDate.CustomFormat = "yyyy";
            this.dtpLeaseEndDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLeaseEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLeaseEndDate.Location = new System.Drawing.Point(186, 138);
            this.dtpLeaseEndDate.Name = "dtpLeaseEndDate";
            this.dtpLeaseEndDate.Size = new System.Drawing.Size(249, 24);
            this.dtpLeaseEndDate.TabIndex = 34;
            this.dtpLeaseEndDate.Value = new System.DateTime(2022, 4, 15, 14, 51, 50, 0);
            // 
            // dtpRentalDate
            // 
            this.dtpRentalDate.CustomFormat = "yyyy";
            this.dtpRentalDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentalDate.Location = new System.Drawing.Point(186, 86);
            this.dtpRentalDate.Name = "dtpRentalDate";
            this.dtpRentalDate.Size = new System.Drawing.Size(249, 24);
            this.dtpRentalDate.TabIndex = 33;
            this.dtpRentalDate.Value = new System.DateTime(2022, 4, 15, 14, 51, 50, 0);
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMemberName.Location = new System.Drawing.Point(267, 261);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(116, 18);
            this.lblMemberName.TabIndex = 32;
            this.lblMemberName.Text = "Member Name";
            // 
            // btnSelectMember
            // 
            this.btnSelectMember.Location = new System.Drawing.Point(186, 259);
            this.btnSelectMember.Name = "btnSelectMember";
            this.btnSelectMember.Size = new System.Drawing.Size(75, 20);
            this.btnSelectMember.TabIndex = 31;
            this.btnSelectMember.Text = "Select";
            this.btnSelectMember.UseVisualStyleBackColor = true;
            this.btnSelectMember.Click += new System.EventHandler(this.btnSelectMember_Click);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBookName.Location = new System.Drawing.Point(267, 201);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(93, 18);
            this.lblBookName.TabIndex = 30;
            this.lblBookName.Text = "Book Name";
            // 
            // btnSelectBook
            // 
            this.btnSelectBook.Location = new System.Drawing.Point(186, 201);
            this.btnSelectBook.Name = "btnSelectBook";
            this.btnSelectBook.Size = new System.Drawing.Size(75, 20);
            this.btnSelectBook.TabIndex = 29;
            this.btnSelectBook.Text = "Select";
            this.btnSelectBook.UseVisualStyleBackColor = true;
            this.btnSelectBook.Click += new System.EventHandler(this.btnSelectBook_Click);
            // 
            // lblBookMemberID
            // 
            this.lblBookMemberID.AutoSize = true;
            this.lblBookMemberID.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookMemberID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBookMemberID.Location = new System.Drawing.Point(180, 40);
            this.lblBookMemberID.Name = "lblBookMemberID";
            this.lblBookMemberID.Size = new System.Drawing.Size(35, 18);
            this.lblBookMemberID.TabIndex = 28;
            this.lblBookMemberID.Text = "000";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(37, 440);
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
            this.btnDelete.Location = new System.Drawing.Point(312, 440);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(34, 314);
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
            this.label8.Location = new System.Drawing.Point(34, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Member";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(34, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(34, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(34, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rental Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(34, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lease End Date";
            // 
            // BookMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(960, 550);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookMember";
            this.Load += new System.EventHandler(this.BookMember_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBookMemberID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpLeaseEndDate;
        private System.Windows.Forms.DateTimePicker dtpRentalDate;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Button btnSelectMember;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Button btnSelectBook;
        private System.Windows.Forms.RadioButton rbtnPassive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblBookID;
    }
}