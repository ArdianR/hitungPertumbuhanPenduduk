using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pertumbuhanPenduduk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       public int[] tahunM;
       public float lPtbPendudukM;
       public float[] jlPendudukArrM;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Show();
            listView1.View = View.Details;


            for (int i = 2015; i < 2026; i++)
                listView1.Columns.Add(Convert.ToString(i), 70);

            int[] tahun = new int[11];
            float lPtbPenduduk = 0.63f;
            float[] jlPendudukArr = new float[11];
            int jlhPenduduk2010 = 2109339;
            label3.Text = Convert.ToString("Laju pertumbuhan penduduk: "+lPtbPenduduk + "%");

            jlPendudukArr[0] = jlhPenduduk2010 + (lPtbPenduduk/100*jlhPenduduk2010)*5;

            for (int i = 1; i < 11; i++)
            {
                jlPendudukArr[i] = jlPendudukArr[i - 1] + lPtbPenduduk / 100 * jlPendudukArr[i - 1];
            }

            listView1.Items.Add(jlPendudukArr[0].ToString("#,###,###.##"));

            for (int i = 1; i < jlPendudukArr.Length; i++)
            {
                listView1.Items[0].SubItems.Add((jlPendudukArr[i].ToString("#,###,###.##")));
            }
          
            DataPoint Data = new DataPoint();
            ChartArea luas = chart1.ChartAreas[0];
            chart1.Series.Clear();
            luas.AxisX.Maximum = 2025; 
            luas.AxisX.Minimum = 2015;
            //luas.AxisY.Maximum = 2400000;
            //luas.AxisY.Minimum = 2000000;
            //Data.SetValueY(2400000);
            //Data.SetValueY(2026);

            for (int i = 0; i < 11; i++)
            {
                tahun[i] = 2014 + i;
            }

            chart1.Series.Add("Pertumbuhan Penduduk");
            chart1.Series["Pertumbuhan Penduduk"].ChartType = SeriesChartType.Line;

            for (int i = 0; i <= 10; i++)
            {
                chart1.Series["Pertumbuhan Penduduk"].Points.AddXY(tahun[i],Convert.ToInt32(jlPendudukArr[i]));
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Show();
            listView1.View = View.Details;


            for (int i = 2015; i < 2026; i++)
                listView1.Columns.Add(Convert.ToString(i), 70);
            int[] tahun = new int[11];
            float lPtbPenduduk = 1.39f;
            float[] jlPendudukArr = new float[11];
            int jlhPenduduk2010 = 12982200;
            label3.Text = Convert.ToString("Laju pertumbuhan penduduk: " + lPtbPenduduk + "%");
            jlPendudukArr[0] = jlhPenduduk2010 + (lPtbPenduduk / 100 * jlhPenduduk2010) * 5;

            for (int i = 0; i < 11; i++)
            {
                tahun[i] = 2015 + i;
            }

            for (int i = 1; i < 11; i++)
            {
                jlPendudukArr[i] = jlPendudukArr[i - 1] + lPtbPenduduk / 100 * jlPendudukArr[i - 1];
            }

            listView1.Items.Add(jlPendudukArr[0].ToString("##,###,###.##"));

            for (int i = 1; i < jlPendudukArr.Length; i++)
            {
                listView1.Items[0].SubItems.Add(jlPendudukArr[i].ToString("##,###,###.##"));
            }

            DataPoint Data = new DataPoint();
            ChartArea luas = chart1.ChartAreas[0];
            chart1.Series.Clear();
            luas.AxisX.Maximum = 2025; 
            luas.AxisX.Minimum = 2015;
            luas.AxisY.Maximum = 16000000;
            luas.AxisY.Minimum = 12000000;

            for (int i = 0; i < 11; i++)
            {
                tahun[i] = 2014 + i;
            }

            chart1.Series.Add("Pertumbuhan Penduduk");
            chart1.Series["Pertumbuhan Penduduk"].ChartType = SeriesChartType.Line;

            for (int i = 0; i <= 10; i++)
            {
                chart1.Series["Pertumbuhan Penduduk"].Points.AddXY(tahun[i],Convert.ToInt32(jlPendudukArr[i]));
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Show();
            listView1.View = View.Details;

            for (int i = 2015; i < 2026; i++)
                listView1.Columns.Add(Convert.ToString(i), 90);
            int[] tahun = new int[11];
            float lPtbPenduduk = 1.40f;
            float[] jlPendudukArr = new float[11];
            int jlhPenduduk2010 = 237641300;
            
            label3.Text = Convert.ToString("Laju pertumbuhan penduduk: " + lPtbPenduduk + "%");
            jlPendudukArr[0] = jlhPenduduk2010 + (lPtbPenduduk / 100 * jlhPenduduk2010) * 5;

            for (int i = 0; i < 11; i++)
            {
                tahun[i] = 2015 + i;
            }

            for (int i = 1; i < 11; i++)
            {
                jlPendudukArr[i] = jlPendudukArr[i - 1] + lPtbPenduduk / 100 * jlPendudukArr[i - 1];
            }

            listView1.Items.Add(jlPendudukArr[0].ToString("###,###,###,###.##"));

            for (int i = 1; i < jlPendudukArr.Length; i++)
            {
                listView1.Items[0].SubItems.Add(jlPendudukArr[i].ToString("###,###,###,###.##"));
            }

            DataPoint Data = new DataPoint();
            ChartArea luas = chart1.ChartAreas[0];
            chart1.Series.Clear();
            luas.AxisX.Maximum = 2025;
            luas.AxisX.Minimum = 2015;
            luas.AxisY.Maximum = 300000000;
            luas.AxisY.Minimum = 200000000;

            for (int i = 0; i < 11; i++)
            {
                tahun[i] = 2014 + i;
            }

            chart1.Series.Add("Pertumbuhan Penduduk");
            chart1.Series["Pertumbuhan Penduduk"].ChartType = SeriesChartType.Line;

            for (int i = 0; i <= 10; i++)
            {
                chart1.Series["Pertumbuhan Penduduk"].Points.AddXY(tahun[i],Convert.ToInt32(jlPendudukArr[i]));
            }
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManual.Checked == true)
            {
                int n;
                listView1.Clear();
                listView1.Show();
                listView1.View = View.Details;

                manual mn = new manual();
                mn.ShowDialog();
                n = mn.tahunSelesai - mn.tahunMulai;
                tahunM = new int[n+1];
                lPtbPendudukM = mn.pertP;

                jlPendudukArrM = new float[n+1];
                jlPendudukArrM[0] = Convert.ToSingle(mn.jlhPendudukAwal);

                for (int i = mn.tahunMulai; i <= mn.tahunSelesai; i++)
                    listView1.Columns.Add(Convert.ToString(i), 90);


                label3.Text = Convert.ToString(lPtbPendudukM);

                for (int i = 0; i <= n; i++)
                {
                    tahunM[i] = mn.tahunMulai + i;
                }

                for (int i = 1; i <= n; i++)
                {
                    jlPendudukArrM[i] = jlPendudukArrM[i - 1] + lPtbPendudukM / 100 * jlPendudukArrM[i - 1];
                }

                listView1.Items.Add(jlPendudukArrM[0].ToString("###,###,###,###.##"));

                for (int i = 1; i < jlPendudukArrM.Length; i++)
                {
                    listView1.Items[0].SubItems.Add(jlPendudukArrM[i].ToString("###,###,###,###.##"));
                }
                label3.Text = Convert.ToString("Laju pertumbuhan penduduk: " + lPtbPendudukM + "%");
                DataPoint Data = new DataPoint();
                ChartArea luas = chart1.ChartAreas[0];
                chart1.Series.Clear();
                luas.AxisX.Maximum = mn.tahunSelesai;
                luas.AxisX.Minimum = mn.tahunMulai;
                luas.AxisY.Maximum = mn.jlhPendudukAwal * 2;
                luas.AxisY.Minimum = mn.jlhPendudukAwal;

                chart1.Series.Add("Pertumbuhan Penduduk");
                chart1.Series["Pertumbuhan Penduduk"].ChartType = SeriesChartType.Line;

                for (int i = 0; i <= n; i++)
                {
                    chart1.Series["Pertumbuhan Penduduk"].Points.AddXY(tahunM[i], Convert.ToInt32(jlPendudukArrM[i]));
                }
                mn.Close();
            }
        }
        


    }
}
