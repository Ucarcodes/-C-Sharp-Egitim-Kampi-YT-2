namespace CSharpEgitimKampi301.EFProject
{
    partial class FrmLocation
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
            this.btnIdGetir = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tBoxUlke = new System.Windows.Forms.TextBox();
            this.lblUlke = new System.Windows.Forms.Label();
            this.tBoxSehir = new System.Windows.Forms.TextBox();
            this.lblSehir = new System.Windows.Forms.Label();
            this.dataGridLokasyon = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.tBoxLokasyonID = new System.Windows.Forms.TextBox();
            this.lblLokasyonID = new System.Windows.Forms.Label();
            this.tBoxGunGece = new System.Windows.Forms.TextBox();
            this.lblGunGece = new System.Windows.Forms.Label();
            this.tBoxFiyat = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.lblRehber = new System.Windows.Forms.Label();
            this.numUpDKapasite = new System.Windows.Forms.NumericUpDown();
            this.cBoxRehber = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLokasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDKapasite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIdGetir
            // 
            this.btnIdGetir.BackColor = System.Drawing.Color.DarkRed;
            this.btnIdGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIdGetir.ForeColor = System.Drawing.Color.White;
            this.btnIdGetir.Location = new System.Drawing.Point(169, 484);
            this.btnIdGetir.Name = "btnIdGetir";
            this.btnIdGetir.Size = new System.Drawing.Size(196, 42);
            this.btnIdGetir.TabIndex = 23;
            this.btnIdGetir.Text = "ID\'ye Göre Getir";
            this.btnIdGetir.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Orange;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(169, 436);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(196, 42);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(169, 388);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(196, 42);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(169, 340);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(196, 42);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tBoxUlke
            // 
            this.tBoxUlke.Location = new System.Drawing.Point(169, 84);
            this.tBoxUlke.Name = "tBoxUlke";
            this.tBoxUlke.Size = new System.Drawing.Size(196, 22);
            this.tBoxUlke.TabIndex = 19;
            // 
            // lblUlke
            // 
            this.lblUlke.AutoSize = true;
            this.lblUlke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUlke.Location = new System.Drawing.Point(97, 81);
            this.lblUlke.Name = "lblUlke";
            this.lblUlke.Size = new System.Drawing.Size(62, 25);
            this.lblUlke.TabIndex = 18;
            this.lblUlke.Text = "Ülke:";
            // 
            // tBoxSehir
            // 
            this.tBoxSehir.Location = new System.Drawing.Point(169, 48);
            this.tBoxSehir.Name = "tBoxSehir";
            this.tBoxSehir.Size = new System.Drawing.Size(196, 22);
            this.tBoxSehir.TabIndex = 17;
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehir.Location = new System.Drawing.Point(89, 45);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(70, 25);
            this.lblSehir.TabIndex = 16;
            this.lblSehir.Text = "Şehir:";
            // 
            // dataGridLokasyon
            // 
            this.dataGridLokasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLokasyon.Location = new System.Drawing.Point(385, 12);
            this.dataGridLokasyon.Name = "dataGridLokasyon";
            this.dataGridLokasyon.RowHeadersWidth = 51;
            this.dataGridLokasyon.RowTemplate.Height = 24;
            this.dataGridLokasyon.Size = new System.Drawing.Size(1178, 514);
            this.dataGridLokasyon.TabIndex = 15;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Teal;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(169, 292);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(196, 42);
            this.btnListele.TabIndex = 14;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // tBoxLokasyonID
            // 
            this.tBoxLokasyonID.Location = new System.Drawing.Point(169, 12);
            this.tBoxLokasyonID.Name = "tBoxLokasyonID";
            this.tBoxLokasyonID.Size = new System.Drawing.Size(196, 22);
            this.tBoxLokasyonID.TabIndex = 13;
            // 
            // lblLokasyonID
            // 
            this.lblLokasyonID.AutoSize = true;
            this.lblLokasyonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLokasyonID.Location = new System.Drawing.Point(20, 8);
            this.lblLokasyonID.Name = "lblLokasyonID";
            this.lblLokasyonID.Size = new System.Drawing.Size(139, 25);
            this.lblLokasyonID.TabIndex = 12;
            this.lblLokasyonID.Text = "Lokasyon ID:";
            // 
            // tBoxGunGece
            // 
            this.tBoxGunGece.Location = new System.Drawing.Point(169, 195);
            this.tBoxGunGece.Name = "tBoxGunGece";
            this.tBoxGunGece.Size = new System.Drawing.Size(196, 22);
            this.tBoxGunGece.TabIndex = 29;
            // 
            // lblGunGece
            // 
            this.lblGunGece.AutoSize = true;
            this.lblGunGece.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunGece.Location = new System.Drawing.Point(43, 192);
            this.lblGunGece.Name = "lblGunGece";
            this.lblGunGece.Size = new System.Drawing.Size(116, 25);
            this.lblGunGece.TabIndex = 28;
            this.lblGunGece.Text = "Gün Gece:";
            // 
            // tBoxFiyat
            // 
            this.tBoxFiyat.Location = new System.Drawing.Point(169, 159);
            this.tBoxFiyat.Name = "tBoxFiyat";
            this.tBoxFiyat.Size = new System.Drawing.Size(196, 22);
            this.tBoxFiyat.TabIndex = 27;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(93, 156);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(66, 25);
            this.lblFiyat.TabIndex = 26;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapasite.Location = new System.Drawing.Point(55, 120);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(104, 25);
            this.lblKapasite.TabIndex = 24;
            this.lblKapasite.Text = "Kapasite:";
            // 
            // lblRehber
            // 
            this.lblRehber.AutoSize = true;
            this.lblRehber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRehber.Location = new System.Drawing.Point(71, 235);
            this.lblRehber.Name = "lblRehber";
            this.lblRehber.Size = new System.Drawing.Size(88, 25);
            this.lblRehber.TabIndex = 30;
            this.lblRehber.Text = "Rehber:";
            // 
            // numUpDKapasite
            // 
            this.numUpDKapasite.Location = new System.Drawing.Point(169, 120);
            this.numUpDKapasite.Name = "numUpDKapasite";
            this.numUpDKapasite.Size = new System.Drawing.Size(196, 22);
            this.numUpDKapasite.TabIndex = 32;
            // 
            // cBoxRehber
            // 
            this.cBoxRehber.FormattingEnabled = true;
            this.cBoxRehber.Location = new System.Drawing.Point(169, 235);
            this.cBoxRehber.Name = "cBoxRehber";
            this.cBoxRehber.Size = new System.Drawing.Size(196, 24);
            this.cBoxRehber.TabIndex = 33;
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1575, 592);
            this.Controls.Add(this.cBoxRehber);
            this.Controls.Add(this.numUpDKapasite);
            this.Controls.Add(this.lblRehber);
            this.Controls.Add(this.tBoxGunGece);
            this.Controls.Add(this.lblGunGece);
            this.Controls.Add(this.tBoxFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblKapasite);
            this.Controls.Add(this.btnIdGetir);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tBoxUlke);
            this.Controls.Add(this.lblUlke);
            this.Controls.Add(this.tBoxSehir);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.dataGridLokasyon);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.tBoxLokasyonID);
            this.Controls.Add(this.lblLokasyonID);
            this.Name = "FrmLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lokasyon İşlemleri";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLokasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDKapasite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIdGetir;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox tBoxUlke;
        private System.Windows.Forms.Label lblUlke;
        private System.Windows.Forms.TextBox tBoxSehir;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.DataGridView dataGridLokasyon;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox tBoxLokasyonID;
        private System.Windows.Forms.Label lblLokasyonID;
        private System.Windows.Forms.TextBox tBoxGunGece;
        private System.Windows.Forms.Label lblGunGece;
        private System.Windows.Forms.TextBox tBoxFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.Label lblRehber;
        private System.Windows.Forms.NumericUpDown numUpDKapasite;
        private System.Windows.Forms.ComboBox cBoxRehber;
    }
}