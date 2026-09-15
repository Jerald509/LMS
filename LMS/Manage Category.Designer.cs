namespace LMS
{
    partial class Manage_Category
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
            this.catTxt = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.Button();
            this.Back3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Category";
            // 
            // catTxt
            // 
            this.catTxt.Location = new System.Drawing.Point(183, 29);
            this.catTxt.Name = "catTxt";
            this.catTxt.Size = new System.Drawing.Size(255, 20);
            this.catTxt.TabIndex = 3;
            // 
            // Category
            // 
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(325, 74);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(95, 41);
            this.Category.TabIndex = 6;
            this.Category.Text = "Submit";
            this.Category.UseVisualStyleBackColor = true;
            this.Category.Click += new System.EventHandler(this.Category_Click);
            // 
            // Back3
            // 
            this.Back3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back3.Location = new System.Drawing.Point(197, 74);
            this.Back3.Name = "Back3";
            this.Back3.Size = new System.Drawing.Size(95, 41);
            this.Back3.TabIndex = 7;
            this.Back3.Text = "Back";
            this.Back3.UseVisualStyleBackColor = true;
            this.Back3.Click += new System.EventHandler(this.BackClick);
            // 
            // Manage_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 153);
            this.Controls.Add(this.Back3);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.catTxt);
            this.Controls.Add(this.label1);
            this.Name = "Manage_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox catTxt;
        private System.Windows.Forms.Button Category;
        private System.Windows.Forms.Button Back3;
    }
}