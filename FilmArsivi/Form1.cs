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

namespace FilmArsivi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TFCL3EH;Initial Catalog=FilmArsivi;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }
        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLFILM",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFILM (Ad,KATEGORI,LINK) values (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtfilmad.Text);
            komut.Parameters.AddWithValue("@P2", txtkategori.Text);
            komut.Parameters.AddWithValue("@P3", txtlink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film Listenize Eklendi", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            filmler();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow.Cells.Count > 3)
                {
                    string link = selectedRow.Cells[3].Value.ToString();
                    webBrowser1.Navigate(link);
                }
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void btnhakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Proje Ali Kaplan tarafından 10 Temmuz 2023'de kodlandı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Arkaplan Rengi Değiştirmek İçin Kod
        private bool isBlack = true;

        private void ChangeControlColors(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                ctrl.ForeColor = isBlack ? Color.White : Color.Black;

                if (ctrl.HasChildren)
                {
                    ChangeControlColors(ctrl);
                }
            }
        }
        private void ChangeDataGridViewColors(DataGridView dataGridView)
        {
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = isBlack ? Color.White : Color.Black;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = isBlack ? Color.Black : Color.White;
            dataGridView.DefaultCellStyle.ForeColor = isBlack ? Color.White : Color.Black;
            dataGridView.DefaultCellStyle.BackColor = isBlack ? Color.Black : Color.White;
        }

        private void btntema_Click(object sender, EventArgs e)
        {
            if (isBlack)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                ChangeControlColors(this);
                ChangeDataGridViewColors(dataGridView1);
                isBlack = false;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                ChangeControlColors(this);
                ChangeDataGridViewColors(dataGridView1);
                isBlack = true;
            }
        }
    }
}
