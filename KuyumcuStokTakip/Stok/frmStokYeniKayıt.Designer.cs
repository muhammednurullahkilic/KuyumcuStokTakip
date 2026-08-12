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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMilyem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lueUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUrunAyar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(69, 111);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(66, 16);
            this.lblUrunAd.TabIndex = 0;
            this.lblUrunAd.Text = "*Ürün Adı:";
            // 
            // lblUrunAyar
            // 
            this.lblUrunAyar.AutoSize = true;
            this.lblUrunAyar.Location = new System.Drawing.Point(69, 148);
            this.lblUrunAyar.Name = "lblUrunAyar";
            this.lblUrunAyar.Size = new System.Drawing.Size(74, 16);
            this.lblUrunAyar.TabIndex = 1;
            this.lblUrunAyar.Text = "*Ürün Ayar:";
            // 
            // lueUrunAd
            // 
            this.lueUrunAd.Location = new System.Drawing.Point(176, 105);
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
            this.lueUrunAyar.Location = new System.Drawing.Point(176, 142);
            this.lueUrunAyar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueUrunAyar.Name = "lueUrunAyar";
            this.lueUrunAyar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUrunAyar.Properties.NullText = "";
            this.lueUrunAyar.Size = new System.Drawing.Size(149, 22);
            this.lueUrunAyar.TabIndex = 1;
            this.lueUrunAyar.Leave += new System.EventHandler(this.lueUrunAyar_Leave);
            // 
            // btnStokYeniUrunKayıt
            // 
            this.btnStokYeniUrunKayıt.Location = new System.Drawing.Point(180, 275);
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
            this.chkAktifMi.Location = new System.Drawing.Point(196, 239);
            this.chkAktifMi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAktifMi.Name = "chkAktifMi";
            this.chkAktifMi.Size = new System.Drawing.Size(71, 20);
            this.chkAktifMi.TabIndex = 18;
            this.chkAktifMi.Text = "Aktif Mi";
            this.chkAktifMi.UseVisualStyleBackColor = true;
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(69, 79);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(63, 16);
            this.lblBarkodNo.TabIndex = 6;
            this.lblBarkodNo.Text = "*Stok No:";
            // 
            // txtStokNo
            // 
            this.txtStokNo.Enabled = false;
            this.txtStokNo.Location = new System.Drawing.Point(176, 70);
            this.txtStokNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStokNo.Name = "txtStokNo";
            this.txtStokNo.Size = new System.Drawing.Size(151, 22);
            this.txtStokNo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "*Milyem:";
            // 
            // txtMilyem
            // 
            this.txtMilyem.Location = new System.Drawing.Point(176, 187);
            this.txtMilyem.Name = "txtMilyem";
            this.txtMilyem.Size = new System.Drawing.Size(149, 22);
            this.txtMilyem.TabIndex = 20;
            // 
            // frmStokYeniKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 436);
            this.Controls.Add(this.txtMilyem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkAktifMi);
            this.Controls.Add(this.btnStokYeniUrunKayıt);
            this.Controls.Add(this.txtStokNo);
            this.Controls.Add(this.lueUrunAyar);
            this.Controls.Add(this.lueUrunAd);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.lblUrunAyar);
            this.Controls.Add(this.lblUrunAd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMilyem;
    }
}