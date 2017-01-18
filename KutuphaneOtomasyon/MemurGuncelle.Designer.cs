namespace KutuphaneOtomasyon
{
    partial class MemurGuncelle
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
            this.label13 = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cins = new System.Windows.Forms.ComboBox();
            this.adı = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.tcno = new System.Windows.Forms.TextBox();
            this.eposta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kutuphane = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(48, 161);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "Telefon";
            // 
            // Telefon
            // 
            this.Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Telefon.Location = new System.Drawing.Point(239, 157);
            this.Telefon.Margin = new System.Windows.Forms.Padding(2);
            this.Telefon.MaxLength = 11;
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(199, 23);
            this.Telefon.TabIndex = 32;
            this.Telefon.TextChanged += new System.EventHandler(this.Telefon_TextChanged);
            this.Telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefon_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(166, 321);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 27);
            this.button2.TabIndex = 35;
            this.button2.Text = "VAZGEÇ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(166, 272);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 27);
            this.button1.TabIndex = 34;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cins
            // 
            this.cins.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cins.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cins.FormattingEnabled = true;
            this.cins.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cins.Location = new System.Drawing.Point(239, 98);
            this.cins.Margin = new System.Windows.Forms.Padding(2);
            this.cins.Name = "cins";
            this.cins.Size = new System.Drawing.Size(199, 25);
            this.cins.TabIndex = 29;
            this.cins.SelectedIndexChanged += new System.EventHandler(this.cins_SelectedIndexChanged);
            // 
            // adı
            // 
            this.adı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adı.Location = new System.Drawing.Point(239, 15);
            this.adı.Margin = new System.Windows.Forms.Padding(2);
            this.adı.Name = "adı";
            this.adı.Size = new System.Drawing.Size(199, 23);
            this.adı.TabIndex = 23;
            this.adı.TextChanged += new System.EventHandler(this.adı_TextChanged);
            // 
            // soyad
            // 
            this.soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad.Location = new System.Drawing.Point(239, 42);
            this.soyad.Margin = new System.Windows.Forms.Padding(2);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(199, 23);
            this.soyad.TabIndex = 25;
            this.soyad.TextChanged += new System.EventHandler(this.soyad_TextChanged);
            // 
            // tcno
            // 
            this.tcno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcno.Location = new System.Drawing.Point(239, 71);
            this.tcno.Margin = new System.Windows.Forms.Padding(2);
            this.tcno.MaxLength = 11;
            this.tcno.Name = "tcno";
            this.tcno.Size = new System.Drawing.Size(199, 23);
            this.tcno.TabIndex = 27;
            this.tcno.TextChanged += new System.EventHandler(this.tcno_TextChanged);
            this.tcno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcno_KeyPress);
            // 
            // eposta
            // 
            this.eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eposta.Location = new System.Drawing.Point(239, 125);
            this.eposta.Margin = new System.Windows.Forms.Padding(2);
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(199, 23);
            this.eposta.TabIndex = 30;
            this.eposta.TextChanged += new System.EventHandler(this.eposta_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(49, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "E-posta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(49, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ad";
            // 
            // kutuphane
            // 
            this.kutuphane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kutuphane.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kutuphane.FormattingEnabled = true;
            this.kutuphane.Location = new System.Drawing.Point(239, 189);
            this.kutuphane.Name = "kutuphane";
            this.kutuphane.Size = new System.Drawing.Size(199, 28);
            this.kutuphane.TabIndex = 38;
            this.kutuphane.SelectedIndexChanged += new System.EventHandler(this.kutuphane_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Kütüphane";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MemurGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 401);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kutuphane);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cins);
            this.Controls.Add(this.adı);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.tcno);
            this.Controls.Add(this.eposta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MemurGuncelle";
            this.Text = "Memur Bilgilerini Güncelle";
            this.Load += new System.EventHandler(this.MemurGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Telefon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cins;
        private System.Windows.Forms.TextBox adı;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox tcno;
        private System.Windows.Forms.TextBox eposta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kutuphane;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}