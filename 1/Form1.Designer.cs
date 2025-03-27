namespace _1
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkBlue;
            label1.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 192, 255);
            label1.Location = new Point(477, 44);
            label1.Name = "label1";
            label1.Size = new Size(386, 46);
            label1.TabIndex = 0;
            label1.Text = "Mozijegy Vásárlás";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(428, 152);
            label2.Name = "label2";
            label2.Size = new Size(138, 31);
            label2.TabIndex = 1;
            label2.Text = "Your Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(678, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(775, 395);
            button1.Name = "button1";
            button1.Size = new Size(166, 32);
            button1.TabIndex = 3;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkBlue;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(501, 399);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(449, 203);
            label4.Name = "label4";
            label4.Size = new Size(123, 31);
            label4.TabIndex = 5;
            label4.Text = "Birth Age:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(678, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(366, 27);
            textBox2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.viktor;
            pictureBox1.Location = new Point(93, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cinema;
            pictureBox2.Location = new Point(93, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(472, 255);
            label5.Name = "label5";
            label5.Size = new Size(94, 31);
            label5.TabIndex = 9;
            label5.Text = "Jegyek:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(678, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(366, 27);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(361, 305);
            label6.Name = "label6";
            label6.Size = new Size(297, 31);
            label6.TabIndex = 11;
            label6.Text = "Diákjegyek száma(ha van):";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(678, 305);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(366, 27);
            textBox4.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(1119, 450);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Windows";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
    }
}
