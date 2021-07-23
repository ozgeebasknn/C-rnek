
namespace ProgramlamaDilleriOdev
{
    partial class frmMusteri
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
            this.btnMusteriGeri = new System.Windows.Forms.Button();
            this.grMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.lvMusteri = new System.Windows.Forms.ListView();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.grMusteriBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMusteriGeri
            // 
            this.btnMusteriGeri.BackColor = System.Drawing.Color.Purple;
            this.btnMusteriGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGeri.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMusteriGeri.Location = new System.Drawing.Point(657, 388);
            this.btnMusteriGeri.Name = "btnMusteriGeri";
            this.btnMusteriGeri.Size = new System.Drawing.Size(131, 61);
            this.btnMusteriGeri.TabIndex = 0;
            this.btnMusteriGeri.Text = "Geri";
            this.btnMusteriGeri.UseVisualStyleBackColor = false;
            this.btnMusteriGeri.Click += new System.EventHandler(this.btnMusteriGeri_Click);
            // 
            // grMusteriBilgileri
            // 
            this.grMusteriBilgileri.Controls.Add(this.btnMusteriSil);
            this.grMusteriBilgileri.Controls.Add(this.lvMusteri);
            this.grMusteriBilgileri.Location = new System.Drawing.Point(12, 28);
            this.grMusteriBilgileri.Name = "grMusteriBilgileri";
            this.grMusteriBilgileri.Size = new System.Drawing.Size(743, 354);
            this.grMusteriBilgileri.TabIndex = 1;
            this.grMusteriBilgileri.TabStop = false;
            this.grMusteriBilgileri.Text = "Müşteri Bilgiler";
            // 
            // lvMusteri
            // 
            this.lvMusteri.HideSelection = false;
            this.lvMusteri.Location = new System.Drawing.Point(19, 21);
            this.lvMusteri.Name = "lvMusteri";
            this.lvMusteri.Size = new System.Drawing.Size(674, 288);
            this.lvMusteri.TabIndex = 0;
            this.lvMusteri.UseCompatibleStateImageBehavior = false;
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.BackColor = System.Drawing.Color.Purple;
            this.btnMusteriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriSil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMusteriSil.Location = new System.Drawing.Point(19, 311);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(121, 37);
            this.btnMusteriSil.TabIndex = 12;
            this.btnMusteriSil.Text = "Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = false;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grMusteriBilgileri);
            this.Controls.Add(this.btnMusteriGeri);
            this.Name = "frmMusteri";
            this.Text = "frmMusteri";
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            this.grMusteriBilgileri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriGeri;
        private System.Windows.Forms.GroupBox grMusteriBilgileri;
        private System.Windows.Forms.ListView lvMusteri;
        private System.Windows.Forms.Button btnMusteriSil;
    }
}