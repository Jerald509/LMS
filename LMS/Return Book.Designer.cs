namespace LMS
{
    partial class Return_Book
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
            this.button1 = new System.Windows.Forms.Button();
            this.ISBNTxt = new System.Windows.Forms.TextBox();
            this.EnrollTxt = new System.Windows.Forms.TextBox();
            this.Back1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter ISBN Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Student Enrollment Number";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(289, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Book Return";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ISBNTxt
            // 
            this.ISBNTxt.Location = new System.Drawing.Point(180, 32);
            this.ISBNTxt.Name = "ISBNTxt";
            this.ISBNTxt.Size = new System.Drawing.Size(221, 20);
            this.ISBNTxt.TabIndex = 3;
            // 
            // EnrollTxt
            // 
            this.EnrollTxt.Location = new System.Drawing.Point(180, 79);
            this.EnrollTxt.Name = "EnrollTxt";
            this.EnrollTxt.Size = new System.Drawing.Size(221, 20);
            this.EnrollTxt.TabIndex = 4;
            // 
            // Back1
            // 
            this.Back1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back1.Location = new System.Drawing.Point(171, 131);
            this.Back1.Name = "Back1";
            this.Back1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Back1.Size = new System.Drawing.Size(112, 39);
            this.Back1.TabIndex = 5;
            this.Back1.Text = "Back";
            this.Back1.UseVisualStyleBackColor = true;
            this.Back1.Click += new System.EventHandler(this.BackClick);
            // 
            // Return_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 207);
            this.Controls.Add(this.Back1);
            this.Controls.Add(this.EnrollTxt);
            this.Controls.Add(this.ISBNTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Return_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ISBNTxt;
        private System.Windows.Forms.TextBox EnrollTxt;
        private System.Windows.Forms.Button Back1;
    }
}