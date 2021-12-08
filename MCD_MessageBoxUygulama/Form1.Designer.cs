
namespace MCD_MessageBoxUygulama
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.txtTelefonNumarasi = new System.Windows.Forms.TextBox();
            this.txtEmailAdres = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lblTelefonNumarasi = new System.Windows.Forms.Label();
            this.lblEmailAdres = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listMusteriler = new System.Windows.Forms.ListBox();
            this.bildirimCubugu = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYeniKayit);
            this.groupBox1.Controls.Add(this.txtTelefonNumarasi);
            this.groupBox1.Controls.Add(this.txtEmailAdres);
            this.groupBox1.Controls.Add(this.txtSoyisim);
            this.groupBox1.Controls.Add(this.txtIsim);
            this.groupBox1.Controls.Add(this.lblTelefonNumarasi);
            this.groupBox1.Controls.Add(this.lblEmailAdres);
            this.groupBox1.Controls.Add(this.lblSoyisim);
            this.groupBox1.Controls.Add(this.lblIsim);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(44, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Müşteri Ekleme Formu";
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(195, 196);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(109, 30);
            this.btnYeniKayit.TabIndex = 0;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // txtTelefonNumarasi
            // 
            this.txtTelefonNumarasi.Location = new System.Drawing.Point(195, 146);
            this.txtTelefonNumarasi.Name = "txtTelefonNumarasi";
            this.txtTelefonNumarasi.Size = new System.Drawing.Size(109, 28);
            this.txtTelefonNumarasi.TabIndex = 1;
            // 
            // txtEmailAdres
            // 
            this.txtEmailAdres.Location = new System.Drawing.Point(195, 112);
            this.txtEmailAdres.Name = "txtEmailAdres";
            this.txtEmailAdres.Size = new System.Drawing.Size(109, 28);
            this.txtEmailAdres.TabIndex = 1;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(195, 75);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(109, 28);
            this.txtSoyisim.TabIndex = 1;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(195, 42);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(109, 28);
            this.txtIsim.TabIndex = 1;
            // 
            // lblTelefonNumarasi
            // 
            this.lblTelefonNumarasi.AutoSize = true;
            this.lblTelefonNumarasi.Location = new System.Drawing.Point(20, 151);
            this.lblTelefonNumarasi.Name = "lblTelefonNumarasi";
            this.lblTelefonNumarasi.Size = new System.Drawing.Size(166, 21);
            this.lblTelefonNumarasi.TabIndex = 0;
            this.lblTelefonNumarasi.Text = "Telefon Numarası:";
            // 
            // lblEmailAdres
            // 
            this.lblEmailAdres.AutoSize = true;
            this.lblEmailAdres.Location = new System.Drawing.Point(20, 115);
            this.lblEmailAdres.Name = "lblEmailAdres";
            this.lblEmailAdres.Size = new System.Drawing.Size(116, 21);
            this.lblEmailAdres.TabIndex = 0;
            this.lblEmailAdres.Text = "Email Adres:";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(20, 82);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(83, 21);
            this.lblSoyisim.TabIndex = 0;
            this.lblSoyisim.Text = "Soyisim:";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(20, 49);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(54, 21);
            this.lblIsim.TabIndex = 0;
            this.lblIsim.Text = "İsim:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listMusteriler);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(416, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Kayıt Listesi";
            // 
            // listMusteriler
            // 
            this.listMusteriler.FormattingEnabled = true;
            this.listMusteriler.ItemHeight = 21;
            this.listMusteriler.Location = new System.Drawing.Point(23, 44);
            this.listMusteriler.Name = "listMusteriler";
            this.listMusteriler.Size = new System.Drawing.Size(305, 214);
            this.listMusteriler.TabIndex = 0;
            // 
            // bildirimCubugu
            // 
            this.bildirimCubugu.Text = "notifyIcon1";
            this.bildirimCubugu.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(908, 604);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "MessageBox Uygulama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.TextBox txtTelefonNumarasi;
        private System.Windows.Forms.TextBox txtEmailAdres;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label lblTelefonNumarasi;
        private System.Windows.Forms.Label lblEmailAdres;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NotifyIcon bildirimCubugu;
        private System.Windows.Forms.ListBox listMusteriler;
    }
}

