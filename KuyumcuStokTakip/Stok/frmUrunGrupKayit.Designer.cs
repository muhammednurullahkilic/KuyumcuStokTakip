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
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtUrunKisaKod = new System.Windows.Forms.TextBox();
            this.chkUrunGrupAktifMi = new System.Windows.Forms.CheckBox();
            this.lblUrunID = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lblUrunKisaKod = new System.Windows.Forms.Label();
            this.btnUrunGrubuKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(127, 50);
            this.txtUrunID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(92, 20);
            this.txtUrunID.TabIndex = 0;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(127, 96);
            this.txtUrunAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(92, 20);
            this.txtUrunAd.TabIndex = 1;
            // 
            // txtUrunKisaKod
            // 
            this.txtUrunKisaKod.Location = new System.Drawing.Point(127, 149);
            this.txtUrunKisaKod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUrunKisaKod.Name = "txtUrunKisaKod";
            this.txtUrunKisaKod.Size = new System.Drawing.Size(92, 20);
            this.txtUrunKisaKod.TabIndex = 2;
            // 
            // chkUrunGrupAktifMi
            // 
            this.chkUrunGrupAktifMi.AutoSize = true;
            this.chkUrunGrupAktifMi.Location = new System.Drawing.Point(127, 191);
            this.chkUrunGrupAktifMi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkUrunGrupAktifMi.Name = "chkUrunGrupAktifMi";
            this.chkUrunGrupAktifMi.Size = new System.Drawing.Size(61, 17);
            this.chkUrunGrupAktifMi.TabIndex = 3;
            this.chkUrunGrupAktifMi.Text = "Aktif Mi";
            this.chkUrunGrupAktifMi.UseVisualStyleBackColor = true;
            // 
            // lblUrunID
            // 
            this.lblUrunID.AutoSize = true;
            this.lblUrunID.Location = new System.Drawing.Point(39, 50);
            this.lblUrunID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrunID.Name = "lblUrunID";
            this.lblUrunID.Size = new System.Drawing.Size(51, 13);
            this.lblUrunID.TabIndex = 4;
            this.lblUrunID.Text = "*Ürün ID:";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(39, 98);
            this.lblUrunAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(53, 13);
            this.lblUrunAd.TabIndex = 5;
            this.lblUrunAd.Text = "*Ürün Ad:";
            // 
            // lblUrunKisaKod
            // 
            this.lblUrunKisaKod.AutoSize = true;
            this.lblUrunKisaKod.Location = new System.Drawing.Point(39, 151);
            this.lblUrunKisaKod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrunKisaKod.Name = "lblUrunKisaKod";
            this.lblUrunKisaKod.Size = new System.Drawing.Size(82, 13);
            this.lblUrunKisaKod.TabIndex = 6;
            this.lblUrunKisaKod.Text = "*Ürün Kısa Kod:";
            // 
            // btnUrunGrubuKaydet
            // 
            this.btnUrunGrubuKaydet.Location = new System.Drawing.Point(115, 226);
            this.btnUrunGrubuKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUrunGrubuKaydet.Name = "btnUrunGrubuKaydet";
            this.btnUrunGrubuKaydet.Size = new System.Drawing.Size(94, 31);
            this.btnUrunGrubuKaydet.TabIndex = 7;
            this.btnUrunGrubuKaydet.Text = "Kaydet";
            // 
            // frmUrunGrupKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 297);
            this.Controls.Add(this.btnUrunGrubuKaydet);
            this.Controls.Add(this.lblUrunKisaKod);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.lblUrunID);
            this.Controls.Add(this.chkUrunGrupAktifMi);
            this.Controls.Add(this.txtUrunKisaKod);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.txtUrunID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUrunGrupKayit";
            this.Text = "Ürün Grubu Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtUrunKisaKod;
        private System.Windows.Forms.CheckBox chkUrunGrupAktifMi;
        private System.Windows.Forms.Label lblUrunID;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblUrunKisaKod;
        private DevExpress.XtraEditors.SimpleButton btnUrunGrubuKaydet;
    }
}