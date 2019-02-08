namespace multiplication
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
            this.lab1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.tex1 = new System.Windows.Forms.TextBox();
            this.tex2 = new System.Windows.Forms.TextBox();
            this.tex3 = new System.Windows.Forms.TextBox();
            this.lab5 = new System.Windows.Forms.Label();
            this.btnmul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(38, 13);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(21, 13);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "1st";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(41, 41);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(25, 13);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "2nd";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(41, 78);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(22, 13);
            this.lab3.TabIndex = 2;
            this.lab3.Text = "3rd";
            // 
            // tex1
            // 
            this.tex1.Location = new System.Drawing.Point(135, 5);
            this.tex1.Name = "tex1";
            this.tex1.Size = new System.Drawing.Size(100, 20);
            this.tex1.TabIndex = 3;
            // 
            // tex2
            // 
            this.tex2.Location = new System.Drawing.Point(135, 41);
            this.tex2.Name = "tex2";
            this.tex2.Size = new System.Drawing.Size(100, 20);
            this.tex2.TabIndex = 4;
            // 
            // tex3
            // 
            this.tex3.Location = new System.Drawing.Point(135, 78);
            this.tex3.Name = "tex3";
            this.tex3.Size = new System.Drawing.Size(100, 20);
            this.tex3.TabIndex = 5;
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Location = new System.Drawing.Point(160, 144);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(0, 13);
            this.lab5.TabIndex = 7;
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(391, 216);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(75, 23);
            this.btnmul.TabIndex = 8;
            this.btnmul.Text = "mul";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 363);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.lab5);
            this.Controls.Add(this.tex3);
            this.Controls.Add(this.tex2);
            this.Controls.Add(this.tex1);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lab1);
            this.Name = "Form1";
            this.Text = "multiplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.TextBox tex1;
        private System.Windows.Forms.TextBox tex2;
        private System.Windows.Forms.TextBox tex3;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Button btnmul;
    }
}

