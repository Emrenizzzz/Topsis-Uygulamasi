namespace TopsisUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.topsisGitBttn = new System.Windows.Forms.Button();
            this.dogrulaBttn = new System.Windows.Forms.Button();
            this.agirliklandirmaGridview = new System.Windows.Forms.DataGridView();
            this.agirlandirmaBttn = new System.Windows.Forms.Button();
            this.kriterlerListbox = new System.Windows.Forms.ListBox();
            this.silBttn = new System.Windows.Forms.Button();
            this.ekleBttn = new System.Windows.Forms.Button();
            this.minimumRadio = new System.Windows.Forms.RadioButton();
            this.maximumRadio = new System.Windows.Forms.RadioButton();
            this.kriterlerTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agirliklandirmaGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.topsisGitBttn);
            this.panel1.Controls.Add(this.dogrulaBttn);
            this.panel1.Controls.Add(this.agirliklandirmaGridview);
            this.panel1.Controls.Add(this.agirlandirmaBttn);
            this.panel1.Controls.Add(this.kriterlerListbox);
            this.panel1.Controls.Add(this.silBttn);
            this.panel1.Controls.Add(this.ekleBttn);
            this.panel1.Controls.Add(this.minimumRadio);
            this.panel1.Controls.Add(this.maximumRadio);
            this.panel1.Controls.Add(this.kriterlerTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 434);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(267, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ağırlıklandırma";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // topsisGitBttn
            // 
            this.topsisGitBttn.BackColor = System.Drawing.Color.CadetBlue;
            this.topsisGitBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topsisGitBttn.Location = new System.Drawing.Point(56, 378);
            this.topsisGitBttn.Name = "topsisGitBttn";
            this.topsisGitBttn.Size = new System.Drawing.Size(817, 53);
            this.topsisGitBttn.TabIndex = 11;
            this.topsisGitBttn.Text = "Topsis\'e Git";
            this.topsisGitBttn.UseVisualStyleBackColor = false;
            this.topsisGitBttn.Visible = false;
            this.topsisGitBttn.Click += new System.EventHandler(this.topsisGitBttn_Click);
            // 
            // dogrulaBttn
            // 
            this.dogrulaBttn.BackColor = System.Drawing.Color.BlueViolet;
            this.dogrulaBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogrulaBttn.Location = new System.Drawing.Point(708, 296);
            this.dogrulaBttn.Name = "dogrulaBttn";
            this.dogrulaBttn.Size = new System.Drawing.Size(165, 48);
            this.dogrulaBttn.TabIndex = 10;
            this.dogrulaBttn.Text = "Doğrula";
            this.dogrulaBttn.UseVisualStyleBackColor = false;
            this.dogrulaBttn.Visible = false;
            this.dogrulaBttn.Click += new System.EventHandler(this.dogrulaBttn_Click);
            // 
            // agirliklandirmaGridview
            // 
            this.agirliklandirmaGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.agirliklandirmaGridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.agirliklandirmaGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.agirliklandirmaGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.agirliklandirmaGridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.agirliklandirmaGridview.Location = new System.Drawing.Point(56, 296);
            this.agirliklandirmaGridview.Name = "agirliklandirmaGridview";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.agirliklandirmaGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.agirliklandirmaGridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.agirliklandirmaGridview.RowTemplate.Height = 24;
            this.agirliklandirmaGridview.Size = new System.Drawing.Size(624, 48);
            this.agirliklandirmaGridview.TabIndex = 9;
            this.agirliklandirmaGridview.Visible = false;
            // 
            // agirlandirmaBttn
            // 
            this.agirlandirmaBttn.BackColor = System.Drawing.Color.Gold;
            this.agirlandirmaBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.agirlandirmaBttn.Location = new System.Drawing.Point(708, 37);
            this.agirlandirmaBttn.Name = "agirlandirmaBttn";
            this.agirlandirmaBttn.Size = new System.Drawing.Size(165, 180);
            this.agirlandirmaBttn.TabIndex = 8;
            this.agirlandirmaBttn.Text = "Doğrudan Ağırlıklandırma";
            this.agirlandirmaBttn.UseVisualStyleBackColor = false;
            this.agirlandirmaBttn.Visible = false;
            this.agirlandirmaBttn.Click += new System.EventHandler(this.agirlandirmaBttn_Click);
            // 
            // kriterlerListbox
            // 
            this.kriterlerListbox.BackColor = System.Drawing.SystemColors.Info;
            this.kriterlerListbox.FormattingEnabled = true;
            this.kriterlerListbox.ItemHeight = 16;
            this.kriterlerListbox.Location = new System.Drawing.Point(524, 37);
            this.kriterlerListbox.Name = "kriterlerListbox";
            this.kriterlerListbox.Size = new System.Drawing.Size(156, 180);
            this.kriterlerListbox.TabIndex = 7;
            // 
            // silBttn
            // 
            this.silBttn.BackColor = System.Drawing.Color.Red;
            this.silBttn.Location = new System.Drawing.Point(409, 165);
            this.silBttn.Name = "silBttn";
            this.silBttn.Size = new System.Drawing.Size(75, 23);
            this.silBttn.TabIndex = 6;
            this.silBttn.Text = "Sil";
            this.silBttn.UseVisualStyleBackColor = false;
            this.silBttn.Click += new System.EventHandler(this.silBttn_Click);
            // 
            // ekleBttn
            // 
            this.ekleBttn.BackColor = System.Drawing.Color.LawnGreen;
            this.ekleBttn.Location = new System.Drawing.Point(294, 165);
            this.ekleBttn.Name = "ekleBttn";
            this.ekleBttn.Size = new System.Drawing.Size(75, 23);
            this.ekleBttn.TabIndex = 5;
            this.ekleBttn.Text = "Ekle";
            this.ekleBttn.UseVisualStyleBackColor = false;
            this.ekleBttn.Click += new System.EventHandler(this.ekleBttn_Click);
            // 
            // minimumRadio
            // 
            this.minimumRadio.AutoSize = true;
            this.minimumRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minimumRadio.Location = new System.Drawing.Point(394, 109);
            this.minimumRadio.Name = "minimumRadio";
            this.minimumRadio.Size = new System.Drawing.Size(90, 22);
            this.minimumRadio.TabIndex = 4;
            this.minimumRadio.TabStop = true;
            this.minimumRadio.Text = "Minimum";
            this.minimumRadio.UseVisualStyleBackColor = true;
            // 
            // maximumRadio
            // 
            this.maximumRadio.AutoSize = true;
            this.maximumRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maximumRadio.Location = new System.Drawing.Point(294, 109);
            this.maximumRadio.Name = "maximumRadio";
            this.maximumRadio.Size = new System.Drawing.Size(94, 22);
            this.maximumRadio.TabIndex = 3;
            this.maximumRadio.TabStop = true;
            this.maximumRadio.Text = "Maximum";
            this.maximumRadio.UseVisualStyleBackColor = true;
            // 
            // kriterlerTxt
            // 
            this.kriterlerTxt.Location = new System.Drawing.Point(294, 70);
            this.kriterlerTxt.Name = "kriterlerTxt";
            this.kriterlerTxt.Size = new System.Drawing.Size(190, 22);
            this.kriterlerTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(330, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kriterler";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::TopsisUygulamasi.Properties.Resources.olduOldu;
            this.pictureBox1.Location = new System.Drawing.Point(56, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.ekleBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(695, 233);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPSİS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agirliklandirmaGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton minimumRadio;
        private System.Windows.Forms.RadioButton maximumRadio;
        private System.Windows.Forms.TextBox kriterlerTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox kriterlerListbox;
        private System.Windows.Forms.Button silBttn;
        private System.Windows.Forms.Button ekleBttn;
        private System.Windows.Forms.Button agirlandirmaBttn;
        private System.Windows.Forms.DataGridView agirliklandirmaGridview;
        private System.Windows.Forms.Button dogrulaBttn;
        private System.Windows.Forms.Button topsisGitBttn;
        private System.Windows.Forms.Label label2;
    }
}

