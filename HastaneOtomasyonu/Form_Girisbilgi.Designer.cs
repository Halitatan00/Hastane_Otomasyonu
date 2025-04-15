namespace HastaneOtomasyonu
{
    partial class Form_Girisbilgi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_uyeol = new System.Windows.Forms.LinkLabel();
            this.tc_sifre = new System.Windows.Forms.TextBox();
            this.tx_tcno = new System.Windows.Forms.MaskedTextBox();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.lbl_baslık = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC KİMLİK NO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(88, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFRE :";
            // 
            // lbl_uyeol
            // 
            this.lbl_uyeol.AutoSize = true;
            this.lbl_uyeol.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbl_uyeol.Location = new System.Drawing.Point(321, 109);
            this.lbl_uyeol.Name = "lbl_uyeol";
            this.lbl_uyeol.Size = new System.Drawing.Size(57, 21);
            this.lbl_uyeol.TabIndex = 2;
            this.lbl_uyeol.TabStop = true;
            this.lbl_uyeol.Text = "Üye Ol";
            this.lbl_uyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_uyeol_LinkClicked);
            // 
            // tc_sifre
            // 
            this.tc_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tc_sifre.Location = new System.Drawing.Point(165, 101);
            this.tc_sifre.Name = "tc_sifre";
            this.tc_sifre.PasswordChar = '*';
            this.tc_sifre.Size = new System.Drawing.Size(150, 29);
            this.tc_sifre.TabIndex = 2;
            // 
            // tx_tcno
            // 
            this.tx_tcno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tx_tcno.Location = new System.Drawing.Point(165, 66);
            this.tx_tcno.Mask = "00000000000";
            this.tx_tcno.Name = "tx_tcno";
            this.tx_tcno.Size = new System.Drawing.Size(150, 29);
            this.tx_tcno.TabIndex = 1;
            this.tx_tcno.ValidatingType = typeof(int);
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_girisyap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_girisyap.Location = new System.Drawing.Point(165, 136);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(150, 36);
            this.btn_girisyap.TabIndex = 3;
            this.btn_girisyap.Text = "Giriş Yap";
            this.btn_girisyap.UseVisualStyleBackColor = true;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // lbl_baslık
            // 
            this.lbl_baslık.AutoSize = true;
            this.lbl_baslık.Font = new System.Drawing.Font("hooge 05_54", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslık.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbl_baslık.Location = new System.Drawing.Point(9, 9);
            this.lbl_baslık.Name = "lbl_baslık";
            this.lbl_baslık.Size = new System.Drawing.Size(505, 44);
            this.lbl_baslık.TabIndex = 9;
            this.lbl_baslık.Text = "HASTA GIRIS EKRANI";
            // 
            // Form_Girisbilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(649, 217);
            this.Controls.Add(this.lbl_baslık);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.tx_tcno);
            this.Controls.Add(this.tc_sifre);
            this.Controls.Add(this.lbl_uyeol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form_Girisbilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ BİLGİLERİ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Girisbilgi_FormClosed);
            this.Load += new System.EventHandler(this.Form_Hasta_Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lbl_uyeol;
        private System.Windows.Forms.TextBox tc_sifre;
        private System.Windows.Forms.MaskedTextBox tx_tcno;
        private System.Windows.Forms.Button btn_girisyap;
        private System.Windows.Forms.Label lbl_baslık;
    }
}