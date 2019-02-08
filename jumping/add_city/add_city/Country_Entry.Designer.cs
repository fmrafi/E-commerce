namespace add_city
{
    partial class Country_Entry
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
            this.lblabout = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtabout = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.DGVshow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVshow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(39, 39);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // lblabout
            // 
            this.lblabout.AutoSize = true;
            this.lblabout.Location = new System.Drawing.Point(39, 101);
            this.lblabout.Name = "lblabout";
            this.lblabout.Size = new System.Drawing.Size(35, 13);
            this.lblabout.TabIndex = 1;
            this.lblabout.Text = "About";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(105, 39);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(173, 20);
            this.txtname.TabIndex = 2;
            // 
            // txtabout
            // 
            this.txtabout.Location = new System.Drawing.Point(105, 101);
            this.txtabout.Name = "txtabout";
            this.txtabout.Size = new System.Drawing.Size(173, 20);
            this.txtabout.TabIndex = 3;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(105, 168);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(203, 168);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(75, 23);
            this.btncancle.TabIndex = 5;
            this.btncancle.Text = "Cancel";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // DGVshow
            // 
            this.DGVshow.AllowUserToAddRows = false;
            this.DGVshow.AllowUserToDeleteRows = false;
            this.DGVshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVshow.Location = new System.Drawing.Point(42, 260);
            this.DGVshow.Name = "DGVshow";
            this.DGVshow.ReadOnly = true;
            this.DGVshow.Size = new System.Drawing.Size(690, 150);
            this.DGVshow.TabIndex = 6;
            // 
            // Country_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 472);
            this.Controls.Add(this.DGVshow);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtabout);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblabout);
            this.Controls.Add(this.lblname);
            this.Name = "Country_Entry";
            this.Text = "Country_Entry";
            this.Load += new System.EventHandler(this.Country_Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblabout;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtabout;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.DataGridView DGVshow;
    }
}