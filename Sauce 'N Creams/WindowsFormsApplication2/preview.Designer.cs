namespace WindowsFormsApplication2
{
    partial class preview
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sl_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rs = new System.Windows.Forms.TextBox();
            this.vt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.net_amt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datepre = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.bill_no = new System.Windows.Forms.Label();
            this.billno = new System.Windows.Forms.Label();
            this.heading2 = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
            this.sauce = new System.Windows.Forms.Label();
            this.tin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.rs);
            this.panel1.Controls.Add(this.vt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.datepre);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.bill_no);
            this.panel1.Controls.Add(this.billno);
            this.panel1.Controls.Add(this.heading2);
            this.panel1.Controls.Add(this.heading);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.sauce);
            this.panel1.Controls.Add(this.tin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 495);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(3, 206);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 166);
            this.panel4.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sl_no,
            this.itm_name,
            this.qty,
            this.rate,
            this.vat,
            this.amt});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 24;
            this.dataGridView1.Size = new System.Drawing.Size(486, 166);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sl_no
            // 
            this.sl_no.HeaderText = "#";
            this.sl_no.Name = "sl_no";
            this.sl_no.ReadOnly = true;
            this.sl_no.Width = 30;
            // 
            // itm_name
            // 
            this.itm_name.HeaderText = "Item Name";
            this.itm_name.Name = "itm_name";
            this.itm_name.ReadOnly = true;
            this.itm_name.Width = 225;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 35;
            // 
            // rate
            // 
            this.rate.HeaderText = "Rate";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            this.rate.Width = 50;
            // 
            // vat
            // 
            this.vat.HeaderText = "VAT%";
            this.vat.Name = "vat";
            this.vat.ReadOnly = true;
            this.vat.Width = 50;
            // 
            // amt
            // 
            this.amt.HeaderText = "Amount";
            this.amt.Name = "amt";
            this.amt.ReadOnly = true;
            this.amt.Width = 75;
            // 
            // rs
            // 
            this.rs.Enabled = false;
            this.rs.Location = new System.Drawing.Point(93, 461);
            this.rs.Name = "rs";
            this.rs.ReadOnly = true;
            this.rs.Size = new System.Drawing.Size(268, 21);
            this.rs.TabIndex = 15;
            // 
            // vt
            // 
            this.vt.Enabled = false;
            this.vt.Location = new System.Drawing.Point(93, 430);
            this.vt.Name = "vt";
            this.vt.Size = new System.Drawing.Size(93, 21);
            this.vt.TabIndex = 14;
            this.vt.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rupees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "VAT%";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.net_amt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 41);
            this.panel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rs";
            // 
            // net_amt
            // 
            this.net_amt.Enabled = false;
            this.net_amt.Location = new System.Drawing.Point(357, 15);
            this.net_amt.Name = "net_amt";
            this.net_amt.Size = new System.Drawing.Size(67, 21);
            this.net_amt.TabIndex = 1;
            this.net_amt.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "NET AMOUNT";
            // 
            // datepre
            // 
            this.datepre.AutoSize = true;
            this.datepre.Location = new System.Drawing.Point(442, 189);
            this.datepre.Name = "datepre";
            this.datepre.Size = new System.Drawing.Size(37, 13);
            this.datepre.TabIndex = 9;
            this.datepre.Text = "label2";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(391, 188);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(33, 14);
            this.date.TabIndex = 8;
            this.date.Text = "Date";
            // 
            // bill_no
            // 
            this.bill_no.AutoSize = true;
            this.bill_no.Location = new System.Drawing.Point(73, 190);
            this.bill_no.Name = "bill_no";
            this.bill_no.Size = new System.Drawing.Size(37, 13);
            this.bill_no.TabIndex = 7;
            this.bill_no.Text = "label2";
            // 
            // billno
            // 
            this.billno.AutoSize = true;
            this.billno.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billno.Location = new System.Drawing.Point(14, 189);
            this.billno.Name = "billno";
            this.billno.Size = new System.Drawing.Size(50, 14);
            this.billno.TabIndex = 6;
            this.billno.Text = "BILL NO.";
            // 
            // heading2
            // 
            this.heading2.AutoSize = true;
            this.heading2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading2.Location = new System.Drawing.Point(185, 144);
            this.heading2.Name = "heading2";
            this.heading2.Size = new System.Drawing.Size(104, 15);
            this.heading2.TabIndex = 5;
            this.heading2.Text = "TAX INVOICE Cash";
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(117, 109);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(244, 13);
            this.heading.TabIndex = 4;
            this.heading.Text = "THE KERALA VALUE ADDED TAX RULES, 2003 FORM 8B";
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(203, 61);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(66, 30);
            this.add.TabIndex = 3;
            this.add.Text = "Kangath Jn\r\nKollam-12\r\n";
            // 
            // sauce
            // 
            this.sauce.AutoSize = true;
            this.sauce.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sauce.Location = new System.Drawing.Point(184, 42);
            this.sauce.Name = "sauce";
            this.sauce.Size = new System.Drawing.Size(112, 19);
            this.sauce.TabIndex = 2;
            this.sauce.Text = "sauce \'N cream";
            // 
            // tin
            // 
            this.tin.AutoSize = true;
            this.tin.Location = new System.Drawing.Point(62, 21);
            this.tin.Name = "tin";
            this.tin.Size = new System.Drawing.Size(73, 13);
            this.tin.TabIndex = 1;
            this.tin.Text = "32020800456";
            this.tin.Click += new System.EventHandler(this.tin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIN";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(1, 495);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 41);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thank You .... Come Again ......!!!";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(359, 542);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 23);
            this.print.TabIndex = 2;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 565);
            this.Controls.Add(this.print);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "preview";
            this.Text = "Preview";
            this.Load += new System.EventHandler(this.preview_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label datepre;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label bill_no;
        private System.Windows.Forms.Label billno;
        private System.Windows.Forms.Label heading2;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.Label sauce;
        private System.Windows.Forms.Label tin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rs;
        public System.Windows.Forms.TextBox vt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox net_amt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn itm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn amt;
    }
}