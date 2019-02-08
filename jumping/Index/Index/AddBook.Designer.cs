namespace Index
{
    partial class AddBook
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblISBL = new System.Windows.Forms.Label();
            this.lblauthor = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(25, 44);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // lblISBL
            // 
            this.lblISBL.AutoSize = true;
            this.lblISBL.Location = new System.Drawing.Point(25, 84);
            this.lblISBL.Name = "lblISBL";
            this.lblISBL.Size = new System.Drawing.Size(32, 13);
            this.lblISBL.TabIndex = 1;
            this.lblISBL.Text = "ISBN";
            // 
            // lblauthor
            // 
            this.lblauthor.AutoSize = true;
            this.lblauthor.Location = new System.Drawing.Point(25, 128);
            this.lblauthor.Name = "lblauthor";
            this.lblauthor.Size = new System.Drawing.Size(38, 13);
            this.lblauthor.TabIndex = 2;
            this.lblauthor.Text = "Author";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(93, 36);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 3;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(92, 81);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 4;
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(92, 125);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(100, 20);
            this.txtauthor.TabIndex = 5;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(116, 164);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblauthor);
            this.Controls.Add(this.lblISBL);
            this.Controls.Add(this.lblname);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblISBL;
        private System.Windows.Forms.Label lblauthor;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.Button btnsave;
    }
}