namespace PercyLimCompany
{
    partial class Form2
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
            this.valTBox = new System.Windows.Forms.TextBox();
            this.enterBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invalid input! Enter again";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter value:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valTBox
            // 
            this.valTBox.Location = new System.Drawing.Point(130, 107);
            this.valTBox.Name = "valTBox";
            this.valTBox.Size = new System.Drawing.Size(243, 20);
            this.valTBox.TabIndex = 2;
            // 
            // enterBut
            // 
            this.enterBut.Location = new System.Drawing.Point(178, 163);
            this.enterBut.Name = "enterBut";
            this.enterBut.Size = new System.Drawing.Size(75, 23);
            this.enterBut.TabIndex = 3;
            this.enterBut.Text = "Enter";
            this.enterBut.UseVisualStyleBackColor = true;
            this.enterBut.Click += new System.EventHandler(this.enterBut_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 262);
            this.Controls.Add(this.enterBut);
            this.Controls.Add(this.valTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valTBox;
        private System.Windows.Forms.Button enterBut;
    }
}