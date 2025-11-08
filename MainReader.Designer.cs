namespace Library
{
    partial class MainReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainReader));
            this.dataBooksOrder = new System.Windows.Forms.DataGridView();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonProfile = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataBooksOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBooksOrder
            // 
            this.dataBooksOrder.AllowUserToAddRows = false;
            this.dataBooksOrder.AllowUserToDeleteRows = false;
            this.dataBooksOrder.AllowUserToResizeColumns = false;
            this.dataBooksOrder.AllowUserToResizeRows = false;
            this.dataBooksOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBooksOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataBooksOrder.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBooksOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataBooksOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataBooksOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataBooksOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataBooksOrder.GridColor = System.Drawing.Color.LightBlue;
            this.dataBooksOrder.Location = new System.Drawing.Point(12, 72);
            this.dataBooksOrder.MultiSelect = false;
            this.dataBooksOrder.Name = "dataBooksOrder";
            this.dataBooksOrder.ReadOnly = true;
            this.dataBooksOrder.RowHeadersVisible = false;
            this.dataBooksOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataBooksOrder.Size = new System.Drawing.Size(510, 311);
            this.dataBooksOrder.TabIndex = 0;
            // 
            // CreateOrder
            // 
            this.CreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateOrder.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateOrder.Location = new System.Drawing.Point(13, 390);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(255, 50);
            this.CreateOrder.TabIndex = 1;
            this.CreateOrder.Text = "Оформить заказ";
            this.CreateOrder.UseVisualStyleBackColor = true;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(316, 398);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(206, 34);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Library.Properties.Resources.icons8_поиск_96;
            this.pictureBox1.Location = new System.Drawing.Point(490, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.White;
            this.buttonProfile.Image = global::Library.Properties.Resources.Ресурс_2;
            this.buttonProfile.Location = new System.Drawing.Point(12, 3);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(64, 64);
            this.buttonProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonProfile.TabIndex = 5;
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
            this.button1.Location = new System.Drawing.Point(46, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.White;
            this.labelName.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(82, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 19);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "NameLabel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(56, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 61);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // MainReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Library.Properties.Resources.book_library_with_open_textbook__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.CreateOrder);
            this.Controls.Add(this.dataBooksOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 500);
            this.MinimumSize = new System.Drawing.Size(550, 500);
            this.Name = "MainReader";
            this.Activated += new System.EventHandler(this.MainReader_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainReader_FormClosed);
            this.Shown += new System.EventHandler(this.MainReader_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataBooksOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataBooksOrder;
        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox buttonProfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}