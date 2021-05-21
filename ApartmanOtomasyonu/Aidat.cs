using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyonu
{
    public partial class Aidat : Form
    {
        public Aidat()
        {
            InitializeComponent();
        }

        

        private void gelirler_Click(object sender, EventArgs e)
        {
            Gelirler gelir = new Gelirler();
            gelir.Show();
            this.Hide();
        }

        private void giderler_Click(object sender, EventArgs e)
        {
            Giderler gider = new Giderler();
            gider.Show();
            this.Hide();
        }
    }
}
