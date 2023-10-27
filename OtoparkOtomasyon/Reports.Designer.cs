namespace OtoparkOtomasyon
{
    partial class Reports
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
            this.gbRapor = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gbToplamBilgi = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblUcret = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAracSayısı = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtRaporTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.minimizeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.FormMovement = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gbRapor.SuspendLayout();
            this.gbToplamBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRaporTable)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRapor
            // 
            this.gbRapor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbRapor.Controls.Add(this.gbToplamBilgi);
            this.gbRapor.Controls.Add(this.dtRaporTable);
            this.gbRapor.Controls.Add(this.minimizeBox);
            this.gbRapor.Controls.Add(this.closeBox);
            this.gbRapor.CustomBorderColor = System.Drawing.Color.Black;
            this.gbRapor.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.gbRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRapor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbRapor.ForeColor = System.Drawing.Color.White;
            this.gbRapor.Location = new System.Drawing.Point(0, 0);
            this.gbRapor.Name = "gbRapor";
            this.gbRapor.Size = new System.Drawing.Size(758, 500);
            this.gbRapor.TabIndex = 1;
            this.gbRapor.Text = "Otopark Otomasyonu";
            this.gbRapor.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // gbToplamBilgi
            // 
            this.gbToplamBilgi.BackColor = System.Drawing.Color.Transparent;
            this.gbToplamBilgi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(206)))), ((int)(((byte)(177)))));
            this.gbToplamBilgi.Controls.Add(this.lblUcret);
            this.gbToplamBilgi.Controls.Add(this.label2);
            this.gbToplamBilgi.Controls.Add(this.lblAracSayısı);
            this.gbToplamBilgi.Controls.Add(this.label3);
            this.gbToplamBilgi.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.gbToplamBilgi.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.gbToplamBilgi.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gbToplamBilgi.ForeColor = System.Drawing.Color.White;
            this.gbToplamBilgi.Location = new System.Drawing.Point(12, 40);
            this.gbToplamBilgi.Name = "gbToplamBilgi";
            this.gbToplamBilgi.Size = new System.Drawing.Size(734, 105);
            this.gbToplamBilgi.TabIndex = 5;
            this.gbToplamBilgi.Text = "Toplam Bilgiler";
            this.gbToplamBilgi.TextOffset = new System.Drawing.Point(0, -6);
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblUcret.ForeColor = System.Drawing.Color.Black;
            this.lblUcret.Location = new System.Drawing.Point(428, 73);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(46, 25);
            this.lblUcret.TabIndex = 12;
            this.lblUcret.Text = "0 TL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(129, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Toplam Araç Sayısı";
            // 
            // lblAracSayısı
            // 
            this.lblAracSayısı.AutoSize = true;
            this.lblAracSayısı.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblAracSayısı.ForeColor = System.Drawing.Color.Black;
            this.lblAracSayısı.Location = new System.Drawing.Point(139, 73);
            this.lblAracSayısı.Name = "lblAracSayısı";
            this.lblAracSayısı.Size = new System.Drawing.Size(22, 25);
            this.lblAracSayısı.TabIndex = 11;
            this.lblAracSayısı.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(418, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Toplam Ücret Miktarı";
            // 
            // dtRaporTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dtRaporTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtRaporTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtRaporTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtRaporTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtRaporTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtRaporTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dtRaporTable.Location = new System.Drawing.Point(12, 151);
            this.dtRaporTable.Name = "dtRaporTable";
            this.dtRaporTable.RowHeadersVisible = false;
            this.dtRaporTable.Size = new System.Drawing.Size(734, 337);
            this.dtRaporTable.TabIndex = 4;
            this.dtRaporTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dtRaporTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dtRaporTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtRaporTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtRaporTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtRaporTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtRaporTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtRaporTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dtRaporTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dtRaporTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtRaporTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtRaporTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtRaporTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtRaporTable.ThemeStyle.HeaderStyle.Height = 23;
            this.dtRaporTable.ThemeStyle.ReadOnly = false;
            this.dtRaporTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dtRaporTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtRaporTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtRaporTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtRaporTable.ThemeStyle.RowsStyle.Height = 22;
            this.dtRaporTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dtRaporTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            this.FormMovement.TargetControl = this.gbRapor;
            this.FormMovement.UseTransparentDrag = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 500);
            this.Controls.Add(this.gbRapor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Reports_Load);
            this.gbRapor.ResumeLayout(false);
            this.gbToplamBilgi.ResumeLayout(false);
            this.gbToplamBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRaporTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbRapor;
        private Guna.UI2.WinForms.Guna2DataGridView dtRaporTable;
        private Guna.UI2.WinForms.Guna2ControlBox minimizeBox;
        private Guna.UI2.WinForms.Guna2ControlBox closeBox;
        private Guna.UI2.WinForms.Guna2GroupBox gbToplamBilgi;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAracSayısı;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DragControl FormMovement;
    }
}