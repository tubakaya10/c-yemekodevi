﻿
namespace YemekTarifi
{
    partial class frmYemekEkleme
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
            this.btnYemekEklemeYemekEkle = new System.Windows.Forms.Button();
            this.lblYemekEklemeYemekAdi = new System.Windows.Forms.Label();
            this.lblYemekEklemeMalzemeler = new System.Windows.Forms.Label();
            this.txtYemekEklemeMalzemeler = new System.Windows.Forms.TextBox();
            this.btnYemekEkleMalzemeEkle = new System.Windows.Forms.Button();
            this.txtYemekEklemeYemekAdi = new System.Windows.Forms.TextBox();
            this.lbYemeklerVeMalzemeler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnYemekEklemeYemekEkle
            // 
            this.btnYemekEklemeYemekEkle.Location = new System.Drawing.Point(211, 94);
            this.btnYemekEklemeYemekEkle.Name = "btnYemekEklemeYemekEkle";
            this.btnYemekEklemeYemekEkle.Size = new System.Drawing.Size(379, 23);
            this.btnYemekEklemeYemekEkle.TabIndex = 5;
            this.btnYemekEklemeYemekEkle.Text = "Yemeği Ekle";
            this.btnYemekEklemeYemekEkle.UseVisualStyleBackColor = true;
            this.btnYemekEklemeYemekEkle.Click += new System.EventHandler(this.btnYemekEklemeYemekEkle_Click);
            // 
            // lblYemekEklemeYemekAdi
            // 
            this.lblYemekEklemeYemekAdi.AutoSize = true;
            this.lblYemekEklemeYemekAdi.Location = new System.Drawing.Point(374, 42);
            this.lblYemekEklemeYemekAdi.Name = "lblYemekEklemeYemekAdi";
            this.lblYemekEklemeYemekAdi.Size = new System.Drawing.Size(63, 15);
            this.lblYemekEklemeYemekAdi.TabIndex = 6;
            this.lblYemekEklemeYemekAdi.Text = "Yemek Adı\r\n";
            // 
            // lblYemekEklemeMalzemeler
            // 
            this.lblYemekEklemeMalzemeler.AutoSize = true;
            this.lblYemekEklemeMalzemeler.Location = new System.Drawing.Point(374, 144);
            this.lblYemekEklemeMalzemeler.Name = "lblYemekEklemeMalzemeler";
            this.lblYemekEklemeMalzemeler.Size = new System.Drawing.Size(68, 15);
            this.lblYemekEklemeMalzemeler.TabIndex = 7;
            this.lblYemekEklemeMalzemeler.Text = "Malzemeler";
            // 
            // txtYemekEklemeMalzemeler
            // 
            this.txtYemekEklemeMalzemeler.Location = new System.Drawing.Point(211, 167);
            this.txtYemekEklemeMalzemeler.Name = "txtYemekEklemeMalzemeler";
            this.txtYemekEklemeMalzemeler.Size = new System.Drawing.Size(379, 23);
            this.txtYemekEklemeMalzemeler.TabIndex = 8;
            // 
            // btnYemekEkleMalzemeEkle
            // 
            this.btnYemekEkleMalzemeEkle.Location = new System.Drawing.Point(211, 198);
            this.btnYemekEkleMalzemeEkle.Name = "btnYemekEkleMalzemeEkle";
            this.btnYemekEkleMalzemeEkle.Size = new System.Drawing.Size(379, 23);
            this.btnYemekEkleMalzemeEkle.TabIndex = 9;
            this.btnYemekEkleMalzemeEkle.Text = "Malzemeyi Ekle";
            this.btnYemekEkleMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnYemekEkleMalzemeEkle.Click += new System.EventHandler(this.btnYemekEkleMalzemeEkle_Click);
            // 
            // txtYemekEklemeYemekAdi
            // 
            this.txtYemekEklemeYemekAdi.Location = new System.Drawing.Point(211, 65);
            this.txtYemekEklemeYemekAdi.Name = "txtYemekEklemeYemekAdi";
            this.txtYemekEklemeYemekAdi.Size = new System.Drawing.Size(379, 23);
            this.txtYemekEklemeYemekAdi.TabIndex = 11;
            // 
            // lbYemeklerVeMalzemeler
            // 
            this.lbYemeklerVeMalzemeler.FormattingEnabled = true;
            this.lbYemeklerVeMalzemeler.ItemHeight = 15;
            this.lbYemeklerVeMalzemeler.Location = new System.Drawing.Point(211, 256);
            this.lbYemeklerVeMalzemeler.Name = "lbYemeklerVeMalzemeler";
            this.lbYemeklerVeMalzemeler.Size = new System.Drawing.Size(379, 244);
            this.lbYemeklerVeMalzemeler.TabIndex = 12;
            // 
            // frmYemekEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 544);
            this.Controls.Add(this.lbYemeklerVeMalzemeler);
            this.Controls.Add(this.txtYemekEklemeYemekAdi);
            this.Controls.Add(this.btnYemekEkleMalzemeEkle);
            this.Controls.Add(this.txtYemekEklemeMalzemeler);
            this.Controls.Add(this.lblYemekEklemeMalzemeler);
            this.Controls.Add(this.lblYemekEklemeYemekAdi);
            this.Controls.Add(this.btnYemekEklemeYemekEkle);
            this.Name = "frmYemekEkleme";
            this.Text = "Yemek Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnYemekEklemeYemekEkle;
        private System.Windows.Forms.Label lblYemekEklemeYemekAdi;
        private System.Windows.Forms.Label lblYemekEklemeMalzemeler;
        private System.Windows.Forms.TextBox txtYemekEklemeMalzemeler;
        private System.Windows.Forms.Button btnYemekEkleMalzemeEkle;
        private System.Windows.Forms.TextBox txtYemekEklemeYemekAdi;
        private System.Windows.Forms.ListBox lbYemeklerVeMalzemeler;
    }
}