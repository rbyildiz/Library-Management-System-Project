using LibraryManagementSystem.Business.Concrete;
using LibraryManagementSystem.Entities;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagementSystem.WinFormUI
{
    public partial class BookForm : Form
    {
        private readonly int _id;
        private readonly EntityContext _context;

        public BookForm(int id)
        {
            InitializeComponent();
            _id = id;

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _context = new EntityContext(connectionString);
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnDelete.Visible = true;
            btnSave.Visible = true;

            // ComboBox'larin doldurulmasi
            ComboBoxFill();

            if (_id > 0)
            {
                Book book = _context.Books.Get(_id);
                if (book != null)
                {
                    // Verilerin gosterilemesi
                    pbxImage.Image = Image.FromFile(book.BookImagePath);
                    lblImagePath.Text = book.BookImagePath;
                    txtName.Text = book.BookName;
                    dtpPublicationYear.Value = new DateTime(book.BookPublicationYear, 01, 01);
                    txtSummary.Text = book.BookSummary;
                    cbxCategory.SelectedValue = book.CategoryID;
                    cbxAuthor.SelectedValue = book.AuthorID;
                    txtLanguage.Text = book.BookLanguage;

                    if (book.Active == true)
                        rbtnActive.Checked = true;
                    else
                        rbtnPassive.Checked = true;
                }
            }
            else
            {
                btnAdd.Visible = true;
                btnDelete.Visible = false;
                btnSave.Visible = false;

                pbxImage.Image = Image.FromFile(@"..\ImageBooks\null.png");
            }
        }

        // CLOSE Button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // ComboBox'larin doldurulmasi
        private void ComboBoxFill()
        {
            cbxCategory.DataSource = _context.Categories.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "Id";
            cbxCategory.SelectedIndex = 0;

            cbxAuthor.DataSource = _context.Authors.GetAll();
            cbxAuthor.DisplayMember = "AuthorLastName";
            cbxAuthor.ValueMember = "Id";
            cbxAuthor.SelectedIndex = 0;
        }

        // Goruntunun secilmesi
        private void btnImagePath_Click(object sender, EventArgs e)
        {
            opFile.Title = "Select a image";
            opFile.Filter = "(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|All files(*.*)|*.*";

            //string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ImageBooks\";
            string appPath = @"C:\Users\rberh\OneDrive\Masaüstü\1091000\Projects\LibraryManagementSystemProject\Images\books\";

            if (Directory.Exists(appPath) == false)
                Directory.CreateDirectory(appPath);

            if (DialogResult.OK == opFile.ShowDialog())
            {
                string fileName = opFile.SafeFileName;
                string filePath = opFile.FileName;
                File.Copy(filePath, appPath + fileName);

                pbxImage.Image = new Bitmap(opFile.OpenFile());
                lblImagePath.Text = opFile.FileName;
            }
        }

        // Ekleme islemi
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckPanelControllers())
            {
                Book book = new Book()
                {
                    BookName = txtName.Text,
                    BookPublicationYear = dtpPublicationYear.Value.Year,
                    BookSummary = txtSummary.Text,
                    CategoryID = cbxCategory.SelectedIndex + 1,
                    AuthorID = cbxAuthor.SelectedIndex + 1,
                    BookImagePath = lblImagePath.Text,
                    BookLanguage = txtLanguage.Text,
                    Active = rbtnActive.Checked
                };

                _context.Books.Add(book);
                MessageBox.Show("Data Added.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Incomplete data entry.");
            }
        }


        private bool CheckPanelControllers()
        {
            foreach (Control control in pnlForm.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                    if (string.IsNullOrEmpty(control.Text))
                        return false;
                    else if (control.GetType() == typeof(ComboBox))
                        if (((ComboBox)control).SelectedIndex == 0)
                            return false;
            }

            return true;
        }

        // Guncelleme islemi
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckPanelControllers())
            {
                Book book = new Book()
                {
                    Id = _id,
                    BookName = txtName.Text,
                    BookPublicationYear = dtpPublicationYear.Value.Year,
                    BookSummary = txtSummary.Text,
                    CategoryID = cbxCategory.SelectedIndex + 1,
                    AuthorID = cbxAuthor.SelectedIndex + 1,
                    BookImagePath = lblImagePath.Text,
                    BookLanguage = txtLanguage.Text,
                    Active = rbtnActive.Checked
                };


                DialogResult result = MessageBox.Show("Existing data will be destroyed. Are you sure you want to update the data?", "Update Data", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _context.Books.Update(book);
                    MessageBox.Show("Data has been updated.");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Incomplete data entry.");
            }
        }

        // Veri silme islemi
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the data?", "Delete Data", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _context.Books.Delete(_id);
                MessageBox.Show("Data was deleted.");
            }
            this.Close();
        }
    }
}
