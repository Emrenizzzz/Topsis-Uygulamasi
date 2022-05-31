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
    public partial class Form4 : Form
    {
        DataTable sEksiDT = new DataTable();
        DataTable siDT = new DataTable();
        List<Kriter> kriterler = new List<Kriter>();
        public Form4(DataTable gEksiDT,DataTable gSiDT,List<Kriter> gKriterler)
        {
            InitializeComponent();
            sEksiDT = gEksiDT;
            siDT = gSiDT;
            kriterler = gKriterler;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DataTable sonucDT = new DataTable();
            sonucDT.Columns.Add("Alternatifler");
            sonucDT.Columns.Add("Si*");
            sonucDT.Columns.Add("Si-");
            sonucDT.Columns.Add("C*");
            for (int i = 0; i < sEksiDT.Rows.Count; i++)
            {
                sonucDT.Rows.Add(sEksiDT.Rows[i][0]);
            }
            for(int i = 0; i < siDT.Rows.Count; i++)
            {
                for(int j = 1; j < sonucDT.Columns.Count; j++)
                {
                    if(j == 3)
                    {
                        sonucDT.Rows[i][j] = Convert.ToDouble(sEksiDT.Rows[i][sEksiDT.Columns.Count - 1])/(Convert.ToDouble(siDT.Rows[i][siDT.Columns.Count-1])+Convert.ToDouble(sEksiDT.Rows[i][sEksiDT.Columns.Count-1]));
                    }else if(j % 2 == 1)
                    {
                        sonucDT.Rows[i][j] = siDT.Rows[i][siDT.Columns.Count - 1];
                    }
                    else
                    {
                        sonucDT.Rows[i][j] = sEksiDT.Rows[i][sEksiDT.Columns.Count - 1];
                    }
                }
            }
            sonucDataGridView1.DataSource = sonucDT;
            sonucDataGridView1.ClearSelection();
            double buyukSayi = Convert.ToDouble(sonucDT.Rows[0][3]);
            for(int i = 0; i < sonucDT.Rows.Count; i++)
            {
                if(buyukSayi <= Convert.ToDouble(sonucDT.Rows[i][3]))
                {
                    buyukSayi = Convert.ToDouble(sonucDT.Rows[i][3]);
                    sonucDataGridView1.ClearSelection();
                    sonucDataGridView1.Rows[i].Selected = true;
                }
            }

        }

        
        
    }
}
