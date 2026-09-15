namespace LMS
{
    partial class ManageBook
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
            this.button1 = new System.Windows.Forms.Button();
            this.catecombo = new System.Windows.Forms.ComboBox();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.QtyTxt = new System.Windows.Forms.TextBox();
            this.isbnTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rcattxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rqtytxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Back3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rtitletxt = new System.Windows.Forms.TextBox();
            this.aqtytxt = new System.Windows.Forms.TextBox();
            this.risbntxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.catecombo);
            this.groupBox1.Controls.Add(this.titleTxt);
            this.groupBox1.Controls.Add(this.QtyTxt);
            this.groupBox1.Controls.Add(this.isbnTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Books";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(227, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add New Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // catecombo
            // 
            this.catecombo.FormattingEnabled = true;
            this.catecombo.Location = new System.Drawing.Point(147, 127);
            this.catecombo.Name = "catecombo";
            this.catecombo.Size = new System.Drawing.Size(273, 21);
            this.catecombo.TabIndex = 8;
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(147, 78);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(273, 20);
            this.titleTxt.TabIndex = 7;
            // 
            // QtyTxt
            // 
            this.QtyTxt.Location = new System.Drawing.Point(147, 170);
            this.QtyTxt.Name = "QtyTxt";
            this.QtyTxt.Size = new System.Drawing.Size(273, 20);
            this.QtyTxt.TabIndex = 6;
            // 
            // isbnTxt
            // 
            this.isbnTxt.Location = new System.Drawing.Point(147, 36);
            this.isbnTxt.Name = "isbnTxt";
            this.isbnTxt.Size = new System.Drawing.Size(273, 20);
            this.isbnTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ISBN Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rcattxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.rqtytxt);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.Back3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.rtitletxt);
            this.groupBox2.Controls.Add(this.aqtytxt);
            this.groupBox2.Controls.Add(this.risbntxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 288);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Books";
            // 
            // rcattxt
            // 
            this.rcattxt.Location = new System.Drawing.Point(147, 122);
            this.rcattxt.Name = "rcattxt";
            this.rcattxt.Size = new System.Drawing.Size(273, 20);
            this.rcattxt.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Quantity To be removed";
            // 
            // rqtytxt
            // 
            this.rqtytxt.Location = new System.Drawing.Point(147, 206);
            this.rqtytxt.Name = "rqtytxt";
            this.rqtytxt.Size = new System.Drawing.Size(273, 20);
            this.rqtytxt.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(426, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Back3
            // 
            this.Back3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back3.Location = new System.Drawing.Point(147, 236);
            this.Back3.Name = "Back3";
            this.Back3.Size = new System.Drawing.Size(108, 46);
            this.Back3.TabIndex = 10;
            this.Back3.Text = "Back";
            this.Back3.UseVisualStyleBackColor = true;
            this.Back3.Click += new System.EventHandler(this.BackClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(303, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtitletxt
            // 
            this.rtitletxt.Location = new System.Drawing.Point(147, 78);
            this.rtitletxt.Name = "rtitletxt";
            this.rtitletxt.Size = new System.Drawing.Size(273, 20);
            this.rtitletxt.TabIndex = 7;
            // 
            // aqtytxt
            // 
            this.aqtytxt.Location = new System.Drawing.Point(147, 163);
            this.aqtytxt.Name = "aqtytxt";
            this.aqtytxt.Size = new System.Drawing.Size(273, 20);
            this.aqtytxt.TabIndex = 6;
            // 
            // risbntxt
            // 
            this.risbntxt.Location = new System.Drawing.Point(147, 33);
            this.risbntxt.Name = "risbntxt";
            this.risbntxt.Size = new System.Drawing.Size(273, 20);
            this.risbntxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Book Title ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Book ISBN Number";
            // 
            // ManageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 589);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBook";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox catecombo;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox QtyTxt;
        private System.Windows.Forms.TextBox isbnTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox rtitletxt;
        private System.Windows.Forms.TextBox aqtytxt;
        private System.Windows.Forms.TextBox risbntxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Back3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rqtytxt;
        private System.Windows.Forms.TextBox rcattxt;
    }
}