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
            this.txtAyar = new System.Windows.Forms.TextBox();
            this.chkAyarAktifMi = new System.Windows.Forms.CheckBox();
            this.lblAyar = new System.Windows.Forms.Label();
            this.btnAyarKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtAyar
            // 
            this.txtAyar.Location = new System.Drawing.Point(134, 73);
            this.txtAyar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAyar.Name = "txtAyar";
            this.txtAyar.Size = new System.Drawing.Size(111, 22);
            this.txtAyar.TabIndex = 1;
            // 
            // chkAyarAktifMi
            // 
            this.chkAyarAktifMi.AutoSize = true;
            this.chkAyarAktifMi.Location = new System.Drawing.Point(147, 124);
            this.chkAyarAktifMi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAyarAktifMi.Name = "chkAyarAktifMi";
            this.chkAyarAktifMi.Size = new System.Drawing.Size(71, 20);
            this.chkAyarAktifMi.TabIndex = 2;
            this.chkAyarAktifMi.Text = "Aktif Mi";
            this.chkAyarAktifMi.UseVisualStyleBackColor = true;
            // 
            // lblAyar
            // 
            this.lblAyar.AutoSize = true;
            this.lblAyar.Location = new System.Drawing.Point(47, 80);
            this.lblAyar.Name = "lblAyar";
            this.lblAyar.Size = new System.Drawing.Size(43, 16);
            this.lblAyar.TabIndex = 4;
            this.lblAyar.Text = "*Ayar:";
            // 
            // btnAyarKaydet
            // 
            this.btnAyarKaydet.Location = new System.Drawing.Point(118, 167);
            this.btnAyarKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAyarKaydet.Name = "btnAyarKaydet";
            this.btnAyarKaydet.Size = new System.Drawing.Size(128, 30);
            this.btnAyarKaydet.TabIndex = 5;
            this.btnAyarKaydet.Text = "Kaydet";
            this.btnAyarKaydet.Click += new System.EventHandler(this.btnAyarKaydet_Click);
            // 
            // frmAyarKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 277);
            this.Controls.Add(this.btnAyarKaydet);
            this.Controls.Add(this.lblAyar);
            this.Controls.Add(this.chkAyarAktifMi);
            this.Controls.Add(this.txtAyar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAyarKayit";
            this.Text = "Ayar Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAyar;
        private System.Windows.Forms.CheckBox chkAyarAktifMi;
        private System.Windows.Forms.Label lblAyar;
        private DevExpress.XtraEditors.SimpleButton btnAyarKaydet;
    }
}