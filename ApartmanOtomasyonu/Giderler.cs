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
    public partial class Giderler : Form
    {
        SqlHelper sh = new SqlHelper();

        public Giderler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aidat form1 = new Aidat();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int para = (int)numericUpDown1.Value;
            DateTime tarih = dateTimePicker1.Value;

            string gider = "";
            foreach (Control item in groupBox1.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    gider += ","+item.Text;
                }
            }
            gider = gider.Remove(0,1);

            SqlParameter p1 = new SqlParameter("Gider",gider);
            SqlParameter p2 = new SqlParameter("Para",para);
            SqlParameter p3 = new SqlParameter("Tarih",tarih);


            sh.ExecuteProc("giderlerim",p1,p2,p3);
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            DataTable dt = sh.GetTable("Select * From Gider");

            foreach (DataRow item in dt.Rows)
            {
                listBox1.Items.Add(item[3]).ToString();
                listBox2.Items.Add(item[1]).ToString();
                listBox3.Items.Add(item[2]).ToString();
            }
        }
    }
}
