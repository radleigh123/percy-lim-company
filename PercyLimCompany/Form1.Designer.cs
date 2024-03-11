namespace PercyLimCompany
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayBut = new System.Windows.Forms.Button();
            this.completeBut = new System.Windows.Forms.Button();
            this.clearBut = new System.Windows.Forms.Button();
            this.addBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pocketCheckBox = new System.Windows.Forms.CheckBox();
            this.monoCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.large2Radio = new System.Windows.Forms.RadioButton();
            this.smallRadio = new System.Windows.Forms.RadioButton();
            this.largeRadio = new System.Windows.Forms.RadioButton();
            this.medRadio = new System.Windows.Forms.RadioButton();
            this.XXLRadio = new System.Windows.Forms.RadioButton();
            this.qtyTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.custTBox = new System.Windows.Forms.TextBox();
            this.orderTBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 319);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.displayBut);
            this.panel1.Controls.Add(this.completeBut);
            this.panel1.Controls.Add(this.clearBut);
            this.panel1.Controls.Add(this.addBut);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.custTBox);
            this.panel1.Controls.Add(this.orderTBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 313);
            this.panel1.TabIndex = 0;
            // 
            // displayBut
            // 
            this.displayBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBut.Location = new System.Drawing.Point(428, 256);
            this.displayBut.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.displayBut.Name = "displayBut";
            this.displayBut.Size = new System.Drawing.Size(75, 36);
            this.displayBut.TabIndex = 15;
            this.displayBut.Text = "Display";
            this.displayBut.UseVisualStyleBackColor = true;
            this.displayBut.Click += new System.EventHandler(this.displayBut_Click);
            // 
            // completeBut
            // 
            this.completeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeBut.Location = new System.Drawing.Point(299, 256);
            this.completeBut.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.completeBut.Name = "completeBut";
            this.completeBut.Size = new System.Drawing.Size(86, 36);
            this.completeBut.TabIndex = 14;
            this.completeBut.Text = "Complete";
            this.completeBut.UseVisualStyleBackColor = true;
            this.completeBut.Click += new System.EventHandler(this.completeBut_Click);
            // 
            // clearBut
            // 
            this.clearBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBut.Location = new System.Drawing.Point(181, 256);
            this.clearBut.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.clearBut.Name = "clearBut";
            this.clearBut.Size = new System.Drawing.Size(75, 36);
            this.clearBut.TabIndex = 13;
            this.clearBut.Text = "Clear";
            this.clearBut.UseVisualStyleBackColor = true;
            this.clearBut.Click += new System.EventHandler(this.clearBut_Click);
            // 
            // addBut
            // 
            this.addBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBut.Location = new System.Drawing.Point(63, 256);
            this.addBut.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(75, 36);
            this.addBut.TabIndex = 12;
            this.addBut.Text = "Add";
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pocketCheckBox);
            this.groupBox1.Controls.Add(this.monoCheckBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.qtyTBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(579, 167);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shirt";
            // 
            // pocketCheckBox
            // 
            this.pocketCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pocketCheckBox.Location = new System.Drawing.Point(318, 127);
            this.pocketCheckBox.Name = "pocketCheckBox";
            this.pocketCheckBox.Size = new System.Drawing.Size(165, 20);
            this.pocketCheckBox.TabIndex = 8;
            this.pocketCheckBox.Text = "Pocket";
            this.pocketCheckBox.UseVisualStyleBackColor = true;
            // 
            // monoCheckBox
            // 
            this.monoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoCheckBox.Location = new System.Drawing.Point(111, 125);
            this.monoCheckBox.Name = "monoCheckBox";
            this.monoCheckBox.Size = new System.Drawing.Size(165, 24);
            this.monoCheckBox.TabIndex = 7;
            this.monoCheckBox.Text = "Monogram";
            this.monoCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.large2Radio);
            this.groupBox2.Controls.Add(this.smallRadio);
            this.groupBox2.Controls.Add(this.largeRadio);
            this.groupBox2.Controls.Add(this.medRadio);
            this.groupBox2.Controls.Add(this.XXLRadio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(11, 52);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 60);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shirt size";
            // 
            // large2Radio
            // 
            this.large2Radio.AutoSize = true;
            this.large2Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.large2Radio.Location = new System.Drawing.Point(319, 26);
            this.large2Radio.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.large2Radio.Name = "large2Radio";
            this.large2Radio.Size = new System.Drawing.Size(99, 20);
            this.large2Radio.TabIndex = 14;
            this.large2Radio.TabStop = true;
            this.large2Radio.Text = "extra large";
            this.large2Radio.UseVisualStyleBackColor = true;
            // 
            // smallRadio
            // 
            this.smallRadio.AutoSize = true;
            this.smallRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallRadio.Location = new System.Drawing.Point(87, 26);
            this.smallRadio.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.smallRadio.Name = "smallRadio";
            this.smallRadio.Size = new System.Drawing.Size(62, 20);
            this.smallRadio.TabIndex = 10;
            this.smallRadio.TabStop = true;
            this.smallRadio.Text = "small";
            this.smallRadio.UseVisualStyleBackColor = true;
            // 
            // largeRadio
            // 
            this.largeRadio.AutoSize = true;
            this.largeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeRadio.Location = new System.Drawing.Point(248, 26);
            this.largeRadio.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.largeRadio.Name = "largeRadio";
            this.largeRadio.Size = new System.Drawing.Size(61, 20);
            this.largeRadio.TabIndex = 13;
            this.largeRadio.TabStop = true;
            this.largeRadio.Text = "large";
            this.largeRadio.UseVisualStyleBackColor = true;
            // 
            // medRadio
            // 
            this.medRadio.AutoSize = true;
            this.medRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medRadio.Location = new System.Drawing.Point(159, 26);
            this.medRadio.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.medRadio.Name = "medRadio";
            this.medRadio.Size = new System.Drawing.Size(79, 20);
            this.medRadio.TabIndex = 12;
            this.medRadio.TabStop = true;
            this.medRadio.Text = "medium";
            this.medRadio.UseVisualStyleBackColor = true;
            // 
            // XXLRadio
            // 
            this.XXLRadio.AutoSize = true;
            this.XXLRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XXLRadio.Location = new System.Drawing.Point(428, 26);
            this.XXLRadio.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.XXLRadio.Name = "XXLRadio";
            this.XXLRadio.Size = new System.Drawing.Size(51, 20);
            this.XXLRadio.TabIndex = 11;
            this.XXLRadio.TabStop = true;
            this.XXLRadio.Text = "XXL";
            this.XXLRadio.UseVisualStyleBackColor = true;
            // 
            // qtyTBox
            // 
            this.qtyTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTBox.Location = new System.Drawing.Point(259, 24);
            this.qtyTBox.Name = "qtyTBox";
            this.qtyTBox.Size = new System.Drawing.Size(203, 22);
            this.qtyTBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Order number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // custTBox
            // 
            this.custTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custTBox.Location = new System.Drawing.Point(262, 0);
            this.custTBox.Name = "custTBox";
            this.custTBox.Size = new System.Drawing.Size(203, 22);
            this.custTBox.TabIndex = 7;
            // 
            // orderTBox
            // 
            this.orderTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTBox.Location = new System.Drawing.Point(262, 33);
            this.orderTBox.Name = "orderTBox";
            this.orderTBox.Size = new System.Drawing.Size(203, 22);
            this.orderTBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 343);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Percy Lim Company";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox pocketCheckBox;
        private System.Windows.Forms.CheckBox monoCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton large2Radio;
        private System.Windows.Forms.RadioButton smallRadio;
        private System.Windows.Forms.RadioButton largeRadio;
        private System.Windows.Forms.RadioButton medRadio;
        private System.Windows.Forms.RadioButton XXLRadio;
        private System.Windows.Forms.TextBox qtyTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox custTBox;
        private System.Windows.Forms.TextBox orderTBox;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Button displayBut;
        private System.Windows.Forms.Button completeBut;
        private System.Windows.Forms.Button clearBut;
    }
}

