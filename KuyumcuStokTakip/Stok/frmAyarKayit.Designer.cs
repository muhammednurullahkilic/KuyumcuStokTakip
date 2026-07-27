namespace KuyumcuStokTakip.Stok
{
    partial class frmAyarKayit
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
            this.txtAyarID = new System.Windows.Forms.TextBox();
            this.txtAyarAd = new System.Windows.Forms.TextBox();
            this.chkAyarAktifMi = new System.Windows.Forms.CheckBox();
            this.lblAyarID = new System.Windows.Forms.Label();
            this.lblAyarAd = new System.Windows.Forms.Label();
            this.btnAyarKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAyarID
            // 
            this.txtAyarID.Location = new System.Drawing.Point(132, 61);
            this.txtAyarID.Name = "txtAyarID";
            this.txtAyarID.Size = new System.Drawing.Size(111, 22);
            this.txtAyarID.TabIndex = 0;
            // 
            // txtAyarAd
            // 
            this.txtAyarAd.Location = new System.Drawing.Point(132, 114);
            this.txtAyarAd.Name = "txtAyarAd";
            this.txtAyarAd.Size = new System.Drawing.Size(111, 22);
            this.txtAyarAd.TabIndex = 1;
            // 
            // chkAyarAktifMi
            // 
            this.chkAyarAktifMi.AutoSize = true;
            this.chkAyarAktifMi.Location = new System.Drawing.Point(132, 205);
            this.chkAyarAktifMi.Name = "chkAyarAktifMi";
            this.chkAyarAktifMi.Size = new System.Drawing.Size(71, 20);
            this.chkAyarAktifMi.TabIndex = 2;
            this.chkAyarAktifMi.Text = "Aktif Mi";
            this.chkAyarAktifMi.UseVisualStyleBackColor = true;
            // 
            // lblAyarID
            // 
            this.lblAyarID.AutoSize = true;
            this.lblAyarID.Location = new System.Drawing.Point(45, 64);
            this.lblAyarID.Name = "lblAyarID";
            this.lblAyarID.Size = new System.Drawing.Size(64, 20);
            this.lblAyarID.TabIndex = 3;
            this.lblAyarID.Text = "Ayar ID";
            // 
            // lblAyarAd
            // 
            this.lblAyarAd.AutoSize = true;
            this.lblAyarAd.Location = new System.Drawing.Point(45, 120);
            this.lblAyarAd.Name = "lblAyarAd";
            this.lblAyarAd.Size = new System.Drawing.Size(79, 20);
            this.lblAyarAd.TabIndex = 4;
            this.lblAyarAd.Text = "*Ayar Ad:";
            // 
            // btnAyarKaydet
            // 
            this.btnAyarKaydet.Location = new System.Drawing.Point(115, 244);
            this.btnAyarKaydet.Name = "btnAyarKaydet";
            this.btnAyarKaydet.Size = new System.Drawing.Size(128, 29);
            this.btnAyarKaydet.TabIndex = 5;
            this.btnAyarKaydet.Text = "Kaydet";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(45, 165);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(76, 20);
            this.lblPersonel.TabIndex = 6;
            this.lblPersonel.Text = "Personel";
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(132, 159);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(111, 22);
            this.txtPersonelAd.TabIndex = 7;
            // 
            // frmAyarKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 308);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.lblPersonel);
            this.Controls.Add(this.btnAyarKaydet);
            this.Controls.Add(this.lblAyarAd);
            this.Controls.Add(this.lblAyarID);
            this.Controls.Add(this.chkAyarAktifMi);
            this.Controls.Add(this.txtAyarAd);
            this.Controls.Add(this.txtAyarID);
            this.Name = "frmAyarKayit";
            this.Text = "Ayar Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAyarID;
        private System.Windows.Forms.TextBox txtAyarAd;
        private System.Windows.Forms.CheckBox chkAyarAktifMi;
        private System.Windows.Forms.Label lblAyarID;
        private System.Windows.Forms.Label lblAyarAd;
        private DevExpress.XtraEditors.SimpleButton btnAyarKaydet;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.TextBox txtPersonelAd;
    }
}