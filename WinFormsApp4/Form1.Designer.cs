namespace WinFormsApp4
{
    partial class frmSatis
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatis));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label1 = new Label();
            cmbOtobus = new ComboBox();
            cmbNereden = new ComboBox();
            label2 = new Label();
            cmbNereye = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dtpTarih = new DateTimePicker();
            label5 = new Label();
            nudFiyat = new NumericUpDown();
            button1 = new Button();
            groupBox1 = new GroupBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            rezerveEtToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            groupBox1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.MenuHighlight;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.GridLines = true;
            listView1.Location = new Point(714, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(623, 659);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Müşteri";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Telefon";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cinsiyet";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nereden";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nereye";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Koltuk No";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tarih";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 51);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Otobüs Seçiniz";
            // 
            // cmbOtobus
            // 
            cmbOtobus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOtobus.FormattingEnabled = true;
            cmbOtobus.Items.AddRange(new object[] { "Travego", "Neoplan", "Setra" });
            cmbOtobus.Location = new Point(505, 48);
            cmbOtobus.Name = "cmbOtobus";
            cmbOtobus.Size = new Size(169, 28);
            cmbOtobus.TabIndex = 2;
            cmbOtobus.SelectedIndexChanged += cmbOtobus_SelectedIndexChanged;
            // 
            // cmbNereden
            // 
            cmbNereden.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNereden.FormattingEnabled = true;
            cmbNereden.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elâzığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Kelkit", "Hakkâri", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" });
            cmbNereden.Location = new Point(80, 31);
            cmbNereden.Name = "cmbNereden";
            cmbNereden.Size = new Size(169, 28);
            cmbNereden.TabIndex = 4;
            cmbNereden.SelectedIndexChanged += cmbNereden_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 34);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Nereden ";
            // 
            // cmbNereye
            // 
            cmbNereye.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNereye.FormattingEnabled = true;
            cmbNereye.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elâzığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Kelkit", "Hakkâri", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" });
            cmbNereye.Location = new Point(81, 87);
            cmbNereye.Name = "cmbNereye";
            cmbNereye.Size = new Size(169, 28);
            cmbNereye.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 87);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 5;
            label3.Text = "Nereye";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 216);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 7;
            label4.Text = "Tarih";
            // 
            // dtpTarih
            // 
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(505, 211);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(169, 27);
            dtpTarih.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 271);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 9;
            label5.Text = "Fiyat";
            // 
            // nudFiyat
            // 
            nudFiyat.Location = new Point(505, 269);
            nudFiyat.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudFiyat.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(169, 27);
            nudFiyat.TabIndex = 10;
            nudFiyat.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(525, 330);
            button1.Name = "button1";
            button1.Size = new Size(114, 41);
            button1.TabIndex = 11;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbNereye);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbNereden);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(424, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 121);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "İstikamet";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { rezerveEtToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(148, 28);
            // 
            // rezerveEtToolStripMenuItem
            // 
            rezerveEtToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            rezerveEtToolStripMenuItem.Size = new Size(147, 24);
            rezerveEtToolStripMenuItem.Text = "Rezerve Et";
            rezerveEtToolStripMenuItem.Click += rezerveEtToolStripMenuItem_Click;
            // 
            // frmSatis
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1374, 719);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(nudFiyat);
            Controls.Add(label5);
            Controls.Add(dtpTarih);
            Controls.Add(label4);
            Controls.Add(cmbOtobus);
            Controls.Add(label1);
            Controls.Add(listView1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSatis";
            Text = "Lüks Gümüşhane Turizm A.Ş.";
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private ComboBox cmbOtobus;
        private ComboBox cmbNereden;
        private Label label2;
        private ComboBox cmbNereye;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpTarih;
        private Label label5;
        private NumericUpDown nudFiyat;
        private Button button1;
        private GroupBox groupBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem rezerveEtToolStripMenuItem;
    }
}
