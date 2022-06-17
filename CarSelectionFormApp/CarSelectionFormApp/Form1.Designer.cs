
namespace CarSelectionFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ubox = new System.Windows.Forms.Label();
            this.PBox = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-417, -136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1974, 1193);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(544, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 35);
            this.textBox1.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(544, 357);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(319, 35);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.UseSystemPasswordChar = true;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Impact", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(544, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "MBT SELECTOR";
            // 
            // Ubox
            // 
            this.Ubox.AutoSize = true;
            this.Ubox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ubox.Location = new System.Drawing.Point(544, 219);
            this.Ubox.Name = "Ubox";
            this.Ubox.Size = new System.Drawing.Size(106, 30);
            this.Ubox.TabIndex = 5;
            this.Ubox.Text = "Username";
            // 
            // PBox
            // 
            this.PBox.AutoSize = true;
            this.PBox.Location = new System.Drawing.Point(544, 324);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(99, 30);
            this.PBox.TabIndex = 6;
            this.PBox.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.LoginButton.Location = new System.Drawing.Point(544, 440);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(131, 40);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(506, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 294);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 936);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.Ubox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ubox;
        private System.Windows.Forms.Label PBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

