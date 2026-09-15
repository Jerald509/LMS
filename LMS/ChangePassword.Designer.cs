namespace LMS
{
    partial class ChangePassword
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
            this.oldPass = new System.Windows.Forms.TextBox();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confPass = new System.Windows.Forms.TextBox();
            this.ConfromPass = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // oldPass
            // 
            this.oldPass.Location = new System.Drawing.Point(185, 46);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(212, 20);
            this.oldPass.TabIndex = 2;
            // 
            // NewPass
            // 
            this.NewPass.Location = new System.Drawing.Point(185, 88);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(212, 20);
            this.NewPass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password";
            // 
            // confPass
            // 
            this.confPass.Location = new System.Drawing.Point(185, 130);
            this.confPass.Name = "confPass";
            this.confPass.Size = new System.Drawing.Size(212, 20);
            this.confPass.TabIndex = 5;
            // 
            // ConfromPass
            // 
            this.ConfromPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfromPass.Location = new System.Drawing.Point(297, 177);
            this.ConfromPass.Name = "ConfromPass";
            this.ConfromPass.Size = new System.Drawing.Size(99, 32);
            this.ConfromPass.TabIndex = 6;
            this.ConfromPass.Text = "Confirm";
            this.ConfromPass.UseVisualStyleBackColor = true;
            this.ConfromPass.Click += new System.EventHandler(this.ConfromPass_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(185, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 251);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ConfromPass);
            this.Controls.Add(this.confPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.oldPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confPass;
        private System.Windows.Forms.Button ConfromPass;
        private System.Windows.Forms.Button button2;
    }
}