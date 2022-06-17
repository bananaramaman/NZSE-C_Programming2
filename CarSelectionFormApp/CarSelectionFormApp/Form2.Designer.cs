
namespace CarSelectionFormApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(571, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 35);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Occupation";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(571, 339);
            this.dob.Mask = "00000";
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(175, 35);
            this.dob.TabIndex = 11;
            this.dob.ValidatingType = typeof(int);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(570, 410);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 35);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(570, 481);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(308, 35);
            this.textBox3.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-641, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2182, 1071);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuText;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(659, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Postcode";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(570, 552);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(175, 35);
            this.maskedTextBox1.TabIndex = 18;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 936);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.MaskedTextBox dob;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}