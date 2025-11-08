namespace Library
{
    partial class AddGenreForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddGenre = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Добавление жанра";
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.BackColor = System.Drawing.Color.White;
            this.buttonAddGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGenre.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddGenre.Location = new System.Drawing.Point(65, 115);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(204, 43);
            this.buttonAddGenre.TabIndex = 2;
            this.buttonAddGenre.Text = "Добавить";
            this.buttonAddGenre.UseVisualStyleBackColor = false;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(65, 78);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(204, 31);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Название";
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(118, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Название";
            // 
            // AddGenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.book_library_with_open_textbook__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 201);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.textBoxName);
            this.MaximumSize = new System.Drawing.Size(350, 240);
            this.MinimumSize = new System.Drawing.Size(350, 240);
            this.Name = "AddGenreForm";
            this.Text = "Добавление жанра";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddGenre;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBox1;
    }
}