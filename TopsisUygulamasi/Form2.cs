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
    public partial class Form2 : Form
    {
        List<Kriter> kriterler = new List<Kriter>();
        List<Alternatif> alternatifList = new List<Alternatif>();
        DataTable degerTablosu = new DataTable();
        DataTable dt = new DataTable();
        public Form2(List<Kriter> gelenKriterler)
        {
            InitializeComponent();
            this.kriterler = gelenKriterler;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(Kriter kriter in kriterler)
            {
                frm2KriterLstBx.Items.Add(kriter.SecondToString());
            }
        }

        private void altrntifEkleBttn_Click(object sender, EventArgs e)
        {
            Alternatif alternatif = new Alternatif(alternatifTxt.Text);
            altrntflerLstBx.Items.Add(alternatif);

            if(topsisHesaplamasiBttn.Visible == false)
            {
                topsisHesaplamasiBttn.Visible = true;
            }
            alternatifTxt.Clear();
            alternatifTxt.Focus();
        }

        private void altrnatifSilBttn_Click(object sender, EventArgs e)
        {
            altrntflerLstBx.Items.RemoveAt(altrntflerLstBx.SelectedIndex);
        }

        private void topsisHesaplamasiBttn_Click(object sender, EventArgs e)
        {
            if(label4.Visible == false && degerDataGridView.Visible == false && ilerleBttn.Visible == false)
            {
                
                label4.Visible = true;
                degerDataGridView.Visible = true;
                ilerleBttn.Visible = true;
            }
            foreach(Alternatif alternatif in altrntflerLstBx.Items)
            {
                alternatifList.Add(alternatif);
            }

            if(degerDataGridView.Visible == false && ilerleBttn.Visible == false)
            {
                degerDataGridView.Visible = true;
                ilerleBttn.Visible = true;
            }


            degerTablosu.Columns.Add("Alternatifler");
            foreach (Kriter kriter in kriterler)
            {
                degerTablosu.Columns.Add(kriter.Adi + "(" + kriter.Agirlik + ")");
            }

            foreach (Alternatif secenek in alternatifList)
            {
                degerTablosu.Rows.Add(secenek);
            }
            
            degerDataGridView.DataSource = degerTablosu;
           
            
        }

        private void ilerleBttn_Click(object sender, EventArgs e)
        {
            if(normalizasyonDataGridView.Visible == false && agirlikMatrisiBttn.Visible == false && label5.Visible == false)
            {
                
                normalizasyonDataGridView.Visible = true;
                agirlikMatrisiBttn.Visible = true;
                label5.Visible = true;
            }
            DataTable normTablo = new DataTable();
            normTablo.Columns.Add("Alternatifler");
            foreach (Kriter kriter in kriterler)
            {
                normTablo.Columns.Add(kriter.Adi);
            }
            foreach (Alternatif secenek in alternatifList)
            {
                normTablo.Rows.Add(secenek);
            }
            normalizasyonDataGridView.DataSource = normTablo;

            double[] degiskenler = new double[kriterler.Count];
            
      
            for (int i = 1; i < normTablo.Columns.Count; i++)
            {
                for (int j = 0; j < normTablo.Rows.Count; j++)
                {
                    degiskenler[i-1] += Math.Pow(Convert.ToDouble(degerDataGridView.Rows[j].Cells[i].Value), 2);

                }
            }

            for(int i = 0; i < degerDataGridView.Rows.Count; i++)
            {
                for (int j = 1; j < degerDataGridView.Columns.Count; j++)
                {
                    normalizasyonDataGridView.Rows[i].Cells[j].Value = Convert.ToDouble(degerDataGridView.Rows[i].Cells[j].Value) / Math.Sqrt(degiskenler[j - 1]);
                }
            }

        }

        private void agirlikMatrisiBttn_Click(object sender, EventArgs e)
        {
            
            dt.Columns.Add("Alternatifler");
            foreach (Kriter kriter in kriterler)
            {
                dt.Columns.Add(kriter.Adi+" ("+kriter.Agirlik+")");
            }
            
            for (int i = 0; i < normalizasyonDataGridView.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < normalizasyonDataGridView.Columns.Count; j++)
                {
                    dr[j] = normalizasyonDataGridView.Rows[i].Cells[j].Value;
                }
                dt.Rows.Add(dr);
            }

            Form3 form3 = new Form3(this.dt,this.kriterler);
            form3.Show();
            this.Hide();
        }

    }
}
