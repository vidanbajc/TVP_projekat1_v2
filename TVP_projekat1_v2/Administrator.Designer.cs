namespace TVP_projekat1_v2
{
    partial class Administrator
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
            this.Korisnici_str = new System.Windows.Forms.TabPage();
            this.lbl_vrsta_korisnika = new System.Windows.Forms.Label();
            this.lbl_lozinka = new System.Windows.Forms.Label();
            this.lbl_korisnicko_ime = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_id_korisnika = new System.Windows.Forms.Label();
            this.tb_vrsta = new System.Windows.Forms.TextBox();
            this.tb_lozinka = new System.Windows.Forms.TextBox();
            this.tb_korisnicko_ime = new System.Windows.Forms.TextBox();
            this.tb_prezime = new System.Windows.Forms.TextBox();
            this.tb_ime = new System.Windows.Forms.TextBox();
            this.tb_id_korisnik = new System.Windows.Forms.TextBox();
            this.odjava1 = new System.Windows.Forms.Button();
            this.obrisi_korisnika = new System.Windows.Forms.Button();
            this.izmeni_korisnika = new System.Windows.Forms.Button();
            this.dodaj_korisnika = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_korisnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnicko_ime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrsta_korisnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destinacije_str = new System.Windows.Forms.TabPage();
            this.lbl_datum_destinacija = new System.Windows.Forms.Label();
            this.lbl_uk_mesta = new System.Windows.Forms.Label();
            this.lbl_br_dana = new System.Windows.Forms.Label();
            this.lbl_popust = new System.Windows.Forms.Label();
            this.lbl_cena = new System.Windows.Forms.Label();
            this.lbl_drzava = new System.Windows.Forms.Label();
            this.lbl_mesto = new System.Windows.Forms.Label();
            this.lbl_id_destinacije = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tb_uk_mesta = new System.Windows.Forms.TextBox();
            this.tb_br_dana = new System.Windows.Forms.TextBox();
            this.tb_popust = new System.Windows.Forms.TextBox();
            this.tb_cena = new System.Windows.Forms.TextBox();
            this.tb_drzava = new System.Windows.Forms.TextBox();
            this.tb_mesto = new System.Windows.Forms.TextBox();
            this.tb_id_destinacije = new System.Windows.Forms.TextBox();
            this.odjava2 = new System.Windows.Forms.Button();
            this.obrisi_destinaciju = new System.Windows.Forms.Button();
            this.izmeni_destinaciju = new System.Windows.Forms.Button();
            this.dodaj_destinaciju = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_destinacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.br_dana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uk_mesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_polaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezervacije_str = new System.Windows.Forms.TabPage();
            this.lbl_br_rezervisanih_mesta = new System.Windows.Forms.Label();
            this.lbl_uk_cena = new System.Windows.Forms.Label();
            this.lbl_id_destinacije_r = new System.Windows.Forms.Label();
            this.lbl_id_korisnika_r = new System.Windows.Forms.Label();
            this.tb_br_rezervisanih_mesta = new System.Windows.Forms.TextBox();
            this.tb_uk_cena = new System.Windows.Forms.TextBox();
            this.tb_id_destinacije_r = new System.Windows.Forms.TextBox();
            this.tb_id_korisnika_r = new System.Windows.Forms.TextBox();
            this.odjava3 = new System.Windows.Forms.Button();
            this.obrisi_rezervaciju = new System.Windows.Forms.Button();
            this.izmeni_rezervaciju = new System.Windows.Forms.Button();
            this.dodaj_rezervaciju = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.id_korisnika_r = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_destinacije_r = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uk_cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.br_rezervisanih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_vreme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Korisnici_str.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Destinacije_str.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Rezervacije_str.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Korisnici_str);
            this.tabControl1.Controls.Add(this.Destinacije_str);
            this.tabControl1.Controls.Add(this.Rezervacije_str);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(732, 533);
            this.tabControl1.TabIndex = 0;
            // 
            // Korisnici_str
            // 
            this.Korisnici_str.Controls.Add(this.lbl_vrsta_korisnika);
            this.Korisnici_str.Controls.Add(this.lbl_lozinka);
            this.Korisnici_str.Controls.Add(this.lbl_korisnicko_ime);
            this.Korisnici_str.Controls.Add(this.lbl_prezime);
            this.Korisnici_str.Controls.Add(this.lbl_ime);
            this.Korisnici_str.Controls.Add(this.lbl_id_korisnika);
            this.Korisnici_str.Controls.Add(this.tb_vrsta);
            this.Korisnici_str.Controls.Add(this.tb_lozinka);
            this.Korisnici_str.Controls.Add(this.tb_korisnicko_ime);
            this.Korisnici_str.Controls.Add(this.tb_prezime);
            this.Korisnici_str.Controls.Add(this.tb_ime);
            this.Korisnici_str.Controls.Add(this.tb_id_korisnik);
            this.Korisnici_str.Controls.Add(this.odjava1);
            this.Korisnici_str.Controls.Add(this.obrisi_korisnika);
            this.Korisnici_str.Controls.Add(this.izmeni_korisnika);
            this.Korisnici_str.Controls.Add(this.dodaj_korisnika);
            this.Korisnici_str.Controls.Add(this.label1);
            this.Korisnici_str.Controls.Add(this.dataGridView1);
            this.Korisnici_str.Location = new System.Drawing.Point(4, 25);
            this.Korisnici_str.Name = "Korisnici_str";
            this.Korisnici_str.Padding = new System.Windows.Forms.Padding(3);
            this.Korisnici_str.Size = new System.Drawing.Size(724, 504);
            this.Korisnici_str.TabIndex = 0;
            this.Korisnici_str.Text = "Korisnici";
            this.Korisnici_str.UseVisualStyleBackColor = true;
            // 
            // lbl_vrsta_korisnika
            // 
            this.lbl_vrsta_korisnika.AutoSize = true;
            this.lbl_vrsta_korisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vrsta_korisnika.Location = new System.Drawing.Point(173, 345);
            this.lbl_vrsta_korisnika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vrsta_korisnika.Name = "lbl_vrsta_korisnika";
            this.lbl_vrsta_korisnika.Size = new System.Drawing.Size(46, 20);
            this.lbl_vrsta_korisnika.TabIndex = 49;
            this.lbl_vrsta_korisnika.Text = "vrsta";
            // 
            // lbl_lozinka
            // 
            this.lbl_lozinka.AutoSize = true;
            this.lbl_lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lozinka.Location = new System.Drawing.Point(173, 293);
            this.lbl_lozinka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lozinka.Name = "lbl_lozinka";
            this.lbl_lozinka.Size = new System.Drawing.Size(61, 20);
            this.lbl_lozinka.TabIndex = 48;
            this.lbl_lozinka.Text = "lozinka";
            // 
            // lbl_korisnicko_ime
            // 
            this.lbl_korisnicko_ime.AutoSize = true;
            this.lbl_korisnicko_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_korisnicko_ime.Location = new System.Drawing.Point(12, 448);
            this.lbl_korisnicko_ime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_korisnicko_ime.Name = "lbl_korisnicko_ime";
            this.lbl_korisnicko_ime.Size = new System.Drawing.Size(116, 20);
            this.lbl_korisnicko_ime.TabIndex = 47;
            this.lbl_korisnicko_ime.Text = "korisnicko ime";
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prezime.Location = new System.Drawing.Point(12, 396);
            this.lbl_prezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(69, 20);
            this.lbl_prezime.TabIndex = 46;
            this.lbl_prezime.Text = "prezime";
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ime.Location = new System.Drawing.Point(12, 345);
            this.lbl_ime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(36, 20);
            this.lbl_ime.TabIndex = 45;
            this.lbl_ime.Text = "ime";
            // 
            // lbl_id_korisnika
            // 
            this.lbl_id_korisnika.AutoSize = true;
            this.lbl_id_korisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_korisnika.Location = new System.Drawing.Point(12, 293);
            this.lbl_id_korisnika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_korisnika.Name = "lbl_id_korisnika";
            this.lbl_id_korisnika.Size = new System.Drawing.Size(22, 20);
            this.lbl_id_korisnika.TabIndex = 44;
            this.lbl_id_korisnika.Text = "id";
            // 
            // tb_vrsta
            // 
            this.tb_vrsta.Location = new System.Drawing.Point(173, 368);
            this.tb_vrsta.Margin = new System.Windows.Forms.Padding(4);
            this.tb_vrsta.Name = "tb_vrsta";
            this.tb_vrsta.Size = new System.Drawing.Size(132, 22);
            this.tb_vrsta.TabIndex = 41;
            // 
            // tb_lozinka
            // 
            this.tb_lozinka.Location = new System.Drawing.Point(173, 316);
            this.tb_lozinka.Margin = new System.Windows.Forms.Padding(4);
            this.tb_lozinka.Name = "tb_lozinka";
            this.tb_lozinka.PasswordChar = '*';
            this.tb_lozinka.Size = new System.Drawing.Size(132, 22);
            this.tb_lozinka.TabIndex = 40;
            // 
            // tb_korisnicko_ime
            // 
            this.tb_korisnicko_ime.Location = new System.Drawing.Point(12, 471);
            this.tb_korisnicko_ime.Margin = new System.Windows.Forms.Padding(4);
            this.tb_korisnicko_ime.Name = "tb_korisnicko_ime";
            this.tb_korisnicko_ime.Size = new System.Drawing.Size(132, 22);
            this.tb_korisnicko_ime.TabIndex = 39;
            // 
            // tb_prezime
            // 
            this.tb_prezime.Location = new System.Drawing.Point(12, 420);
            this.tb_prezime.Margin = new System.Windows.Forms.Padding(4);
            this.tb_prezime.Name = "tb_prezime";
            this.tb_prezime.Size = new System.Drawing.Size(132, 22);
            this.tb_prezime.TabIndex = 38;
            // 
            // tb_ime
            // 
            this.tb_ime.Location = new System.Drawing.Point(12, 368);
            this.tb_ime.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ime.Name = "tb_ime";
            this.tb_ime.Size = new System.Drawing.Size(132, 22);
            this.tb_ime.TabIndex = 37;
            // 
            // tb_id_korisnik
            // 
            this.tb_id_korisnik.Location = new System.Drawing.Point(12, 316);
            this.tb_id_korisnik.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id_korisnik.Name = "tb_id_korisnik";
            this.tb_id_korisnik.Size = new System.Drawing.Size(132, 22);
            this.tb_id_korisnik.TabIndex = 36;
            // 
            // odjava1
            // 
            this.odjava1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odjava1.Location = new System.Drawing.Point(533, 406);
            this.odjava1.Margin = new System.Windows.Forms.Padding(4);
            this.odjava1.Name = "odjava1";
            this.odjava1.Size = new System.Drawing.Size(133, 49);
            this.odjava1.TabIndex = 35;
            this.odjava1.Text = "Odjavi se";
            this.odjava1.UseVisualStyleBackColor = true;
            this.odjava1.Click += new System.EventHandler(this.odjava1_Click);
            // 
            // obrisi_korisnika
            // 
            this.obrisi_korisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisi_korisnika.Location = new System.Drawing.Point(533, 349);
            this.obrisi_korisnika.Margin = new System.Windows.Forms.Padding(4);
            this.obrisi_korisnika.Name = "obrisi_korisnika";
            this.obrisi_korisnika.Size = new System.Drawing.Size(133, 49);
            this.obrisi_korisnika.TabIndex = 34;
            this.obrisi_korisnika.Text = "Obrisi";
            this.obrisi_korisnika.UseVisualStyleBackColor = true;
            this.obrisi_korisnika.Click += new System.EventHandler(this.obrisi_korisnika_Click);
            // 
            // izmeni_korisnika
            // 
            this.izmeni_korisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izmeni_korisnika.Location = new System.Drawing.Point(391, 406);
            this.izmeni_korisnika.Margin = new System.Windows.Forms.Padding(4);
            this.izmeni_korisnika.Name = "izmeni_korisnika";
            this.izmeni_korisnika.Size = new System.Drawing.Size(133, 49);
            this.izmeni_korisnika.TabIndex = 33;
            this.izmeni_korisnika.Text = "Izmeni";
            this.izmeni_korisnika.UseVisualStyleBackColor = true;
            this.izmeni_korisnika.Click += new System.EventHandler(this.izmeni_korisnika_Click);
            // 
            // dodaj_korisnika
            // 
            this.dodaj_korisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj_korisnika.Location = new System.Drawing.Point(391, 349);
            this.dodaj_korisnika.Margin = new System.Windows.Forms.Padding(4);
            this.dodaj_korisnika.Name = "dodaj_korisnika";
            this.dodaj_korisnika.Size = new System.Drawing.Size(133, 49);
            this.dodaj_korisnika.TabIndex = 32;
            this.dodaj_korisnika.Text = "Dodaj";
            this.dodaj_korisnika.UseVisualStyleBackColor = true;
            this.dodaj_korisnika.Click += new System.EventHandler(this.dodaj_korisnika_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ulogovani ste ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_korisnika,
            this.ime,
            this.prezime,
            this.korisnicko_ime1,
            this.lozinka,
            this.vrsta_korisnika});
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(703, 207);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // id_korisnika
            // 
            this.id_korisnika.DataPropertyName = "id_korisnika";
            this.id_korisnika.HeaderText = "id";
            this.id_korisnika.MinimumWidth = 6;
            this.id_korisnika.Name = "id_korisnika";
            this.id_korisnika.Width = 47;
            // 
            // ime
            // 
            this.ime.DataPropertyName = "ime";
            this.ime.HeaderText = "ime";
            this.ime.MinimumWidth = 6;
            this.ime.Name = "ime";
            this.ime.Width = 58;
            // 
            // prezime
            // 
            this.prezime.DataPropertyName = "prezime";
            this.prezime.HeaderText = "prezime";
            this.prezime.MinimumWidth = 6;
            this.prezime.Name = "prezime";
            this.prezime.Width = 84;
            // 
            // korisnicko_ime1
            // 
            this.korisnicko_ime1.DataPropertyName = "korisnicko_ime1";
            this.korisnicko_ime1.HeaderText = "korisnicko ime";
            this.korisnicko_ime1.MinimumWidth = 6;
            this.korisnicko_ime1.Name = "korisnicko_ime1";
            this.korisnicko_ime1.Width = 122;
            // 
            // lozinka
            // 
            this.lozinka.DataPropertyName = "lozinka";
            this.lozinka.HeaderText = "lozinka";
            this.lozinka.MinimumWidth = 6;
            this.lozinka.Name = "lozinka";
            this.lozinka.Width = 78;
            // 
            // vrsta_korisnika
            // 
            this.vrsta_korisnika.DataPropertyName = "vrsta_korisnika";
            this.vrsta_korisnika.HeaderText = "vrsta";
            this.vrsta_korisnika.MinimumWidth = 6;
            this.vrsta_korisnika.Name = "vrsta_korisnika";
            this.vrsta_korisnika.Width = 65;
            // 
            // Destinacije_str
            // 
            this.Destinacije_str.Controls.Add(this.lbl_datum_destinacija);
            this.Destinacije_str.Controls.Add(this.lbl_uk_mesta);
            this.Destinacije_str.Controls.Add(this.lbl_br_dana);
            this.Destinacije_str.Controls.Add(this.lbl_popust);
            this.Destinacije_str.Controls.Add(this.lbl_cena);
            this.Destinacije_str.Controls.Add(this.lbl_drzava);
            this.Destinacije_str.Controls.Add(this.lbl_mesto);
            this.Destinacije_str.Controls.Add(this.lbl_id_destinacije);
            this.Destinacije_str.Controls.Add(this.dateTimePicker2);
            this.Destinacije_str.Controls.Add(this.tb_uk_mesta);
            this.Destinacije_str.Controls.Add(this.tb_br_dana);
            this.Destinacije_str.Controls.Add(this.tb_popust);
            this.Destinacije_str.Controls.Add(this.tb_cena);
            this.Destinacije_str.Controls.Add(this.tb_drzava);
            this.Destinacije_str.Controls.Add(this.tb_mesto);
            this.Destinacije_str.Controls.Add(this.tb_id_destinacije);
            this.Destinacije_str.Controls.Add(this.odjava2);
            this.Destinacije_str.Controls.Add(this.obrisi_destinaciju);
            this.Destinacije_str.Controls.Add(this.izmeni_destinaciju);
            this.Destinacije_str.Controls.Add(this.dodaj_destinaciju);
            this.Destinacije_str.Controls.Add(this.label18);
            this.Destinacije_str.Controls.Add(this.dataGridView2);
            this.Destinacije_str.Location = new System.Drawing.Point(4, 25);
            this.Destinacije_str.Name = "Destinacije_str";
            this.Destinacije_str.Padding = new System.Windows.Forms.Padding(3);
            this.Destinacije_str.Size = new System.Drawing.Size(724, 504);
            this.Destinacije_str.TabIndex = 1;
            this.Destinacije_str.Text = "Destinacije/Izleti";
            this.Destinacije_str.UseVisualStyleBackColor = true;
            // 
            // lbl_datum_destinacija
            // 
            this.lbl_datum_destinacija.AutoSize = true;
            this.lbl_datum_destinacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datum_destinacija.Location = new System.Drawing.Point(174, 446);
            this.lbl_datum_destinacija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_datum_destinacija.Name = "lbl_datum_destinacija";
            this.lbl_datum_destinacija.Size = new System.Drawing.Size(55, 20);
            this.lbl_datum_destinacija.TabIndex = 73;
            this.lbl_datum_destinacija.Text = "datum";
            // 
            // lbl_uk_mesta
            // 
            this.lbl_uk_mesta.AutoSize = true;
            this.lbl_uk_mesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uk_mesta.Location = new System.Drawing.Point(174, 394);
            this.lbl_uk_mesta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_uk_mesta.Name = "lbl_uk_mesta";
            this.lbl_uk_mesta.Size = new System.Drawing.Size(113, 20);
            this.lbl_uk_mesta.TabIndex = 72;
            this.lbl_uk_mesta.Text = "ukupno mesta";
            // 
            // lbl_br_dana
            // 
            this.lbl_br_dana.AutoSize = true;
            this.lbl_br_dana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_br_dana.Location = new System.Drawing.Point(174, 343);
            this.lbl_br_dana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_br_dana.Name = "lbl_br_dana";
            this.lbl_br_dana.Size = new System.Drawing.Size(78, 20);
            this.lbl_br_dana.TabIndex = 71;
            this.lbl_br_dana.Text = "broj dana";
            // 
            // lbl_popust
            // 
            this.lbl_popust.AutoSize = true;
            this.lbl_popust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_popust.Location = new System.Drawing.Point(174, 291);
            this.lbl_popust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_popust.Name = "lbl_popust";
            this.lbl_popust.Size = new System.Drawing.Size(59, 20);
            this.lbl_popust.TabIndex = 70;
            this.lbl_popust.Text = "popust";
            // 
            // lbl_cena
            // 
            this.lbl_cena.AutoSize = true;
            this.lbl_cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cena.Location = new System.Drawing.Point(13, 446);
            this.lbl_cena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cena.Name = "lbl_cena";
            this.lbl_cena.Size = new System.Drawing.Size(45, 20);
            this.lbl_cena.TabIndex = 69;
            this.lbl_cena.Text = "cena";
            // 
            // lbl_drzava
            // 
            this.lbl_drzava.AutoSize = true;
            this.lbl_drzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_drzava.Location = new System.Drawing.Point(13, 394);
            this.lbl_drzava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_drzava.Name = "lbl_drzava";
            this.lbl_drzava.Size = new System.Drawing.Size(59, 20);
            this.lbl_drzava.TabIndex = 68;
            this.lbl_drzava.Text = "drzava";
            // 
            // lbl_mesto
            // 
            this.lbl_mesto.AutoSize = true;
            this.lbl_mesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mesto.Location = new System.Drawing.Point(13, 343);
            this.lbl_mesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mesto.Name = "lbl_mesto";
            this.lbl_mesto.Size = new System.Drawing.Size(55, 20);
            this.lbl_mesto.TabIndex = 67;
            this.lbl_mesto.Text = "mesto";
            // 
            // lbl_id_destinacije
            // 
            this.lbl_id_destinacije.AutoSize = true;
            this.lbl_id_destinacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_destinacije.Location = new System.Drawing.Point(13, 291);
            this.lbl_id_destinacije.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_destinacije.Name = "lbl_id_destinacije";
            this.lbl_id_destinacije.Size = new System.Drawing.Size(22, 20);
            this.lbl_id_destinacije.TabIndex = 66;
            this.lbl_id_destinacije.Text = "id";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(174, 469);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker2.TabIndex = 65;
            // 
            // tb_uk_mesta
            // 
            this.tb_uk_mesta.Location = new System.Drawing.Point(174, 418);
            this.tb_uk_mesta.Margin = new System.Windows.Forms.Padding(4);
            this.tb_uk_mesta.Name = "tb_uk_mesta";
            this.tb_uk_mesta.Size = new System.Drawing.Size(132, 22);
            this.tb_uk_mesta.TabIndex = 64;
            // 
            // tb_br_dana
            // 
            this.tb_br_dana.Location = new System.Drawing.Point(174, 366);
            this.tb_br_dana.Margin = new System.Windows.Forms.Padding(4);
            this.tb_br_dana.Name = "tb_br_dana";
            this.tb_br_dana.Size = new System.Drawing.Size(132, 22);
            this.tb_br_dana.TabIndex = 63;
            // 
            // tb_popust
            // 
            this.tb_popust.Location = new System.Drawing.Point(174, 314);
            this.tb_popust.Margin = new System.Windows.Forms.Padding(4);
            this.tb_popust.Name = "tb_popust";
            this.tb_popust.Size = new System.Drawing.Size(132, 22);
            this.tb_popust.TabIndex = 62;
            // 
            // tb_cena
            // 
            this.tb_cena.Location = new System.Drawing.Point(13, 469);
            this.tb_cena.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cena.Name = "tb_cena";
            this.tb_cena.Size = new System.Drawing.Size(132, 22);
            this.tb_cena.TabIndex = 61;
            // 
            // tb_drzava
            // 
            this.tb_drzava.Location = new System.Drawing.Point(13, 418);
            this.tb_drzava.Margin = new System.Windows.Forms.Padding(4);
            this.tb_drzava.Name = "tb_drzava";
            this.tb_drzava.Size = new System.Drawing.Size(132, 22);
            this.tb_drzava.TabIndex = 60;
            // 
            // tb_mesto
            // 
            this.tb_mesto.Location = new System.Drawing.Point(13, 366);
            this.tb_mesto.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mesto.Name = "tb_mesto";
            this.tb_mesto.Size = new System.Drawing.Size(132, 22);
            this.tb_mesto.TabIndex = 59;
            // 
            // tb_id_destinacije
            // 
            this.tb_id_destinacije.Location = new System.Drawing.Point(13, 314);
            this.tb_id_destinacije.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id_destinacije.Name = "tb_id_destinacije";
            this.tb_id_destinacije.Size = new System.Drawing.Size(132, 22);
            this.tb_id_destinacije.TabIndex = 58;
            // 
            // odjava2
            // 
            this.odjava2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odjava2.Location = new System.Drawing.Point(534, 404);
            this.odjava2.Margin = new System.Windows.Forms.Padding(4);
            this.odjava2.Name = "odjava2";
            this.odjava2.Size = new System.Drawing.Size(133, 49);
            this.odjava2.TabIndex = 57;
            this.odjava2.Text = "Odjavi se";
            this.odjava2.UseVisualStyleBackColor = true;
            this.odjava2.Click += new System.EventHandler(this.odjava2_Click);
            // 
            // obrisi_destinaciju
            // 
            this.obrisi_destinaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisi_destinaciju.Location = new System.Drawing.Point(534, 347);
            this.obrisi_destinaciju.Margin = new System.Windows.Forms.Padding(4);
            this.obrisi_destinaciju.Name = "obrisi_destinaciju";
            this.obrisi_destinaciju.Size = new System.Drawing.Size(133, 49);
            this.obrisi_destinaciju.TabIndex = 56;
            this.obrisi_destinaciju.Text = "Obrisi";
            this.obrisi_destinaciju.UseVisualStyleBackColor = true;
            this.obrisi_destinaciju.Click += new System.EventHandler(this.obrisi_destinaciju_Click);
            // 
            // izmeni_destinaciju
            // 
            this.izmeni_destinaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izmeni_destinaciju.Location = new System.Drawing.Point(392, 404);
            this.izmeni_destinaciju.Margin = new System.Windows.Forms.Padding(4);
            this.izmeni_destinaciju.Name = "izmeni_destinaciju";
            this.izmeni_destinaciju.Size = new System.Drawing.Size(133, 49);
            this.izmeni_destinaciju.TabIndex = 55;
            this.izmeni_destinaciju.Text = "Izmeni";
            this.izmeni_destinaciju.UseVisualStyleBackColor = true;
            this.izmeni_destinaciju.Click += new System.EventHandler(this.izmeni_destinaciju_Click);
            // 
            // dodaj_destinaciju
            // 
            this.dodaj_destinaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj_destinaciju.Location = new System.Drawing.Point(392, 347);
            this.dodaj_destinaciju.Margin = new System.Windows.Forms.Padding(4);
            this.dodaj_destinaciju.Name = "dodaj_destinaciju";
            this.dodaj_destinaciju.Size = new System.Drawing.Size(133, 49);
            this.dodaj_destinaciju.TabIndex = 54;
            this.dodaj_destinaciju.Text = "Dodaj";
            this.dodaj_destinaciju.UseVisualStyleBackColor = true;
            this.dodaj_destinaciju.Click += new System.EventHandler(this.dodaj_destinaciju_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 13);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(179, 29);
            this.label18.TabIndex = 53;
            this.label18.Text = "Ulogovani ste ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_destinacije,
            this.mesto,
            this.drzava,
            this.cena,
            this.popust,
            this.br_dana,
            this.uk_mesta,
            this.datum_polaska});
            this.dataGridView2.Location = new System.Drawing.Point(13, 59);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(703, 207);
            this.dataGridView2.TabIndex = 52;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // id_destinacije
            // 
            this.id_destinacije.DataPropertyName = "id_destinacije";
            this.id_destinacije.HeaderText = "id";
            this.id_destinacije.MinimumWidth = 6;
            this.id_destinacije.Name = "id_destinacije";
            this.id_destinacije.Width = 47;
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
            // cena
            // 
            this.cena.DataPropertyName = "cena";
            this.cena.HeaderText = "cena";
            this.cena.MinimumWidth = 6;
            this.cena.Name = "cena";
            this.cena.Width = 66;
            // 
            // popust
            // 
            this.popust.DataPropertyName = "popust";
            this.popust.HeaderText = "popust";
            this.popust.MinimumWidth = 6;
            this.popust.Name = "popust";
            this.popust.Width = 77;
            // 
            // br_dana
            // 
            this.br_dana.DataPropertyName = "br_dana";
            this.br_dana.HeaderText = "broj dana";
            this.br_dana.MinimumWidth = 6;
            this.br_dana.Name = "br_dana";
            this.br_dana.Width = 93;
            // 
            // uk_mesta
            // 
            this.uk_mesta.DataPropertyName = "uk_mesta";
            this.uk_mesta.HeaderText = "ukupno mesta";
            this.uk_mesta.MinimumWidth = 6;
            this.uk_mesta.Name = "uk_mesta";
            this.uk_mesta.Width = 120;
            // 
            // datum_polaska
            // 
            this.datum_polaska.DataPropertyName = "datum_polaska";
            this.datum_polaska.HeaderText = "datum";
            this.datum_polaska.MinimumWidth = 6;
            this.datum_polaska.Name = "datum_polaska";
            this.datum_polaska.Width = 73;
            // 
            // Rezervacije_str
            // 
            this.Rezervacije_str.Controls.Add(this.lbl_br_rezervisanih_mesta);
            this.Rezervacije_str.Controls.Add(this.lbl_uk_cena);
            this.Rezervacije_str.Controls.Add(this.lbl_id_destinacije_r);
            this.Rezervacije_str.Controls.Add(this.lbl_id_korisnika_r);
            this.Rezervacije_str.Controls.Add(this.tb_br_rezervisanih_mesta);
            this.Rezervacije_str.Controls.Add(this.tb_uk_cena);
            this.Rezervacije_str.Controls.Add(this.tb_id_destinacije_r);
            this.Rezervacije_str.Controls.Add(this.tb_id_korisnika_r);
            this.Rezervacije_str.Controls.Add(this.odjava3);
            this.Rezervacije_str.Controls.Add(this.obrisi_rezervaciju);
            this.Rezervacije_str.Controls.Add(this.izmeni_rezervaciju);
            this.Rezervacije_str.Controls.Add(this.dodaj_rezervaciju);
            this.Rezervacije_str.Controls.Add(this.label27);
            this.Rezervacije_str.Controls.Add(this.dataGridView3);
            this.Rezervacije_str.Location = new System.Drawing.Point(4, 25);
            this.Rezervacije_str.Name = "Rezervacije_str";
            this.Rezervacije_str.Padding = new System.Windows.Forms.Padding(3);
            this.Rezervacije_str.Size = new System.Drawing.Size(724, 504);
            this.Rezervacije_str.TabIndex = 2;
            this.Rezervacije_str.Text = "Rezervacije";
            this.Rezervacije_str.UseVisualStyleBackColor = true;
            // 
            // lbl_br_rezervisanih_mesta
            // 
            this.lbl_br_rezervisanih_mesta.AutoSize = true;
            this.lbl_br_rezervisanih_mesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_br_rezervisanih_mesta.Location = new System.Drawing.Point(13, 446);
            this.lbl_br_rezervisanih_mesta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_br_rezervisanih_mesta.Name = "lbl_br_rezervisanih_mesta";
            this.lbl_br_rezervisanih_mesta.Size = new System.Drawing.Size(184, 20);
            this.lbl_br_rezervisanih_mesta.TabIndex = 91;
            this.lbl_br_rezervisanih_mesta.Text = "broj rezervisanih mesta";
            // 
            // lbl_uk_cena
            // 
            this.lbl_uk_cena.AutoSize = true;
            this.lbl_uk_cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uk_cena.Location = new System.Drawing.Point(13, 394);
            this.lbl_uk_cena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_uk_cena.Name = "lbl_uk_cena";
            this.lbl_uk_cena.Size = new System.Drawing.Size(103, 20);
            this.lbl_uk_cena.TabIndex = 90;
            this.lbl_uk_cena.Text = "ukupna cena";
            // 
            // lbl_id_destinacije_r
            // 
            this.lbl_id_destinacije_r.AutoSize = true;
            this.lbl_id_destinacije_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_destinacije_r.Location = new System.Drawing.Point(13, 343);
            this.lbl_id_destinacije_r.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_destinacije_r.Name = "lbl_id_destinacije_r";
            this.lbl_id_destinacije_r.Size = new System.Drawing.Size(107, 20);
            this.lbl_id_destinacije_r.TabIndex = 89;
            this.lbl_id_destinacije_r.Text = "id destinacije";
            // 
            // lbl_id_korisnika_r
            // 
            this.lbl_id_korisnika_r.AutoSize = true;
            this.lbl_id_korisnika_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_korisnika_r.Location = new System.Drawing.Point(13, 291);
            this.lbl_id_korisnika_r.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_korisnika_r.Name = "lbl_id_korisnika_r";
            this.lbl_id_korisnika_r.Size = new System.Drawing.Size(93, 20);
            this.lbl_id_korisnika_r.TabIndex = 88;
            this.lbl_id_korisnika_r.Text = "id korisnika";
            // 
            // tb_br_rezervisanih_mesta
            // 
            this.tb_br_rezervisanih_mesta.Location = new System.Drawing.Point(13, 469);
            this.tb_br_rezervisanih_mesta.Margin = new System.Windows.Forms.Padding(4);
            this.tb_br_rezervisanih_mesta.Name = "tb_br_rezervisanih_mesta";
            this.tb_br_rezervisanih_mesta.Size = new System.Drawing.Size(132, 22);
            this.tb_br_rezervisanih_mesta.TabIndex = 83;
            // 
            // tb_uk_cena
            // 
            this.tb_uk_cena.Location = new System.Drawing.Point(13, 418);
            this.tb_uk_cena.Margin = new System.Windows.Forms.Padding(4);
            this.tb_uk_cena.Name = "tb_uk_cena";
            this.tb_uk_cena.Size = new System.Drawing.Size(132, 22);
            this.tb_uk_cena.TabIndex = 82;
            // 
            // tb_id_destinacije_r
            // 
            this.tb_id_destinacije_r.Location = new System.Drawing.Point(13, 366);
            this.tb_id_destinacije_r.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id_destinacije_r.Name = "tb_id_destinacije_r";
            this.tb_id_destinacije_r.Size = new System.Drawing.Size(132, 22);
            this.tb_id_destinacije_r.TabIndex = 81;
            // 
            // tb_id_korisnika_r
            // 
            this.tb_id_korisnika_r.Location = new System.Drawing.Point(13, 314);
            this.tb_id_korisnika_r.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id_korisnika_r.Name = "tb_id_korisnika_r";
            this.tb_id_korisnika_r.Size = new System.Drawing.Size(132, 22);
            this.tb_id_korisnika_r.TabIndex = 80;
            // 
            // odjava3
            // 
            this.odjava3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odjava3.Location = new System.Drawing.Point(534, 404);
            this.odjava3.Margin = new System.Windows.Forms.Padding(4);
            this.odjava3.Name = "odjava3";
            this.odjava3.Size = new System.Drawing.Size(133, 49);
            this.odjava3.TabIndex = 79;
            this.odjava3.Text = "Odjavi se";
            this.odjava3.UseVisualStyleBackColor = true;
            this.odjava3.Click += new System.EventHandler(this.odjava3_Click);
            // 
            // obrisi_rezervaciju
            // 
            this.obrisi_rezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisi_rezervaciju.Location = new System.Drawing.Point(534, 347);
            this.obrisi_rezervaciju.Margin = new System.Windows.Forms.Padding(4);
            this.obrisi_rezervaciju.Name = "obrisi_rezervaciju";
            this.obrisi_rezervaciju.Size = new System.Drawing.Size(133, 49);
            this.obrisi_rezervaciju.TabIndex = 78;
            this.obrisi_rezervaciju.Text = "Obrisi";
            this.obrisi_rezervaciju.UseVisualStyleBackColor = true;
            this.obrisi_rezervaciju.Click += new System.EventHandler(this.obrisi_rezervaciju_Click);
            // 
            // izmeni_rezervaciju
            // 
            this.izmeni_rezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izmeni_rezervaciju.Location = new System.Drawing.Point(392, 404);
            this.izmeni_rezervaciju.Margin = new System.Windows.Forms.Padding(4);
            this.izmeni_rezervaciju.Name = "izmeni_rezervaciju";
            this.izmeni_rezervaciju.Size = new System.Drawing.Size(133, 49);
            this.izmeni_rezervaciju.TabIndex = 77;
            this.izmeni_rezervaciju.Text = "Izmeni";
            this.izmeni_rezervaciju.UseVisualStyleBackColor = true;
            this.izmeni_rezervaciju.Click += new System.EventHandler(this.izmeni_rezervaciju_Click);
            // 
            // dodaj_rezervaciju
            // 
            this.dodaj_rezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj_rezervaciju.Location = new System.Drawing.Point(392, 347);
            this.dodaj_rezervaciju.Margin = new System.Windows.Forms.Padding(4);
            this.dodaj_rezervaciju.Name = "dodaj_rezervaciju";
            this.dodaj_rezervaciju.Size = new System.Drawing.Size(133, 49);
            this.dodaj_rezervaciju.TabIndex = 76;
            this.dodaj_rezervaciju.Text = "Dodaj";
            this.dodaj_rezervaciju.UseVisualStyleBackColor = true;
            this.dodaj_rezervaciju.Click += new System.EventHandler(this.dodaj_rezervaciju_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(8, 13);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(179, 29);
            this.label27.TabIndex = 75;
            this.label27.Text = "Ulogovani ste ";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_korisnika_r,
            this.id_destinacije_r,
            this.uk_cena,
            this.br_rezervisanih,
            this.datum_vreme});
            this.dataGridView3.Location = new System.Drawing.Point(13, 59);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(702, 207);
            this.dataGridView3.TabIndex = 74;
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // id_korisnika_r
            // 
            this.id_korisnika_r.DataPropertyName = "id_korisnika_r";
            this.id_korisnika_r.HeaderText = "id korisnika";
            this.id_korisnika_r.MinimumWidth = 6;
            this.id_korisnika_r.Name = "id_korisnika_r";
            this.id_korisnika_r.Width = 96;
            // 
            // id_destinacije_r
            // 
            this.id_destinacije_r.DataPropertyName = "id_destinacije_r";
            this.id_destinacije_r.HeaderText = "id destinacije";
            this.id_destinacije_r.MinimumWidth = 6;
            this.id_destinacije_r.Name = "id_destinacije_r";
            this.id_destinacije_r.Width = 106;
            // 
            // uk_cena
            // 
            this.uk_cena.DataPropertyName = "uk_cena";
            this.uk_cena.HeaderText = "ukupna cena";
            this.uk_cena.MinimumWidth = 6;
            this.uk_cena.Name = "uk_cena";
            this.uk_cena.Width = 104;
            // 
            // br_rezervisanih
            // 
            this.br_rezervisanih.DataPropertyName = "br_rezervisanih";
            this.br_rezervisanih.HeaderText = "broj rezervisanih mesta";
            this.br_rezervisanih.MinimumWidth = 6;
            this.br_rezervisanih.Name = "br_rezervisanih";
            this.br_rezervisanih.Width = 159;
            // 
            // datum_vreme
            // 
            this.datum_vreme.DataPropertyName = "datum_vreme";
            this.datum_vreme.HeaderText = "datum i vreme";
            this.datum_vreme.MinimumWidth = 6;
            this.datum_vreme.Name = "datum_vreme";
            this.datum_vreme.Width = 110;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administrator_FormClosed_1);
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.tabControl1.ResumeLayout(false);
            this.Korisnici_str.ResumeLayout(false);
            this.Korisnici_str.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Destinacije_str.ResumeLayout(false);
            this.Destinacije_str.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Rezervacije_str.ResumeLayout(false);
            this.Rezervacije_str.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Korisnici_str;
        private System.Windows.Forms.TabPage Destinacije_str;
        private System.Windows.Forms.Label lbl_vrsta_korisnika;
        private System.Windows.Forms.Label lbl_lozinka;
        private System.Windows.Forms.Label lbl_korisnicko_ime;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_id_korisnika;
        private System.Windows.Forms.TextBox tb_vrsta;
        private System.Windows.Forms.TextBox tb_lozinka;
        private System.Windows.Forms.TextBox tb_korisnicko_ime;
        private System.Windows.Forms.TextBox tb_prezime;
        private System.Windows.Forms.TextBox tb_ime;
        private System.Windows.Forms.TextBox tb_id_korisnik;
        private System.Windows.Forms.Button odjava1;
        private System.Windows.Forms.Button obrisi_korisnika;
        private System.Windows.Forms.Button izmeni_korisnika;
        private System.Windows.Forms.Button dodaj_korisnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_datum_destinacija;
        private System.Windows.Forms.Label lbl_uk_mesta;
        private System.Windows.Forms.Label lbl_br_dana;
        private System.Windows.Forms.Label lbl_popust;
        private System.Windows.Forms.Label lbl_cena;
        private System.Windows.Forms.Label lbl_drzava;
        private System.Windows.Forms.Label lbl_mesto;
        private System.Windows.Forms.Label lbl_id_destinacije;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox tb_uk_mesta;
        private System.Windows.Forms.TextBox tb_br_dana;
        private System.Windows.Forms.TextBox tb_popust;
        private System.Windows.Forms.TextBox tb_cena;
        private System.Windows.Forms.TextBox tb_drzava;
        private System.Windows.Forms.TextBox tb_mesto;
        private System.Windows.Forms.TextBox tb_id_destinacije;
        private System.Windows.Forms.Button odjava2;
        private System.Windows.Forms.Button obrisi_destinaciju;
        private System.Windows.Forms.Button izmeni_destinaciju;
        private System.Windows.Forms.Button dodaj_destinaciju;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage Rezervacije_str;
        private System.Windows.Forms.Label lbl_br_rezervisanih_mesta;
        private System.Windows.Forms.Label lbl_uk_cena;
        private System.Windows.Forms.Label lbl_id_destinacije_r;
        private System.Windows.Forms.Label lbl_id_korisnika_r;
        private System.Windows.Forms.TextBox tb_br_rezervisanih_mesta;
        private System.Windows.Forms.TextBox tb_uk_cena;
        private System.Windows.Forms.TextBox tb_id_destinacije_r;
        private System.Windows.Forms.TextBox tb_id_korisnika_r;
        private System.Windows.Forms.Button odjava3;
        private System.Windows.Forms.Button obrisi_rezervaciju;
        private System.Windows.Forms.Button izmeni_rezervaciju;
        private System.Windows.Forms.Button dodaj_rezervaciju;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_korisnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnicko_ime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinka;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrsta_korisnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_destinacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzava;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn popust;
        private System.Windows.Forms.DataGridViewTextBoxColumn br_dana;
        private System.Windows.Forms.DataGridViewTextBoxColumn uk_mesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_polaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_korisnika_r;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_destinacije_r;
        private System.Windows.Forms.DataGridViewTextBoxColumn uk_cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn br_rezervisanih;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_vreme;
    }
}