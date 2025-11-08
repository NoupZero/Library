namespace Library
{
    partial class AddBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.AddBook = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(100, 102);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(188, 36);
            this.comboBoxAuthors.TabIndex = 5;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(100, 144);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(188, 36);
            this.comboBoxGenre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добавление книги";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(47, 65);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(241, 31);
            this.textBoxName.TabIndex = 9;
            this.textBoxName.Text = "Название";
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // AddBook
            // 
            this.AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBook.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBook.Location = new System.Drawing.Point(47, 287);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(241, 51);
            this.AddBook.TabIndex = 16;
            this.AddBook.Text = "Внести книгу";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(100, 187);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(188, 31);
            this.numericUpDown1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Год:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Автор:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Жанр:";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCount.Location = new System.Drawing.Point(100, 224);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(188, 31);
            this.numericUpDownCount.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Кол-во:";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.open_book_beautiful_setting__1___1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAuthors);
            this.Controls.Add(this.comboBoxGenre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "AddBookForm";
            this.Text = "Добавление книги";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label label5;
    }
}