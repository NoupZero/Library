namespace Library
{
    partial class BooksCount
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
            this.dataTables = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataTables)).BeginInit();
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
            this.dataTables.Location = new System.Drawing.Point(13, 9);
            this.dataTables.MultiSelect = false;
            this.dataTables.Name = "dataTables";
            this.dataTables.ReadOnly = true;
            this.dataTables.RowHeadersVisible = false;
            this.dataTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTables.Size = new System.Drawing.Size(410, 200);
            this.dataTables.StandardTab = true;
            this.dataTables.TabIndex = 2;
            this.dataTables.VirtualMode = true;
            // 
            // BooksCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.book_library_with_open_textbook__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 221);
            this.Controls.Add(this.dataTables);
            this.MaximumSize = new System.Drawing.Size(450, 260);
            this.MinimumSize = new System.Drawing.Size(450, 260);
            this.Name = "BooksCount";
            this.Text = "Книги в наличии";
            ((System.ComponentModel.ISupportInitialize)(this.dataTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTables;
    }
}