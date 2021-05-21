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

namespace ApartmanOtomasyonu
{
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Aidat form1 = new Aidat();
            form1.Show();
            this.Hide();
        }

        SqlHelper sh = new SqlHelper();

        private void button1_Click(object sender, EventArgs e)
        {
            int daireno = Convert.ToInt32(comboBox1.Text);
            int para = (int)numericUpDown1.Value;
            DateTime tarih = dateTimePicker1.Value;

            SqlParameter p1 = new SqlParameter("@Daireno",daireno);
            SqlParameter p2 = new SqlParameter("@Para", para);
            SqlParameter p3 = new SqlParameter("@Tarih", tarih);

            sh.ExecuteProc("odeme_al",p1,p2,p3);

        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            DataTable dt = sh.GetTable("Select * from AidatOdemesi");

            foreach (DataRow item in dt.Rows)
            {
                listBox1.Items.Add(item["DaireNo"]).ToString();
                listBox2.Items.Add(item["Para"]).ToString();
                listBox3.Items.Add(item["Tarih"]).ToString();
            }
        }
    }
}
