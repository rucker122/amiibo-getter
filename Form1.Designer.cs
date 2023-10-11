namespace amiibo_getter
{
    partial class amiibo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Fetch = new System.Windows.Forms.Button();
            this.gv_amiibo = new System.Windows.Forms.DataGridView();
            this.gv_Idno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_AmiiboName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_AmiiboSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.processBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tp_Table = new System.Windows.Forms.TabControl();
            this.tabTable = new System.Windows.Forms.TabPage();
            this.tabJson = new System.Windows.Forms.TabPage();
            this.tb_Json = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_amiibo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tp_Table.SuspendLayout();
            this.tabTable.SuspendLayout();
            this.tabJson.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Fetch
            // 
            this.btn_Fetch.Location = new System.Drawing.Point(713, 3);
            this.btn_Fetch.Name = "btn_Fetch";
            this.btn_Fetch.Size = new System.Drawing.Size(175, 78);
            this.btn_Fetch.TabIndex = 0;
            this.btn_Fetch.Text = "Fetch";
            this.btn_Fetch.UseVisualStyleBackColor = true;
            this.btn_Fetch.Click += new System.EventHandler(this.btn_Fetch_Click);
            // 
            // gv_amiibo
            // 
            this.gv_amiibo.AllowUserToAddRows = false;
            this.gv_amiibo.AllowUserToDeleteRows = false;
            this.gv_amiibo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gv_amiibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_amiibo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gv_Idno,
            this.gv_AmiiboName,
            this.gv_AmiiboSeries,
            this.gv_ReleaseDate});
            this.gv_amiibo.Location = new System.Drawing.Point(0, 0);
            this.gv_amiibo.Name = "gv_amiibo";
            this.gv_amiibo.ReadOnly = true;
            this.gv_amiibo.RowTemplate.Height = 25;
            this.gv_amiibo.Size = new System.Drawing.Size(642, 420);
            this.gv_amiibo.TabIndex = 2;
            this.gv_amiibo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_amiibo_CellContentClick);
            // 
            // gv_Idno
            // 
            this.gv_Idno.HeaderText = "Idno";
            this.gv_Idno.Name = "gv_Idno";
            this.gv_Idno.ReadOnly = true;
            this.gv_Idno.Width = 82;
            // 
            // gv_AmiiboName
            // 
            this.gv_AmiiboName.HeaderText = "AmiiboName";
            this.gv_AmiiboName.Name = "gv_AmiiboName";
            this.gv_AmiiboName.ReadOnly = true;
            this.gv_AmiiboName.Width = 164;
            // 
            // gv_AmiiboSeries
            // 
            this.gv_AmiiboSeries.HeaderText = "AmiiboSeries";
            this.gv_AmiiboSeries.Name = "gv_AmiiboSeries";
            this.gv_AmiiboSeries.ReadOnly = true;
            this.gv_AmiiboSeries.Width = 192;
            // 
            // gv_ReleaseDate
            // 
            this.gv_ReleaseDate.HeaderText = "ReleaseDate";
            this.gv_ReleaseDate.Name = "gv_ReleaseDate";
            this.gv_ReleaseDate.ReadOnly = true;
            this.gv_ReleaseDate.Width = 128;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(891, 22);
            this.statusStrip1.TabIndex = 100;
            // 
            // processBar
            // 
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Fetch);
            this.panel1.Location = new System.Drawing.Point(0, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 84);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tp_Table);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 454);
            this.panel2.TabIndex = 8;
            // 
            // tp_Table
            // 
            this.tp_Table.Controls.Add(this.tabTable);
            this.tp_Table.Controls.Add(this.tabJson);
            this.tp_Table.Location = new System.Drawing.Point(242, 3);
            this.tp_Table.Name = "tp_Table";
            this.tp_Table.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tp_Table.SelectedIndex = 0;
            this.tp_Table.Size = new System.Drawing.Size(646, 448);
            this.tp_Table.TabIndex = 5;
            // 
            // tabTable
            // 
            this.tabTable.Controls.Add(this.gv_amiibo);
            this.tabTable.Location = new System.Drawing.Point(4, 24);
            this.tabTable.Name = "tabTable";
            this.tabTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTable.Size = new System.Drawing.Size(638, 420);
            this.tabTable.TabIndex = 0;
            this.tabTable.Text = "Table";
            this.tabTable.UseVisualStyleBackColor = true;
            // 
            // tabJson
            // 
            this.tabJson.Controls.Add(this.tb_Json);
            this.tabJson.Location = new System.Drawing.Point(4, 24);
            this.tabJson.Name = "tabJson";
            this.tabJson.Padding = new System.Windows.Forms.Padding(3);
            this.tabJson.Size = new System.Drawing.Size(638, 420);
            this.tabJson.TabIndex = 1;
            this.tabJson.Text = "Json";
            this.tabJson.UseVisualStyleBackColor = true;
            // 
            // tb_Json
            // 
            this.tb_Json.Location = new System.Drawing.Point(0, 0);
            this.tb_Json.Multiline = true;
            this.tb_Json.Name = "tb_Json";
            this.tb_Json.Size = new System.Drawing.Size(642, 417);
            this.tb_Json.TabIndex = 0;
            // 
            // amiibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(891, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "amiibo";
            this.Text = "amiibo-getter v0.1 [https://github.com/rucker122/amiibo-getter]";
            ((System.ComponentModel.ISupportInitialize)(this.gv_amiibo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tp_Table.ResumeLayout(false);
            this.tabTable.ResumeLayout(false);
            this.tabJson.ResumeLayout(false);
            this.tabJson.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Fetch;
        private DataGridView gv_amiibo;
        private DataGridViewTextBoxColumn gv_Idno;
        private DataGridViewTextBoxColumn gv_AmiiboName;
        private DataGridViewTextBoxColumn gv_AmiiboSeries;
        private DataGridViewTextBoxColumn gv_ReleaseDate;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel processBar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private TabControl tp_Table;
        private TabPage tabTable;
        private TabPage tabJson;
        private TextBox tb_Json;
    }
}