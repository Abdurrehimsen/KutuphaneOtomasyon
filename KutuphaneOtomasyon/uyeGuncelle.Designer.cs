namespace KutuphaneOtomasyon
{
    partial class uyeGuncelle
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
            this.adres = new System.Windows.Forms.GroupBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.adres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(46, 167);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 19);
            this.label13.TabIndex = 37;
            this.label13.Text = "Telefon";
            // 
            // Telefon
            // 
            this.Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Telefon.Location = new System.Drawing.Point(236, 165);
            this.Telefon.Margin = new System.Windows.Forms.Padding(2);
            this.Telefon.MaxLength = 11;
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(199, 23);
            this.Telefon.TabIndex = 32;
            this.Telefon.TextChanged += new System.EventHandler(this.Telefon_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(170, 498);
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
            this.button1.Location = new System.Drawing.Point(170, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 27);
            this.button1.TabIndex = 34;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cins
            // 
            this.cins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cins.FormattingEnabled = true;
            this.cins.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cins.Location = new System.Drawing.Point(236, 106);
            this.cins.Margin = new System.Windows.Forms.Padding(2);
            this.cins.Name = "cins";
            this.cins.Size = new System.Drawing.Size(199, 25);
            this.cins.TabIndex = 29;
            this.cins.SelectedIndexChanged += new System.EventHandler(this.cins_SelectedIndexChanged);
            // 
            // adı
            // 
            this.adı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adı.Location = new System.Drawing.Point(236, 24);
            this.adı.Margin = new System.Windows.Forms.Padding(2);
            this.adı.Name = "adı";
            this.adı.Size = new System.Drawing.Size(199, 23);
            this.adı.TabIndex = 23;
            this.adı.TextChanged += new System.EventHandler(this.adı_TextChanged);
            // 
            // soyad
            // 
            this.soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad.Location = new System.Drawing.Point(236, 50);
            this.soyad.Margin = new System.Windows.Forms.Padding(2);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(199, 23);
            this.soyad.TabIndex = 25;
            this.soyad.TextChanged += new System.EventHandler(this.soyad_TextChanged);
            // 
            // tcno
            // 
            this.tcno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcno.Location = new System.Drawing.Point(236, 79);
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
            this.eposta.Location = new System.Drawing.Point(236, 133);
            this.eposta.Margin = new System.Windows.Forms.Padding(2);
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(199, 23);
            this.eposta.TabIndex = 30;
            this.eposta.TextChanged += new System.EventHandler(this.eposta_TextChanged);
            // 
            // adres
            // 
            this.adres.Controls.Add(this.adress);
            this.adres.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres.Location = new System.Drawing.Point(49, 224);
            this.adres.Margin = new System.Windows.Forms.Padding(2);
            this.adres.Name = "adres";
            this.adres.Padding = new System.Windows.Forms.Padding(2);
            this.adres.Size = new System.Drawing.Size(403, 179);
            this.adres.TabIndex = 33;
            this.adres.TabStop = false;
            this.adres.Text = "Adres";
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(10, 24);
            this.adress.Margin = new System.Windows.Forms.Padding(2);
            this.adress.Multiline = true;
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(376, 128);
            this.adress.TabIndex = 9;
            this.adress.TextChanged += new System.EventHandler(this.adress_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(46, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "E-posta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(46, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ad";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uyeGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 578);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cins);
            this.Controls.Add(this.adı);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.tcno);
            this.Controls.Add(this.eposta);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uyeGuncelle";
            this.Text = "Üye Güncelle";
            this.Load += new System.EventHandler(this.uyeGuncelle_Load);
            this.adres.ResumeLayout(false);
            this.adres.PerformLayout();
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
        private System.Windows.Forms.GroupBox adres;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}