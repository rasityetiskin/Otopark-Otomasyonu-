namespace OtoparkOtomasyon
{
    partial class Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbMenu = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtAracTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmArac = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAracDurum = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblUcret = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.btnSatırRaporu = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbAracGiris = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
            this.cbAbone = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbKontak = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAracTipi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPlaka = new Guna.UI2.WinForms.Guna2TextBox();
            this.minimizeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.FormMovement = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAracTable)).BeginInit();
            this.cmArac.SuspendLayout();
            this.gbAracDurum.SuspendLayout();
            this.gbAracGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbMenu.Controls.Add(this.dtAracTable);
            this.gbMenu.Controls.Add(this.gbAracDurum);
            this.gbMenu.Controls.Add(this.gbAracGiris);
            this.gbMenu.Controls.Add(this.minimizeBox);
            this.gbMenu.Controls.Add(this.closeBox);
            this.gbMenu.CustomBorderColor = System.Drawing.Color.Black;
            this.gbMenu.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.gbMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbMenu.ForeColor = System.Drawing.Color.White;
            this.gbMenu.Location = new System.Drawing.Point(0, 0);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(758, 500);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.Text = "Otopark Otomasyonu";
            this.gbMenu.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // dtAracTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dtAracTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtAracTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtAracTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtAracTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtAracTable.ContextMenuStrip = this.cmArac;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtAracTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtAracTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dtAracTable.Location = new System.Drawing.Point(7, 255);
            this.dtAracTable.Name = "dtAracTable";
            this.dtAracTable.ReadOnly = true;
            this.dtAracTable.RowHeadersVisible = false;
            this.dtAracTable.Size = new System.Drawing.Size(743, 236);
            this.dtAracTable.TabIndex = 4;
            this.dtAracTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dtAracTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dtAracTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtAracTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtAracTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtAracTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtAracTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtAracTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dtAracTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dtAracTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtAracTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtAracTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtAracTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtAracTable.ThemeStyle.HeaderStyle.Height = 23;
            this.dtAracTable.ThemeStyle.ReadOnly = true;
            this.dtAracTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dtAracTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtAracTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtAracTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtAracTable.ThemeStyle.RowsStyle.Height = 22;
            this.dtAracTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dtAracTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtAracTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAracTable_CellClick);
            // 
            // cmArac
            // 
            this.cmArac.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.cmArac.Name = "cmArac";
            this.cmArac.Size = new System.Drawing.Size(131, 28);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.çıkışYapToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // gbAracDurum
            // 
            this.gbAracDurum.BackColor = System.Drawing.Color.Transparent;
            this.gbAracDurum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(206)))), ((int)(((byte)(177)))));
            this.gbAracDurum.BorderRadius = 20;
            this.gbAracDurum.Controls.Add(this.lblUcret);
            this.gbAracDurum.Controls.Add(this.lblSaat);
            this.gbAracDurum.Controls.Add(this.lblPlaka);
            this.gbAracDurum.Controls.Add(this.btnSatırRaporu);
            this.gbAracDurum.Controls.Add(this.label4);
            this.gbAracDurum.Controls.Add(this.label3);
            this.gbAracDurum.Controls.Add(this.label2);
            this.gbAracDurum.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.gbAracDurum.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.gbAracDurum.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gbAracDurum.ForeColor = System.Drawing.Color.White;
            this.gbAracDurum.Location = new System.Drawing.Point(384, 47);
            this.gbAracDurum.Name = "gbAracDurum";
            this.gbAracDurum.Size = new System.Drawing.Size(366, 199);
            this.gbAracDurum.TabIndex = 3;
            this.gbAracDurum.Text = "Araç Durumu";
            this.gbAracDurum.TextOffset = new System.Drawing.Point(0, -6);
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcret.ForeColor = System.Drawing.Color.Black;
            this.lblUcret.Location = new System.Drawing.Point(67, 122);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(41, 23);
            this.lblUcret.TabIndex = 9;
            this.lblUcret.Text = "0 TL";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.Black;
            this.lblSaat.Location = new System.Drawing.Point(59, 84);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(57, 23);
            this.lblSaat.TabIndex = 8;
            this.lblSaat.Text = "0 Saat";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaka.ForeColor = System.Drawing.Color.Black;
            this.lblPlaka.Location = new System.Drawing.Point(123, 42);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(78, 23);
            this.lblPlaka.TabIndex = 7;
            this.lblPlaka.Text = "0 XX 000";
            // 
            // btnSatırRaporu
            // 
            this.btnSatırRaporu.BorderRadius = 15;
            this.btnSatırRaporu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSatırRaporu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSatırRaporu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSatırRaporu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSatırRaporu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.btnSatırRaporu.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSatırRaporu.ForeColor = System.Drawing.Color.White;
            this.btnSatırRaporu.Location = new System.Drawing.Point(14, 153);
            this.btnSatırRaporu.Name = "btnSatırRaporu";
            this.btnSatırRaporu.Size = new System.Drawing.Size(339, 39);
            this.btnSatırRaporu.TabIndex = 6;
            this.btnSatırRaporu.Text = "Günlük Satış Raporu";
            this.btnSatırRaporu.Click += new System.EventHandler(this.btnSatırRaporu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ücret : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Araç Plakası : ";
            // 
            // gbAracGiris
            // 
            this.gbAracGiris.BackColor = System.Drawing.Color.Transparent;
            this.gbAracGiris.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(206)))), ((int)(((byte)(177)))));
            this.gbAracGiris.BorderRadius = 20;
            this.gbAracGiris.Controls.Add(this.btnEkle);
            this.gbAracGiris.Controls.Add(this.cbAbone);
            this.gbAracGiris.Controls.Add(this.cbKontak);
            this.gbAracGiris.Controls.Add(this.label1);
            this.gbAracGiris.Controls.Add(this.cbAracTipi);
            this.gbAracGiris.Controls.Add(this.txtPlaka);
            this.gbAracGiris.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.gbAracGiris.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.gbAracGiris.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gbAracGiris.ForeColor = System.Drawing.Color.White;
            this.gbAracGiris.Location = new System.Drawing.Point(7, 47);
            this.gbAracGiris.Name = "gbAracGiris";
            this.gbAracGiris.Size = new System.Drawing.Size(366, 199);
            this.gbAracGiris.TabIndex = 2;
            this.gbAracGiris.Text = "Araç Girişi";
            this.gbAracGiris.TextOffset = new System.Drawing.Point(0, -6);
            // 
            // btnEkle
            // 
            this.btnEkle.BorderRadius = 15;
            this.btnEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEkle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(12, 153);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(339, 39);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Aracı Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbAbone
            // 
            this.cbAbone.AutoSize = true;
            this.cbAbone.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.cbAbone.CheckedState.BorderRadius = 0;
            this.cbAbone.CheckedState.BorderThickness = 0;
            this.cbAbone.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.cbAbone.ForeColor = System.Drawing.Color.Black;
            this.cbAbone.Location = new System.Drawing.Point(114, 122);
            this.cbAbone.Name = "cbAbone";
            this.cbAbone.Size = new System.Drawing.Size(68, 23);
            this.cbAbone.TabIndex = 4;
            this.cbAbone.Text = "Abone";
            this.cbAbone.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbAbone.UncheckedState.BorderRadius = 0;
            this.cbAbone.UncheckedState.BorderThickness = 0;
            this.cbAbone.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbAbone.CheckedChanged += new System.EventHandler(this.cbAbone_CheckedChanged);
            // 
            // cbKontak
            // 
            this.cbKontak.AutoSize = true;
            this.cbKontak.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.cbKontak.CheckedState.BorderRadius = 0;
            this.cbKontak.CheckedState.BorderThickness = 0;
            this.cbKontak.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.cbKontak.ForeColor = System.Drawing.Color.Black;
            this.cbKontak.Location = new System.Drawing.Point(13, 121);
            this.cbKontak.Name = "cbKontak";
            this.cbKontak.Size = new System.Drawing.Size(95, 23);
            this.cbKontak.TabIndex = 3;
            this.cbKontak.Text = "Kontak Var";
            this.cbKontak.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbKontak.UncheckedState.BorderRadius = 0;
            this.cbKontak.UncheckedState.BorderThickness = 0;
            this.cbKontak.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(21, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Araç Tipi";
            // 
            // cbAracTipi
            // 
            this.cbAracTipi.BackColor = System.Drawing.Color.Transparent;
            this.cbAracTipi.BorderRadius = 10;
            this.cbAracTipi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAracTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAracTipi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.cbAracTipi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.cbAracTipi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAracTipi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbAracTipi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(206)))), ((int)(((byte)(177)))));
            this.cbAracTipi.ItemHeight = 22;
            this.cbAracTipi.Items.AddRange(new object[] {
            "Otomobil(2₺)",
            "Minibüs(4₺)",
            "Otobüs(8₺)",
            "Kamyon(8₺)",
            "Tır(16₺)"});
            this.cbAracTipi.Location = new System.Drawing.Point(12, 80);
            this.cbAracTipi.Name = "cbAracTipi";
            this.cbAracTipi.Size = new System.Drawing.Size(339, 28);
            this.cbAracTipi.TabIndex = 1;
            this.cbAracTipi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPlaka
            // 
            this.txtPlaka.BorderRadius = 10;
            this.txtPlaka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlaka.DefaultText = "";
            this.txtPlaka.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlaka.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlaka.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlaka.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlaka.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.txtPlaka.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPlaka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPlaka.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(206)))), ((int)(((byte)(177)))));
            this.txtPlaka.Location = new System.Drawing.Point(12, 38);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.PasswordChar = '\0';
            this.txtPlaka.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPlaka.PlaceholderText = "Araç Plakası";
            this.txtPlaka.SelectedText = "";
            this.txtPlaka.ShortcutsEnabled = false;
            this.txtPlaka.Size = new System.Drawing.Size(339, 28);
            this.txtPlaka.TabIndex = 0;
            // 
            // minimizeBox
            // 
            this.minimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizeBox.FillColor = System.Drawing.Color.Black;
            this.minimizeBox.IconColor = System.Drawing.Color.White;
            this.minimizeBox.Location = new System.Drawing.Point(666, 0);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(45, 30);
            this.minimizeBox.TabIndex = 1;
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.FillColor = System.Drawing.Color.Black;
            this.closeBox.IconColor = System.Drawing.Color.White;
            this.closeBox.Location = new System.Drawing.Point(713, 0);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(45, 30);
            this.closeBox.TabIndex = 0;
            // 
            // FormMovement
            // 
            this.FormMovement.DockIndicatorTransparencyValue = 0.6D;
            this.FormMovement.TargetControl = this.gbMenu;
            this.FormMovement.UseTransparentDrag = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 500);
            this.Controls.Add(this.gbMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otopark Otomasyonu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.gbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAracTable)).EndInit();
            this.cmArac.ResumeLayout(false);
            this.gbAracDurum.ResumeLayout(false);
            this.gbAracDurum.PerformLayout();
            this.gbAracGiris.ResumeLayout(false);
            this.gbAracGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbMenu;
        private Guna.UI2.WinForms.Guna2ControlBox closeBox;
        private Guna.UI2.WinForms.Guna2ControlBox minimizeBox;
        private Guna.UI2.WinForms.Guna2DragControl FormMovement;
        private Guna.UI2.WinForms.Guna2GroupBox gbAracGiris;
        private Guna.UI2.WinForms.Guna2TextBox txtPlaka;
        private Guna.UI2.WinForms.Guna2ComboBox cbAracTipi;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox cbKontak;
        private Guna.UI2.WinForms.Guna2CheckBox cbAbone;
        private Guna.UI2.WinForms.Guna2Button btnEkle;
        private Guna.UI2.WinForms.Guna2GroupBox gbAracDurum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnSatırRaporu;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblPlaka;
        private Guna.UI2.WinForms.Guna2DataGridView dtAracTable;
        private System.Windows.Forms.ContextMenuStrip cmArac;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}

