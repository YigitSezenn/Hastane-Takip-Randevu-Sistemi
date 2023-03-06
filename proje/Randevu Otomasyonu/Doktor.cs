using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;

namespace Randevu_Otomasyonu
{
    public partial class Doktor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UNB1QD5\\SQLEXPRESS;Initial Catalog=HastaneVeri;Integrated Security=True");

        public Doktor(string name_, string surname_, int statuID)
        {
            InitializeComponent();
            name = name_;
            surname = surname_;
            statu = statuID;
        }
        string name, surname;
        int statu;
        private byte[] memoryResim;
        private string fromstream;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void kan()
        {
            SqlCommand komut = new SqlCommand("Select * from Kangrup", con);
            SqlDataAdapter da2 = new SqlDataAdapter(komut);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            kangrubu.ValueMember = "KangrubuID";
            kangrubu.DisplayMember = "KanGrubu";
            kangrubu.DataSource = dt2;
        }

        void entry()
        {
            label7.Text = name + " " + surname + " " + " DOKTOR";
        }
        void columns()
        {

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;

        }
        private void Doktor_Load(object sender, EventArgs e)
        {
            entry();

            kan();
            kangrubu.Text = null;

        }

        void view(string Ara)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(Ara, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            columns();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                byte[] resim = new byte[0];
                con.Open();
                SqlCommand komutt = new SqlCommand("select * from Users where ID='" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "'", con);
                SqlDataReader dr = komutt.ExecuteReader();
                if (dr.Read())
                {

                    if (dr["Picture"] != null)
                    {
                        resim = (byte[])dr["Picture"];
                        MemoryStream memorySream = new MemoryStream(resim);
                        pictureBox1.Image = Image.FromStream(memorySream);
                        memoryResim = resim;
                        fromstream = memorySream.ToString();
                        pictureBox1.Image = pictureBox1.Image;
                        dr.Close();
                        komutt.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Getirilemedi");
                    }
                    txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtsoy.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    kangrubu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    dogumgunu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    maskTxtPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    txtemail.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    // pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcının Resmi Yok ");

            }
            con.Close();



        }

        private void btnhastalar_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("SELECT ID,AD,SoyAd,KanGrubu,DogumTarihi,Telefon,Eposta,Picture from Users  INNER JOIN Kangrup ON Users.KangrubuID=Kangrup.KangrubuID where TcKimlik like '" + hastaara.Text.Trim() + "%'", con);
            dataGridView1.DataSource = dt;
            ara.Fill(dt);
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            hastaara.MaxLength = 11;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHastaRandevu_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DoktorRandevu frm = new DoktorRandevu();
            frm.ShowDialog();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}