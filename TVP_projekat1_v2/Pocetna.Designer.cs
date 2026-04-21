namespace TVP_projekat1_v2
{
    partial class Pocetna
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
            this.izlaz = new System.Windows.Forms.Button();
            this.prijava = new System.Windows.Forms.Button();
            this.tb_lozinka = new System.Windows.Forms.TextBox();
            this.tb_korisnicko_ime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // izlaz
            // 
            this.izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izlaz.Location = new System.Drawing.Point(18, 249);
            this.izlaz.Margin = new System.Windows.Forms.Padding(4);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(133, 49);
            this.izlaz.TabIndex = 16;
            this.izlaz.Text = "Izadji";
            this.izlaz.UseVisualStyleBackColor = true;
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            // 
            // prijava
            // 
            this.prijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijava.Location = new System.Drawing.Point(18, 192);
            this.prijava.Margin = new System.Windows.Forms.Padding(4);
            this.prijava.Name = "prijava";
            this.prijava.Size = new System.Drawing.Size(133, 49);
            this.prijava.TabIndex = 15;
            this.prijava.Text = "Prijavi se";
            this.prijava.UseVisualStyleBackColor = true;
            this.prijava.Click += new System.EventHandler(this.prijava_Click);
            // 
            // tb_lozinka
            // 
            this.tb_lozinka.Location = new System.Drawing.Point(18, 138);
            this.tb_lozinka.Margin = new System.Windows.Forms.Padding(4);
            this.tb_lozinka.Name = "tb_lozinka";
            this.tb_lozinka.PasswordChar = '*';
            this.tb_lozinka.Size = new System.Drawing.Size(132, 22);
            this.tb_lozinka.TabIndex = 14;
            // 
            // tb_korisnicko_ime
            // 
            this.tb_korisnicko_ime.Location = new System.Drawing.Point(18, 79);
            this.tb_korisnicko_ime.Margin = new System.Windows.Forms.Padding(4);
            this.tb_korisnicko_ime.Name = "tb_korisnicko_ime";
            this.tb_korisnicko_ime.Size = new System.Drawing.Size(132, 22);
            this.tb_korisnicko_ime.TabIndex = 13;
            this.tb_korisnicko_ime.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lozinka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Korisnicko ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dobrodisli, unesite potrebne podatke";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 323);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.prijava);
            this.Controls.Add(this.tb_lozinka);
            this.Controls.Add(this.tb_korisnicko_ime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izlaz;
        private System.Windows.Forms.Button prijava;
        private System.Windows.Forms.TextBox tb_lozinka;
        private System.Windows.Forms.TextBox tb_korisnicko_ime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

