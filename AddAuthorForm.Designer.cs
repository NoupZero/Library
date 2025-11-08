namespace Library
{
    partial class AddAuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuthorForm));
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFio
            // 
            this.textBoxFio.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFio.Location = new System.Drawing.Point(68, 68);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(204, 31);
            this.textBoxFio.TabIndex = 2;
            this.textBoxFio.Text = "ФИО";
            this.textBoxFio.Enter += new System.EventHandler(this.textBoxFio_Enter);
            this.textBoxFio.Leave += new System.EventHandler(this.textBoxFio_Leave);
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.BackColor = System.Drawing.Color.White;
            this.buttonAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAuthor.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddAuthor.Location = new System.Drawing.Point(68, 105);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(204, 43);
            this.buttonAddAuthor.TabIndex = 3;
            this.buttonAddAuthor.Text = "Добавить";
            this.buttonAddAuthor.UseVisualStyleBackColor = false;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Добавление автора";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.book_library_with_open_textbook__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.textBoxFio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 240);
            this.MinimumSize = new System.Drawing.Size(350, 240);
            this.Name = "AddAuthorForm";
            this.Text = "Добавление автора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}