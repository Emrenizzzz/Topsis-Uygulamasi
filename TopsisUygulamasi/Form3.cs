using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopsisUygulamasi
{
    public partial class Form3 : Form
    {
        DataTable dt = new DataTable();
        List<Kriter> kriterler = new List<Kriter>();
        double[] pozitif;
        double[] negatif;
        DataTable siDT = new DataTable();
        DataTable sEksiDT = new DataTable();
        public Form3(DataTable gDt,List<Kriter> gKriterler)
        {
            InitializeComponent();
            this.dt = gDt;
            this.kriterler = gKriterler;
            
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for(int j = 1; j < dt.Columns.Count; j++)
                {
                    dt.Rows[i][j] = Convert.ToDouble(dt.Rows[i][j]) * kriterler[j-1].Agirlik;
                    
                }
                dt.Rows[i].AcceptChanges();
            }
            agirlandirilmisMatrisDataGridView.DataSource = dt;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void idealCozumBttn_Click(object sender, EventArgs e)
        {
            pozitif = new double[dt.Columns.Count];
            for(int i = 1; i < dt.Columns.Count; i++)
            {
                double ideal = Convert.ToDouble(dt.Rows[0][i]);
                if(kriterler[i-1].Türü == "Maximum")
                {
                    for(int j = 0; j < dt.Rows.Count; j++)
                    {
                        if(Convert.ToDouble(dt.Rows[j][i]) > ideal)
                        {
                            ideal = Convert.ToDouble(dt.Rows[j][i]);
                        }
                    }
                    pozitif[i-1] = ideal;
                }
                else
                {
                    for(int j = 0; j < dt.Rows.Count; j++)
                    {
                        if(Convert.ToDouble(dt.Rows[j][i]) < ideal)
                        {
                            ideal = Convert.ToDouble(dt.Rows[j][i]);
                        }
                    }
                    pozitif[i - 1] = ideal;
                }
            }

            DataTable pozitifTablo = new DataTable();
            foreach (Kriter kriter in kriterler)
            {
                pozitifTablo.Columns.Add(kriter.Adi);
            }
            DataRow satir = pozitifTablo.NewRow();
            for (int j = 0; j < kriterler.Count; j++)
            {
                satir[j] = pozitif[j];
            }
            pozitifTablo.Rows.Add(satir);
            idealDegerlerDataGridView1.DataSource = pozitifTablo;


            negatif = new double[kriterler.Count];
            for(int i = 1; i < dt.Columns.Count; i++)
            {
                double idealOlmayan = Convert.ToDouble(dt.Rows[0][i]);
                if(kriterler[i-1].Türü == "Maximum")
                {
                    for(int j = 0; j < dt.Rows.Count; j++)
                    {
                        if(Convert.ToDouble(dt.Rows[j][i]) < idealOlmayan)
                        {
                            idealOlmayan = Convert.ToDouble(dt.Rows[j][i]);
                        }
                    }
                    negatif[i-1] = idealOlmayan;
                }
                else
                {
                    for(int j = 0; j < dt.Rows.Count; j++)
                    {
                        if(Convert.ToDouble(dt.Rows[j][i]) > idealOlmayan)
                        {
                            idealOlmayan = Convert.ToDouble(dt.Rows[j][i]);
                        }
                    }
                    negatif[i - 1] = idealOlmayan;
                }
            }

            DataTable negatifTablo = new DataTable();
            foreach (Kriter kriter in kriterler)
            {
                negatifTablo.Columns.Add(kriter.Adi);
            }
            DataRow r = negatifTablo.NewRow();
            for (int j = 0; j < kriterler.Count; j++)
            {
                r[j] = negatif[j];
            }
            negatifTablo.Rows.Add(r);
            nİdealDegerlerdataGridView1.DataSource = negatifTablo;
        }

        private void sİBttn_Click(object sender, EventArgs e)
        {
            siDT = dt.Copy();
            double[] toplamlar = new double[siDT.Rows.Count];
            
            for (int i = 0; i < siDT.Rows.Count; i++)
            {
                double toplam = 0;
                for (int j = 1; j < siDT.Columns.Count; j++)
                {
                    siDT.Rows[i][j] = Math.Pow((Convert.ToDouble(siDT.Rows[i][j]) - pozitif[j-1]),2);
                    toplam += Convert.ToDouble(siDT.Rows[i][j]);
                }
                toplamlar[i] = Math.Sqrt(toplam);
                siDT.Rows[i].AcceptChanges();
            }
            siDT.Columns.Add("Si*");
            for (int i = 0; i < siDT.Rows.Count; i++)
            {
                siDT.Rows[i][siDT.Columns.Count - 1] = toplamlar[i];
            }
            sİDataGridView1.DataSource = siDT;


            sEksiDT = dt.Copy();
            double[] tplmlar = new double[sEksiDT.Rows.Count];

            for(int i = 0; i < sEksiDT.Rows.Count; i++)
            {
                double toplam = 0;
                for(int j = 1; j < sEksiDT.Columns.Count; j++)
                {
                    sEksiDT.Rows[i][j] = Math.Pow(Convert.ToDouble(sEksiDT.Rows[i][j]) - negatif[j - 1], 2);
                    toplam += Convert.ToDouble(sEksiDT.Rows[i][j]);
                }
                tplmlar[i] = Math.Sqrt(toplam);
                sEksiDT.Rows[i].AcceptChanges();
            }
            sEksiDT.Columns.Add("S-");
            for(int i = 0; i < sEksiDT.Rows.Count; i++)
            {
                sEksiDT.Rows[i][sEksiDT.Columns.Count - 1] = tplmlar[i];
            }
            sEksiDataGridView1.DataSource = sEksiDT;
        }

        private void sonucBttn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this.sEksiDT,this.siDT,this.kriterler);
            form4.Show();
            this.Hide();
        }
    }
}
