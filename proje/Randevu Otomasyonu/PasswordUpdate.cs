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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;

namespace Randevu_Otomasyonu
{
    public partial class PasswordUpdate : Form
    {
        public PasswordUpdate()
        {
            InitializeComponent();
        }
        public double x;
        public string email,tc;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UNB1QD5\\SQLEXPRESS;Initial Catalog=HastaneVeri;Integrated Security=True");
        public static string MD5Sifrele(string sifrelenecekMetin)
        {
            // MD5CryptoServiceProvider sınıfının bir örneğini oluşturduk.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk.
            StringBuilder sb = new StringBuilder();
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürdük.
            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordUpdate_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dr["FirstActivation"].ToString() == 0.ToString())
            {
                try
                {
                    Random rnd = new Random();

                    string eMail = textBox1.Text;

                    double x = rnd.Next(100000, 999999);


                    SmtpClient sc = new SmtpClient();
                    sc.Port = 587;
                    sc.Host = "smtp-mail.outlook.com";
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential("yigitsezenn@outlook.com", "yigitsezen001");
                    MailMessage mesaj = new MailMessage("yigitsezenn@outlook.com", eMail);

                    mesaj.Subject = "Şifreyi değiştir ?";
                    mesaj.Body = "Şifrenizi Değiştirmek için 6 haneli aktivasyon kodunu programda yazınız. Aktivaston kodu = " + x;


                    sc.Send(mesaj);

                    PasswordUpdate yeni = new PasswordUpdate();
                    yeni.x = x;
                    yeni.email = eMail;
                    yeni.Show();
                    this.Hide();
                    MessageBox.Show("Şifreyi değiştirmek için aktivasyon kodunu  " + " '" + eMail + "' " + " Adresine gönderildi.", "OLUMLU", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception hata)
                {

                    MessageBox.Show("Kayıtlı böyle bir mail adresi yoktur! " + hata);
                }
            }
        }
        void update()
        {
                con.Open();
                string text = "update Users set Password=@pw where TcKimlik=@Tckimlik";
                SqlCommand update = new SqlCommand(text,con);
                update.Parameters.AddWithValue("@pw",MD5Sifrele(textBox2.Text));
                update.Parameters.AddWithValue("@Tckimlik",tc);
                update.ExecuteNonQuery();
                string fa = "update Users set FirstActivation=1 where TcKimlik=@tc";
                SqlCommand updatefa = new SqlCommand(fa,con);
                updatefa.Parameters.AddWithValue("@tc", tc);
                updatefa.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Şifre güncellendi");
                Giris frm = new Giris();
                frm.ShowDialog();
                this.Hide();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text==textBox3.Text)
            {
                update();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmamaktadır. Lütfen tekrara deneyiniz.");
            }
        }
    }
    
}
