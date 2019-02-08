namespace ATM_app
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
            this.components = new System.ComponentModel.Container();
            this.lbwelcome = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.lbpin = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpin = new System.Windows.Forms.TextBox();
            this.btnabout = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.lbtime = new System.Windows.Forms.Label();
            this.btntime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbwelcome
            // 
            this.lbwelcome.AutoSize = true;
            this.lbwelcome.Location = new System.Drawing.Point(252, 13);
            this.lbwelcome.Name = "lbwelcome";
            this.lbwelcome.Size = new System.Drawing.Size(90, 13);
            this.lbwelcome.TabIndex = 0;
            this.lbwelcome.Text = "Welcome to ATM";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(168, 102);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(88, 13);
            this.lbusername.TabIndex = 1;
            this.lbusername.Text = "Enter User Name";
            // 
            // lbpin
            // 
            this.lbpin.AutoSize = true;
            this.lbpin.Location = new System.Drawing.Point(168, 153);
            this.lbpin.Name = "lbpin";
            this.lbpin.Size = new System.Drawing.Size(75, 13);
            this.lbpin.TabIndex = 2;
            this.lbpin.Text = "Enter Your Pin";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(262, 102);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 3;
            // 
            // txtpin
            // 
            this.txtpin.Location = new System.Drawing.Point(262, 153);
            this.txtpin.Name = "txtpin";
            this.txtpin.Size = new System.Drawing.Size(100, 20);
            this.txtpin.TabIndex = 4;
            this.txtpin.TextChanged += new System.EventHandler(this.txtpin_TextChanged);
            this.txtpin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtpin_MouseDoubleClick);
            // 
            // btnabout
            // 
            this.btnabout.Location = new System.Drawing.Point(23, 35);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(75, 23);
            this.btnabout.TabIndex = 5;
            this.btnabout.Text = "About";
            this.btnabout.UseVisualStyleBackColor = true;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.Location = new System.Drawing.Point(23, 327);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(75, 23);
            this.btnadmin.TabIndex = 6;
            this.btnadmin.Text = "Admin";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(267, 208);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(527, 327);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(183, 208);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 10;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Location = new System.Drawing.Point(547, 35);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(0, 13);
            this.lbtime.TabIndex = 11;
            // 
            // btntime
            // 
            this.btntime.Location = new System.Drawing.Point(527, 111);
            this.btntime.Name = "btntime";
            this.btntime.Size = new System.Drawing.Size(75, 23);
            this.btntime.TabIndex = 12;
            this.btntime.UseVisualStyleBackColor = true;
            this.btntime.Click += new System.EventHandler(this.btntime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 362);
            this.Controls.Add(this.btntime);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnabout);
            this.Controls.Add(this.txtpin);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbpin);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.lbwelcome);
            this.Name = "Form1";
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbwelcome;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label lbpin;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpin;
        private System.Windows.Forms.Button btnabout;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Button btntime;
    }
}

