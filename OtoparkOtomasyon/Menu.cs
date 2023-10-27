using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
namespace OtoparkOtomasyon
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        #region Sql Connections, Insert Data AND Price Calculations
        SqlConnection con = new SqlConnection("Data Source="+ Environment.MachineName.ToString()+ ";Initial Catalog=dbOtopark;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        SqlCommand cmd;
        private void getData()
        {
            try
            {
                da = new SqlDataAdapter("Select *From tbArac WHERE giris_durumu='G'", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "tbArac");
                dtAracTable.DataSource = ds.Tables["tbArac"];
                con.Close();
                dtAracTable.Columns["arac_plaka"].HeaderText = "Plaka";
                dtAracTable.Columns["arac_tipi"].HeaderText = "Araç Tipi";
                dtAracTable.Columns["kontak_durumu"].HeaderText = "Kontak Durumu";
                dtAracTable.Columns["abone_durumu"].HeaderText = "Abone Durumu";
                dtAracTable.Columns["sure"].Visible = false;
                dtAracTable.Columns["ucret"].Visible = false;
                dtAracTable.Columns["giris_durumu"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtAracTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updatePrice();
        }

        private void updatePrice()
        {
            try
            {
                double toplamUcret;
                string girisZamani = dtAracTable.SelectedRows[0].Cells["sure"].Value.ToString();
                string guncelZaman = DateTime.Now.ToShortTimeString();
                TimeSpan fark = DateTime.Parse(guncelZaman).Subtract(DateTime.Parse(girisZamani));
                int gecensure = Convert.ToInt32(fark.TotalHours);
                string x= dtAracTable.SelectedRows[0].Cells["arac_tipi"].Value.ToString();
                x = x.Split('(').Last();
                x = x.Split('₺').First();
                double ilkUcret = Convert.ToDouble(x);
                if (gecensure == 0)
                {
                    toplamUcret = ilkUcret;
                }
                else if (gecensure == 1)
                {
                    toplamUcret = ilkUcret * 2;
                }
                else
                {
                    toplamUcret = ilkUcret * gecensure;
                }
                lblSaat.Text = gecensure.ToString() + " Saat";
                lblPlaka.Text = dtAracTable.SelectedRows[0].Cells["arac_plaka"].Value.ToString();
                lblUcret.Text = toplamUcret.ToString() + " TL";
                con.Open();
                string plaka = dtAracTable.SelectedRows[0].Cells["arac_plaka"].Value.ToString();
                cmd = new SqlCommand("UPDATE tbArac SET ucret=@ucret WHERE arac_plaka=@arac_plaka", con);
                cmd.Parameters.AddWithValue("@ucret", toplamUcret);
                cmd.Parameters.AddWithValue("@arac_plaka", plaka);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            getData();
        }
        #endregion

        #region Add Car and Delete Car


        private void cbAbone_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAbone.Checked)
            {
                cbAracTipi.Items[0] = "Otomobil(1,60₺)";
                cbAracTipi.Items[1] = "Minibüs(3,20₺)";
                cbAracTipi.Items[2] = "Otobüs(6,40₺)";
                cbAracTipi.Items[3] = "Kamyon(6,40₺)";
                cbAracTipi.Items[4] = "Tır(12,80₺)";
            }
            else
            {
                cbAracTipi.Items[0] = "Otomobil(2₺)";
                cbAracTipi.Items[1] = "Minibüs(4₺)";
                cbAracTipi.Items[2] = "Otobüs(8₺)";
                cbAracTipi.Items[3] = "Kamyon(8₺)";
                cbAracTipi.Items[4] = "Tır(16₺)";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPlaka.Text != null && cbAracTipi.SelectedIndex != -1)
                {
                    char kontakDurum, aboneDurum;
                    if (cbKontak.Checked)
                        kontakDurum = 'E';
                    else
                        kontakDurum = 'H';
                    if (cbAbone.Checked)
                        aboneDurum = 'E';
                    else
                        aboneDurum = 'H';

                    con.Open();
                    cmd = new SqlCommand("INSERT INTO tbArac(arac_plaka,arac_tipi,kontak_durumu,abone_durumu,sure,ucret,giris_durumu) VALUES (@arac_plaka,@arac_tipi,@kontak_durumu,@abone_durumu,@sure,@ucret,@giris_durumu)", con);
                    cmd.Parameters.AddWithValue("@arac_plaka", txtPlaka.Text);
                    cmd.Parameters.AddWithValue("@arac_tipi", cbAracTipi.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@kontak_durumu", kontakDurum);
                    cmd.Parameters.AddWithValue("@abone_durumu", aboneDurum);
                    cmd.Parameters.AddWithValue("@sure", DateTime.Now.ToShortTimeString());
                    double ucret = 0;
                    #region UcretBelirleme
                    if (cbAracTipi.SelectedIndex == 0 && cbAbone.Checked)
                    {
                        ucret = 1.60;
                    }
                    else if (cbAracTipi.SelectedIndex == 0 && !cbAbone.Checked)
                    {
                        ucret = 2;
                    }

                    if (cbAracTipi.SelectedIndex == 1 && cbAbone.Checked)
                    {
                        ucret = 3.20;
                    }
                    else if (cbAracTipi.SelectedIndex == 1 && !cbAbone.Checked)
                    {
                        ucret = 4;
                    }

                    if (cbAracTipi.SelectedIndex == 2 && cbAbone.Checked)
                    {
                        ucret = 6.40;
                    }
                    else if (cbAracTipi.SelectedIndex == 2 && !cbAbone.Checked)
                    {
                        ucret = 8;
                    }

                    if (cbAracTipi.SelectedIndex == 3 && cbAbone.Checked)
                    {
                        ucret = 6.40;
                    }
                    else if (cbAracTipi.SelectedIndex == 3 && !cbAbone.Checked)
                    {
                        ucret = 8;
                    }

                    if (cbAracTipi.SelectedIndex == 4 && cbAbone.Checked)
                    {
                        ucret = 12.80;
                    }
                    else if (cbAracTipi.SelectedIndex == 4 && !cbAbone.Checked)
                    {
                        ucret = 16;
                    }
                    #endregion
                    cmd.Parameters.AddWithValue("@ucret", ucret);
                    cmd.Parameters.AddWithValue("@giris_durumu", 'G');
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(txtPlaka.Text + " plakalı aracın girişi yapıldı!", "Otopark Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPlaka.Text = "";
                    cbAracTipi.SelectedIndex = -1;
                    cbKontak.Checked = false; cbAbone.Checked = false;
                    getData();
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Bilgileri Doldurun!","Otopark Otomasyonu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string plaka = dtAracTable.SelectedRows[0].Cells["arac_plaka"].Value.ToString();
                DialogResult dr = MessageBox.Show(plaka+" plakalı aracın çıkışını yapmak istediğinizden emin misiniz?","Otopark Otomasyonu",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr==DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE tbArac SET giris_durumu=@giris_durumu WHERE arac_plaka=@arac_plaka", con);
                    cmd.Parameters.AddWithValue("@giris_durumu", 'C');
                    cmd.Parameters.AddWithValue("@arac_plaka", plaka);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(plaka+" plakalı aracın çıkışı yapıldı!","Otopark Otomasyonu",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    getData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Open Reports Form
        private void btnSatırRaporu_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            r.ShowDialog();
        }
        #endregion
    }
}
