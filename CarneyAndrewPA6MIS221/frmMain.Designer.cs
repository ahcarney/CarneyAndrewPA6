namespace CarneyAndrewPA6MIS221
{
    partial class frmMain
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
            this.txtTitleData = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenreData = new System.Windows.Forms.TextBox();
            this.txtAuthorData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCopies = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitleData
            // 
            this.txtTitleData.Location = new System.Drawing.Point(337, 66);
            this.txtTitleData.Name = "txtTitleData";
            this.txtTitleData.Size = new System.Drawing.Size(222, 34);
            this.txtTitleData.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(332, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 29);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(332, 172);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(80, 29);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre";
            // 
            // txtGenreData
            // 
            this.txtGenreData.Location = new System.Drawing.Point(337, 204);
            this.txtGenreData.Name = "txtGenreData";
            this.txtGenreData.Size = new System.Drawing.Size(222, 34);
            this.txtGenreData.TabIndex = 5;
            // 
            // txtAuthorData
            // 
            this.txtAuthorData.Location = new System.Drawing.Point(337, 135);
            this.txtAuthorData.Name = "txtAuthorData";
            this.txtAuthorData.Size = new System.Drawing.Size(222, 34);
            this.txtAuthorData.TabIndex = 3;
            this.txtAuthorData.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(332, 241);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(142, 29);
            this.lblCopies.TabIndex = 8;
            this.lblCopies.Text = "Copies Avlb";
            this.lblCopies.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(337, 273);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(222, 34);
            this.txtCopies.TabIndex = 7;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(332, 310);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(69, 29);
            this.lblIsbn.TabIndex = 10;
            this.lblIsbn.Text = "ISBN";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(337, 342);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(222, 34);
            this.txtIsbn.TabIndex = 9;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(332, 379);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(86, 29);
            this.lblLength.TabIndex = 12;
            this.lblLength.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(337, 411);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(222, 34);
            this.txtLength.TabIndex = 11;
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 29;
            this.lstBooks.Location = new System.Drawing.Point(11, 57);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(308, 352);
            this.lstBooks.TabIndex = 13;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(615, 66);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(294, 310);
            this.pbCover.TabIndex = 14;
            this.pbCover.TabStop = false;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(615, 411);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(126, 58);
            this.btnRent.TabIndex = 15;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(790, 411);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(119, 58);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(238, 528);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(138, 52);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(412, 528);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(138, 52);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(594, 528);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 52);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(771, 528);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 52);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 618);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtGenreData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAuthorData);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitleData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Text = "Audio Book Rental System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitleData;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenreData;
        private System.Windows.Forms.TextBox txtAuthorData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}