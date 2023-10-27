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
namespace OtoparkOtomasyon
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        #region Get Data
        SqlConnection con = new SqlConnection("Data Source=" + Environment.MachineName.ToString() + ";Initial Catalog=dbOtopark;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        private void getData()
        {
            try
            {
                da = new SqlDataAdapter("Select *From tbArac WHERE giris_durumu='G'", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "tbArac");
                dtRaporTable.DataSource = ds.Tables["tbArac"];
                con.Close();
                dtRaporTable.Columns["arac_plaka"].HeaderText = "Plaka";
                dtRaporTable.Columns["arac_tipi"].HeaderText = "Araç Tipi";
                dtRaporTable.Columns["kontak_durumu"].Visible = false;
                dtRaporTable.Columns["abone_durumu"].HeaderText = "Abone Durumu";
                dtRaporTable.Columns["sure"].Visible = false;
                dtRaporTable.Columns["ucret"].Visible = false;
                dtRaporTable.Columns["giris_durumu"].Visible = false;

                lblAracSayısı.Text = (dtRaporTable.Rows.Count - 1).ToString();
                string girisZamani = dtRaporTable.SelectedRows[0].Cells["sure"].Value.ToString();
                string guncelZaman = DateTime.Now.ToShortTimeString();
                TimeSpan fark = DateTime.Parse(guncelZaman).Subtract(DateTime.Parse(girisZamani));
                int gecensure = Convert.ToInt32(fark.TotalHours);
                dtRaporTable.Columns.Add("s", "Süre");
                for (int i = 0; i < dtRaporTable.Rows.Count - 1; i++)
                {
                    dtRaporTable.Rows[i].Cells["s"].Value = gecensure.ToString();
                }

                double toplamÜcret = 0;
                for (int j = 0; j < dtRaporTable.Rows.Count - 1; j++)
                {
                    toplamÜcret += Convert.ToDouble(dtRaporTable.Rows[j].Cells["ucret"].Value.ToString());
                }
                lblUcret.Text = toplamÜcret.ToString();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        private void Reports_Load(object sender, EventArgs e)
        {
            getData();
        }
        #endregion

    }
}
