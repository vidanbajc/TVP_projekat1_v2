namespace TVP_projekat1_v2
{
    partial class Klijent
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.odjava3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.obrisi_rezervaciju = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.izmeni_rezervaciju = new System.Windows.Forms.Button();
            this.dodaj_rezervaciju = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_polaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.br_dana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.br_rezervisanih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uk_cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_datum_polaska = new System.Windows.Forms.Label();
            this.lbl_uk_mesta = new System.Windows.Forms.Label();
            this.lbl_br_dana = new System.Windows.Forms.Label();
            this.lbl_drzava = new System.Windows.Forms.Label();
            this.lbl_mesto = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tb_br_rezervisanih = new System.Windows.Forms.TextBox();
            this.tb_br_dana = new System.Windows.Forms.TextBox();
            this.tb_drzava = new System.Windows.Forms.TextBox();
            this.tb_mesto = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(732, 533);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.odjava3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(724, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pocetna";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_datum_polaska);
            this.tabPage2.Controls.Add(this.lbl_uk_mesta);
            this.tabPage2.Controls.Add(this.lbl_br_dana);
            this.tabPage2.Controls.Add(this.lbl_drzava);
            this.tabPage2.Controls.Add(this.lbl_mesto);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.tb_br_rezervisanih);
            this.tabPage2.Controls.Add(this.tb_br_dana);
            this.tabPage2.Controls.Add(this.tb_drzava);
            this.tabPage2.Controls.Add(this.tb_mesto);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.obrisi_rezervaciju);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.izmeni_rezervaciju);
            this.tabPage2.Controls.Add(this.dodaj_rezervaciju);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(724, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rezervisi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // odjava3
            // 
            this.odjava3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odjava3.Location = new System.Drawing.Point(582, 446);
            this.odjava3.Margin = new System.Windows.Forms.Padding(4);
            this.odjava3.Name = "odjava3";
            this.odjava3.Size = new System.Drawing.Size(133, 49);
            this.odjava3.TabIndex = 89;
            this.odjava3.Text = "Odjavi se";
            this.odjava3.UseVisualStyleBackColor = true;
            this.odjava3.Click += new System.EventHandler(this.odjava3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 84;
            this.label1.Text = "Ulogovani ste ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mesto,
            this.drzava,
            this.datum_polaska,
            this.br_dana,
            this.br_rezervisanih,
            this.uk_cena});
            this.dataGridView2.Location = new System.Drawing.Point(11, 50);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(706, 207);
            this.dataGridView2.TabIndex = 91;
            // 
            // obrisi_rezervaciju
            // 
            this.obrisi_rezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisi_rezervaciju.Location = new System.Drawing.Point(582, 446);
            this.obrisi_rezervaciju.Margin = new System.Windows.Forms.Padding(4);
            this.obrisi_rezervaciju.Name = "obrisi_rezervaciju";
            this.obrisi_rezervaciju.Size = new System.Drawing.Size(133, 49);
            this.obrisi_rezervaciju.TabIndex = 94;
            this.obrisi_rezervaciju.Text = "Obrisi";
            this.obrisi_rezervaciju.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 90;
            this.label2.Text = "Ulogovani ste ";
            // 
            // izmeni_rezervaciju
            // 
            this.izmeni_rezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izmeni_rezervaciju.Location = new System.Drawing.Point(582, 389);
            this.izmeni_rezervaciju.Margin = new System.Windows.Forms.Padding(4);
            this.izmeni_rezervaciju.Name = "izmeni_rezervaciju";
            this.izmeni_rezervaciju.Size = new System.Drawing.Size(133, 49);
            this.izmeni_rezervaciju.TabIndex = 93;
            this.izmeni_rezervaciju.Text = "Izmeni";
            this.izmeni_rezervaciju.UseVisualStyleBackColor = true;
            // 
            // dodaj_rezervaciju
            // 
            this.dodaj_rezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj_rezervaciju.Location = new System.Drawing.Point(582, 332);
            this.dodaj_rezervaciju.Margin = new System.Windows.Forms.Padding(4);
            this.dodaj_rezervaciju.Name = "dodaj_rezervaciju";
            this.dodaj_rezervaciju.Size = new System.Drawing.Size(133, 49);
            this.dodaj_rezervaciju.TabIndex = 92;
            this.dodaj_rezervaciju.Text = "Dodaj";
            this.dodaj_rezervaciju.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.Location = new System.Drawing.Point(11, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(706, 384);
            this.dataGridView1.TabIndex = 92;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mesto";
            this.dataGridViewTextBoxColumn1.HeaderText = "mesto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 73;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "drzava";
            this.dataGridViewTextBoxColumn2.HeaderText = "drzava";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "datum_polaska";
            this.dataGridViewTextBoxColumn3.HeaderText = "datum polaska";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 115;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "br_dana";
            this.dataGridViewTextBoxColumn4.HeaderText = "broj dana";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 86;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "br_rezervisanih";
            this.dataGridViewTextBoxColumn5.HeaderText = "broj rezervisanih osoba";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 161;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "uk_cena";
            this.dataGridViewTextBoxColumn6.HeaderText = "ukupna cena";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 104;
            // 
            // mesto
            // 
            this.mesto.DataPropertyName = "mesto";
            this.mesto.HeaderText = "mesto";
            this.mesto.MinimumWidth = 6;
            this.mesto.Name = "mesto";
            this.mesto.Width = 73;
            // 
            // drzava
            // 
            this.drzava.DataPropertyName = "drzava";
            this.drzava.HeaderText = "drzava";
            this.drzava.MinimumWidth = 6;
            this.drzava.Name = "drzava";
            this.drzava.Width = 77;
            // 
            // datum_polaska
            // 
            this.datum_polaska.DataPropertyName = "datum_polaska";
            this.datum_polaska.HeaderText = "datum polaska";
            this.datum_polaska.MinimumWidth = 6;
            this.datum_polaska.Name = "datum_polaska";
            this.datum_polaska.Width = 115;
            // 
            // br_dana
            // 
            this.br_dana.DataPropertyName = "br_dana";
            this.br_dana.HeaderText = "broj dana";
            this.br_dana.MinimumWidth = 6;
            this.br_dana.Name = "br_dana";
            this.br_dana.Width = 86;
            // 
            // br_rezervisanih
            // 
            this.br_rezervisanih.DataPropertyName = "br_rezervisanih";
            this.br_rezervisanih.HeaderText = "broj rezervisanih osoba";
            this.br_rezervisanih.MinimumWidth = 6;
            this.br_rezervisanih.Name = "br_rezervisanih";
            this.br_rezervisanih.Width = 161;
            // 
            // uk_cena
            // 
            this.uk_cena.DataPropertyName = "uk_cena";
            this.uk_cena.HeaderText = "ukupna cena";
            this.uk_cena.MinimumWidth = 6;
            this.uk_cena.Name = "uk_cena";
            this.uk_cena.Width = 104;
            // 
            // lbl_datum_polaska
            // 
            this.lbl_datum_polaska.AutoSize = true;
            this.lbl_datum_polaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datum_polaska.Location = new System.Drawing.Point(11, 377);
            this.lbl_datum_polaska.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_datum_polaska.Name = "lbl_datum_polaska";
            this.lbl_datum_polaska.Size = new System.Drawing.Size(117, 20);
            this.lbl_datum_polaska.TabIndex = 110;
            this.lbl_datum_polaska.Text = "datum polaska";
            // 
            // lbl_uk_mesta
            // 
            this.lbl_uk_mesta.AutoSize = true;
            this.lbl_uk_mesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uk_mesta.Location = new System.Drawing.Point(169, 325);
            this.lbl_uk_mesta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_uk_mesta.Name = "lbl_uk_mesta";
            this.lbl_uk_mesta.Size = new System.Drawing.Size(87, 20);
            this.lbl_uk_mesta.TabIndex = 109;
            this.lbl_uk_mesta.Text = "broj osoba";
            // 
            // lbl_br_dana
            // 
            this.lbl_br_dana.AutoSize = true;
            this.lbl_br_dana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_br_dana.Location = new System.Drawing.Point(169, 274);
            this.lbl_br_dana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_br_dana.Name = "lbl_br_dana";
            this.lbl_br_dana.Size = new System.Drawing.Size(78, 20);
            this.lbl_br_dana.TabIndex = 108;
            this.lbl_br_dana.Text = "broj dana";
            // 
            // lbl_drzava
            // 
            this.lbl_drzava.AutoSize = true;
            this.lbl_drzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_drzava.Location = new System.Drawing.Point(11, 325);
            this.lbl_drzava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_drzava.Name = "lbl_drzava";
            this.lbl_drzava.Size = new System.Drawing.Size(59, 20);
            this.lbl_drzava.TabIndex = 105;
            this.lbl_drzava.Text = "drzava";
            // 
            // lbl_mesto
            // 
            this.lbl_mesto.AutoSize = true;
            this.lbl_mesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mesto.Location = new System.Drawing.Point(11, 274);
            this.lbl_mesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mesto.Name = "lbl_mesto";
            this.lbl_mesto.Size = new System.Drawing.Size(55, 20);
            this.lbl_mesto.TabIndex = 104;
            this.lbl_mesto.Text = "mesto";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 400);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker1.TabIndex = 102;
            // 
            // tb_br_rezervisanih
            // 
            this.tb_br_rezervisanih.Location = new System.Drawing.Point(169, 349);
            this.tb_br_rezervisanih.Margin = new System.Windows.Forms.Padding(4);
            this.tb_br_rezervisanih.Name = "tb_br_rezervisanih";
            this.tb_br_rezervisanih.Size = new System.Drawing.Size(132, 22);
            this.tb_br_rezervisanih.TabIndex = 101;
            // 
            // tb_br_dana
            // 
            this.tb_br_dana.Location = new System.Drawing.Point(169, 297);
            this.tb_br_dana.Margin = new System.Windows.Forms.Padding(4);
            this.tb_br_dana.Name = "tb_br_dana";
            this.tb_br_dana.Size = new System.Drawing.Size(132, 22);
            this.tb_br_dana.TabIndex = 100;
            // 
            // tb_drzava
            // 
            this.tb_drzava.Location = new System.Drawing.Point(11, 349);
            this.tb_drzava.Margin = new System.Windows.Forms.Padding(4);
            this.tb_drzava.Name = "tb_drzava";
            this.tb_drzava.Size = new System.Drawing.Size(132, 22);
            this.tb_drzava.TabIndex = 97;
            // 
            // tb_mesto
            // 
            this.tb_mesto.Location = new System.Drawing.Point(11, 297);
            this.tb_mesto.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mesto.Name = "tb_mesto";
            this.tb_mesto.Size = new System.Drawing.Size(132, 22);
            this.tb_mesto.TabIndex = 96;
            // 
            // Klijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "Klijent";
            this.Text = "Klijent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Klijent_FormClosed);
            this.Load += new System.EventHandler(this.Klijent_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button odjava3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button obrisi_rezervaciju;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button izmeni_rezervaciju;
        private System.Windows.Forms.Button dodaj_rezervaciju;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzava;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_polaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn br_dana;
        private System.Windows.Forms.DataGridViewTextBoxColumn br_rezervisanih;
        private System.Windows.Forms.DataGridViewTextBoxColumn uk_cena;
        private System.Windows.Forms.Label lbl_datum_polaska;
        private System.Windows.Forms.Label lbl_uk_mesta;
        private System.Windows.Forms.Label lbl_br_dana;
        private System.Windows.Forms.Label lbl_drzava;
        private System.Windows.Forms.Label lbl_mesto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tb_br_rezervisanih;
        private System.Windows.Forms.TextBox tb_br_dana;
        private System.Windows.Forms.TextBox tb_drzava;
        private System.Windows.Forms.TextBox tb_mesto;
    }
}