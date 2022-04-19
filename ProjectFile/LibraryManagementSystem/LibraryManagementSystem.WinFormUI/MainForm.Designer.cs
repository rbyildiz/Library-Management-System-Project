namespace LibraryManagementSystem.WinFormUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.btnTypesOfBooks = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.flpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panelLeft.Controls.Add(this.btnAuthors);
            this.panelLeft.Controls.Add(this.btnTypesOfBooks);
            this.panelLeft.Controls.Add(this.btnBooks);
            this.panelLeft.Controls.Add(this.btnMembers);
            this.panelLeft.Controls.Add(this.btnDashboard);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 55);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 495);
            this.panelLeft.TabIndex = 0;
            // 
            // btnAuthors
            // 
            this.btnAuthors.FlatAppearance.BorderSize = 0;
            this.btnAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthors.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthors.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnAuthors.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthors.Image")));
            this.btnAuthors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthors.Location = new System.Drawing.Point(2, 385);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(195, 50);
            this.btnAuthors.TabIndex = 6;
            this.btnAuthors.Text = "Authors";
            this.btnAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAuthors.UseVisualStyleBackColor = true;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // btnTypesOfBooks
            // 
            this.btnTypesOfBooks.FlatAppearance.BorderSize = 0;
            this.btnTypesOfBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypesOfBooks.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypesOfBooks.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnTypesOfBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnTypesOfBooks.Image")));
            this.btnTypesOfBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTypesOfBooks.Location = new System.Drawing.Point(2, 298);
            this.btnTypesOfBooks.Name = "btnTypesOfBooks";
            this.btnTypesOfBooks.Size = new System.Drawing.Size(195, 50);
            this.btnTypesOfBooks.TabIndex = 5;
            this.btnTypesOfBooks.Text = "Types Of Books";
            this.btnTypesOfBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTypesOfBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTypesOfBooks.UseVisualStyleBackColor = true;
            this.btnTypesOfBooks.Click += new System.EventHandler(this.btnTypesOfBooks_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnBooks.Image")));
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(0, 211);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(195, 50);
            this.btnBooks.TabIndex = 4;
            this.btnBooks.Text = "Books";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(2, 124);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(195, 50);
            this.btnMembers.TabIndex = 3;
            this.btnMembers.Text = "Members";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(2, 38);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(195, 50);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
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
            this.panelTop.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Library Management System";
            // 
            // flpSearch
            // 
            this.flpSearch.Controls.Add(this.txtSearch);
            this.flpSearch.Controls.Add(this.btnSearch);
            this.flpSearch.Location = new System.Drawing.Point(205, 65);
            this.flpSearch.Name = "flpSearch";
            this.flpSearch.Size = new System.Drawing.Size(300, 30);
            this.flpSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 25);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Search...";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(266, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 25);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(208, 99);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(738, 422);
            this.dgvTable.TabIndex = 3;
            this.dgvTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvTable_MouseClick);
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.Checked = true;
            this.cbxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActive.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbxActive.Location = new System.Drawing.Point(887, 74);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(59, 19);
            this.cbxActive.TabIndex = 5;
            this.cbxActive.Text = "Active";
            this.cbxActive.UseVisualStyleBackColor = true;
            this.cbxActive.CheckedChanged += new System.EventHandler(this.cbxActive_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(511, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(960, 550);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxActive);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.flpSearch);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.flpSearch.ResumeLayout(false);
            this.flpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnAuthors;
        private System.Windows.Forms.Button btnTypesOfBooks;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.CheckBox cbxActive;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}

