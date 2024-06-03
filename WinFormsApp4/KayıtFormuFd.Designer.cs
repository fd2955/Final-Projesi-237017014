namespace WinFormsApp4
{
    partial class KayıtFormuFd
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
            label1 = new Label();
            txtIsim = new TextBox();
            txtSoyisim = new TextBox();
            label2 = new Label();
            label3 = new Label();
            mskdTelefon = new MaskedTextBox();
            rdbBay = new RadioButton();
            rdbBayan = new RadioButton();
            btnIptal = new Button();
            btnTamam = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 51);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "İsim";
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(212, 53);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(176, 27);
            txtIsim.TabIndex = 1;
            // 
            // txtSoyisim
            // 
            txtSoyisim.Location = new Point(212, 101);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(176, 27);
            txtSoyisim.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 101);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Soyisim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 152);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "Telefon";
            // 
            // mskdTelefon
            // 
            mskdTelefon.Location = new Point(212, 145);
            mskdTelefon.Mask = "(999) 000-0000";
            mskdTelefon.Name = "mskdTelefon";
            mskdTelefon.Size = new Size(176, 27);
            mskdTelefon.TabIndex = 5;
            // 
            // rdbBay
            // 
            rdbBay.AutoSize = true;
            rdbBay.Location = new Point(167, 210);
            rdbBay.Name = "rdbBay";
            rdbBay.Size = new Size(56, 24);
            rdbBay.TabIndex = 6;
            rdbBay.TabStop = true;
            rdbBay.Text = "Bay";
            rdbBay.UseVisualStyleBackColor = true;
            // 
            // rdbBayan
            // 
            rdbBayan.AutoSize = true;
            rdbBayan.Location = new Point(304, 210);
            rdbBayan.Name = "rdbBayan";
            rdbBayan.Size = new Size(73, 24);
            rdbBayan.TabIndex = 7;
            rdbBayan.TabStop = true;
            rdbBayan.Text = "Bayan";
            rdbBayan.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(140, 256);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(123, 36);
            btnIptal.TabIndex = 8;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(285, 256);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(123, 36);
            btnTamam.TabIndex = 9;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // KayıtFormuFd
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 358);
            Controls.Add(btnTamam);
            Controls.Add(btnIptal);
            Controls.Add(rdbBayan);
            Controls.Add(rdbBay);
            Controls.Add(mskdTelefon);
            Controls.Add(label3);
            Controls.Add(txtSoyisim);
            Controls.Add(label2);
            Controls.Add(txtIsim);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "KayıtFormuFd";
            Text = "KayıtFormuFd";
            Load += KayıtFormuFd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnIptal;
        private Button btnTamam;
        public TextBox txtIsim;
        public TextBox txtSoyisim;
        public MaskedTextBox mskdTelefon;
        public RadioButton rdbBay;
        public RadioButton rdbBayan;
    }
}