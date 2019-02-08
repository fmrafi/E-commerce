namespace PersonalInfoApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sve = new System.Windows.Forms.Button();
            this.btn_show_all = new System.Windows.Forms.Button();
            this.btn_name = new System.Windows.Forms.Button();
            this.btn_parents = new System.Windows.Forms.Button();
            this.btn_address = new System.Windows.Forms.Button();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_fathersName = new System.Windows.Forms.TextBox();
            this.txt_mothersName = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Father\'s name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mother\'s name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // btn_sve
            // 
            this.btn_sve.Location = new System.Drawing.Point(206, 273);
            this.btn_sve.Name = "btn_sve";
            this.btn_sve.Size = new System.Drawing.Size(100, 27);
            this.btn_sve.TabIndex = 6;
            this.btn_sve.Text = "Save";
            this.btn_sve.UseVisualStyleBackColor = true;
            this.btn_sve.Click += new System.EventHandler(this.btn_sve_Click);
            // 
            // btn_show_all
            // 
            this.btn_show_all.Location = new System.Drawing.Point(343, 273);
            this.btn_show_all.Name = "btn_show_all";
            this.btn_show_all.Size = new System.Drawing.Size(329, 27);
            this.btn_show_all.TabIndex = 7;
            this.btn_show_all.Text = "Show all information";
            this.btn_show_all.UseVisualStyleBackColor = true;
            this.btn_show_all.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_name
            // 
            this.btn_name.Location = new System.Drawing.Point(206, 320);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(100, 27);
            this.btn_name.TabIndex = 8;
            this.btn_name.Text = "Name";
            this.btn_name.UseVisualStyleBackColor = true;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // btn_parents
            // 
            this.btn_parents.Location = new System.Drawing.Point(343, 320);
            this.btn_parents.Name = "btn_parents";
            this.btn_parents.Size = new System.Drawing.Size(218, 27);
            this.btn_parents.TabIndex = 9;
            this.btn_parents.Text = "Parent\'s name";
            this.btn_parents.UseVisualStyleBackColor = true;
            // 
            // btn_address
            // 
            this.btn_address.Location = new System.Drawing.Point(592, 320);
            this.btn_address.Name = "btn_address";
            this.btn_address.Size = new System.Drawing.Size(100, 27);
            this.btn_address.TabIndex = 10;
            this.btn_address.Text = "Address";
            this.btn_address.UseVisualStyleBackColor = true;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(318, 71);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(336, 26);
            this.txt_firstName.TabIndex = 11;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(318, 107);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(336, 26);
            this.txt_lastName.TabIndex = 12;
            // 
            // txt_fathersName
            // 
            this.txt_fathersName.Location = new System.Drawing.Point(318, 142);
            this.txt_fathersName.Name = "txt_fathersName";
            this.txt_fathersName.Size = new System.Drawing.Size(336, 26);
            this.txt_fathersName.TabIndex = 13;
            // 
            // txt_mothersName
            // 
            this.txt_mothersName.Location = new System.Drawing.Point(318, 171);
            this.txt_mothersName.Name = "txt_mothersName";
            this.txt_mothersName.Size = new System.Drawing.Size(336, 26);
            this.txt_mothersName.TabIndex = 14;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(318, 203);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(336, 26);
            this.txt_address.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(870, 514);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_mothersName);
            this.Controls.Add(this.txt_fathersName);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.btn_address);
            this.Controls.Add(this.btn_parents);
            this.Controls.Add(this.btn_name);
            this.Controls.Add(this.btn_show_all);
            this.Controls.Add(this.btn_sve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Personal Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_sve;
        private System.Windows.Forms.Button btn_show_all;
        private System.Windows.Forms.Button btn_name;
        private System.Windows.Forms.Button btn_parents;
        private System.Windows.Forms.Button btn_address;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_fathersName;
        private System.Windows.Forms.TextBox txt_mothersName;
        private System.Windows.Forms.TextBox txt_address;
    }
}

