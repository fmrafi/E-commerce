namespace lab_final
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblinfo1 = new System.Windows.Forms.Label();
            this.lblinfo2 = new System.Windows.Forms.Label();
            this.lblinfo3 = new System.Windows.Forms.Label();
            this.lblinfo4 = new System.Windows.Forms.Label();
            this.cominfo4 = new System.Windows.Forms.ComboBox();
            this.txtinfo3 = new System.Windows.Forms.TextBox();
            this.txtinfo2 = new System.Windows.Forms.TextBox();
            this.txtinfo1 = new System.Windows.Forms.TextBox();
            this.btnseacr = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.dgvshow = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvshow);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnseacr);
            this.groupBox1.Controls.Add(this.txtinfo1);
            this.groupBox1.Controls.Add(this.txtinfo2);
            this.groupBox1.Controls.Add(this.txtinfo3);
            this.groupBox1.Controls.Add(this.cominfo4);
            this.groupBox1.Controls.Add(this.lblinfo4);
            this.groupBox1.Controls.Add(this.lblinfo3);
            this.groupBox1.Controls.Add(this.lblinfo2);
            this.groupBox1.Controls.Add(this.lblinfo1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1St From";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblinfo1
            // 
            this.lblinfo1.AutoSize = true;
            this.lblinfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo1.Location = new System.Drawing.Point(29, 40);
            this.lblinfo1.Name = "lblinfo1";
            this.lblinfo1.Size = new System.Drawing.Size(116, 20);
            this.lblinfo1.TabIndex = 0;
            this.lblinfo1.Text = "Information 1";
            // 
            // lblinfo2
            // 
            this.lblinfo2.AutoSize = true;
            this.lblinfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo2.Location = new System.Drawing.Point(29, 74);
            this.lblinfo2.Name = "lblinfo2";
            this.lblinfo2.Size = new System.Drawing.Size(116, 20);
            this.lblinfo2.TabIndex = 1;
            this.lblinfo2.Text = "Information 2";
            // 
            // lblinfo3
            // 
            this.lblinfo3.AutoSize = true;
            this.lblinfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo3.Location = new System.Drawing.Point(29, 114);
            this.lblinfo3.Name = "lblinfo3";
            this.lblinfo3.Size = new System.Drawing.Size(116, 20);
            this.lblinfo3.TabIndex = 2;
            this.lblinfo3.Text = "Information 3";
            // 
            // lblinfo4
            // 
            this.lblinfo4.AutoSize = true;
            this.lblinfo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo4.Location = new System.Drawing.Point(29, 151);
            this.lblinfo4.Name = "lblinfo4";
            this.lblinfo4.Size = new System.Drawing.Size(116, 20);
            this.lblinfo4.TabIndex = 3;
            this.lblinfo4.Text = "Information 4";
            // 
            // cominfo4
            // 
            this.cominfo4.FormattingEnabled = true;
            this.cominfo4.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cominfo4.Location = new System.Drawing.Point(185, 151);
            this.cominfo4.Name = "cominfo4";
            this.cominfo4.Size = new System.Drawing.Size(121, 21);
            this.cominfo4.TabIndex = 4;
            // 
            // txtinfo3
            // 
            this.txtinfo3.Location = new System.Drawing.Point(185, 113);
            this.txtinfo3.Name = "txtinfo3";
            this.txtinfo3.Size = new System.Drawing.Size(121, 20);
            this.txtinfo3.TabIndex = 5;
            // 
            // txtinfo2
            // 
            this.txtinfo2.Location = new System.Drawing.Point(185, 76);
            this.txtinfo2.Name = "txtinfo2";
            this.txtinfo2.Size = new System.Drawing.Size(121, 20);
            this.txtinfo2.TabIndex = 6;
            // 
            // txtinfo1
            // 
            this.txtinfo1.Location = new System.Drawing.Point(185, 40);
            this.txtinfo1.Name = "txtinfo1";
            this.txtinfo1.Size = new System.Drawing.Size(121, 20);
            this.txtinfo1.TabIndex = 7;
            // 
            // btnseacr
            // 
            this.btnseacr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseacr.Location = new System.Drawing.Point(33, 216);
            this.btnseacr.Name = "btnseacr";
            this.btnseacr.Size = new System.Drawing.Size(75, 23);
            this.btnseacr.TabIndex = 8;
            this.btnseacr.Text = "Searc";
            this.btnseacr.UseVisualStyleBackColor = true;
            this.btnseacr.Click += new System.EventHandler(this.btnseacr_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(185, 216);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dgvshow
            // 
            this.dgvshow.AllowUserToAddRows = false;
            this.dgvshow.AllowUserToDeleteRows = false;
            this.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshow.Location = new System.Drawing.Point(422, 40);
            this.dgvshow.Name = "dgvshow";
            this.dgvshow.ReadOnly = true;
            this.dgvshow.Size = new System.Drawing.Size(515, 131);
            this.dgvshow.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 352);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Information_save";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvshow;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnseacr;
        private System.Windows.Forms.TextBox txtinfo1;
        private System.Windows.Forms.TextBox txtinfo2;
        private System.Windows.Forms.TextBox txtinfo3;
        private System.Windows.Forms.ComboBox cominfo4;
        private System.Windows.Forms.Label lblinfo4;
        private System.Windows.Forms.Label lblinfo3;
        private System.Windows.Forms.Label lblinfo2;
        private System.Windows.Forms.Label lblinfo1;
    }
}

