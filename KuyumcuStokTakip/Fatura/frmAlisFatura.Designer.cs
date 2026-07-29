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
            this.lblMusteriAd.Location = new System.Drawing.Point(55, 76);
            this.lblMusteriAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(64, 13);
            this.lblMusteriAd.TabIndex = 0;
            this.lblMusteriAd.Text = "*Müşteri Ad:";
            // 
            // lblAlisTarih
            // 
            this.lblAlisTarih.AutoSize = true;
            this.lblAlisTarih.Location = new System.Drawing.Point(55, 117);
            this.lblAlisTarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlisTarih.Name = "lblAlisTarih";
            this.lblAlisTarih.Size = new System.Drawing.Size(38, 13);
            this.lblAlisTarih.TabIndex = 1;
            this.lblAlisTarih.Text = "*Tarih:";
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(55, 156);
            this.lblBarkodNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(65, 13);
            this.lblBarkodNo.TabIndex = 3;
            this.lblBarkodNo.Text = "*Barkod No:";
            // 
            // lblGramFiyat
            // 
            this.lblGramFiyat.AutoSize = true;
            this.lblGramFiyat.Location = new System.Drawing.Point(55, 193);
            this.lblGramFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGramFiyat.Name = "lblGramFiyat";
            this.lblGramFiyat.Size = new System.Drawing.Size(64, 13);
            this.lblGramFiyat.TabIndex = 2;
            this.lblGramFiyat.Text = "*Gram Fiyat:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(55, 235);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(39, 13);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "*Tutar:";
            // 
            // lueMusteriAd
            // 
            this.lueMusteriAd.Location = new System.Drawing.Point(135, 71);
            this.lueMusteriAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lueMusteriAd.Name = "lueMusteriAd";
            this.lueMusteriAd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMusteriAd.Properties.NullText = "";
            this.lueMusteriAd.Size = new System.Drawing.Size(140, 20);
            this.lueMusteriAd.TabIndex = 7;
            // 
            // lueBarkodNo
            // 
            this.lueBarkodNo.Location = new System.Drawing.Point(135, 154);
            this.lueBarkodNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lueBarkodNo.Name = "lueBarkodNo";
            this.lueBarkodNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBarkodNo.Properties.NullText = "";
            this.lueBarkodNo.Size = new System.Drawing.Size(140, 20);
            this.lueBarkodNo.TabIndex = 8;
            // 
            // dtAlisTarihi
            // 
            this.dtAlisTarihi.EditValue = null;
            this.dtAlisTarihi.Location = new System.Drawing.Point(135, 112);
            this.dtAlisTarihi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtAlisTarihi.Name = "dtAlisTarihi";
            this.dtAlisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAlisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAlisTarihi.Size = new System.Drawing.Size(140, 20);
            this.dtAlisTarihi.TabIndex = 9;
            // 
            // txtAlisGramFiyat
            // 
            this.txtAlisGramFiyat.Location = new System.Drawing.Point(135, 188);
            this.txtAlisGramFiyat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAlisGramFiyat.Name = "txtAlisGramFiyat";
            this.txtAlisGramFiyat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtAlisGramFiyat.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtAlisGramFiyat.Size = new System.Drawing.Size(140, 20);
            this.txtAlisGramFiyat.TabIndex = 10;
            // 
            // txtAlisTutar
            // 
            this.txtAlisTutar.Location = new System.Drawing.Point(135, 230);
            this.txtAlisTutar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAlisTutar.Name = "txtAlisTutar";
            this.txtAlisTutar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtAlisTutar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtAlisTutar.Size = new System.Drawing.Size(140, 20);
            this.txtAlisTutar.TabIndex = 12;
            // 
            // btnAlisFaturaOnayla
            // 
            this.btnAlisFaturaOnayla.Location = new System.Drawing.Point(143, 274);
            this.btnAlisFaturaOnayla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlisFaturaOnayla.Name = "btnAlisFaturaOnayla";
            this.btnAlisFaturaOnayla.Size = new System.Drawing.Size(122, 32);
            this.btnAlisFaturaOnayla.TabIndex = 14;
            this.btnAlisFaturaOnayla.Text = "Onayla";
            // 
            // txtAlisFaturaNo
            // 
            this.txtAlisFaturaNo.Location = new System.Drawing.Point(135, 40);
            this.txtAlisFaturaNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAlisFaturaNo.Name = "txtAlisFaturaNo";
            this.txtAlisFaturaNo.Size = new System.Drawing.Size(141, 20);
            this.txtAlisFaturaNo.TabIndex = 15;
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.AutoSize = true;
            this.lblFaturaNo.Location = new System.Drawing.Point(55, 45);
            this.lblFaturaNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(61, 13);
            this.lblFaturaNo.TabIndex = 16;
            this.lblFaturaNo.Text = "*Fatura No:";
            // 
            // frmAlisFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 371);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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