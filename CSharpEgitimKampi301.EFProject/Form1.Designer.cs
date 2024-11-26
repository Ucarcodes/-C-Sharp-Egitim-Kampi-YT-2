namespace CSharpEgitimKampi301.EFProject
{
    partial class Form1
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
            this.lblRehberId = new System.Windows.Forms.Label();
            this.tBoxRehberID = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.dataGridRehber = new System.Windows.Forms.DataGridView();
            this.tBoxRehberAdi = new System.Windows.Forms.TextBox();
            this.lblRehberAdi = new System.Windows.Forms.Label();
            this.tBoxRehberSoyadi = new System.Windows.Forms.TextBox();
            this.lblRehberSoyadi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnIdGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRehber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRehberId
            // 
            this.lblRehberId.AutoSize = true;
            this.lblRehberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRehberId.Location = new System.Drawing.Point(92, 58);
            this.lblRehberId.Name = "lblRehberId";
            this.lblRehberId.Size = new System.Drawing.Size(115, 25);
            this.lblRehberId.TabIndex = 0;
            this.lblRehberId.Text = "Rehber ID:";
            // 
            // tBoxRehberID
            // 
            this.tBoxRehberID.Location = new System.Drawing.Point(209, 61);
            this.tBoxRehberID.Name = "tBoxRehberID";
            this.tBoxRehberID.Size = new System.Drawing.Size(196, 22);
            this.tBoxRehberID.TabIndex = 1;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Teal;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(209, 161);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(196, 42);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dataGridRehber
            // 
            this.dataGridRehber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRehber.Location = new System.Drawing.Point(425, 61);
            this.dataGridRehber.Name = "dataGridRehber";
            this.dataGridRehber.RowHeadersWidth = 51;
            this.dataGridRehber.RowTemplate.Height = 24;
            this.dataGridRehber.Size = new System.Drawing.Size(715, 334);
            this.dataGridRehber.TabIndex = 3;
            // 
            // tBoxRehberAdi
            // 
            this.tBoxRehberAdi.Location = new System.Drawing.Point(209, 97);
            this.tBoxRehberAdi.Name = "tBoxRehberAdi";
            this.tBoxRehberAdi.Size = new System.Drawing.Size(196, 22);
            this.tBoxRehberAdi.TabIndex = 5;
            // 
            // lblRehberAdi
            // 
            this.lblRehberAdi.AutoSize = true;
            this.lblRehberAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRehberAdi.Location = new System.Drawing.Point(81, 94);
            this.lblRehberAdi.Name = "lblRehberAdi";
            this.lblRehberAdi.Size = new System.Drawing.Size(126, 25);
            this.lblRehberAdi.TabIndex = 4;
            this.lblRehberAdi.Text = "Rehber Adı:";
            // 
            // tBoxRehberSoyadi
            // 
            this.tBoxRehberSoyadi.Location = new System.Drawing.Point(209, 133);
            this.tBoxRehberSoyadi.Name = "tBoxRehberSoyadi";
            this.tBoxRehberSoyadi.Size = new System.Drawing.Size(196, 22);
            this.tBoxRehberSoyadi.TabIndex = 7;
            // 
            // lblRehberSoyadi
            // 
            this.lblRehberSoyadi.AutoSize = true;
            this.lblRehberSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRehberSoyadi.Location = new System.Drawing.Point(46, 130);
            this.lblRehberSoyadi.Name = "lblRehberSoyadi";
            this.lblRehberSoyadi.Size = new System.Drawing.Size(161, 25);
            this.lblRehberSoyadi.TabIndex = 6;
            this.lblRehberSoyadi.Text = "Rehber Soyadı:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(209, 209);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(196, 42);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(209, 257);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(196, 42);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Orange;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(209, 305);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(196, 42);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnIdGetir
            // 
            this.btnIdGetir.BackColor = System.Drawing.Color.DarkRed;
            this.btnIdGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIdGetir.ForeColor = System.Drawing.Color.White;
            this.btnIdGetir.Location = new System.Drawing.Point(209, 353);
            this.btnIdGetir.Name = "btnIdGetir";
            this.btnIdGetir.Size = new System.Drawing.Size(196, 42);
            this.btnIdGetir.TabIndex = 11;
            this.btnIdGetir.Text = "ID\'ye Göre Getir";
            this.btnIdGetir.UseVisualStyleBackColor = false;
            this.btnIdGetir.Click += new System.EventHandler(this.btnIdGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1147, 409);
            this.Controls.Add(this.btnIdGetir);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tBoxRehberSoyadi);
            this.Controls.Add(this.lblRehberSoyadi);
            this.Controls.Add(this.tBoxRehberAdi);
            this.Controls.Add(this.lblRehberAdi);
            this.Controls.Add(this.dataGridRehber);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.tBoxRehberID);
            this.Controls.Add(this.lblRehberId);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rehber İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRehber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRehberId;
        private System.Windows.Forms.TextBox tBoxRehberID;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGridRehber;
        private System.Windows.Forms.TextBox tBoxRehberAdi;
        private System.Windows.Forms.Label lblRehberAdi;
        private System.Windows.Forms.TextBox tBoxRehberSoyadi;
        private System.Windows.Forms.Label lblRehberSoyadi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnIdGetir;
    }
}

