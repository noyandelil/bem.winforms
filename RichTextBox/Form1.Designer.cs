﻿namespace RichTextBox
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnFontSec = new System.Windows.Forms.Button();
            this.btnSolaYasla = new System.Windows.Forms.Button();
            this.btnOrtala = new System.Windows.Forms.Button();
            this.btnSagaYasla = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.menuDosya = new System.Windows.Forms.MenuStrip();
            this.menuItemYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAç = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lacivertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beyazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siyahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diğerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDosya.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(12, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(461, 402);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnFontSec
            // 
            this.btnFontSec.Location = new System.Drawing.Point(12, 45);
            this.btnFontSec.Name = "btnFontSec";
            this.btnFontSec.Size = new System.Drawing.Size(75, 23);
            this.btnFontSec.TabIndex = 1;
            this.btnFontSec.Text = "Font Seç";
            this.btnFontSec.UseVisualStyleBackColor = true;
            this.btnFontSec.Click += new System.EventHandler(this.btnFontSec_Click);
            // 
            // btnSolaYasla
            // 
            this.btnSolaYasla.Location = new System.Drawing.Point(115, 45);
            this.btnSolaYasla.Name = "btnSolaYasla";
            this.btnSolaYasla.Size = new System.Drawing.Size(75, 23);
            this.btnSolaYasla.TabIndex = 2;
            this.btnSolaYasla.Text = "Sola Yasla";
            this.btnSolaYasla.UseVisualStyleBackColor = true;
            this.btnSolaYasla.Click += new System.EventHandler(this.btnSolaYasla_Click);
            // 
            // btnOrtala
            // 
            this.btnOrtala.Location = new System.Drawing.Point(196, 45);
            this.btnOrtala.Name = "btnOrtala";
            this.btnOrtala.Size = new System.Drawing.Size(75, 23);
            this.btnOrtala.TabIndex = 3;
            this.btnOrtala.Text = "Ortala";
            this.btnOrtala.UseVisualStyleBackColor = true;
            this.btnOrtala.Click += new System.EventHandler(this.btnOrtala_Click);
            // 
            // btnSagaYasla
            // 
            this.btnSagaYasla.Location = new System.Drawing.Point(277, 45);
            this.btnSagaYasla.Name = "btnSagaYasla";
            this.btnSagaYasla.Size = new System.Drawing.Size(75, 23);
            this.btnSagaYasla.TabIndex = 4;
            this.btnSagaYasla.Text = "Sağa Yasla";
            this.btnSagaYasla.UseVisualStyleBackColor = true;
            this.btnSagaYasla.Click += new System.EventHandler(this.btnSagaYasla_Click);
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.Location = new System.Drawing.Point(398, 45);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnRenkDegistir.TabIndex = 5;
            this.btnRenkDegistir.Text = "Renk";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
            // 
            // menuDosya
            // 
            this.menuDosya.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemYeni,
            this.menuItemAç,
            this.kaydetToolStripMenuItem});
            this.menuDosya.Location = new System.Drawing.Point(0, 0);
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(485, 24);
            this.menuDosya.TabIndex = 6;
            this.menuDosya.Text = "Dosya";
            // 
            // menuItemYeni
            // 
            this.menuItemYeni.Name = "menuItemYeni";
            this.menuItemYeni.Size = new System.Drawing.Size(41, 20);
            this.menuItemYeni.Text = "Yeni";
            this.menuItemYeni.Click += new System.EventHandler(this.menuItemYeni_Click);
            // 
            // menuItemAç
            // 
            this.menuItemAç.Name = "menuItemAç";
            this.menuItemAç.Size = new System.Drawing.Size(33, 20);
            this.menuItemAç.Text = "Aç";
            this.menuItemAç.Click += new System.EventHandler(this.menuItemAç_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // renkToolStripMenuItem
            // 
            this.renkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sarıToolStripMenuItem,
            this.lacivertToolStripMenuItem,
            this.beyazToolStripMenuItem,
            this.siyahToolStripMenuItem,
            this.diğerToolStripMenuItem});
            this.renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            this.renkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.renkToolStripMenuItem.Text = "Renk";
            // 
            // sarıToolStripMenuItem
            // 
            this.sarıToolStripMenuItem.Name = "sarıToolStripMenuItem";
            this.sarıToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sarıToolStripMenuItem.Text = "Sarı";
            this.sarıToolStripMenuItem.Click += new System.EventHandler(this.sarıToolStripMenuItem_Click);
            // 
            // lacivertToolStripMenuItem
            // 
            this.lacivertToolStripMenuItem.Name = "lacivertToolStripMenuItem";
            this.lacivertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lacivertToolStripMenuItem.Text = "Lacivert";
            this.lacivertToolStripMenuItem.Click += new System.EventHandler(this.lacivertToolStripMenuItem_Click);
            // 
            // beyazToolStripMenuItem
            // 
            this.beyazToolStripMenuItem.Name = "beyazToolStripMenuItem";
            this.beyazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beyazToolStripMenuItem.Text = "Beyaz";
            this.beyazToolStripMenuItem.Click += new System.EventHandler(this.beyazToolStripMenuItem_Click);
            // 
            // siyahToolStripMenuItem
            // 
            this.siyahToolStripMenuItem.Name = "siyahToolStripMenuItem";
            this.siyahToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.siyahToolStripMenuItem.Text = "Siyah";
            this.siyahToolStripMenuItem.Click += new System.EventHandler(this.siyahToolStripMenuItem_Click);
            // 
            // diğerToolStripMenuItem
            // 
            this.diğerToolStripMenuItem.Name = "diğerToolStripMenuItem";
            this.diğerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.diğerToolStripMenuItem.Text = "Diğer";
            this.diğerToolStripMenuItem.Click += new System.EventHandler(this.diğerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 497);
            this.Controls.Add(this.btnRenkDegistir);
            this.Controls.Add(this.btnSagaYasla);
            this.Controls.Add(this.btnOrtala);
            this.Controls.Add(this.btnSolaYasla);
            this.Controls.Add(this.btnFontSec);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuDosya);
            this.MainMenuStrip = this.menuDosya;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuDosya.ResumeLayout(false);
            this.menuDosya.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnFontSec;
        private System.Windows.Forms.Button btnSolaYasla;
        private System.Windows.Forms.Button btnOrtala;
        private System.Windows.Forms.Button btnSagaYasla;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRenkDegistir;
        private System.Windows.Forms.MenuStrip menuDosya;
        private System.Windows.Forms.ToolStripMenuItem menuItemYeni;
        private System.Windows.Forms.ToolStripMenuItem menuItemAç;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lacivertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beyazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siyahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diğerToolStripMenuItem;
    }
}

