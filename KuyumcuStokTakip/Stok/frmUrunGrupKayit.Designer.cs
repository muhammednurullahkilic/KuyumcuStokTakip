namespace KuyumcuStokTakip.Stok
{
    partial class frmUrunGrupKayit
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
            this.txtGrubAd = new System.Windows.Forms.TextBox();
            this.txtGrupKod = new System.Windows.Forms.TextBox();
            this.chkUrunGrupAktifMi = new System.Windows.Forms.CheckBox();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lblUrunKisaKod = new System.Windows.Forms.Label();
            this.btnUrunGrubuKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtGrubAd
            // 
            this.txtGrubAd.Location = new System.Drawing.Point(191, 66);
            this.txtGrubAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGrubAd.Name = "txtGrubAd";
            this.txtGrubAd.Size = new System.Drawing.Size(121, 22);
            this.txtGrubAd.TabIndex = 1;
            // 
            // txtGrupKod
            // 
            this.txtGrupKod.Location = new System.Drawing.Point(191, 131);
            this.txtGrupKod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGrupKod.Name = "txtGrupKod";
            this.txtGrupKod.Size = new System.Drawing.Size(121, 22);
            this.txtGrupKod.TabIndex = 2;
            // 
            // chkUrunGrupAktifMi
            // 
            this.chkUrunGrupAktifMi.AutoSize = true;
            this.chkUrunGrupAktifMi.Location = new System.Drawing.Point(191, 183);
            this.chkUrunGrupAktifMi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkUrunGrupAktifMi.Name = "chkUrunGrupAktifMi";
            this.chkUrunGrupAktifMi.Size = new System.Drawing.Size(71, 20);
            this.chkUrunGrupAktifMi.TabIndex = 3;
            this.chkUrunGrupAktifMi.Text = "Aktif Mi";
            this.chkUrunGrupAktifMi.UseVisualStyleBackColor = true;
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(74, 69);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(63, 16);
            this.lblUrunAd.TabIndex = 5;
            this.lblUrunAd.Text = "*Ürün Ad:";
            // 
            // lblUrunKisaKod
            // 
            this.lblUrunKisaKod.AutoSize = true;
            this.lblUrunKisaKod.Location = new System.Drawing.Point(74, 134);
            this.lblUrunKisaKod.Name = "lblUrunKisaKod";
            this.lblUrunKisaKod.Size = new System.Drawing.Size(99, 16);
            this.lblUrunKisaKod.TabIndex = 6;
            this.lblUrunKisaKod.Text = "*Ürün Kısa Kod:";
            // 
            // btnUrunGrubuKaydet
            // 
            this.btnUrunGrubuKaydet.Location = new System.Drawing.Point(175, 226);
            this.btnUrunGrubuKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUrunGrubuKaydet.Name = "btnUrunGrubuKaydet";
            this.btnUrunGrubuKaydet.Size = new System.Drawing.Size(125, 38);
            this.btnUrunGrubuKaydet.TabIndex = 7;
            this.btnUrunGrubuKaydet.Text = "Kaydet";
            this.btnUrunGrubuKaydet.Click += new System.EventHandler(this.btnUrunGrubuKaydet_Click);
            // 
            // frmUrunGrupKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 366);
            this.Controls.Add(this.btnUrunGrubuKaydet);
            this.Controls.Add(this.lblUrunKisaKod);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.chkUrunGrupAktifMi);
            this.Controls.Add(this.txtGrupKod);
            this.Controls.Add(this.txtGrubAd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUrunGrupKayit";
            this.Text = "Ürün Grubu Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGrubAd;
        private System.Windows.Forms.TextBox txtGrupKod;
        private System.Windows.Forms.CheckBox chkUrunGrupAktifMi;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblUrunKisaKod;
        private DevExpress.XtraEditors.SimpleButton btnUrunGrubuKaydet;
    }
}