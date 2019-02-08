namespace lab_final
{
    partial class Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtinfo123 = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dgvsearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information 1/2/3";
            // 
            // txtinfo123
            // 
            this.txtinfo123.Location = new System.Drawing.Point(222, 50);
            this.txtinfo123.Name = "txtinfo123";
            this.txtinfo123.Size = new System.Drawing.Size(350, 20);
            this.txtinfo123.TabIndex = 1;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(636, 46);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // dgvsearch
            // 
            this.dgvsearch.AllowUserToAddRows = false;
            this.dgvsearch.AllowUserToDeleteRows = false;
            this.dgvsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsearch.Location = new System.Drawing.Point(91, 150);
            this.dgvsearch.Name = "dgvsearch";
            this.dgvsearch.ReadOnly = true;
            this.dgvsearch.Size = new System.Drawing.Size(620, 281);
            this.dgvsearch.TabIndex = 3;
            this.dgvsearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsearch_CellContentClick);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 466);
            this.Controls.Add(this.dgvsearch);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtinfo123);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinfo123;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgvsearch;
    }
}