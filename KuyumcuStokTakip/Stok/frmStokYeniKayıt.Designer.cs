namespace KuyumcuStokTakip.Stok
{
    partial class frmStokYeniKayıt
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
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lblUrunAyar = new System.Windows.Forms.Label();
            this.lblToptancı = new System.Windows.Forms.Label();
            this.lblUrunGram = new System.Windows.Forms.Label();
            this.lblMaliyet = new System.Windows.Forms.Label();
            this.lblIscilik = new System.Windows.Forms.Label();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.lueUrunAd = new DevExpress.XtraEditors.LookUpEdit();
            this.lueUrunAyar = new DevExpress.XtraEditors.LookUpEdit();
            this.lueToptanci = new DevExpress.XtraEditors.LookUpEdit();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.txtUrunGram = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunMaliyet = new DevExpress.XtraEditors.TextEdit();
            this.txtIscilik = new DevExpress.XtraEditors.TextEdit();
            this.btnStokYeniUrunKayıt = new DevExpress.XtraEditors.SimpleButton();
            this.chkAktifMi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.lueUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUrunAyar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueToptanci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunGram.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunMaliyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIscilik.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(57, 57);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(66, 16);
            this.lblUrunAd.TabIndex = 0;
            this.lblUrunAd.Text = "*Ürün Adı:";
            // 
            // lblUrunAyar
            // 
            this.lblUrunAyar.AutoSize = true;
            this.lblUrunAyar.Location = new System.Drawing.Point(57, 94);
            this.lblUrunAyar.Name = "lblUrunAyar";
            this.lblUrunAyar.Size = new System.Drawing.Size(74, 16);
            this.lblUrunAyar.TabIndex = 1;
            this.lblUrunAyar.Text = "*Ürün Ayar:";
            // 
            // lblToptancı
            // 
            this.lblToptancı.AutoSize = true;
            this.lblToptancı.Location = new System.Drawing.Point(57, 127);
            this.lblToptancı.Name = "lblToptancı";
            this.lblToptancı.Size = new System.Drawing.Size(68, 16);
            this.lblToptancı.TabIndex = 2;
            this.lblToptancı.Text = "*Toptancı:";
            // 
            // lblUrunGram
            // 
            this.lblUrunGram.AutoSize = true;
            this.lblUrunGram.Location = new System.Drawing.Point(57, 161);
            this.lblUrunGram.Name = "lblUrunGram";
            this.lblUrunGram.Size = new System.Drawing.Size(79, 16);
            this.lblUrunGram.TabIndex = 3;
            this.lblUrunGram.Text = "*Ürün Gram:";
            // 
            // lblMaliyet
            // 
            this.lblMaliyet.AutoSize = true;
            this.lblMaliyet.Location = new System.Drawing.Point(57, 202);
            this.lblMaliyet.Name = "lblMaliyet";
            this.lblMaliyet.Size = new System.Drawing.Size(89, 16);
            this.lblMaliyet.TabIndex = 4;
            this.lblMaliyet.Text = "*Ürün Maliyet:";
            // 
            // lblIscilik
            // 
            this.lblIscilik.AutoSize = true;
            this.lblIscilik.Location = new System.Drawing.Point(57, 240);
            this.lblIscilik.Name = "lblIscilik";
            this.lblIscilik.Size = new System.Drawing.Size(48, 16);
            this.lblIscilik.TabIndex = 5;
            this.lblIscilik.Text = "*İşçilik:";
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(57, 277);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(80, 16);
            this.lblBarkodNo.TabIndex = 6;
            this.lblBarkodNo.Text = "*Barkod No:";
            // 
            // lueUrunAd
            // 
            this.lueUrunAd.Location = new System.Drawing.Point(164, 50);
            this.lueUrunAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueUrunAd.Name = "lueUrunAd";
            this.lueUrunAd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUrunAd.Properties.NullText = "";
            this.lueUrunAd.Size = new System.Drawing.Size(149, 22);
            this.lueUrunAd.TabIndex = 0;
            // 
            // lueUrunAyar
            // 
            this.lueUrunAyar.Location = new System.Drawing.Point(164, 87);
            this.lueUrunAyar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueUrunAyar.Name = "lueUrunAyar";
            this.lueUrunAyar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUrunAyar.Properties.NullText = "";
            this.lueUrunAyar.Size = new System.Drawing.Size(149, 22);
            this.lueUrunAyar.TabIndex = 1;
            // 
            // lueToptanci
            // 
            this.lueToptanci.Location = new System.Drawing.Point(164, 121);
            this.lueToptanci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueToptanci.Name = "lueToptanci";
            this.lueToptanci.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueToptanci.Properties.NullText = "";
            this.lueToptanci.Size = new System.Drawing.Size(149, 22);
            this.lueToptanci.TabIndex = 2;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Enabled = false;
            this.txtBarkodNo.Location = new System.Drawing.Point(164, 271);
            this.txtBarkodNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(151, 22);
            this.txtBarkodNo.TabIndex = 6;
            // 
            // txtUrunGram
            // 
            this.txtUrunGram.Location = new System.Drawing.Point(164, 158);
            this.txtUrunGram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunGram.Name = "txtUrunGram";
            this.txtUrunGram.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtUrunGram.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtUrunGram.Size = new System.Drawing.Size(149, 22);
            this.txtUrunGram.TabIndex = 3;
            // 
            // txtUrunMaliyet
            // 
            this.txtUrunMaliyet.Location = new System.Drawing.Point(164, 196);
            this.txtUrunMaliyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunMaliyet.Name = "txtUrunMaliyet";
            this.txtUrunMaliyet.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtUrunMaliyet.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtUrunMaliyet.Size = new System.Drawing.Size(149, 22);
            this.txtUrunMaliyet.TabIndex = 4;
            // 
            // txtIscilik
            // 
            this.txtIscilik.Location = new System.Drawing.Point(164, 234);
            this.txtIscilik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIscilik.Name = "txtIscilik";
            this.txtIscilik.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtIscilik.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtIscilik.Size = new System.Drawing.Size(149, 22);
            this.txtIscilik.TabIndex = 5;
            this.txtIscilik.Leave += new System.EventHandler(this.txtIscilik_Leave);
            // 
            // btnStokYeniUrunKayıt
            // 
            this.btnStokYeniUrunKayıt.Location = new System.Drawing.Point(173, 352);
            this.btnStokYeniUrunKayıt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStokYeniUrunKayıt.Name = "btnStokYeniUrunKayıt";
            this.btnStokYeniUrunKayıt.Size = new System.Drawing.Size(109, 30);
            this.btnStokYeniUrunKayıt.TabIndex = 17;
            this.btnStokYeniUrunKayıt.Text = "Kaydet";
            this.btnStokYeniUrunKayıt.Click += new System.EventHandler(this.btnStokYeniUrunKayıt_Click);
            // 
            // chkAktifMi
            // 
            this.chkAktifMi.AutoSize = true;
            this.chkAktifMi.Location = new System.Drawing.Point(189, 316);
            this.chkAktifMi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAktifMi.Name = "chkAktifMi";
            this.chkAktifMi.Size = new System.Drawing.Size(71, 20);
            this.chkAktifMi.TabIndex = 18;
            this.chkAktifMi.Text = "Aktif Mi";
            this.chkAktifMi.UseVisualStyleBackColor = true;
            // 
            // frmStokYeniKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 436);
            this.Controls.Add(this.chkAktifMi);
            this.Controls.Add(this.btnStokYeniUrunKayıt);
            this.Controls.Add(this.txtIscilik);
            this.Controls.Add(this.txtUrunMaliyet);
            this.Controls.Add(this.txtUrunGram);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.lueToptanci);
            this.Controls.Add(this.lueUrunAyar);
            this.Controls.Add(this.lueUrunAd);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.lblIscilik);
            this.Controls.Add(this.lblMaliyet);
            this.Controls.Add(this.lblUrunGram);
            this.Controls.Add(this.lblToptancı);
            this.Controls.Add(this.lblUrunAyar);
            this.Controls.Add(this.lblUrunAd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmStokYeniKayıt";
            this.Text = "Stok Yeni Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.lueUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUrunAyar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueToptanci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunGram.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunMaliyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIscilik.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblUrunAyar;
        private System.Windows.Forms.Label lblToptancı;
        private System.Windows.Forms.Label lblUrunGram;
        private System.Windows.Forms.Label lblMaliyet;
        private System.Windows.Forms.Label lblIscilik;
        private System.Windows.Forms.Label lblBarkodNo;
        private DevExpress.XtraEditors.LookUpEdit lueUrunAd;
        private DevExpress.XtraEditors.LookUpEdit lueUrunAyar;
        private DevExpress.XtraEditors.LookUpEdit lueToptanci;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private DevExpress.XtraEditors.TextEdit txtUrunGram;
        private DevExpress.XtraEditors.TextEdit txtUrunMaliyet;
        private DevExpress.XtraEditors.TextEdit txtIscilik;
        private DevExpress.XtraEditors.SimpleButton btnStokYeniUrunKayıt;
        private System.Windows.Forms.CheckBox chkAktifMi;
    }
}