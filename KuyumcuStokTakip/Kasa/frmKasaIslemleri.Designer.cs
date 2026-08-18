namespace KuyumcuStokTakip.Kasa
{
    partial class frmKasaIslemleri
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
            this.lueCari = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbeIslem = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnKasaKayit = new DevExpress.XtraEditors.SimpleButton();
            this.lblCari = new System.Windows.Forms.Label();
            this.lblIslemTuru = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeIslem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lueCari
            // 
            this.lueCari.Location = new System.Drawing.Point(207, 60);
            this.lueCari.Name = "lueCari";
            this.lueCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCari.Properties.PopupView = this.searchLookUpEdit1View;
            this.lueCari.Size = new System.Drawing.Size(149, 22);
            this.lueCari.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cbeIslem
            // 
            this.cbeIslem.Location = new System.Drawing.Point(207, 111);
            this.cbeIslem.Name = "cbeIslem";
            this.cbeIslem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeIslem.Size = new System.Drawing.Size(149, 22);
            this.cbeIslem.TabIndex = 1;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(207, 169);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(149, 22);
            this.txtTutar.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(207, 221);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(149, 22);
            this.txtAciklama.TabIndex = 3;
            // 
            // btnKasaKayit
            // 
            this.btnKasaKayit.Location = new System.Drawing.Point(216, 283);
            this.btnKasaKayit.Name = "btnKasaKayit";
            this.btnKasaKayit.Size = new System.Drawing.Size(103, 30);
            this.btnKasaKayit.TabIndex = 4;
            this.btnKasaKayit.Text = "Kayıt";
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(109, 66);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(45, 20);
            this.lblCari.TabIndex = 5;
            this.lblCari.Text = "Cari*";
            // 
            // lblIslemTuru
            // 
            this.lblIslemTuru.AutoSize = true;
            this.lblIslemTuru.Location = new System.Drawing.Point(109, 117);
            this.lblIslemTuru.Name = "lblIslemTuru";
            this.lblIslemTuru.Size = new System.Drawing.Size(93, 20);
            this.lblIslemTuru.TabIndex = 6;
            this.lblIslemTuru.Text = "İşlem Türü*";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(109, 175);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(54, 20);
            this.lblTutar.TabIndex = 7;
            this.lblTutar.Text = "Tutar*";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(109, 227);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(79, 20);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açıklama";
            // 
            // frmKasaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblIslemTuru);
            this.Controls.Add(this.lblCari);
            this.Controls.Add(this.btnKasaKayit);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.cbeIslem);
            this.Controls.Add(this.lueCari);
            this.Name = "frmKasaIslemleri";
            this.Text = "frmKasaIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeIslem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit lueCari;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.ComboBoxEdit cbeIslem;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtAciklama;
        private DevExpress.XtraEditors.SimpleButton btnKasaKayit;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Label lblIslemTuru;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblAciklama;
    }
}