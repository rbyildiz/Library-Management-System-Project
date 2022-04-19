using LibraryManagementSystem.Business.Concrete;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.WinFormUI
{
    public partial class BookMemberForm : Form
    {
        private readonly int _id;
        private readonly EntityContext _context;

        public int _bookID;
        public int _memberID;

        public BookMemberForm(int id)
        {
            InitializeComponent();
            _id = id;

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _context = new EntityContext(connectionString);
        }

        private void BookMember_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnDelete.Visible = true;
            btnSave.Visible = true;

            if (_id > 0)
            {
                BookMember bookMember = _context.BookMembers.Get(_id);
                if (bookMember != null)
                {
                    // Verilerin gosterilemesi
                    lblBookMemberID.Text = bookMember.Id.ToString();
                    dtpRentalDate.Value = bookMember.BookMemberRentalDate;
                    dtpLeaseEndDate.Value = bookMember.BookMemberLeaseEndDate;
                    lblBookName.Text = bookMember.Books.BookName;
                    lblMemberName.Text = bookMember.Members.MemberFirstName + " " + bookMember.Members.MemberLastName;
                    lblBookID.Text = bookMember.BookID.ToString();
                    lblMemberID.Text = bookMember.MemberID.ToString();

                    if (bookMember.Active == true)
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
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckPanelControllers())
            {
                BookMember bookMember = new BookMember()
                {
                    BookID = int.Parse(lblBookID.Text),
                    MemberID = int.Parse(lblMemberID.Text),
                    BookMemberRentalDate = dtpRentalDate.Value,
                    BookMemberLeaseEndDate = dtpLeaseEndDate.Value,
                    Active = rbtnActive.Checked
                };

                _context.BookMembers.Add(bookMember);
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
                if (control.GetType() == typeof(Label))
                    if (string.IsNullOrEmpty(control.Text))
                        return false;
            }

            return true;
        }

        private void btnSelectBook_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm(this, false);
            tableForm.ShowDialog();

            lblBookID.Text = _bookID.ToString();
            lblBookName.Text = _context.Books.Get(_bookID).BookName;
        }

        private void btnSelectMember_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm(this, true);
            tableForm.ShowDialog();

            lblMemberID.Text = _memberID.ToString();

            Member member = _context.Members.Get(_memberID);
            string fullName = $"{member.MemberFirstName} {member.MemberLastName}";
            lblMemberName.Text = fullName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckPanelControllers())
            {
                BookMember bookMember = new BookMember()
                {
                    Id = _id,
                    BookID = int.Parse(lblBookID.Text),
                    MemberID = int.Parse(lblMemberID.Text),
                    BookMemberRentalDate = dtpRentalDate.Value,
                    BookMemberLeaseEndDate = dtpLeaseEndDate.Value,
                    Active = rbtnActive.Checked
                };


                DialogResult result = MessageBox.Show("Existing data will be destroyed. Are you sure you want to update the data?", "Update Data", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _context.BookMembers.Update(bookMember);
                    MessageBox.Show("Data has been updated.");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Incomplete data entry.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the data?", "Delete Data", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _context.BookMembers.Delete(_id);
                MessageBox.Show("Data was deleted.");
            }
            this.Close();
        }
    }
}
