
namespace ProgramlamaDilleriOdev
{
    partial class frmPersonel
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
            this.btnPersGeri = new System.Windows.Forms.Button();
            this.grpEkle = new System.Windows.Forms.GroupBox();
            this.btnPersEkle = new System.Windows.Forms.Button();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtPersNo = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.lblPersNo = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.grpListe = new System.Windows.Forms.GroupBox();
            this.lvPersonel = new System.Windows.Forms.ListView();
            this.txtTCNo = new System.Windows.Forms.MaskedTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.grpEkle.SuspendLayout();
            this.grpListe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPersGeri
            // 
            this.btnPersGeri.BackColor = System.Drawing.Color.Purple;
            this.btnPersGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersGeri.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPersGeri.Location = new System.Drawing.Point(1065, 424);
            this.btnPersGeri.Name = "btnPersGeri";
            this.btnPersGeri.Size = new System.Drawing.Size(126, 64);
            this.btnPersGeri.TabIndex = 0;
            this.btnPersGeri.Text = "Geri";
            this.btnPersGeri.UseVisualStyleBackColor = false;
            this.btnPersGeri.Click += new System.EventHandler(this.btnPersGeri_Click);
            // 
            // grpEkle
            // 
            this.grpEkle.Controls.Add(this.txtTCNo);
            this.grpEkle.Controls.Add(this.btnPersEkle);
            this.grpEkle.Controls.Add(this.txtMaas);
            this.grpEkle.Controls.Add(this.txtPersNo);
            this.grpEkle.Controls.Add(this.txtSoyisim);
            this.grpEkle.Controls.Add(this.txtIsim);
            this.grpEkle.Controls.Add(this.lblMaas);
            this.grpEkle.Controls.Add(this.lblTcNo);
            this.grpEkle.Controls.Add(this.lblPersNo);
            this.grpEkle.Controls.Add(this.lblSoyisim);
            this.grpEkle.Controls.Add(this.lblIsim);
            this.grpEkle.Location = new System.Drawing.Point(26, 22);
            this.grpEkle.Name = "grpEkle";
            this.grpEkle.Size = new System.Drawing.Size(377, 354);
            this.grpEkle.TabIndex = 1;
            this.grpEkle.TabStop = false;
            this.grpEkle.Text = "Personel Ekleme Paneli";
            // 
            // btnPersEkle
            // 
            this.btnPersEkle.BackColor = System.Drawing.Color.Purple;
            this.btnPersEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersEkle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPersEkle.Location = new System.Drawing.Point(180, 311);
            this.btnPersEkle.Name = "btnPersEkle";
            this.btnPersEkle.Size = new System.Drawing.Size(121, 37);
            this.btnPersEkle.TabIndex = 10;
            this.btnPersEkle.Text = "Ekle";
            this.btnPersEkle.UseVisualStyleBackColor = false;
            this.btnPersEkle.Click += new System.EventHandler(this.btnPersEkle_Click);
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(180, 260);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(121, 22);
            this.txtMaas.TabIndex = 9;
            // 
            // txtPersNo
            // 
            this.txtPersNo.Location = new System.Drawing.Point(180, 147);
            this.txtPersNo.Name = "txtPersNo";
            this.txtPersNo.Size = new System.Drawing.Size(121, 22);
            this.txtPersNo.TabIndex = 7;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(180, 95);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(121, 22);
            this.txtSoyisim.TabIndex = 6;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(180, 42);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(121, 22);
            this.txtIsim.TabIndex = 5;
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaas.Location = new System.Drawing.Point(33, 260);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(60, 24);
            this.lblMaas.TabIndex = 4;
            this.lblMaas.Text = "Maaş:";
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcNo.Location = new System.Drawing.Point(33, 203);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(70, 24);
            this.lblTcNo.TabIndex = 3;
            this.lblTcNo.Text = "TC No:";
            // 
            // lblPersNo
            // 
            this.lblPersNo.AutoSize = true;
            this.lblPersNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersNo.Location = new System.Drawing.Point(33, 145);
            this.lblPersNo.Name = "lblPersNo";
            this.lblPersNo.Size = new System.Drawing.Size(120, 24);
            this.lblPersNo.TabIndex = 2;
            this.lblPersNo.Text = "Personel No:";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyisim.Location = new System.Drawing.Point(33, 93);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(80, 24);
            this.lblSoyisim.TabIndex = 1;
            this.lblSoyisim.Text = "Soyisim:";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.BackColor = System.Drawing.Color.Thistle;
            this.lblIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsim.Location = new System.Drawing.Point(33, 40);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(48, 24);
            this.lblIsim.TabIndex = 0;
            this.lblIsim.Text = "İsim:";
            // 
            // grpListe
            // 
            this.grpListe.Controls.Add(this.btnSil);
            this.grpListe.Controls.Add(this.lvPersonel);
            this.grpListe.Location = new System.Drawing.Point(442, 22);
            this.grpListe.Name = "grpListe";
            this.grpListe.Size = new System.Drawing.Size(749, 354);
            this.grpListe.TabIndex = 2;
            this.grpListe.TabStop = false;
            this.grpListe.Text = "Personel Listesi";
            // 
            // lvPersonel
            // 
            this.lvPersonel.HideSelection = false;
            this.lvPersonel.Location = new System.Drawing.Point(32, 21);
            this.lvPersonel.Name = "lvPersonel";
            this.lvPersonel.Size = new System.Drawing.Size(684, 294);
            this.lvPersonel.TabIndex = 0;
            this.lvPersonel.UseCompatibleStateImageBehavior = false;
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(180, 203);
            this.txtTCNo.Mask = "00000000000";
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(121, 22);
            this.txtTCNo.TabIndex = 11;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Purple;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSil.Location = new System.Drawing.Point(32, 317);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 37);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1247, 500);
            this.Controls.Add(this.grpListe);
            this.Controls.Add(this.grpEkle);
            this.Controls.Add(this.btnPersGeri);
            this.Name = "frmPersonel";
            this.Text = "frmPersonel";
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            this.grpEkle.ResumeLayout(false);
            this.grpEkle.PerformLayout();
            this.grpListe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersGeri;
        private System.Windows.Forms.GroupBox grpEkle;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.Label lblPersNo;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Button btnPersEkle;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.TextBox txtPersNo;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.GroupBox grpListe;
        private System.Windows.Forms.ListView lvPersonel;
        private System.Windows.Forms.MaskedTextBox txtTCNo;
        private System.Windows.Forms.Button btnSil;
    }
}