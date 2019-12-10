using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarneyAndrewPA6MIS221
{
    public partial class frmEdit : Form
    {
        private Book myBook;
        private string cwid;
        private string mode;

        //Edit form constructor
        public frmEdit(Object tempBook, string tempMode, string tempCwid)
        {
            myBook = (Book)tempBook;
            cwid = tempCwid;
            mode = tempMode;
            InitializeComponent();
            pbCover.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Loading information to edit book
        private void frmEdit_Load(object sender, EventArgs e)
        {
            if(mode == "edit")
            {
                txtTitleData.Text = myBook.title;
                txtAuthorData.Text = myBook.author;
                txtGenreData.Text = myBook.genre;
                txtCopies.Text = myBook.copies.ToString();
                txtIsbn.Text = myBook.isbn;
                txtCoverData.Text = myBook.cover;
                txtLength.Text = myBook.length.ToString();

                pbCover.Load(myBook.cover);
            }
        }

        //Method to close the edit menu
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Method to save the edits made to books
        private void btnSave_Click(object sender, EventArgs e)
        {
             myBook.title = txtTitleData.Text;
             myBook.author = txtAuthorData.Text;
             myBook.genre = txtGenreData.Text;
             myBook.copies = int.Parse(txtCopies.Text);
             myBook.isbn = txtIsbn.Text;
             myBook.cover = txtCoverData.Text;
             myBook.length = int.Parse(txtLength.Text);
             myBook.cwid = cwid;

            BookFile.SaveBook(myBook, cwid, mode);

            MessageBox.Show("Content was saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
