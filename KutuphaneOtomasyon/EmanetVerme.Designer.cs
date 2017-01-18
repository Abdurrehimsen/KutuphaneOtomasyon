namespace KutuphaneOtomasyon
{
    partial class EmanetVerme
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.book = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.kitapad = new System.Windows.Forms.Label();
            this.uyead = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kutuphane = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(187, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "VAZGEÇ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(187, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "İŞLEMİ YAP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Üye id giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap id giriniz";
            // 
            // book
            // 
            this.book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.book.Location = new System.Drawing.Point(205, 141);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(100, 26);
            this.book.TabIndex = 4;
            this.book.TextChanged += new System.EventHandler(this.book_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.Location = new System.Drawing.Point(205, 60);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 26);
            this.name.TabIndex = 5;
            this.name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // kitapad
            // 
            this.kitapad.AutoSize = true;
            this.kitapad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapad.Location = new System.Drawing.Point(343, 144);
            this.kitapad.Name = "kitapad";
            this.kitapad.Size = new System.Drawing.Size(0, 20);
            this.kitapad.TabIndex = 6;
            // 
            // uyead
            // 
            this.uyead.AutoSize = true;
            this.uyead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyead.Location = new System.Drawing.Point(343, 60);
            this.uyead.Name = "uyead";
            this.uyead.Size = new System.Drawing.Size(0, 20);
            this.uyead.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(64, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kütüphane";
            // 
            // kutuphane
            // 
            this.kutuphane.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.kutuphane.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kutuphane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kutuphane.FormattingEnabled = true;
            this.kutuphane.Location = new System.Drawing.Point(205, 100);
            this.kutuphane.Name = "kutuphane";
            this.kutuphane.Size = new System.Drawing.Size(164, 28);
            this.kutuphane.TabIndex = 9;
            this.kutuphane.SelectedIndexChanged += new System.EventHandler(this.kutuphane_SelectedIndexChanged_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EmanetVerme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 375);
            this.Controls.Add(this.kutuphane);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uyead);
            this.Controls.Add(this.kitapad);
            this.Controls.Add(this.name);
            this.Controls.Add(this.book);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "EmanetVerme";
            this.Text = "Emanet Verme Sayfası";
            this.Load += new System.EventHandler(this.EmanetVerme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox book;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label kitapad;
        private System.Windows.Forms.Label uyead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox kutuphane;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}