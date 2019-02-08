namespace Index
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
            this.btnadd_book = new System.Windows.Forms.Button();
            this.btnshow_book = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadd_book
            // 
            this.btnadd_book.BackColor = System.Drawing.Color.Blue;
            this.btnadd_book.Location = new System.Drawing.Point(105, 48);
            this.btnadd_book.Name = "btnadd_book";
            this.btnadd_book.Size = new System.Drawing.Size(75, 23);
            this.btnadd_book.TabIndex = 0;
            this.btnadd_book.Text = "Add Book";
            this.btnadd_book.UseVisualStyleBackColor = false;
            this.btnadd_book.Click += new System.EventHandler(this.btnadd_book_Click);
            // 
            // btnshow_book
            // 
            this.btnshow_book.BackColor = System.Drawing.Color.Navy;
            this.btnshow_book.Location = new System.Drawing.Point(105, 119);
            this.btnshow_book.Name = "btnshow_book";
            this.btnshow_book.Size = new System.Drawing.Size(75, 23);
            this.btnshow_book.TabIndex = 1;
            this.btnshow_book.Text = "Show Book";
            this.btnshow_book.UseVisualStyleBackColor = false;
            this.btnshow_book.Click += new System.EventHandler(this.btnshow_book_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnshow_book);
            this.Controls.Add(this.btnadd_book);
            this.Name = "Form1";
            this.Text = "Index";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadd_book;
        private System.Windows.Forms.Button btnshow_book;
    }
}

