namespace LMS
{
    partial class Action
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
            this.ReturnRadio = new System.Windows.Forms.RadioButton();
            this.AddRadios = new System.Windows.Forms.RadioButton();
            this.CatRadio = new System.Windows.Forms.RadioButton();
            this.PassRadios = new System.Windows.Forms.RadioButton();
            this.SearchRadio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReturnRadio);
            this.groupBox1.Controls.Add(this.AddRadios);
            this.groupBox1.Controls.Add(this.CatRadio);
            this.groupBox1.Controls.Add(this.PassRadios);
            this.groupBox1.Controls.Add(this.SearchRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // ReturnRadio
            // 
            this.ReturnRadio.AutoSize = true;
            this.ReturnRadio.Location = new System.Drawing.Point(33, 83);
            this.ReturnRadio.Name = "ReturnRadio";
            this.ReturnRadio.Size = new System.Drawing.Size(85, 17);
            this.ReturnRadio.TabIndex = 4;
            this.ReturnRadio.TabStop = true;
            this.ReturnRadio.Text = "Return Book";
            this.ReturnRadio.UseVisualStyleBackColor = true;
            // 
            // AddRadios
            // 
            this.AddRadios.AutoSize = true;
            this.AddRadios.Location = new System.Drawing.Point(33, 171);
            this.AddRadios.Name = "AddRadios";
            this.AddRadios.Size = new System.Drawing.Size(122, 17);
            this.AddRadios.TabIndex = 3;
            this.AddRadios.TabStop = true;
            this.AddRadios.Text = "Add/Remove Books";
            this.AddRadios.UseVisualStyleBackColor = true;
            // 
            // CatRadio
            // 
            this.CatRadio.AutoSize = true;
            this.CatRadio.Location = new System.Drawing.Point(33, 129);
            this.CatRadio.Name = "CatRadio";
            this.CatRadio.Size = new System.Drawing.Size(117, 17);
            this.CatRadio.TabIndex = 2;
            this.CatRadio.TabStop = true;
            this.CatRadio.Text = "Manage Categories";
            this.CatRadio.UseVisualStyleBackColor = true;
            // 
            // PassRadios
            // 
            this.PassRadios.AutoSize = true;
            this.PassRadios.Location = new System.Drawing.Point(33, 218);
            this.PassRadios.Name = "PassRadios";
            this.PassRadios.Size = new System.Drawing.Size(111, 17);
            this.PassRadios.TabIndex = 1;
            this.PassRadios.TabStop = true;
            this.PassRadios.Text = "Change Password";
            this.PassRadios.UseVisualStyleBackColor = true;
            // 
            // SearchRadio
            // 
            this.SearchRadio.AutoSize = true;
            this.SearchRadio.Location = new System.Drawing.Point(33, 40);
            this.SearchRadio.Name = "SearchRadio";
            this.SearchRadio.Size = new System.Drawing.Size(87, 17);
            this.SearchRadio.TabIndex = 0;
            this.SearchRadio.TabStop = true;
            this.SearchRadio.Text = "Search Book";
            this.SearchRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(152, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bntSubmit);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 364);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Action";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action Form";
        
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ReturnRadio;
        private System.Windows.Forms.RadioButton AddRadios;
        private System.Windows.Forms.RadioButton CatRadio;
        private System.Windows.Forms.RadioButton PassRadios;
        private System.Windows.Forms.RadioButton SearchRadio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}