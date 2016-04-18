using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pertumbuhanPenduduk
{
    public partial class manual : Form
    {
        public manual()
        {
            InitializeComponent();
        }

        public int tahunMulai, tahunSelesai, jlhPendudukAwal;
        public float pertP;



        private void manual_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;

        }

        private void manual_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pertP = Convert.ToSingle(textBox1.Text);
            jlhPendudukAwal = Convert.ToInt32(textBox2.Text);
            tahunMulai = Convert.ToInt32(textBox4.Text);
            tahunSelesai = Convert.ToInt32(textBox5.Text);
            this.Hide();
        }


    }
}
