namespace Library
{
    partial class CreateOrder
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
            this.comboBoxBooks = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxBooks
            // 
            this.comboBoxBooks.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxBooks.FormattingEnabled = true;
            this.comboBoxBooks.Location = new System.Drawing.Point(51, 122);
            this.comboBoxBooks.Name = "comboBoxBooks";
            this.comboBoxBooks.Size = new System.Drawing.Size(241, 36);
            this.comboBoxBooks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заказ";
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.BackColor = System.Drawing.Color.White;
            this.buttonCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateOrder.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateOrder.Location = new System.Drawing.Point(90, 191);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(160, 45);
            this.buttonCreateOrder.TabIndex = 2;
            this.buttonCreateOrder.Text = "Оформить";
            this.buttonCreateOrder.UseVisualStyleBackColor = false;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(51, 71);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(241, 36);
            this.comboBoxAuthors.TabIndex = 3;
            this.comboBoxAuthors.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthors_SelectedIndexChanged);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.book_library_with_open_textbook__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.comboBoxAuthors);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBooks);
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "CreateOrder";
            this.Text = "Оформление заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
    }
}