namespace KutuphaneOtomasyon
{
    partial class EmanetIade
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
            this.kitaplar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bkitaplar = new System.Windows.Forms.Label();
            this.uyeid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // kitaplar
            // 
            this.kitaplar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kitaplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitaplar.FormattingEnabled = true;
            this.kitaplar.Location = new System.Drawing.Point(222, 112);
            this.kitaplar.Name = "kitaplar";
            this.kitaplar.Size = new System.Drawing.Size(121, 28);
            this.kitaplar.TabIndex = 0;
            this.kitaplar.SelectedIndexChanged += new System.EventHandler(this.kitaplar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üye id giriniz";
            // 
            // bkitaplar
            // 
            this.bkitaplar.AutoSize = true;
            this.bkitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bkitaplar.Location = new System.Drawing.Point(86, 112);
            this.bkitaplar.Name = "bkitaplar";
            this.bkitaplar.Size = new System.Drawing.Size(104, 20);
            this.bkitaplar.TabIndex = 2;
            this.bkitaplar.Text = "Aldığı Kitaplar";
            // 
            // uyeid
            // 
            this.uyeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeid.Location = new System.Drawing.Point(243, 60);
            this.uyeid.Name = "uyeid";
            this.uyeid.Size = new System.Drawing.Size(100, 26);
            this.uyeid.TabIndex = 3;
            this.uyeid.TextChanged += new System.EventHandler(this.uyeid_TextChanged);
            this.uyeid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uyeid_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "İŞLEMİ YAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "VAZGEÇ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Aldığı Kitaplar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EmanetIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 351);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uyeid);
            this.Controls.Add(this.bkitaplar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitaplar);
            this.Name = "EmanetIade";
            this.Text = "EmanetIade";
            this.Load += new System.EventHandler(this.EmanetIade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox kitaplar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bkitaplar;
        private System.Windows.Forms.TextBox uyeid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}