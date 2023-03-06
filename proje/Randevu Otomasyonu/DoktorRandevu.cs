using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Randevu_Otomasyonu
{
    public partial class DoktorRandevu : Form
    {
        public DoktorRandevu()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UNB1QD5\\SQLEXPRESS;Initial Catalog=HastaneVeri;Integrated Security=True");
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
        string eMail;
        string email()
        {
            con.Open();
            SqlCommand mail = new SqlCommand("select email from Users where TcKimlik='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'",con);
            eMail = mail.ExecuteScalar().ToString();
            con.Close();
            return eMail;
        }
        void Randevuİptal()
        {
            DialogResult msj = MessageBox.Show(dataGridView1.CurrentRow.Cells[1].Value.ToString()+" Tcli Kişinin Randevusunu İptal Etmek İstiyor musunuz","Randevu İptal",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (msj == DialogResult.Yes)
            {
                try
                {
                    email();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Randevu set randevuID=2 where  ıd=@TcKimlik",con);
                    update.Parameters.AddWithValue("@TcKimlik", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    update.ExecuteNonQuery();
                    SmtpClient sc = new SmtpClient();
                    sc.Port = 587;
                    sc.Host = "smtp-mail.outlook.com";
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential("yigitsezenn@outlook.com", "Kanarya2001");
                    MailMessage mesaj = new MailMessage("yigitsezenn@outlook.com", eMail);

                    mesaj.Subject = "RandevuDeğişikliği";
                    mesaj.Body = "Randevunuz iptal edildi";

                    sc.Send(mesaj);
                    MessageBox.Show(" Randevu İptal Edildi");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hatanız = " + ex);
                }
                

               
            }
            else
            {
                MessageBox.Show("Randevu İptal Edilemedi");

            }
            con.Close();
        }
        void columns()
        {

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            view("Select * from Randevu where randevuID=1");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoktorRandevu_Load(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Randevuİptal();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Randeuvu İptal Edilemedi hatanız= " + ex);

            }
        }
    }
}
