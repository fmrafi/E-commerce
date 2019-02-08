namespace minical
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
            this.lab1st = new System.Windows.Forms.Label();
            this.txt1st = new System.Windows.Forms.TextBox();
            this.lb2nd = new System.Windows.Forms.Label();
            this.txt2nd = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.lbout = new System.Windows.Forms.Label();
            this.txtout = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab1st
            // 
            this.lab1st.AutoSize = true;
            this.lab1st.Location = new System.Drawing.Point(70, 31);
            this.lab1st.Name = "lab1st";
            this.lab1st.Size = new System.Drawing.Size(62, 13);
            this.lab1st.TabIndex = 0;
            this.lab1st.Text = "1st_number";
            // 
            // txt1st
            // 
            this.txt1st.Location = new System.Drawing.Point(209, 31);
            this.txt1st.Name = "txt1st";
            this.txt1st.Size = new System.Drawing.Size(423, 20);
            this.txt1st.TabIndex = 1;
            // 
            // lb2nd
            // 
            this.lb2nd.AutoSize = true;
            this.lb2nd.Location = new System.Drawing.Point(73, 89);
            this.lb2nd.Name = "lb2nd";
            this.lb2nd.Size = new System.Drawing.Size(66, 13);
            this.lb2nd.TabIndex = 2;
            this.lb2nd.Text = "2nd_number";
            // 
            // txt2nd
            // 
            this.txt2nd.Location = new System.Drawing.Point(209, 81);
            this.txt2nd.Name = "txt2nd";
            this.txt2nd.Size = new System.Drawing.Size(423, 20);
            this.txt2nd.TabIndex = 3;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(209, 183);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(329, 182);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 23);
            this.btnsub.TabIndex = 5;
            this.btnsub.Text = "Sub";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(459, 181);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(75, 23);
            this.btnmul.TabIndex = 6;
            this.btnmul.Text = "Mul";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(578, 182);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(75, 23);
            this.btndiv.TabIndex = 7;
            this.btndiv.Text = "Div";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // lbout
            // 
            this.lbout.AutoSize = true;
            this.lbout.Location = new System.Drawing.Point(76, 265);
            this.lbout.Name = "lbout";
            this.lbout.Size = new System.Drawing.Size(37, 13);
            this.lbout.TabIndex = 8;
            this.lbout.Text = "output";
            // 
            // txtout
            // 
            this.txtout.Location = new System.Drawing.Point(209, 257);
            this.txtout.Name = "txtout";
            this.txtout.Size = new System.Drawing.Size(423, 20);
            this.txtout.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 423);
            this.Controls.Add(this.txtout);
            this.Controls.Add(this.lbout);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txt2nd);
            this.Controls.Add(this.lb2nd);
            this.Controls.Add(this.txt1st);
            this.Controls.Add(this.lab1st);
            this.Name = "Form1";
            this.Text = "minical";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1st;
        private System.Windows.Forms.TextBox txt1st;
        private System.Windows.Forms.Label lb2nd;
        private System.Windows.Forms.TextBox txt2nd;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Label lbout;
        private System.Windows.Forms.TextBox txtout;
    }
}

