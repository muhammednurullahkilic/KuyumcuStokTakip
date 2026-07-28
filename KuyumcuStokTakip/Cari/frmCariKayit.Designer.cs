namespace KuyumcuStokTakip
{
    partial class frmCariKayit
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
            this.lblCariAd = new DevExpress.XtraEditors.LabelControl();
            this.lblCariKod = new DevExpress.XtraEditors.LabelControl();
            this.lblHesapTip = new DevExpress.XtraEditors.LabelControl();
            this.lblTelefonNo = new DevExpress.XtraEditors.LabelControl();
            this.lblAdres = new DevExpress.XtraEditors.LabelControl();
            this.lblNot = new DevExpress.XtraEditors.LabelControl();
            this.txtCariAd = new System.Windows.Forms.TextBox();
            this.txtCariKod = new System.Windows.Forms.TextBox();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.chkCariAktifMi = new System.Windows.Forms.CheckBox();
            this.btnCariKayit = new DevExpress.XtraEditors.SimpleButton();
            this.gleCariTip = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gleCariTip.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCariAd
            // 
            this.lblCariAd.Location = new System.Drawing.Point(60, 47);
            this.lblCariAd.Name = "lblCariAd";
            this.lblCariAd.Size = new System.Drawing.Size(55, 16);
            this.lblCariAd.TabIndex = 0;
            this.lblCariAd.Tag = "Cari Ad";
            this.lblCariAd.Text = "*Cari Ad:";
            // 
            // lblCariKod
            // 
            this.lblCariKod.Location = new System.Drawing.Point(60, 83);
            this.lblCariKod.Name = "lblCariKod";
            this.lblCariKod.Size = new System.Drawing.Size(61, 16);
            this.lblCariKod.TabIndex = 1;
            this.lblCariKod.Text = "*Cari Kod:";
            // 
            // lblHesapTip
            // 
            this.lblHesapTip.Location = new System.Drawing.Point(60, 123);
            this.lblHesapTip.Name = "lblHesapTip";
            this.lblHesapTip.Size = new System.Drawing.Size(61, 16);
            this.lblHesapTip.TabIndex = 2;
            this.lblHesapTip.Text = "*Cari Tipi:";
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.Location = new System.Drawing.Point(60, 159);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(67, 16);
            this.lblTelefonNo.TabIndex = 3;
            this.lblTelefonNo.Text = "Telefon No:";
            // 
            // lblAdres
            // 
            this.lblAdres.Location = new System.Drawing.Point(60, 199);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(38, 16);
            this.lblAdres.TabIndex = 4;
            this.lblAdres.Text = "Adres:";
            // 
            // lblNot
            // 
            this.lblNot.Location = new System.Drawing.Point(60, 235);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(24, 16);
            this.lblNot.TabIndex = 5;
            this.lblNot.Text = "Not:";
            // 
            // txtCariAd
            // 
            this.txtCariAd.Location = new System.Drawing.Point(175, 41);
            this.txtCariAd.Name = "txtCariAd";
            this.txtCariAd.Size = new System.Drawing.Size(135, 22);
            this.txtCariAd.TabIndex = 7;
            // 
            // txtCariKod
            // 
            this.txtCariKod.Location = new System.Drawing.Point(175, 83);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(135, 22);
            this.txtCariKod.TabIndex = 8;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(175, 153);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(135, 22);
            this.txtTelefonNo.TabIndex = 9;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(175, 193);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(135, 22);
            this.txtAdres.TabIndex = 10;
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(175, 229);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(135, 22);
            this.txtNot.TabIndex = 11;
            // 
            // chkCariAktifMi
            // 
            this.chkCariAktifMi.AutoSize = true;
            this.chkCariAktifMi.Location = new System.Drawing.Point(175, 268);
            this.chkCariAktifMi.Name = "chkCariAktifMi";
            this.chkCariAktifMi.Size = new System.Drawing.Size(71, 20);
            this.chkCariAktifMi.TabIndex = 12;
            this.chkCariAktifMi.Text = "Aktif Mi";
            this.chkCariAktifMi.UseVisualStyleBackColor = true;
            // 
            // btnCariKayit
            // 
            this.btnCariKayit.Location = new System.Drawing.Point(186, 317);
            this.btnCariKayit.Name = "btnCariKayit";
            this.btnCariKayit.Size = new System.Drawing.Size(84, 34);
            this.btnCariKayit.TabIndex = 13;
            this.btnCariKayit.Text = "Kayıt";
            this.btnCariKayit.Click += new System.EventHandler(this.btnCariKayit_Click);
            // 
            // gleCariTip
            // 
            this.gleCariTip.Location = new System.Drawing.Point(175, 120);
            this.gleCariTip.Name = "gleCariTip";
            this.gleCariTip.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleCariTip.Properties.NullText = "";
            this.gleCariTip.Size = new System.Drawing.Size(131, 22);
            this.gleCariTip.TabIndex = 14;
            this.gleCariTip.Tag = "Cari Tip";
            // 
            // frmCariKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.gleCariTip);
            this.Controls.Add(this.btnCariKayit);
            this.Controls.Add(this.chkCariAktifMi);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.txtCariKod);
            this.Controls.Add(this.txtCariAd);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTelefonNo);
            this.Controls.Add(this.lblHesapTip);
            this.Controls.Add(this.lblCariKod);
            this.Controls.Add(this.lblCariAd);
            this.Name = "frmCariKayit";
            this.Text = "Cari Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.gleCariTip.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCariAd;
        private DevExpress.XtraEditors.LabelControl lblCariKod;
        private DevExpress.XtraEditors.LabelControl lblHesapTip;
        private DevExpress.XtraEditors.LabelControl lblTelefonNo;
        private DevExpress.XtraEditors.LabelControl lblAdres;
        private DevExpress.XtraEditors.LabelControl lblNot;
        private System.Windows.Forms.TextBox txtCariAd;
        private System.Windows.Forms.TextBox txtCariKod;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.CheckBox chkCariAktifMi;
        private DevExpress.XtraEditors.SimpleButton btnCariKayit;
        private DevExpress.XtraEditors.LookUpEdit gleCariTip;
    }
}