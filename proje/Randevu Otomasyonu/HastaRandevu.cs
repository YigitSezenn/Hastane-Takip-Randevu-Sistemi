using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Reflection.Emit;
using System.Data.SqlClient;

namespace Randevu_Otomasyonu
{
    public partial class HastaRandevu : Form
    {
        public HastaRandevu(string name_, string surname_,string TC_)
        {
            InitializeComponent();
            name = name_;
            surname = surname_;
            tc = TC_;
        }
        string name, surname,tc;

        private void button1_Click(object sender, EventArgs e)
        {
            Randevu frm = new Randevu(tc);
            frm.ShowDialog();
            this.Close();
        }

        void entry()
        {
            label2.Text = name + " " + surname + " ";
        }
        private void HastaRandevu_Load(object sender, EventArgs e)
        {
            entry();
        }
    }
}
