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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleBttn_Click(object sender, EventArgs e)
        {
            
            if (maximumRadio.Checked)
            {
                Kriter kriter = new Kriter(kriterlerTxt.Text,"Maximum");
                kriterlerListbox.Items.Add(kriter);
            }
            else if (minimumRadio.Checked)
            {
                Kriter kriter = new Kriter(kriterlerTxt.Text, "Minimum");
                kriterlerListbox.Items.Add(kriter);
            }
            else
            {
                MessageBox.Show("Lütfen radiobox işaretleyiniz !!!");
            }

            if(agirlandirmaBttn.Visible == false && this.Width < 940)
            {
                this.Width = 940;
                agirlandirmaBttn.Visible = true;
            }
            kriterlerTxt.Clear();
            kriterlerTxt.Focus();
        }

        private void silBttn_Click(object sender, EventArgs e)
        {
            kriterlerListbox.Items.Remove(kriterlerListbox.SelectedItem);
        }

        private void agirlandirmaBttn_Click(object sender, EventArgs e)
        {
            if(agirliklandirmaGridview.Visible == false && dogrulaBttn.Visible == false && this.Height < 438)
            {
                this.Height = 438;
                agirliklandirmaGridview.Visible = true;
                dogrulaBttn.Visible = true;
            }

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = SystemColors.GradientActiveCaption;
            columnHeaderStyle.Font = new Font("Verdana",10,FontStyle.Bold);
            agirliklandirmaGridview.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            DataGridViewCellStyle rowHeaderStyle = new DataGridViewCellStyle();
            rowHeaderStyle.BackColor = SystemColors.MenuHighlight;
            rowHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Regular);
            agirliklandirmaGridview.RowHeadersVisible = Visible;
            agirliklandirmaGridview.RowHeadersDefaultCellStyle = rowHeaderStyle;

            DataTable agirlikTablosu = new DataTable();
            foreach(Kriter kriter in kriterlerListbox.Items)
            {
                agirlikTablosu.Columns.Add(kriter.Adi);
            }
            agirliklandirmaGridview.DataSource=agirlikTablosu;
            agirliklandirmaGridview.Rows[0].HeaderCell.Value = "Ağırlıklar(virgüllü)";
        }

        public List<Kriter> kriterList = new List<Kriter>();
        private void dogrulaBttn_Click(object sender, EventArgs e)
        {
            int i = 0;
            
            foreach (Kriter kriter in kriterlerListbox.Items)
            {
                kriter.Agirlik = Convert.ToDouble(agirliklandirmaGridview.Rows[0].Cells[i].Value);
                
                kriterList.Add(kriter);
                i++;
            }

            if(this.Height < 531)
            {
                this.Height = 531;
                topsisGitBttn.Visible = true;
            }
            
        }

        private void topsisGitBttn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this.kriterList);
            form2.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
