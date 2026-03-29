namespace girisform
{
    partial class kategori
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnsil);
            this.panel1.Controls.Add(this.btngüncelle);
            this.panel1.Controls.Add(this.btnekle);
            this.panel1.Controls.Add(this.txtad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(256, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 367);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(88, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori İd:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(215, 129);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(110, 20);
            this.txtid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori Ekleme Güncelleme Silme";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(215, 180);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(110, 20);
            this.txtad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(88, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategori Adı:";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(113, 245);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(71, 23);
            this.btnekle.TabIndex = 5;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(204, 245);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(71, 23);
            this.btngüncelle.TabIndex = 6;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(293, 245);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(71, 23);
            this.btnsil.TabIndex = 7;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::girisform.Properties.Resources.loginimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "kategori";
            this.Text = "Kategori İşlemleri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}