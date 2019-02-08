namespace lab_work
{
    partial class MainFrom
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
            this.lbnew = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbnew
            // 
            this.lbnew.AutoSize = true;
            this.lbnew.Location = new System.Drawing.Point(94, 76);
            this.lbnew.Name = "lbnew";
            this.lbnew.Size = new System.Drawing.Size(105, 13);
            this.lbnew.TabIndex = 0;
            this.lbnew.Text = "welcome to my world";
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 469);
            this.Controls.Add(this.lbnew);
            this.Name = "MainFrom";
            this.Text = "MainFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnew;
    }
}