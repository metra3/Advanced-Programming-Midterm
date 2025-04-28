using AraSinav;
using System;
using System.Windows.Forms;

namespace ARASINAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            listBox1.Items.Clear();
            radioButton1.Checked = true;
            radioButton3.Checked = true;
            checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            toolStripButton1.ToolTipText = "Öðrenci Bilgilerini Temizle";
            toolStripButton2.ToolTipText = "Listeyi Temizle";
            toolStripButton3.ToolTipText = "Hakkýnda";
            SetTabIndexes();
            comboBox1.Items.AddRange(new[] { "Ankara", "Eskiþehir", "Ýstanbul", "Ýzmir" });
            comboBox2.Items.AddRange(new[] { "Büyük Ýkon", "Detay", "Küçük Ýkon", "Liste", "Döþeme" });
            SetupListView();
        }

        private void SetTabIndexes()
        {
            menuStrip1.TabIndex = 0;
            textBox1.TabIndex = 1;
            textBox2.TabIndex = 2;
            comboBox1.TabIndex = 3;
            listBox1.TabIndex = 4;
            radioButton1.TabIndex = 5;
            radioButton2.TabIndex = 6;
            radioButton3.TabIndex = 7;
            radioButton4.TabIndex = 8;
            radioButton5.TabIndex = 9;
            radioButton6.TabIndex = 10;
            checkBox1.TabIndex = 11;
            checkBox2.TabIndex = 12;
            checkBox3.TabIndex = 13;
            button1.TabIndex = 14;
            listView1.TabIndex = 15;
            comboBox2.TabIndex = 16;
            statusStrip1.TabIndex = 17;
        }

        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.Sorting = SortOrder.Ascending;
            listView1.FullRowSelect = true;
            listView1.SmallImageList = imageListSmall;
            listView1.LargeImageList = imageListLarge;
            listView1.Columns.AddRange(new[]
            {
                new ColumnHeader { Text = "Adý", Width = 100 },
                new ColumnHeader { Text = "Soyadý", Width = 100 },
                new ColumnHeader { Text = "Ýli", Width = 100 },
                new ColumnHeader { Text = "Ýlçesi", Width = 100 },
                new ColumnHeader { Text = "Cinsiyet", Width = 100 },
                new ColumnHeader { Text = "Müzik", Width = 50 },
                new ColumnHeader { Text = "Kitap", Width = 50 },
                new ColumnHeader { Text = "Sinema", Width = 50 }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text, surname = textBox2.Text, city = comboBox1.SelectedItem?.ToString();
                string district = listBox1.SelectedItem?.ToString();
                string gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
                string iconChoice = GetSelectedIcon();
                string music = checkBox1.Checked ? "Evet" : "Hayýr";
                string book = checkBox2.Checked ? "Evet" : "Hayýr";
                string cinema = checkBox3.Checked ? "Evet" : "Hayýr";

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(district) || string.IsNullOrEmpty(gender))
                {
                    MessageBox.Show("Bilgilerde eksiklik bulunmaktadýr!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var listViewItem = new ListViewItem(new[] { name, surname, city, district, gender, music, book, cinema });
                listViewItem.ImageIndex = GetIconIndex(iconChoice);
                listView1.Items.Add(listViewItem);
                ResetControls();
            }
            catch (Exception)
            {
                MessageBox.Show("Bilgilerde eksiklik bulunmaktadýr!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private string GetSelectedIcon()
        {
            if (radioButton3.Checked) return radioButton3.Text;
            if (radioButton4.Checked) return radioButton4.Text;
            if (radioButton5.Checked) return radioButton5.Text;
            return radioButton6.Checked ? radioButton6.Text : string.Empty;
        }

        private int GetIconIndex(string iconChoice)
        {
            return iconChoice switch
            {
                "1" => 0,
                "2" => 1,
                "3" => 2,
                "4" => 3,
                _ => -1
            };
        }

        private void ResetControls()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            listBox1.Items.Clear();
            radioButton1.Checked = true;
            radioButton3.Checked = true;
            checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] items = comboBox1.SelectedIndex switch
            {
                0 => ankIlce,
                1 => eskIlce,
                2 => istIlce,
                3 => izmIlce,
                _ => Array.Empty<string>()
            };
            listBox1.Items.AddRange(items);
        }

        private void toolStripButton2_Click(object sender, EventArgs e) => listView1.Items.Clear();
        private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = comboBox2.SelectedIndex switch
            {
                0 => View.LargeIcon,
                1 => View.Details,
                2 => View.SmallIcon,
                3 => View.List,
                4 => View.Tile,
                _ => listView1.View
            };
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                toolStripStatusLabel1.Text = $"Adý: {item.SubItems[0].Text} - Soyadý: {item.SubItems[1].Text} - Ýl: {item.SubItems[2].Text} - Ýlçe: {item.SubItems[3].Text} - Cinsiyet: {item.SubItems[4].Text} - Müzik: {item.SubItems[5].Text} - Kitap: {item.SubItems[6].Text} - Sinema: {item.SubItems[7].Text}";
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e) => new Form2 { StartPosition = FormStartPosition.CenterScreen }.Show();
    }
}
