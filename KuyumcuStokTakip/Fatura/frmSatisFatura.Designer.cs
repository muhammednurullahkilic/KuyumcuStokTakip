namespace KuyumcuStokTakip.Fatura
{
    partial class frmSatisFatura
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
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.lblSatisTarih = new System.Windows.Forms.Label();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.lblGramFiyat = new System.Windows.Forms.Label();
            this.lblIskonto = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lueMusteriAd = new DevExpress.XtraEditors.LookUpEdit();
            this.lueBarkodNo = new DevExpress.XtraEditors.LookUpEdit();
            this.dtSatisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtSatisGramFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtIskonto = new DevExpress.XtraEditors.TextEdit();
            this.txtSatisTutar = new DevExpress.XtraEditors.TextEdit();
            this.btnSatisFaturaOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.lblFaturaNo = new System.Windows.Forms.Label();
            this.txtSatisFaturaNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lueMusteriAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBarkodNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSatisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSatisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisGramFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIskonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisTutar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(29, 57);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(78, 16);
            this.lblMusteriAd.TabIndex = 0;
            this.lblMusteriAd.Text = "*Müşteri Ad:";
            // 
            // lblSatisTarih
            // 
            this.lblSatisTarih.AutoSize = true;
            this.lblSatisTarih.Location = new System.Drawing.Point(29, 107);
            this.lblSatisTarih.Name = "lblSatisTarih";
            this.lblSatisTarih.Size = new System.Drawing.Size(38, 16);
            this.lblSatisTarih.TabIndex = 1;
            this.lblSatisTarih.Text = "Tarih";
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(29, 155);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(80, 16);
            this.lblBarkodNo.TabIndex = 3;
            this.lblBarkodNo.Text = "*Barkod No:";
            // 
            // lblGramFiyat
            // 
            this.lblGramFiyat.AutoSize = true;
            this.lblGramFiyat.Location = new System.Drawing.Point(29, 201);
            this.lblGramFiyat.Name = "lblGramFiyat";
            this.lblGramFiyat.Size = new System.Drawing.Size(72, 16);
            this.lblGramFiyat.TabIndex = 2;
            this.lblGramFiyat.Text = "Gram Fiyat";
            // 
            // lblIskonto
            // 
            this.lblIskonto.AutoSize = true;
            this.lblIskonto.Location = new System.Drawing.Point(29, 241);
            this.lblIskonto.Name = "lblIskonto";
            this.lblIskonto.Size = new System.Drawing.Size(50, 16);
            this.lblIskonto.TabIndex = 5;
            this.lblIskonto.Text = "İskonto";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(29, 286);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(38, 16);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "Tutar";
            // 
            // lueMusteriAd
            // 
            this.lueMusteriAd.Location = new System.Drawing.Point(136, 51);
            this.lueMusteriAd.Name = "lueMusteriAd";
            this.lueMusteriAd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMusteriAd.Size = new System.Drawing.Size(187, 22);
            this.lueMusteriAd.TabIndex = 7;
            // 
            // lueBarkodNo
            // 
            this.lueBarkodNo.Location = new System.Drawing.Point(136, 152);
            this.lueBarkodNo.Name = "lueBarkodNo";
            this.lueBarkodNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBarkodNo.Size = new System.Drawing.Size(187, 22);
            this.lueBarkodNo.TabIndex = 8;
            // 
            // dtSatisTarihi
            // 
            this.dtSatisTarihi.EditValue = null;
            this.dtSatisTarihi.Location = new System.Drawing.Point(136, 101);
            this.dtSatisTarihi.Name = "dtSatisTarihi";
            this.dtSatisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSatisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSatisTarihi.Size = new System.Drawing.Size(187, 22);
            this.dtSatisTarihi.TabIndex = 9;
            // 
            // txtSatisGramFiyat
            // 
            this.txtSatisGramFiyat.Location = new System.Drawing.Point(136, 195);
            this.txtSatisGramFiyat.Name = "txtSatisGramFiyat";
            this.txtSatisGramFiyat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSatisGramFiyat.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSatisGramFiyat.Size = new System.Drawing.Size(187, 22);
            this.txtSatisGramFiyat.TabIndex = 10;
            // 
            // txtIskonto
            // 
            this.txtIskonto.Location = new System.Drawing.Point(136, 235);
            this.txtIskonto.Name = "txtIskonto";
            this.txtIskonto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtIskonto.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtIskonto.Size = new System.Drawing.Size(187, 22);
            this.txtIskonto.TabIndex = 11;
            // 
            // txtSatisTutar
            // 
            this.txtSatisTutar.Location = new System.Drawing.Point(136, 280);
            this.txtSatisTutar.Name = "txtSatisTutar";
            this.txtSatisTutar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSatisTutar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSatisTutar.Size = new System.Drawing.Size(187, 22);
            this.txtSatisTutar.TabIndex = 12;
            // 
            // btnSatisFaturaOnayla
            // 
            this.btnSatisFaturaOnayla.Location = new System.Drawing.Point(149, 325);
            this.btnSatisFaturaOnayla.Name = "btnSatisFaturaOnayla";
            this.btnSatisFaturaOnayla.Size = new System.Drawing.Size(162, 39);
            this.btnSatisFaturaOnayla.TabIndex = 14;
            this.btnSatisFaturaOnayla.Text = "Onayla";
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.AutoSize = true;
            this.lblFaturaNo.Location = new System.Drawing.Point(29, 19);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(66, 16);
            this.lblFaturaNo.TabIndex = 15;
            this.lblFaturaNo.Text = "Fatura No";
            // 
            // txtSatisFaturaNo
            // 
            this.txtSatisFaturaNo.Location = new System.Drawing.Point(136, 16);
            this.txtSatisFaturaNo.Name = "txtSatisFaturaNo";
            this.txtSatisFaturaNo.Size = new System.Drawing.Size(187, 22);
            this.txtSatisFaturaNo.TabIndex = 16;
            // 
            // frmSatisFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 396);
            this.Controls.Add(this.txtSatisFaturaNo);
            this.Controls.Add(this.lblFaturaNo);
            this.Controls.Add(this.btnSatisFaturaOnayla);
            this.Controls.Add(this.txtSatisTutar);
            this.Controls.Add(this.txtIskonto);
            this.Controls.Add(this.txtSatisGramFiyat);
            this.Controls.Add(this.dtSatisTarihi);
            this.Controls.Add(this.lueBarkodNo);
            this.Controls.Add(this.lueMusteriAd);
            this.Controls.Add(this.lblIskonto);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.lblGramFiyat);
            this.Controls.Add(this.lblSatisTarih);
            this.Controls.Add(this.lblMusteriAd);
            this.Name = "frmSatisFatura";
            this.Text = "Satış Fatura";
            ((System.ComponentModel.ISupportInitialize)(this.lueMusteriAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBarkodNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSatisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSatisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisGramFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIskonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisTutar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Label lblSatisTarih;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.Label lblGramFiyat;
        private System.Windows.Forms.Label lblIskonto;
        private System.Windows.Forms.Label lblTutar;
        private DevExpress.XtraEditors.LookUpEdit lueMusteriAd;
        private DevExpress.XtraEditors.LookUpEdit lueBarkodNo;
        private DevExpress.XtraEditors.DateEdit dtSatisTarihi;
        private DevExpress.XtraEditors.TextEdit txtSatisGramFiyat;
        private DevExpress.XtraEditors.TextEdit txtIskonto;
        private DevExpress.XtraEditors.TextEdit txtSatisTutar;
        private DevExpress.XtraEditors.SimpleButton btnSatisFaturaOnayla;
        private System.Windows.Forms.Label lblFaturaNo;
        private System.Windows.Forms.TextBox txtSatisFaturaNo;
    }
}