namespace LMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsrTxt = new System.Windows.Forms.TextBox();
            this.usrlbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowPass = new System.Windows.Forms.PictureBox();
            this.HidePass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePass)).BeginInit();
            this.SuspendLayout();
            // 
            // UsrTxt
            // 
            this.UsrTxt.BackColor = System.Drawing.Color.White;
            this.UsrTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.UsrTxt.Location = new System.Drawing.Point(138, 70);
            this.UsrTxt.Name = "UsrTxt";
            this.UsrTxt.Size = new System.Drawing.Size(256, 31);
            this.UsrTxt.TabIndex = 0;
            // 
            // usrlbl
            // 
            this.usrlbl.AutoSize = true;
            this.usrlbl.BackColor = System.Drawing.Color.Transparent;
            this.usrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.usrlbl.ForeColor = System.Drawing.Color.White;
            this.usrlbl.Location = new System.Drawing.Point(39, 77);
            this.usrlbl.Name = "usrlbl";
            this.usrlbl.Size = new System.Drawing.Size(93, 20);
            this.usrlbl.TabIndex = 2;
            this.usrlbl.Text = "UserName\r\n";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.BackColor = System.Drawing.Color.Transparent;
            this.passlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.passlbl.ForeColor = System.Drawing.Color.White;
            this.passlbl.Location = new System.Drawing.Point(46, 184);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(86, 20);
            this.passlbl.TabIndex = 5;
            this.passlbl.Text = "Password";
            // 
            // PassTxt
            // 
            this.PassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.PassTxt.Location = new System.Drawing.Point(138, 180);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '*';
            this.PassTxt.Size = new System.Drawing.Size(256, 31);
            this.PassTxt.TabIndex = 4;
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.Transparent;
            this.Loginbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Loginbutton.BackgroundImage")));
            this.Loginbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Loginbutton.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold);
            this.Loginbutton.ForeColor = System.Drawing.Color.Transparent;
            this.Loginbutton.Location = new System.Drawing.Point(162, 239);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(210, 53);
            this.Loginbutton.TabIndex = 7;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Playbill", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Library Management System";
            // 
            // ShowPass
            // 
            this.ShowPass.BackColor = System.Drawing.Color.White;
            this.ShowPass.Image = ((System.Drawing.Image)(resources.GetObject("ShowPass.Image")));
            this.ShowPass.Location = new System.Drawing.Point(358, 184);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(27, 23);
            this.ShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPass.TabIndex = 9;
            this.ShowPass.TabStop = false;
            this.ShowPass.Click += new System.EventHandler(this.ShowPass_Click);
            // 
            // HidePass
            // 
            this.HidePass.BackColor = System.Drawing.Color.White;
            this.HidePass.Image = ((System.Drawing.Image)(resources.GetObject("HidePass.Image")));
            this.HidePass.Location = new System.Drawing.Point(358, 184);
            this.HidePass.Name = "HidePass";
            this.HidePass.Size = new System.Drawing.Size(27, 23);
            this.HidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HidePass.TabIndex = 10;
            this.HidePass.TabStop = false;
            this.HidePass.Click += new System.EventHandler(this.HidePass_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.HidePass);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.usrlbl);
            this.Controls.Add(this.UsrTxt);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsrTxt;
        private System.Windows.Forms.Label usrlbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ShowPass;
        private System.Windows.Forms.PictureBox HidePass;
    }
}

