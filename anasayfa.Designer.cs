namespace girisform
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnkitap = new System.Windows.Forms.ToolStripButton();
            this.btnuyeler = new System.Windows.Forms.ToolStripButton();
            this.btnemanet = new System.Windows.Forms.ToolStripButton();
            this.btnkategori = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblktpcount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnaddktp = new System.Windows.Forms.Button();
            this.btnadduye = new System.Windows.Forms.Button();
            this.btnaddemanet = new System.Windows.Forms.Button();
            this.btnaddkategori = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnkitap,
            this.btnuyeler,
            this.btnemanet,
            this.btnkategori});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(959, 55);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnkitap
            // 
            this.btnkitap.Image = ((System.Drawing.Image)(resources.GetObject("btnkitap.Image")));
            this.btnkitap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnkitap.Name = "btnkitap";
            this.btnkitap.Size = new System.Drawing.Size(99, 52);
            this.btnkitap.Text = "Kitaplar";
            this.btnkitap.Click += new System.EventHandler(this.btnkitap_Click);
            // 
            // btnuyeler
            // 
            this.btnuyeler.Image = global::girisform.Properties.Resources.uyelericon;
            this.btnuyeler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnuyeler.Name = "btnuyeler";
            this.btnuyeler.Size = new System.Drawing.Size(92, 52);
            this.btnuyeler.Text = "Üyeler";
            this.btnuyeler.Click += new System.EventHandler(this.btnuyeler_Click);
            // 
            // btnemanet
            // 
            this.btnemanet.Image = global::girisform.Properties.Resources.emanetii;
            this.btnemanet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnemanet.Name = "btnemanet";
            this.btnemanet.Size = new System.Drawing.Size(112, 52);
            this.btnemanet.Text = "Emanetler";
            this.btnemanet.ToolTipText = "emanet ";
            this.btnemanet.Click += new System.EventHandler(this.btnemanet_Click);
            // 
            // btnkategori
            // 
            this.btnkategori.Image = global::girisform.Properties.Resources.categories;
            this.btnkategori.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnkategori.Name = "btnkategori";
            this.btnkategori.Size = new System.Drawing.Size(116, 52);
            this.btnkategori.Text = "Kategoriler";
            this.btnkategori.Click += new System.EventHandler(this.btnkategori_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.lblktpcount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 115);
            this.panel1.TabIndex = 3;
            // 
            // lblktpcount
            // 
            this.lblktpcount.AutoSize = true;
            this.lblktpcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblktpcount.Location = new System.Drawing.Point(87, 70);
            this.lblktpcount.Name = "lblktpcount";
            this.lblktpcount.Size = new System.Drawing.Size(36, 25);
            this.lblktpcount.TabIndex = 1;
            this.lblktpcount.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Kitap Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(366, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "İSTATİSTİKLER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(329, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 115);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(95, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "00";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Aktif Üye Sayısı:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(618, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 115);
            this.panel3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(93, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "00";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Emanet Verilen Kitap Sayısı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(935, 346);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnaddktp
            // 
            this.btnaddktp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaddktp.Location = new System.Drawing.Point(86, 669);
            this.btnaddktp.Name = "btnaddktp";
            this.btnaddktp.Size = new System.Drawing.Size(115, 32);
            this.btnaddktp.TabIndex = 6;
            this.btnaddktp.Text = "Kitap işlemleri";
            this.btnaddktp.UseVisualStyleBackColor = true;
            this.btnaddktp.Click += new System.EventHandler(this.btnaddktp_Click);
            // 
            // btnadduye
            // 
            this.btnadduye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadduye.Location = new System.Drawing.Point(280, 669);
            this.btnadduye.Name = "btnadduye";
            this.btnadduye.Size = new System.Drawing.Size(115, 32);
            this.btnadduye.TabIndex = 7;
            this.btnadduye.Text = "Üye işlemleri";
            this.btnadduye.UseVisualStyleBackColor = true;
            this.btnadduye.Click += new System.EventHandler(this.btnadduye_Click);
            // 
            // btnaddemanet
            // 
            this.btnaddemanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaddemanet.Location = new System.Drawing.Point(673, 669);
            this.btnaddemanet.Name = "btnaddemanet";
            this.btnaddemanet.Size = new System.Drawing.Size(115, 32);
            this.btnaddemanet.TabIndex = 8;
            this.btnaddemanet.Text = "Emanet işlemleri";
            this.btnaddemanet.UseVisualStyleBackColor = true;
            this.btnaddemanet.Click += new System.EventHandler(this.btnaddemanet_Click);
            // 
            // btnaddkategori
            // 
            this.btnaddkategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaddkategori.Location = new System.Drawing.Point(473, 669);
            this.btnaddkategori.Name = "btnaddkategori";
            this.btnaddkategori.Size = new System.Drawing.Size(115, 32);
            this.btnaddkategori.TabIndex = 9;
            this.btnaddkategori.Text = "Kategori işlm";
            this.btnaddkategori.UseVisualStyleBackColor = true;
            this.btnaddkategori.Click += new System.EventHandler(this.btnaddkategori_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::girisform.Properties.Resources.loginimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 713);
            this.Controls.Add(this.btnaddkategori);
            this.Controls.Add(this.btnaddemanet);
            this.Controls.Add(this.btnadduye);
            this.Controls.Add(this.btnaddktp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "anasayfa";
            this.Text = "anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnkitap;
        private System.Windows.Forms.ToolStripButton btnuyeler;
        private System.Windows.Forms.ToolStripButton btnemanet;
        private System.Windows.Forms.ToolStripButton btnkategori;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblktpcount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnaddktp;
        private System.Windows.Forms.Button btnadduye;
        private System.Windows.Forms.Button btnaddemanet;
        private System.Windows.Forms.Button btnaddkategori;
    }
}