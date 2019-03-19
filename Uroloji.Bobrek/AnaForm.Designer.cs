namespace Uroloji.Bobrek
{
    partial class AnaForm
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
            this.splAna = new System.Windows.Forms.SplitContainer();
            this.btnHastaBul = new System.Windows.Forms.Button();
            this.btnYeniHasta = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlHastaBul = new System.Windows.Forms.Panel();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtProtNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.dtpOpTar = new System.Windows.Forms.DateTimePicker();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProtNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpTar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splAna)).BeginInit();
            this.splAna.Panel1.SuspendLayout();
            this.splAna.Panel2.SuspendLayout();
            this.splAna.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pnlHastaBul.SuspendLayout();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // splAna
            // 
            this.splAna.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splAna.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splAna.Location = new System.Drawing.Point(0, 0);
            this.splAna.Name = "splAna";
            // 
            // splAna.Panel1
            // 
            this.splAna.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.splAna.Panel1.Controls.Add(this.btnYeniHasta);
            this.splAna.Panel1.Controls.Add(this.btnHastaBul);
            // 
            // splAna.Panel2
            // 
            this.splAna.Panel2.Controls.Add(this.pnlHastaBul);
            this.splAna.Panel2.Controls.Add(this.tabControl1);
            this.splAna.Size = new System.Drawing.Size(916, 487);
            this.splAna.SplitterDistance = 201;
            this.splAna.TabIndex = 0;
            // 
            // btnHastaBul
            // 
            this.btnHastaBul.Location = new System.Drawing.Point(25, 25);
            this.btnHastaBul.Name = "btnHastaBul";
            this.btnHastaBul.Size = new System.Drawing.Size(137, 36);
            this.btnHastaBul.TabIndex = 0;
            this.btnHastaBul.Text = "Hasta Bul";
            this.btnHastaBul.UseVisualStyleBackColor = true;
            // 
            // btnYeniHasta
            // 
            this.btnYeniHasta.Location = new System.Drawing.Point(25, 67);
            this.btnYeniHasta.Name = "btnYeniHasta";
            this.btnYeniHasta.Size = new System.Drawing.Size(137, 36);
            this.btnYeniHasta.TabIndex = 0;
            this.btnYeniHasta.Text = "Yeni Hasta";
            this.btnYeniHasta.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hasta Bilgileri";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 146);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Operatif Özellikler";
            // 
            // pnlHastaBul
            // 
            this.pnlHastaBul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlHastaBul.Controls.Add(this.Liste);
            this.pnlHastaBul.Controls.Add(this.pnlUst);
            this.pnlHastaBul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHastaBul.Location = new System.Drawing.Point(0, 0);
            this.pnlHastaBul.Name = "pnlHastaBul";
            this.pnlHastaBul.Size = new System.Drawing.Size(707, 483);
            this.pnlHastaBul.TabIndex = 1;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlUst.Controls.Add(this.dtpOpTar);
            this.pnlUst.Controls.Add(this.txtSoyad);
            this.pnlUst.Controls.Add(this.txtProtNo);
            this.pnlUst.Controls.Add(this.txtAd);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(707, 58);
            this.pnlUst.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ad,
            this.Soyad,
            this.ProtNo,
            this.OpTar});
            this.Liste.Location = new System.Drawing.Point(40, 88);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(369, 275);
            this.Liste.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(52, 3);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtProtNo
            // 
            this.txtProtNo.Location = new System.Drawing.Point(52, 35);
            this.txtProtNo.Name = "txtProtNo";
            this.txtProtNo.Size = new System.Drawing.Size(100, 20);
            this.txtProtNo.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(176, 3);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 0;
            // 
            // dtpOpTar
            // 
            this.dtpOpTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOpTar.Location = new System.Drawing.Point(176, 32);
            this.dtpOpTar.Name = "dtpOpTar";
            this.dtpOpTar.Size = new System.Drawing.Size(100, 20);
            this.dtpOpTar.TabIndex = 1;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            // 
            // ProtNo
            // 
            this.ProtNo.HeaderText = "Protokol No";
            this.ProtNo.Name = "ProtNo";
            // 
            // OpTar
            // 
            this.OpTar.HeaderText = "Opersayon Tarih";
            this.OpTar.Name = "OpTar";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(570, 146);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Demografik Özellikler";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(570, 146);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Patoloji";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(570, 146);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Takip";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(570, 146);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "PostOperatif Dönem";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 487);
            this.Controls.Add(this.splAna);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.splAna.Panel1.ResumeLayout(false);
            this.splAna.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splAna)).EndInit();
            this.splAna.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.pnlHastaBul.ResumeLayout(false);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splAna;
        private System.Windows.Forms.Button btnYeniHasta;
        private System.Windows.Forms.Button btnHastaBul;
        private System.Windows.Forms.Panel pnlHastaBul;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProtNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpTar;
        private System.Windows.Forms.DateTimePicker dtpOpTar;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtProtNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
    }
}