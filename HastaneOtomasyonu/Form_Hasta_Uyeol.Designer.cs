namespace HastaneOtomasyonu
{
    partial class Form_Hasta_Uyeol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Hasta_Uyeol));
            this.label4 = new System.Windows.Forms.Label();
            this.tx_tcno = new System.Windows.Forms.MaskedTextBox();
            this.tx_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_telefonno = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.btn_kayıtol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("hooge 05_54", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 88);
            this.label4.TabIndex = 14;
            this.label4.Text = "Meditek\n Hastanesi";
            // 
            // tx_tcno
            // 
            this.tx_tcno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tx_tcno.Location = new System.Drawing.Point(168, 125);
            this.tx_tcno.Mask = "00000000000";
            this.tx_tcno.Name = "tx_tcno";
            this.tx_tcno.Size = new System.Drawing.Size(150, 33);
            this.tx_tcno.TabIndex = 1;
            this.tx_tcno.ValidatingType = typeof(int);
            // 
            // tx_ad
            // 
            this.tx_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tx_ad.Location = new System.Drawing.Point(168, 160);
            this.tx_ad.Name = "tx_ad";
            this.tx_ad.Size = new System.Drawing.Size(150, 33);
            this.tx_ad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(113, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "AD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(15, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC KİMLİK NO :";
            // 
            // tx_soyad
            // 
            this.tx_soyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tx_soyad.Location = new System.Drawing.Point(168, 199);
            this.tx_soyad.Name = "tx_soyad";
            this.tx_soyad.Size = new System.Drawing.Size(150, 33);
            this.tx_soyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(77, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "SOYAD :";
            // 
            // tx_sifre
            // 
            this.tx_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tx_sifre.Location = new System.Drawing.Point(168, 277);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.PasswordChar = '*';
            this.tx_sifre.Size = new System.Drawing.Size(150, 33);
            this.tx_sifre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(91, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "ŞİFRE :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(57, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "CİNSİYET :";
            // 
            // tx_telefonno
            // 
            this.tx_telefonno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tx_telefonno.Location = new System.Drawing.Point(168, 238);
            this.tx_telefonno.Mask = "(999) 000-0000";
            this.tx_telefonno.Name = "tx_telefonno";
            this.tx_telefonno.Size = new System.Drawing.Size(150, 33);
            this.tx_telefonno.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(60, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "TELEFON :";
            // 
            // cb_cinsiyet
            // 
            this.cb_cinsiyet.FormattingEnabled = true;
            this.cb_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cb_cinsiyet.Location = new System.Drawing.Point(168, 316);
            this.cb_cinsiyet.Name = "cb_cinsiyet";
            this.cb_cinsiyet.Size = new System.Drawing.Size(150, 33);
            this.cb_cinsiyet.TabIndex = 6;
            // 
            // btn_kayıtol
            // 
            this.btn_kayıtol.Location = new System.Drawing.Point(168, 355);
            this.btn_kayıtol.Name = "btn_kayıtol";
            this.btn_kayıtol.Size = new System.Drawing.Size(147, 36);
            this.btn_kayıtol.TabIndex = 7;
            this.btn_kayıtol.Text = "KAYIT OL";
            this.btn_kayıtol.UseVisualStyleBackColor = true;
            this.btn_kayıtol.Click += new System.EventHandler(this.btn_kayıtol_Click);
            // 
            // Form_Hasta_Uyeol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(412, 449);
            this.Controls.Add(this.btn_kayıtol);
            this.Controls.Add(this.cb_cinsiyet);
            this.Controls.Add(this.tx_telefonno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_soyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_tcno);
            this.Controls.Add(this.tx_ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form_Hasta_Uyeol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASTA ÜYE OL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Hasta_Uyeol_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tx_tcno;
        private System.Windows.Forms.TextBox tx_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tx_telefonno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_cinsiyet;
        private System.Windows.Forms.Button btn_kayıtol;
    }
}