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
            this.txtAyar = new System.Windows.Forms.TextBox();
            this.chkAyarAktifMi = new System.Windows.Forms.CheckBox();
            this.lblAyarID = new System.Windows.Forms.Label();
            this.lblAyar = new System.Windows.Forms.Label();
            this.btnAyarKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtAyarID
            // 
            this.txtAyarID.Location = new System.Drawing.Point(99, 50);
            this.txtAyarID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAyarID.Name = "txtAyarID";
            this.txtAyarID.Size = new System.Drawing.Size(84, 20);
            this.txtAyarID.TabIndex = 0;
            // 
            // txtAyar
            // 
            this.txtAyar.Location = new System.Drawing.Point(99, 93);
            this.txtAyar.Margin = new System.Windows.Forms.Padding(2);
            this.txtAyar.Name = "txtAyar";
            this.txtAyar.Size = new System.Drawing.Size(84, 20);
            this.txtAyar.TabIndex = 1;
            // 
            // chkAyarAktifMi
            // 
            this.chkAyarAktifMi.AutoSize = true;
            this.chkAyarAktifMi.Location = new System.Drawing.Point(109, 134);
            this.chkAyarAktifMi.Margin = new System.Windows.Forms.Padding(2);
            this.chkAyarAktifMi.Name = "chkAyarAktifMi";
            this.chkAyarAktifMi.Size = new System.Drawing.Size(61, 17);
            this.chkAyarAktifMi.TabIndex = 2;
            this.chkAyarAktifMi.Text = "Aktif Mi";
            this.chkAyarAktifMi.UseVisualStyleBackColor = true;
            // 
            // lblAyarID
            // 
            this.lblAyarID.AutoSize = true;
            this.lblAyarID.Location = new System.Drawing.Point(34, 57);
            this.lblAyarID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAyarID.Name = "lblAyarID";
            this.lblAyarID.Size = new System.Drawing.Size(49, 13);
            this.lblAyarID.TabIndex = 3;
            this.lblAyarID.Text = "*Ayar ID:";
            // 
            // lblAyar
            // 
            this.lblAyar.AutoSize = true;
            this.lblAyar.Location = new System.Drawing.Point(34, 98);
            this.lblAyar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAyar.Name = "lblAyar";
            this.lblAyar.Size = new System.Drawing.Size(35, 13);
            this.lblAyar.TabIndex = 4;
            this.lblAyar.Text = "*Ayar:";
            // 
            // btnAyarKaydet
            // 
            this.btnAyarKaydet.Location = new System.Drawing.Point(87, 169);
            this.btnAyarKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnAyarKaydet.Name = "btnAyarKaydet";
            this.btnAyarKaydet.Size = new System.Drawing.Size(96, 24);
            this.btnAyarKaydet.TabIndex = 5;
            this.btnAyarKaydet.Text = "Kaydet";
            // 
            // frmAyarKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 225);
            this.Controls.Add(this.btnAyarKaydet);
            this.Controls.Add(this.lblAyar);
            this.Controls.Add(this.lblAyarID);
            this.Controls.Add(this.chkAyarAktifMi);
            this.Controls.Add(this.txtAyar);
            this.Controls.Add(this.txtAyarID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAyarKayit";
            this.Text = "Ayar Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAyarID;
        private System.Windows.Forms.TextBox txtAyar;
        private System.Windows.Forms.CheckBox chkAyarAktifMi;
        private System.Windows.Forms.Label lblAyarID;
        private System.Windows.Forms.Label lblAyar;
        private DevExpress.XtraEditors.SimpleButton btnAyarKaydet;
    }
}