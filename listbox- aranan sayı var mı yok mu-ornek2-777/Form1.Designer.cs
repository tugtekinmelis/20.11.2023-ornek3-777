namespace listbox__aranan_sayı_var_mı_yok_mu_ornek2_777
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
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.Location = new System.Drawing.Point(12, 122);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(226, 368);
            this.lbSayilar.TabIndex = 0;
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(12, 81);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(226, 20);
            this.txtAranan.TabIndex = 1;
            // 
            // btnArama
            // 
            this.btnArama.Location = new System.Drawing.Point(12, 24);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(226, 39);
            this.btnArama.TabIndex = 2;
            this.btnArama.Text = "Arama";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 503);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.lbSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayilar;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Button btnArama;
    }
}

