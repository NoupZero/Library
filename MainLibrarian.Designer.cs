namespace Library
{
    partial class MainLibrarian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataTables = new System.Windows.Forms.DataGridView();
            this.buttonTake = new System.Windows.Forms.Button();
            this.labelTakeOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.dataTableReturn = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonProfile = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AddAuthor = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.numericUpDownIDOrder = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownIDorderReturn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.bookInLibrary = new System.Windows.Forms.Button();
            this.buttonAddGenre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDorderReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTables
            // 
            this.dataTables.AllowUserToAddRows = false;
            this.dataTables.AllowUserToDeleteRows = false;
            this.dataTables.AllowUserToResizeRows = false;
            this.dataTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTables.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataTables.BackgroundColor = System.Drawing.Color.White;
            this.dataTables.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTables.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataTables.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataTables.GridColor = System.Drawing.Color.LightBlue;
            this.dataTables.Location = new System.Drawing.Point(12, 194);
            this.dataTables.MultiSelect = false;
            this.dataTables.Name = "dataTables";
            this.dataTables.ReadOnly = true;
            this.dataTables.RowHeadersVisible = false;
            this.dataTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTables.Size = new System.Drawing.Size(510, 70);
            this.dataTables.StandardTab = true;
            this.dataTables.TabIndex = 1;
            this.dataTables.VirtualMode = true;
            // 
            // buttonTake
            // 
            this.buttonTake.BackColor = System.Drawing.Color.White;
            this.buttonTake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTake.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTake.Location = new System.Drawing.Point(272, 270);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(250, 37);
            this.buttonTake.TabIndex = 2;
            this.buttonTake.Text = "Выдать";
            this.buttonTake.UseVisualStyleBackColor = false;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // labelTakeOrder
            // 
            this.labelTakeOrder.AutoSize = true;
            this.labelTakeOrder.BackColor = System.Drawing.Color.Transparent;
            this.labelTakeOrder.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTakeOrder.ForeColor = System.Drawing.Color.White;
            this.labelTakeOrder.Location = new System.Drawing.Point(5, 151);
            this.labelTakeOrder.Name = "labelTakeOrder";
            this.labelTakeOrder.Size = new System.Drawing.Size(242, 40);
            this.labelTakeOrder.TabIndex = 5;
            this.labelTakeOrder.Text = "Выдача заказов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Возврат книг";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.White;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReturn.Location = new System.Drawing.Point(272, 429);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(250, 37);
            this.buttonReturn.TabIndex = 7;
            this.buttonReturn.Text = "Принять";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // dataTableReturn
            // 
            this.dataTableReturn.AllowUserToAddRows = false;
            this.dataTableReturn.AllowUserToDeleteRows = false;
            this.dataTableReturn.AllowUserToResizeRows = false;
            this.dataTableReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableReturn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataTableReturn.BackgroundColor = System.Drawing.Color.White;
            this.dataTableReturn.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataTableReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableReturn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataTableReturn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataTableReturn.GridColor = System.Drawing.Color.LightBlue;
            this.dataTableReturn.Location = new System.Drawing.Point(12, 355);
            this.dataTableReturn.MultiSelect = false;
            this.dataTableReturn.Name = "dataTableReturn";
            this.dataTableReturn.ReadOnly = true;
            this.dataTableReturn.RowHeadersVisible = false;
            this.dataTableReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTableReturn.Size = new System.Drawing.Size(510, 68);
            this.dataTableReturn.StandardTab = true;
            this.dataTableReturn.TabIndex = 6;
            this.dataTableReturn.VirtualMode = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.White;
            this.labelName.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(82, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 19);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "NameLabel";
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.White;
            this.buttonProfile.Image = global::Library.Properties.Resources.Ресурс_2;
            this.buttonProfile.Location = new System.Drawing.Point(12, 9);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(64, 64);
            this.buttonProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonProfile.TabIndex = 10;
            this.buttonProfile.TabStop = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            this.buttonProfile.MouseEnter += new System.EventHandler(this.buttonProfile_MouseEnter);
            this.buttonProfile.MouseLeave += new System.EventHandler(this.buttonProfile_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(43, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(53, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 61);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // AddAuthor
            // 
            this.AddAuthor.BackColor = System.Drawing.Color.White;
            this.AddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAuthor.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAuthor.Location = new System.Drawing.Point(282, 56);
            this.AddAuthor.Name = "AddAuthor";
            this.AddAuthor.Size = new System.Drawing.Size(240, 40);
            this.AddAuthor.TabIndex = 14;
            this.AddAuthor.Text = "Внести автора";
            this.AddAuthor.UseVisualStyleBackColor = false;
            this.AddAuthor.Click += new System.EventHandler(this.AddAuthor_Click);
            // 
            // AddBook
            // 
            this.AddBook.BackColor = System.Drawing.Color.White;
            this.AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBook.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBook.Location = new System.Drawing.Point(282, 10);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(240, 40);
            this.AddBook.TabIndex = 15;
            this.AddBook.Text = "Внести книгу";
            this.AddBook.UseVisualStyleBackColor = false;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // numericUpDownIDOrder
            // 
            this.numericUpDownIDOrder.AutoSize = true;
            this.numericUpDownIDOrder.BackColor = System.Drawing.Color.White;
            this.numericUpDownIDOrder.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownIDOrder.Location = new System.Drawing.Point(134, 270);
            this.numericUpDownIDOrder.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownIDOrder.Name = "numericUpDownIDOrder";
            this.numericUpDownIDOrder.Size = new System.Drawing.Size(132, 37);
            this.numericUpDownIDOrder.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID заказа";
            // 
            // numericUpDownIDorderReturn
            // 
            this.numericUpDownIDorderReturn.AutoSize = true;
            this.numericUpDownIDorderReturn.BackColor = System.Drawing.Color.White;
            this.numericUpDownIDorderReturn.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownIDorderReturn.Location = new System.Drawing.Point(134, 429);
            this.numericUpDownIDorderReturn.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownIDorderReturn.Name = "numericUpDownIDorderReturn";
            this.numericUpDownIDorderReturn.Size = new System.Drawing.Size(132, 37);
            this.numericUpDownIDorderReturn.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "ID заказа";
            // 
            // bookInLibrary
            // 
            this.bookInLibrary.BackColor = System.Drawing.Color.White;
            this.bookInLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookInLibrary.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookInLibrary.Location = new System.Drawing.Point(282, 148);
            this.bookInLibrary.Name = "bookInLibrary";
            this.bookInLibrary.Size = new System.Drawing.Size(240, 40);
            this.bookInLibrary.TabIndex = 20;
            this.bookInLibrary.Text = "Книги в наличии";
            this.bookInLibrary.UseVisualStyleBackColor = false;
            this.bookInLibrary.Click += new System.EventHandler(this.bookInLibrary_Click);
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.BackColor = System.Drawing.Color.White;
            this.buttonAddGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGenre.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddGenre.Location = new System.Drawing.Point(282, 102);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(240, 40);
            this.buttonAddGenre.TabIndex = 21;
            this.buttonAddGenre.Text = "Внести жанр";
            this.buttonAddGenre.UseVisualStyleBackColor = false;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // MainLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.book_library_with_open_textbook__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.bookInLibrary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownIDorderReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownIDOrder);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.AddAuthor);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.dataTableReturn);
            this.Controls.Add(this.labelTakeOrder);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.dataTables);
            this.MaximumSize = new System.Drawing.Size(550, 550);
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "MainLibrarian";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainAdmin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDorderReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataTables;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Label labelTakeOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.DataGridView dataTableReturn;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox buttonProfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button AddAuthor;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.NumericUpDown numericUpDownIDOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownIDorderReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bookInLibrary;
        private System.Windows.Forms.Button buttonAddGenre;
    }
}