namespace ARASINAV

{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            pictureBox1.Image = AraSinav.Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 524);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            textBox1.Location = new Point(443, 303);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(577, 233);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            button1.Location = new Point(665, 544);
            button1.Name = "button1";
            button1.Size = new Size(355, 39);
            button1.TabIndex = 3;
            button1.Text = "Tamam";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(444, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 285);
            panel1.TabIndex = 8;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(472, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 98);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            label2.AutoSize = true;
            label2.Location = new Point(17, 48);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 5;
            label2.Text = "Version: 1.0.0";
            label4.AutoSize = true;
            label4.Location = new Point(17, 113);
            label4.Name = "label4";
            label4.Size = new Size(222, 20);
            label4.TabIndex = 7;
            label4.Text = "Eskişehir Osmangazi Üniversitesi";
            label1.AutoSize = true;
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 4;
            label1.Text = "Öğrenci Bilgi Sistemi";
            label3.AutoSize = true;
            label3.Location = new Point(17, 81);
            label3.Name = "label3";
            label3.Size = new Size(246, 20);
            label3.TabIndex = 6;
            label3.Text = "Copyright © 2025 Metehan DOĞAN";
            ClientSize = new Size(1032, 628);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "Hakkında";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label5;
    }
}