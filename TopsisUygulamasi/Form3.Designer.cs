namespace TopsisUygulamasi
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sonucBttn = new System.Windows.Forms.Button();
            this.sEksiDataGridView1 = new System.Windows.Forms.DataGridView();
            this.sİDataGridView1 = new System.Windows.Forms.DataGridView();
            this.sİBttn = new System.Windows.Forms.Button();
            this.nİdealDegerlerdataGridView1 = new System.Windows.Forms.DataGridView();
            this.idealDegerlerDataGridView1 = new System.Windows.Forms.DataGridView();
            this.idealCozumBttn = new System.Windows.Forms.Button();
            this.agirlandirilmisMatrisDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sEksiDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sİDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nİdealDegerlerdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idealDegerlerDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agirlandirilmisMatrisDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sonucBttn);
            this.panel1.Controls.Add(this.sEksiDataGridView1);
            this.panel1.Controls.Add(this.sİDataGridView1);
            this.panel1.Controls.Add(this.sİBttn);
            this.panel1.Controls.Add(this.nİdealDegerlerdataGridView1);
            this.panel1.Controls.Add(this.idealDegerlerDataGridView1);
            this.panel1.Controls.Add(this.idealCozumBttn);
            this.panel1.Controls.Add(this.agirlandirilmisMatrisDataGridView);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 893);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(717, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "İdeal ve İdeal Olmayan Noktalara Olan Uzaklık Değerlerinin Elde Edilmesi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(122, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "İdeal ve Negatif İdeal Çözüm Değerlerinin Elde Edilmesi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(164, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ağırlıklandırılmış Normalize Matrisinin Elde Edilmesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sonucBttn
            // 
            this.sonucBttn.BackColor = System.Drawing.Color.DarkGreen;
            this.sonucBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sonucBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucBttn.Location = new System.Drawing.Point(331, 840);
            this.sonucBttn.Name = "sonucBttn";
            this.sonucBttn.Size = new System.Drawing.Size(186, 35);
            this.sonucBttn.TabIndex = 7;
            this.sonucBttn.Text = "SONUÇ";
            this.sonucBttn.UseVisualStyleBackColor = false;
            this.sonucBttn.Click += new System.EventHandler(this.sonucBttn_Click);
            // 
            // sEksiDataGridView1
            // 
            this.sEksiDataGridView1.AllowUserToAddRows = false;
            this.sEksiDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sEksiDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.sEksiDataGridView1.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.sEksiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sEksiDataGridView1.Location = new System.Drawing.Point(66, 706);
            this.sEksiDataGridView1.Name = "sEksiDataGridView1";
            this.sEksiDataGridView1.RowHeadersVisible = false;
            this.sEksiDataGridView1.RowHeadersWidth = 51;
            this.sEksiDataGridView1.RowTemplate.Height = 24;
            this.sEksiDataGridView1.Size = new System.Drawing.Size(716, 133);
            this.sEksiDataGridView1.TabIndex = 6;
            // 
            // sİDataGridView1
            // 
            this.sİDataGridView1.AllowUserToAddRows = false;
            this.sİDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sİDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.sİDataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.sİDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sİDataGridView1.Location = new System.Drawing.Point(66, 567);
            this.sİDataGridView1.Name = "sİDataGridView1";
            this.sİDataGridView1.RowHeadersVisible = false;
            this.sİDataGridView1.RowHeadersWidth = 51;
            this.sİDataGridView1.RowTemplate.Height = 24;
            this.sİDataGridView1.Size = new System.Drawing.Size(716, 133);
            this.sİDataGridView1.TabIndex = 5;
            // 
            // sİBttn
            // 
            this.sİBttn.BackColor = System.Drawing.Color.Maroon;
            this.sİBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sİBttn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sİBttn.Location = new System.Drawing.Point(66, 475);
            this.sİBttn.Name = "sİBttn";
            this.sİBttn.Size = new System.Drawing.Size(716, 47);
            this.sİBttn.TabIndex = 4;
            this.sİBttn.Text = "İLERLE";
            this.sİBttn.UseVisualStyleBackColor = false;
            this.sİBttn.Click += new System.EventHandler(this.sİBttn_Click);
            // 
            // nİdealDegerlerdataGridView1
            // 
            this.nİdealDegerlerdataGridView1.AllowUserToAddRows = false;
            this.nİdealDegerlerdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nİdealDegerlerdataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.nİdealDegerlerdataGridView1.BackgroundColor = System.Drawing.Color.Red;
            this.nİdealDegerlerdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nİdealDegerlerdataGridView1.Location = new System.Drawing.Point(66, 377);
            this.nİdealDegerlerdataGridView1.Name = "nİdealDegerlerdataGridView1";
            this.nİdealDegerlerdataGridView1.RowHeadersVisible = false;
            this.nİdealDegerlerdataGridView1.RowHeadersWidth = 51;
            this.nİdealDegerlerdataGridView1.RowTemplate.Height = 24;
            this.nİdealDegerlerdataGridView1.Size = new System.Drawing.Size(716, 92);
            this.nİdealDegerlerdataGridView1.TabIndex = 3;
            // 
            // idealDegerlerDataGridView1
            // 
            this.idealDegerlerDataGridView1.AllowUserToAddRows = false;
            this.idealDegerlerDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.idealDegerlerDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.idealDegerlerDataGridView1.BackgroundColor = System.Drawing.Color.Chartreuse;
            this.idealDegerlerDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idealDegerlerDataGridView1.Location = new System.Drawing.Point(66, 282);
            this.idealDegerlerDataGridView1.Name = "idealDegerlerDataGridView1";
            this.idealDegerlerDataGridView1.RowHeadersVisible = false;
            this.idealDegerlerDataGridView1.RowHeadersWidth = 51;
            this.idealDegerlerDataGridView1.RowTemplate.Height = 24;
            this.idealDegerlerDataGridView1.Size = new System.Drawing.Size(716, 89);
            this.idealDegerlerDataGridView1.TabIndex = 2;
            // 
            // idealCozumBttn
            // 
            this.idealCozumBttn.BackColor = System.Drawing.Color.Brown;
            this.idealCozumBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idealCozumBttn.Location = new System.Drawing.Point(66, 202);
            this.idealCozumBttn.Name = "idealCozumBttn";
            this.idealCozumBttn.Size = new System.Drawing.Size(716, 38);
            this.idealCozumBttn.TabIndex = 1;
            this.idealCozumBttn.Text = "İLERLE";
            this.idealCozumBttn.UseVisualStyleBackColor = false;
            this.idealCozumBttn.Click += new System.EventHandler(this.idealCozumBttn_Click);
            // 
            // agirlandirilmisMatrisDataGridView
            // 
            this.agirlandirilmisMatrisDataGridView.AllowUserToAddRows = false;
            this.agirlandirilmisMatrisDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.agirlandirilmisMatrisDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.agirlandirilmisMatrisDataGridView.BackgroundColor = System.Drawing.Color.Gold;
            this.agirlandirilmisMatrisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agirlandirilmisMatrisDataGridView.Location = new System.Drawing.Point(66, 46);
            this.agirlandirilmisMatrisDataGridView.Name = "agirlandirilmisMatrisDataGridView";
            this.agirlandirilmisMatrisDataGridView.RowHeadersVisible = false;
            this.agirlandirilmisMatrisDataGridView.RowHeadersWidth = 51;
            this.agirlandirilmisMatrisDataGridView.RowTemplate.Height = 24;
            this.agirlandirilmisMatrisDataGridView.Size = new System.Drawing.Size(716, 150);
            this.agirlandirilmisMatrisDataGridView.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 896);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPSİS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sEksiDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sİDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nİdealDegerlerdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idealDegerlerDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agirlandirilmisMatrisDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView agirlandirilmisMatrisDataGridView;
        private System.Windows.Forms.DataGridView idealDegerlerDataGridView1;
        private System.Windows.Forms.Button idealCozumBttn;
        private System.Windows.Forms.DataGridView nİdealDegerlerdataGridView1;
        private System.Windows.Forms.DataGridView sİDataGridView1;
        private System.Windows.Forms.Button sİBttn;
        private System.Windows.Forms.DataGridView sEksiDataGridView1;
        private System.Windows.Forms.Button sonucBttn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}