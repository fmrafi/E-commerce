namespace infoapp
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
            this.lbpersonal = new System.Windows.Forms.Label();
            this.lb1st = new System.Windows.Forms.Label();
            this.lblast = new System.Windows.Forms.Label();
            this.lbfather = new System.Windows.Forms.Label();
            this.lbmother = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.txt1stname = new System.Windows.Forms.TextBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.txtfather = new System.Windows.Forms.TextBox();
            this.txtmother = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            this.btnname = new System.Windows.Forms.Button();
            this.btnpname = new System.Windows.Forms.Button();
            this.btnaddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbpersonal
            // 
            this.lbpersonal.AutoSize = true;
            this.lbpersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpersonal.Location = new System.Drawing.Point(156, 18);
            this.lbpersonal.Name = "lbpersonal";
            this.lbpersonal.Size = new System.Drawing.Size(229, 25);
            this.lbpersonal.TabIndex = 0;
            this.lbpersonal.Text = "Personal Information";
            // 
            // lb1st
            // 
            this.lb1st.AutoSize = true;
            this.lb1st.Location = new System.Drawing.Point(13, 87);
            this.lb1st.Name = "lb1st";
            this.lb1st.Size = new System.Drawing.Size(57, 13);
            this.lb1st.TabIndex = 1;
            this.lb1st.Text = "First Name";
            // 
            // lblast
            // 
            this.lblast.AutoSize = true;
            this.lblast.Location = new System.Drawing.Point(12, 119);
            this.lblast.Name = "lblast";
            this.lblast.Size = new System.Drawing.Size(58, 13);
            this.lblast.TabIndex = 2;
            this.lblast.Text = "Last Name";
            // 
            // lbfather
            // 
            this.lbfather.AutoSize = true;
            this.lbfather.Location = new System.Drawing.Point(12, 154);
            this.lbfather.Name = "lbfather";
            this.lbfather.Size = new System.Drawing.Size(68, 13);
            this.lbfather.TabIndex = 3;
            this.lbfather.Text = "Father Name";
            // 
            // lbmother
            // 
            this.lbmother.AutoSize = true;
            this.lbmother.Location = new System.Drawing.Point(12, 181);
            this.lbmother.Name = "lbmother";
            this.lbmother.Size = new System.Drawing.Size(71, 13);
            this.lbmother.TabIndex = 4;
            this.lbmother.Text = "Mother Name";
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.Location = new System.Drawing.Point(12, 210);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(45, 13);
            this.lbaddress.TabIndex = 5;
            this.lbaddress.Text = "Address";
            // 
            // txt1stname
            // 
            this.txt1stname.Location = new System.Drawing.Point(106, 87);
            this.txt1stname.Name = "txt1stname";
            this.txt1stname.Size = new System.Drawing.Size(279, 20);
            this.txt1stname.TabIndex = 6;
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(106, 116);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(279, 20);
            this.txtlast.TabIndex = 7;
            // 
            // txtfather
            // 
            this.txtfather.Location = new System.Drawing.Point(106, 151);
            this.txtfather.Name = "txtfather";
            this.txtfather.Size = new System.Drawing.Size(279, 20);
            this.txtfather.TabIndex = 8;
            // 
            // txtmother
            // 
            this.txtmother.Location = new System.Drawing.Point(106, 174);
            this.txtmother.Name = "txtmother";
            this.txtmother.Size = new System.Drawing.Size(279, 20);
            this.txtmother.TabIndex = 9;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(106, 207);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(279, 20);
            this.txtaddress.TabIndex = 10;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(86, 260);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btninfo
            // 
            this.btninfo.Location = new System.Drawing.Point(191, 260);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(141, 23);
            this.btninfo.TabIndex = 12;
            this.btninfo.Text = "Show All Information";
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // btnname
            // 
            this.btnname.Location = new System.Drawing.Point(86, 315);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(75, 23);
            this.btnname.TabIndex = 13;
            this.btnname.Text = "Name";
            this.btnname.UseVisualStyleBackColor = true;
            this.btnname.Click += new System.EventHandler(this.btnname_Click);
            // 
            // btnpname
            // 
            this.btnpname.Location = new System.Drawing.Point(191, 315);
            this.btnpname.Name = "btnpname";
            this.btnpname.Size = new System.Drawing.Size(89, 23);
            this.btnpname.TabIndex = 14;
            this.btnpname.Text = "Parent\'s Name";
            this.btnpname.UseVisualStyleBackColor = true;
            this.btnpname.Click += new System.EventHandler(this.btnpname_Click);
            // 
            // btnaddress
            // 
            this.btnaddress.Location = new System.Drawing.Point(310, 315);
            this.btnaddress.Name = "btnaddress";
            this.btnaddress.Size = new System.Drawing.Size(75, 23);
            this.btnaddress.TabIndex = 15;
            this.btnaddress.Text = "Address";
            this.btnaddress.UseVisualStyleBackColor = true;
            this.btnaddress.Click += new System.EventHandler(this.btnaddress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 377);
            this.Controls.Add(this.btnaddress);
            this.Controls.Add(this.btnpname);
            this.Controls.Add(this.btnname);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtmother);
            this.Controls.Add(this.txtfather);
            this.Controls.Add(this.txtlast);
            this.Controls.Add(this.txt1stname);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbmother);
            this.Controls.Add(this.lbfather);
            this.Controls.Add(this.lblast);
            this.Controls.Add(this.lb1st);
            this.Controls.Add(this.lbpersonal);
            this.Name = "Form1";
            this.Text = "Personal Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbpersonal;
        private System.Windows.Forms.Label lb1st;
        private System.Windows.Forms.Label lblast;
        private System.Windows.Forms.Label lbfather;
        private System.Windows.Forms.Label lbmother;
        private System.Windows.Forms.Label lbaddress;
        private System.Windows.Forms.TextBox txt1stname;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.TextBox txtfather;
        private System.Windows.Forms.TextBox txtmother;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.Button btnname;
        private System.Windows.Forms.Button btnpname;
        private System.Windows.Forms.Button btnaddress;
    }
}

