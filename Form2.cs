using System;
using System.Drawing;
using System.Windows.Forms;

namespace ARASINAV
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.label1.Text = "Öğrenci Bilgi Sistemi";
            this.label2.Text = "Version: 1.0.0";
            this.label3.Text = "Copyright © 2025 Metehan DOĞAN";
            this.label4.Text = "Eskişehir Osmangazi Üniversitesi";
            this.textBox1.Text = "Uyarı: Bu bilgisayar programı, telif hakkı yasası ve "
                + "uluslararası anlaşmalarla korunmaktadır. Bu programın veya "
                + "herhangi bir kısmının izinsiz çoğaltılması veya dağıtılması, "
                + "ciddi hukuki ve cezai cezalara neden olabilir ve kanunen "
                + "mümkün olan en geniş kapsamda kovuşturmaya tabi tutulacaktır.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
