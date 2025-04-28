using ARASINAV;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace ARASINAV
{
    public partial class Form1 : Form
    {
        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            bilgileriTemizleToolStripMenuItem = new ToolStripMenuItem();
            listeyiTemizleToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            hakkındaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox4 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox3 = new GroupBox();
            pictureBox4 = new PictureBox();
            radioButton6 = new RadioButton();
            pictureBox3 = new PictureBox();
            radioButton5 = new RadioButton();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox5 = new GroupBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            listView1 = new ListView();
            imageListSmall = new ImageList(components);
            imageListLarge = new ImageList(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((ISupportInitialize)pictureBox4).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, yardımToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1050, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bilgileriTemizleToolStripMenuItem, listeyiTemizleToolStripMenuItem, çıkışToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(64, 24);
            dosyaToolStripMenuItem.Text = "&Dosya";
            bilgileriTemizleToolStripMenuItem.Name = "bilgileriTemizleToolStripMenuItem";
            bilgileriTemizleToolStripMenuItem.Size = new Size(198, 26);
            bilgileriTemizleToolStripMenuItem.Text = "Bilgileri Temizle";
            bilgileriTemizleToolStripMenuItem.Click += toolStripButton1_Click;
            listeyiTemizleToolStripMenuItem.Name = "listeyiTemizleToolStripMenuItem";
            listeyiTemizleToolStripMenuItem.Size = new Size(198, 26);
            listeyiTemizleToolStripMenuItem.Text = "Listeyi Temizle";
            listeyiTemizleToolStripMenuItem.Click += toolStripButton2_Click;
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(198, 26);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            yardımToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hakkındaToolStripMenuItem });
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            yardımToolStripMenuItem.Size = new Size(69, 24);
            yardımToolStripMenuItem.Text = "&Yardım";
            hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            hakkındaToolStripMenuItem.Size = new Size(154, 26);
            hakkındaToolStripMenuItem.Text = "Hakkında";
            hakkındaToolStripMenuItem.Click += toolStripButton3_Click;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 620);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1050, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(92, 20);
            toolStripStatusLabel1.Text = "Hoşgeldiniz!";
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripButton2, toolStripSeparator2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1050, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click; 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 61);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(349, 553);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Bilgileri"; 
            button1.Location = new Point(24, 509);
            button1.Name = "button1";
            button1.Size = new Size(183, 32);
            button1.TabIndex = 11;
            button1.Text = "Listeye Ekle>>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click; 
            groupBox4.Controls.Add(checkBox3);
            groupBox4.Controls.Add(checkBox2);
            groupBox4.Controls.Add(checkBox1);
            groupBox4.Location = new Point(24, 380);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(302, 123);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hobiler";
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 86);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 28);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Sinema";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(161, 28);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Kitap okumak";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(177, 28);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Müzik dinlemek";
            checkBox1.UseVisualStyleBackColor = true; 
            groupBox3.Controls.Add(pictureBox4);
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(radioButton5);
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(radioButton4);
            groupBox3.Location = new Point(155, 284);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(171, 89);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ikon Seçiniz"; 
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Image = AraSinav.Properties.Resources.person4_small;
            pictureBox4.Location = new Point(133, 60);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(16, 17);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(100, 60);
            radioButton6.Margin = new Padding(4);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(17, 16);
            radioButton6.TabIndex = 6;
            radioButton6.TabStop = true;
            radioButton6.UseVisualStyleBackColor = true; 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = AraSinav.Properties.Resources.person3_small;
            pictureBox3.Location = new Point(46, 60);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 17);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(19, 60);
            radioButton5.Margin = new Padding(4);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(17, 16);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.UseVisualStyleBackColor = true;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = AraSinav.Properties.Resources.person2_small;
            pictureBox2.Location = new Point(133, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 17);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = AraSinav.Properties.Resources.person1_small;
            pictureBox1.Location = new Point(46, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 17);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(19, 29);
            radioButton3.Margin = new Padding(4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(17, 16);
            radioButton3.TabIndex = 1;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(100, 29);
            radioButton4.Margin = new Padding(4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(17, 16);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true; 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(24, 284);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(123, 89);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cinsiyet";
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(20, 56);
            radioButton2.Margin = new Padding(4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(85, 28);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kadın";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 29);
            radioButton1.Margin = new Padding(4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 28);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Erkek";
            radioButton1.UseVisualStyleBackColor = true;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(128, 134);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(198, 124);
            listBox1.TabIndex = 7;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(128, 100);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 32);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            textBox2.Location = new Point(128, 66);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 30);
            textBox2.TabIndex = 5;
            textBox1.Location = new Point(128, 33);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 30);
            textBox1.TabIndex = 4;
            label4.AutoSize = true;
            label4.Location = new Point(20, 138);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 24);
            label4.TabIndex = 3;
            label4.Text = "İlçesi:";
            label3.AutoSize = true;
            label3.Location = new Point(20, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 24);
            label3.TabIndex = 2;
            label3.Text = "İli:";
            label2.AutoSize = true;
            label2.Location = new Point(20, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 24);
            label2.TabIndex = 1;
            label2.Text = "Soyadı:";
            label1.AutoSize = true;
            label1.Location = new Point(20, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 24);
            label1.TabIndex = 0;
            label1.Text = "Adı:";
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(comboBox2);
            groupBox5.Controls.Add(listView1);
            groupBox5.Location = new Point(369, 61);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(669, 553);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Öğrenci Listesi";
            label5.AutoSize = true;
            label5.Location = new Point(307, 517);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(170, 24);
            label5.TabIndex = 12;
            label5.Text = "Liste Görünümü:";
            comboBox2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(485, 513);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(150, 24);
            comboBox2.TabIndex = 12;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            listView1.Location = new Point(7, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(650, 470);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged; 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 646);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Bilgi Sistemi";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private string[] ankIlce = new string[]
{
            "Merkez",
            "Çankaya",
            "Beypazarı",
            "Polatlı",
            "Gölbaşı",
            "Sincan",
            "Mamak"
};

        private string[] eskIlce = new string[]
        {
            "Merkez",
            "Alpu",
            "Sivrihisar",
            "Odunpazarı",
            "Çifteler",
            "Seyitgazi",
            "Sarıcakaya"
        };

        private string[] istIlce = new string[]
        {
            "Beşiktaş",
            "Bakırköy",
            "Beyoğlu",
            "Beylikdüzü",
            "Eyüp",
            "Kadıköy",
            "Şişli",
            "Üsküdar",
            "Zeytinburnu"
        };

        private string[] izmIlce = new string[]
        {
            "Bornova",
            "Foça",
            "Karşıyaka",
            "Konak",
            "Urla",
            "Torbalı",
            "Çeşme",
            "Dikili"
        };

        private IContainer components = null;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem bilgileriTemizleToolStripMenuItem;
        private ToolStripMenuItem listeyiTemizleToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStripMenuItem hakkındaToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;

        private ListBox listBox1;

        private TextBox textBox1;
        private TextBox textBox2;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;

        private Button button1;

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;

        private ComboBox comboBox1;
        private ComboBox comboBox2;

        private ListView listView1;

        private ToolStripButton toolStripButton1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ImageList imageListSmall;
        private ImageList imageListLarge;
    }
}