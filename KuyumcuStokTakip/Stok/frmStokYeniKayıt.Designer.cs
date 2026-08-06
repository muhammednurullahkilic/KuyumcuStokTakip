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
            this.lueUrunAd = new DevExpress.XtraEditors.LookUpEdit();
            this.lueUrunAyar = new DevExpress.XtraEditors.LookUpEdit();
            this.btnStokYeniUrunKayıt = new DevExpress.XtraEditors.SimpleButton();
            this.chkAktifMi = new System.Windows.Forms.CheckBox();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.txtStokNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lueUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUrunAyar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(52, 90);
            this.lblUrunAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(55, 13);
            this.lblUrunAd.TabIndex = 0;
            this.lblUrunAd.Text = "*Ürün Adı:";
            // 
            // lblUrunAyar
            // 
            this.lblUrunAyar.AutoSize = true;
            this.lblUrunAyar.Location = new System.Drawing.Point(52, 120);
            this.lblUrunAyar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrunAyar.Name = "lblUrunAyar";
            this.lblUrunAyar.Size = new System.Drawing.Size(61, 13);
            this.lblUrunAyar.TabIndex = 1;
            this.lblUrunAyar.Text = "*Ürün Ayar:";
            // 
            // lueUrunAd
            // 
            this.lueUrunAd.Location = new System.Drawing.Point(132, 85);
            this.lueUrunAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lueUrunAd.Name = "lueUrunAd";
            this.lueUrunAd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUrunAd.Properties.NullText = "";
            this.lueUrunAd.Size = new System.Drawing.Size(112, 20);
            this.lueUrunAd.TabIndex = 0;
            // 
            // lueUrunAyar
            // 
            this.lueUrunAyar.Location = new System.Drawing.Point(132, 115);
            this.lueUrunAyar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lueUrunAyar.Name = "lueUrunAyar";
            this.lueUrunAyar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUrunAyar.Properties.NullText = "";
            this.lueUrunAyar.Size = new System.Drawing.Size(112, 20);
            this.lueUrunAyar.TabIndex = 1;
            this.lueUrunAyar.Leave += new System.EventHandler(this.lueUrunAyar_Leave);
            // 
            // btnStokYeniUrunKayıt
            // 
            this.btnStokYeniUrunKayıt.Location = new System.Drawing.Point(132, 191);
            this.btnStokYeniUrunKayıt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStokYeniUrunKayıt.Name = "btnStokYeniUrunKayıt";
            this.btnStokYeniUrunKayıt.Size = new System.Drawing.Size(82, 24);
            this.btnStokYeniUrunKayıt.TabIndex = 17;
            this.btnStokYeniUrunKayıt.Text = "Kaydet";
            this.btnStokYeniUrunKayıt.Click += new System.EventHandler(this.btnStokYeniUrunKayıt_Click);
            // 
            // chkAktifMi
            // 
            this.chkAktifMi.AutoSize = true;
            this.chkAktifMi.Location = new System.Drawing.Point(144, 162);
            this.chkAktifMi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAktifMi.Name = "chkAktifMi";
            this.chkAktifMi.Size = new System.Drawing.Size(61, 17);
            this.chkAktifMi.TabIndex = 18;
            this.chkAktifMi.Text = "Aktif Mi";
            this.chkAktifMi.UseVisualStyleBackColor = true;
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(52, 64);
            this.lblBarkodNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(53, 13);
            this.lblBarkodNo.TabIndex = 6;
            this.lblBarkodNo.Text = "*Stok No:";
            // 
            // txtStokNo
            // 
            this.txtStokNo.Enabled = false;
            this.txtStokNo.Location = new System.Drawing.Point(132, 57);
            this.txtStokNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtStokNo.Name = "txtStokNo";
            this.txtStokNo.Size = new System.Drawing.Size(114, 20);
            this.txtStokNo.TabIndex = 6;
            // 
            // frmStokYeniKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 354);
            this.Controls.Add(this.chkAktifMi);
            this.Controls.Add(this.btnStokYeniUrunKayıt);
            this.Controls.Add(this.txtStokNo);
            this.Controls.Add(this.lueUrunAyar);
            this.Controls.Add(this.lueUrunAd);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.lblUrunAyar);
            this.Controls.Add(this.lblUrunAd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmStokYeniKayıt";
            this.Text = "Stok Yeni Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.lueUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUrunAyar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblUrunAyar;
        private DevExpress.XtraEditors.LookUpEdit lueUrunAd;
        private DevExpress.XtraEditors.LookUpEdit lueUrunAyar;
        private DevExpress.XtraEditors.SimpleButton btnStokYeniUrunKayıt;
        private System.Windows.Forms.CheckBox chkAktifMi;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.TextBox txtStokNo;
    }
}