namespace KuyumcuStokTakip.Fatura
{
    partial class frmAlisFatura
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
            this.lblAlisTarih = new System.Windows.Forms.Label();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.lblGramFiyat = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lueMusteriAd = new DevExpress.XtraEditors.LookUpEdit();
            this.lueBarkodNo = new DevExpress.XtraEditors.LookUpEdit();
            this.dtAlisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtAlisGramFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtAlisTutar = new DevExpress.XtraEditors.TextEdit();
            this.btnAlisFaturaOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.txtAlisFaturaNo = new System.Windows.Forms.TextBox();
            this.lblFaturaNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lueMusteriAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBarkodNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisGramFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisTutar.Properties)).BeginInit();
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
            // lblAlisTarih
            // 
            this.lblAlisTarih.AutoSize = true;
            this.lblAlisTarih.Location = new System.Drawing.Point(29, 107);
            this.lblAlisTarih.Name = "lblAlisTarih";
            this.lblAlisTarih.Size = new System.Drawing.Size(38, 16);
            this.lblAlisTarih.TabIndex = 1;
            this.lblAlisTarih.Text = "Tarih";
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
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(29, 252);
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
            // dtAlisTarihi
            // 
            this.dtAlisTarihi.EditValue = null;
            this.dtAlisTarihi.Location = new System.Drawing.Point(136, 101);
            this.dtAlisTarihi.Name = "dtAlisTarihi";
            this.dtAlisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAlisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAlisTarihi.Size = new System.Drawing.Size(187, 22);
            this.dtAlisTarihi.TabIndex = 9;
            // 
            // txtAlisGramFiyat
            // 
            this.txtAlisGramFiyat.Location = new System.Drawing.Point(136, 195);
            this.txtAlisGramFiyat.Name = "txtAlisGramFiyat";
            this.txtAlisGramFiyat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtAlisGramFiyat.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtAlisGramFiyat.Size = new System.Drawing.Size(187, 22);
            this.txtAlisGramFiyat.TabIndex = 10;
            // 
            // txtAlisTutar
            // 
            this.txtAlisTutar.Location = new System.Drawing.Point(136, 246);
            this.txtAlisTutar.Name = "txtAlisTutar";
            this.txtAlisTutar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtAlisTutar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtAlisTutar.Size = new System.Drawing.Size(187, 22);
            this.txtAlisTutar.TabIndex = 12;
            // 
            // btnAlisFaturaOnayla
            // 
            this.btnAlisFaturaOnayla.Location = new System.Drawing.Point(146, 300);
            this.btnAlisFaturaOnayla.Name = "btnAlisFaturaOnayla";
            this.btnAlisFaturaOnayla.Size = new System.Drawing.Size(162, 39);
            this.btnAlisFaturaOnayla.TabIndex = 14;
            this.btnAlisFaturaOnayla.Text = "Onayla";
            // 
            // txtAlisFaturaNo
            // 
            this.txtAlisFaturaNo.Location = new System.Drawing.Point(136, 12);
            this.txtAlisFaturaNo.Name = "txtAlisFaturaNo";
            this.txtAlisFaturaNo.Size = new System.Drawing.Size(187, 22);
            this.txtAlisFaturaNo.TabIndex = 15;
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.AutoSize = true;
            this.lblFaturaNo.Location = new System.Drawing.Point(29, 18);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(83, 20);
            this.lblFaturaNo.TabIndex = 16;
            this.lblFaturaNo.Text = "Fatura No";
            // 
            // frmAlisFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 390);
            this.Controls.Add(this.lblFaturaNo);
            this.Controls.Add(this.txtAlisFaturaNo);
            this.Controls.Add(this.btnAlisFaturaOnayla);
            this.Controls.Add(this.txtAlisTutar);
            this.Controls.Add(this.txtAlisGramFiyat);
            this.Controls.Add(this.dtAlisTarihi);
            this.Controls.Add(this.lueBarkodNo);
            this.Controls.Add(this.lueMusteriAd);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.lblGramFiyat);
            this.Controls.Add(this.lblAlisTarih);
            this.Controls.Add(this.lblMusteriAd);
            this.Name = "frmAlisFatura";
            this.Text = "Alış Fatura";
            ((System.ComponentModel.ISupportInitialize)(this.lueMusteriAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBarkodNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisGramFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisTutar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Label lblAlisTarih;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.Label lblGramFiyat;
        private System.Windows.Forms.Label lblTutar;
        private DevExpress.XtraEditors.LookUpEdit lueMusteriAd;
        private DevExpress.XtraEditors.LookUpEdit lueBarkodNo;
        private DevExpress.XtraEditors.DateEdit dtAlisTarihi;
        private DevExpress.XtraEditors.TextEdit txtAlisGramFiyat;
        private DevExpress.XtraEditors.TextEdit txtAlisTutar;
        private DevExpress.XtraEditors.SimpleButton btnAlisFaturaOnayla;
        private System.Windows.Forms.TextBox txtAlisFaturaNo;
        private System.Windows.Forms.Label lblFaturaNo;
    }
}