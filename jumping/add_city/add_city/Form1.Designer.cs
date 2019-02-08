namespace add_city
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
            this.btncountry = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncountry
            // 
            this.btncountry.Location = new System.Drawing.Point(185, 65);
            this.btncountry.Name = "btncountry";
            this.btncountry.Size = new System.Drawing.Size(90, 23);
            this.btncountry.TabIndex = 0;
            this.btncountry.Text = "Add Country";
            this.btncountry.UseVisualStyleBackColor = true;
            this.btncountry.Click += new System.EventHandler(this.btncountry_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(185, 142);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(90, 23);
            this.btnshow.TabIndex = 1;
            this.btnshow.Text = "Show Country";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 310);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btncountry);
            this.Name = "Form1";
            this.Text = "Home Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncountry;
        private System.Windows.Forms.Button btnshow;
    }
}

