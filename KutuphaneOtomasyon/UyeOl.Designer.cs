namespace KutuphaneOtomasyon
{
    partial class UyeOl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.GroupBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.eposta = new System.Windows.Forms.TextBox();
            this.tcno = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.adı = new System.Windows.Forms.TextBox();
            this.cins = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nick = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.adres.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-posta";
            // 
            // adres
            // 
            this.adres.Controls.Add(this.adress);
            this.adres.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres.Location = new System.Drawing.Point(31, 258);
            this.adres.Margin = new System.Windows.Forms.Padding(2);
            this.adres.Name = "adres";
            this.adres.Padding = new System.Windows.Forms.Padding(2);
            this.adres.Size = new System.Drawing.Size(403, 179);
            this.adres.TabIndex = 7;
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
            // eposta
            // 
            this.eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eposta.Location = new System.Drawing.Point(218, 117);
            this.eposta.Margin = new System.Windows.Forms.Padding(2);
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(199, 23);
            this.eposta.TabIndex = 5;
            this.eposta.TextChanged += new System.EventHandler(this.eposta_TextChanged);
            // 
            // tcno
            // 
            this.tcno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcno.Location = new System.Drawing.Point(218, 63);
            this.tcno.Margin = new System.Windows.Forms.Padding(2);
            this.tcno.MaxLength = 11;
            this.tcno.Name = "tcno";
            this.tcno.Size = new System.Drawing.Size(199, 23);
            this.tcno.TabIndex = 3;
            this.tcno.TextChanged += new System.EventHandler(this.tcno_TextChanged);
            this.tcno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcno_KeyPress);
            // 
            // soyad
            // 
            this.soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad.Location = new System.Drawing.Point(218, 34);
            this.soyad.Margin = new System.Windows.Forms.Padding(2);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(199, 23);
            this.soyad.TabIndex = 2;
            this.soyad.TextChanged += new System.EventHandler(this.soyad_TextChanged);
            // 
            // adı
            // 
            this.adı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adı.Location = new System.Drawing.Point(218, 7);
            this.adı.Margin = new System.Windows.Forms.Padding(2);
            this.adı.Name = "adı";
            this.adı.Size = new System.Drawing.Size(199, 23);
            this.adı.TabIndex = 1;
            this.adı.TextChanged += new System.EventHandler(this.adı_TextChanged);
            // 
            // cins
            // 
            this.cins.AutoCompleteCustomSource.AddRange(new string[] {
            "Erkek",
            "Kadın"});
            this.cins.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cins.FormattingEnabled = true;
            this.cins.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cins.Location = new System.Drawing.Point(218, 89);
            this.cins.Margin = new System.Windows.Forms.Padding(2);
            this.cins.Name = "cins";
            this.cins.Size = new System.Drawing.Size(199, 25);
            this.cins.TabIndex = 4;
            this.cins.SelectedIndexChanged += new System.EventHandler(this.cins_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(152, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "YENİ ÜYE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(152, 507);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "VAZGEÇ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.nick);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(30, 171);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(404, 81);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pass.Location = new System.Drawing.Point(188, 54);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(199, 23);
            this.pass.TabIndex = 8;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(8, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Şifre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(4, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Kullanıcı Adı";
            // 
            // nick
            // 
            this.nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nick.Location = new System.Drawing.Point(188, 21);
            this.nick.Margin = new System.Windows.Forms.Padding(2);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(199, 23);
            this.nick.TabIndex = 7;
            this.nick.TextChanged += new System.EventHandler(this.nick_TextChanged);
            // 
            // Telefon
            // 
            this.Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Telefon.Location = new System.Drawing.Point(218, 149);
            this.Telefon.Margin = new System.Windows.Forms.Padding(2);
            this.Telefon.MaxLength = 11;
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(199, 23);
            this.Telefon.TabIndex = 6;
            this.Telefon.TextChanged += new System.EventHandler(this.Telefon_TextChanged);
            this.Telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefon_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(28, 151);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 19);
            this.label13.TabIndex = 21;
            this.label13.Text = "Telefon";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 564);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.groupBox1);
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
            this.Name = "UyeOl";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.UyeOl_Load);
            this.adres.ResumeLayout(false);
            this.adres.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox adres;
        private System.Windows.Forms.TextBox eposta;
        private System.Windows.Forms.TextBox tcno;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox adı;
        private System.Windows.Forms.ComboBox cins;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.TextBox Telefon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}