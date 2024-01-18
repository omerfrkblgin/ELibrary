namespace ELibrary.WebFormsUI
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
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.tbxBookGenre = new System.Windows.Forms.TextBox();
            this.tbxPages = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookGenre = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.lblAuthorUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxAuthorUpdate = new System.Windows.Forms.TextBox();
            this.lblGenreUpdate = new System.Windows.Forms.Label();
            this.tbxBookNameUpdate = new System.Windows.Forms.TextBox();
            this.lblBookGenreUpdate = new System.Windows.Forms.Label();
            this.tbxBookGenreUpdate = new System.Windows.Forms.TextBox();
            this.lblBookNameUpdate = new System.Windows.Forms.Label();
            this.tbxPagesUpdate = new System.Windows.Forms.TextBox();
            this.gbxSearching = new System.Windows.Forms.GroupBox();
            this.lblGenreSearch = new System.Windows.Forms.Label();
            this.cbxGenre = new System.Windows.Forms.ComboBox();
            this.lblBookNameSearch = new System.Windows.Forms.Label();
            this.tbxBookNameSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxSearching.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.Location = new System.Drawing.Point(13, 70);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.RowHeadersWidth = 51;
            this.dgwBooks.RowTemplate.Height = 24;
            this.dgwBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwBooks.Size = new System.Drawing.Size(1000, 342);
            this.dgwBooks.TabIndex = 0;
            this.dgwBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooks_CellClick);
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Location = new System.Drawing.Point(139, 31);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(149, 22);
            this.tbxAuthor.TabIndex = 1;
            // 
            // tbxBookName
            // 
            this.tbxBookName.Location = new System.Drawing.Point(139, 79);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(149, 22);
            this.tbxBookName.TabIndex = 1;
            // 
            // tbxBookGenre
            // 
            this.tbxBookGenre.Location = new System.Drawing.Point(139, 123);
            this.tbxBookGenre.Name = "tbxBookGenre";
            this.tbxBookGenre.Size = new System.Drawing.Size(149, 22);
            this.tbxBookGenre.TabIndex = 1;
            // 
            // tbxPages
            // 
            this.tbxPages.Location = new System.Drawing.Point(139, 168);
            this.tbxPages.Name = "tbxPages";
            this.tbxPages.Size = new System.Drawing.Size(149, 22);
            this.tbxPages.TabIndex = 1;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(83, 34);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(51, 16);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author :";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(48, 82);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(85, 16);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Book Name :";
            // 
            // lblBookGenre
            // 
            this.lblBookGenre.AutoSize = true;
            this.lblBookGenre.Location = new System.Drawing.Point(83, 126);
            this.lblBookGenre.Name = "lblBookGenre";
            this.lblBookGenre.Size = new System.Drawing.Size(50, 16);
            this.lblBookGenre.TabIndex = 2;
            this.lblBookGenre.Text = "Genre :";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(80, 171);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(53, 16);
            this.lblPages.TabIndex = 2;
            this.lblPages.Text = "Pages :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(196, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.lblAuthor);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxAuthor);
            this.gbxAdd.Controls.Add(this.lblPages);
            this.gbxAdd.Controls.Add(this.tbxBookName);
            this.gbxAdd.Controls.Add(this.lblBookGenre);
            this.gbxAdd.Controls.Add(this.tbxBookGenre);
            this.gbxAdd.Controls.Add(this.lblBookName);
            this.gbxAdd.Controls.Add(this.tbxPages);
            this.gbxAdd.Location = new System.Drawing.Point(13, 429);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(321, 265);
            this.gbxAdd.TabIndex = 4;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Book Adding";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.lblAuthorUpdate);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxAuthorUpdate);
            this.gbxUpdate.Controls.Add(this.lblGenreUpdate);
            this.gbxUpdate.Controls.Add(this.tbxBookNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblBookGenreUpdate);
            this.gbxUpdate.Controls.Add(this.tbxBookGenreUpdate);
            this.gbxUpdate.Controls.Add(this.lblBookNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxPagesUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(692, 429);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(321, 265);
            this.gbxUpdate.TabIndex = 4;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Book Updating";
            // 
            // lblAuthorUpdate
            // 
            this.lblAuthorUpdate.AutoSize = true;
            this.lblAuthorUpdate.Location = new System.Drawing.Point(83, 34);
            this.lblAuthorUpdate.Name = "lblAuthorUpdate";
            this.lblAuthorUpdate.Size = new System.Drawing.Size(51, 16);
            this.lblAuthorUpdate.TabIndex = 2;
            this.lblAuthorUpdate.Text = "Author :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(196, 219);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 34);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxAuthorUpdate
            // 
            this.tbxAuthorUpdate.Location = new System.Drawing.Point(139, 31);
            this.tbxAuthorUpdate.Name = "tbxAuthorUpdate";
            this.tbxAuthorUpdate.Size = new System.Drawing.Size(149, 22);
            this.tbxAuthorUpdate.TabIndex = 1;
            // 
            // lblGenreUpdate
            // 
            this.lblGenreUpdate.AutoSize = true;
            this.lblGenreUpdate.Location = new System.Drawing.Point(80, 171);
            this.lblGenreUpdate.Name = "lblGenreUpdate";
            this.lblGenreUpdate.Size = new System.Drawing.Size(53, 16);
            this.lblGenreUpdate.TabIndex = 2;
            this.lblGenreUpdate.Text = "Pages :";
            // 
            // tbxBookNameUpdate
            // 
            this.tbxBookNameUpdate.Location = new System.Drawing.Point(139, 79);
            this.tbxBookNameUpdate.Name = "tbxBookNameUpdate";
            this.tbxBookNameUpdate.Size = new System.Drawing.Size(149, 22);
            this.tbxBookNameUpdate.TabIndex = 1;
            // 
            // lblBookGenreUpdate
            // 
            this.lblBookGenreUpdate.AutoSize = true;
            this.lblBookGenreUpdate.Location = new System.Drawing.Point(83, 126);
            this.lblBookGenreUpdate.Name = "lblBookGenreUpdate";
            this.lblBookGenreUpdate.Size = new System.Drawing.Size(50, 16);
            this.lblBookGenreUpdate.TabIndex = 2;
            this.lblBookGenreUpdate.Text = "Genre :";
            // 
            // tbxBookGenreUpdate
            // 
            this.tbxBookGenreUpdate.Location = new System.Drawing.Point(139, 123);
            this.tbxBookGenreUpdate.Name = "tbxBookGenreUpdate";
            this.tbxBookGenreUpdate.Size = new System.Drawing.Size(149, 22);
            this.tbxBookGenreUpdate.TabIndex = 1;
            // 
            // lblBookNameUpdate
            // 
            this.lblBookNameUpdate.AutoSize = true;
            this.lblBookNameUpdate.Location = new System.Drawing.Point(48, 82);
            this.lblBookNameUpdate.Name = "lblBookNameUpdate";
            this.lblBookNameUpdate.Size = new System.Drawing.Size(85, 16);
            this.lblBookNameUpdate.TabIndex = 2;
            this.lblBookNameUpdate.Text = "Book Name :";
            // 
            // tbxPagesUpdate
            // 
            this.tbxPagesUpdate.Location = new System.Drawing.Point(139, 168);
            this.tbxPagesUpdate.Name = "tbxPagesUpdate";
            this.tbxPagesUpdate.Size = new System.Drawing.Size(149, 22);
            this.tbxPagesUpdate.TabIndex = 1;
            // 
            // gbxSearching
            // 
            this.gbxSearching.Controls.Add(this.lblGenreSearch);
            this.gbxSearching.Controls.Add(this.cbxGenre);
            this.gbxSearching.Controls.Add(this.lblBookNameSearch);
            this.gbxSearching.Controls.Add(this.tbxBookNameSearch);
            this.gbxSearching.Location = new System.Drawing.Point(362, 429);
            this.gbxSearching.Name = "gbxSearching";
            this.gbxSearching.Size = new System.Drawing.Size(301, 265);
            this.gbxSearching.TabIndex = 5;
            this.gbxSearching.TabStop = false;
            this.gbxSearching.Text = "Searching";
            // 
            // lblGenreSearch
            // 
            this.lblGenreSearch.AutoSize = true;
            this.lblGenreSearch.Location = new System.Drawing.Point(13, 85);
            this.lblGenreSearch.Name = "lblGenreSearch";
            this.lblGenreSearch.Size = new System.Drawing.Size(50, 16);
            this.lblGenreSearch.TabIndex = 1;
            this.lblGenreSearch.Text = "Genre :";
            // 
            // cbxGenre
            // 
            this.cbxGenre.FormattingEnabled = true;
            this.cbxGenre.Location = new System.Drawing.Point(69, 82);
            this.cbxGenre.Name = "cbxGenre";
            this.cbxGenre.Size = new System.Drawing.Size(214, 24);
            this.cbxGenre.TabIndex = 0;
            this.cbxGenre.SelectedIndexChanged += new System.EventHandler(this.cbxGenre_SelectedIndexChanged);
            // 
            // lblBookNameSearch
            // 
            this.lblBookNameSearch.AutoSize = true;
            this.lblBookNameSearch.Location = new System.Drawing.Point(10, 130);
            this.lblBookNameSearch.Name = "lblBookNameSearch";
            this.lblBookNameSearch.Size = new System.Drawing.Size(85, 16);
            this.lblBookNameSearch.TabIndex = 2;
            this.lblBookNameSearch.Text = "Book Name :";
            // 
            // tbxBookNameSearch
            // 
            this.tbxBookNameSearch.Location = new System.Drawing.Point(101, 127);
            this.tbxBookNameSearch.Name = "tbxBookNameSearch";
            this.tbxBookNameSearch.Size = new System.Drawing.Size(182, 22);
            this.tbxBookNameSearch.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(921, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 721);
            this.Controls.Add(this.gbxSearching);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwBooks);
            this.Name = "Form1";
            this.Text = "ELibrary";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxSearching.ResumeLayout(false);
            this.gbxSearching.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBooks;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.TextBox tbxBookGenre;
        private System.Windows.Forms.TextBox tbxPages;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookGenre;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Label lblAuthorUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxAuthorUpdate;
        private System.Windows.Forms.Label lblGenreUpdate;
        private System.Windows.Forms.TextBox tbxBookNameUpdate;
        private System.Windows.Forms.Label lblBookGenreUpdate;
        private System.Windows.Forms.TextBox tbxBookGenreUpdate;
        private System.Windows.Forms.Label lblBookNameUpdate;
        private System.Windows.Forms.TextBox tbxPagesUpdate;
        private System.Windows.Forms.GroupBox gbxSearching;
        private System.Windows.Forms.Label lblGenreSearch;
        private System.Windows.Forms.ComboBox cbxGenre;
        private System.Windows.Forms.Label lblBookNameSearch;
        private System.Windows.Forms.TextBox tbxBookNameSearch;
        private System.Windows.Forms.Button btnDelete;
    }
}

