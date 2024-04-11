namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainStock = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bilno = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.agency = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrdNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RteUnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qntcse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qntyunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrsVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CshDsct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NtAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TtlAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchUnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.mainStock.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStock
            // 
            this.mainStock.AutoSize = true;
            this.mainStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainStock.Controls.Add(this.label16);
            this.mainStock.Controls.Add(this.panel1);
            this.mainStock.Controls.Add(this.splitter1);
            this.mainStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainStock.Location = new System.Drawing.Point(0, 0);
            this.mainStock.Name = "mainStock";
            this.mainStock.Size = new System.Drawing.Size(1354, 189);
            this.mainStock.TabIndex = 0;
            this.mainStock.Paint += new System.Windows.Forms.PaintEventHandler(this.mainStock_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(579, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(226, 45);
            this.label16.TabIndex = 2;
            this.label16.Text = "STOCK ENTRY";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.bilno);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.tin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.phno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.agency);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 127);
            this.panel1.TabIndex = 1;
            // 
            // bilno
            // 
            this.bilno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilno.Location = new System.Drawing.Point(1047, 90);
            this.bilno.Name = "bilno";
            this.bilno.Size = new System.Drawing.Size(264, 24);
            this.bilno.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(949, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Bill No.  : ";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // tin
            // 
            this.tin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tin.Location = new System.Drawing.Point(1047, 36);
            this.tin.Name = "tin";
            this.tin.Size = new System.Drawing.Size(264, 24);
            this.tin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(949, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tin : ";
            // 
            // phno
            // 
            this.phno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phno.Location = new System.Drawing.Point(105, 94);
            this.phno.Name = "phno";
            this.phno.Size = new System.Drawing.Size(264, 24);
            this.phno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone No :";
            // 
            // agency
            // 
            this.agency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agency.Location = new System.Drawing.Point(105, 36);
            this.agency.Name = "agency";
            this.agency.Size = new System.Drawing.Size(264, 24);
            this.agency.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agency :";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 187);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.PrdNam,
            this.Mrp,
            this.Vat,
            this.RteUnt,
            this.Qntcse,
            this.Qntyunt,
            this.GrsVal,
            this.CshDsct,
            this.Schme,
            this.NtAmt,
            this.VatAmt,
            this.TtlAmt,
            this.SchUnt});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1354, 311);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // SlNo
            // 
            this.SlNo.DividerWidth = 2;
            this.SlNo.HeaderText = "Sl. No.";
            this.SlNo.Name = "SlNo";
            this.SlNo.ReadOnly = true;
            this.SlNo.Width = 40;
            // 
            // PrdNam
            // 
            this.PrdNam.HeaderText = "Product Name";
            this.PrdNam.Name = "PrdNam";
            this.PrdNam.Width = 260;
            // 
            // Mrp
            // 
            this.Mrp.HeaderText = "MRP";
            this.Mrp.Name = "Mrp";
            this.Mrp.Width = 90;
            // 
            // Vat
            // 
            this.Vat.HeaderText = "VAT %";
            this.Vat.Name = "Vat";
            this.Vat.Width = 85;
            // 
            // RteUnt
            // 
            this.RteUnt.HeaderText = "Rate/Unit";
            this.RteUnt.Name = "RteUnt";
            this.RteUnt.Width = 90;
            // 
            // Qntcse
            // 
            this.Qntcse.HeaderText = "Quantity Case";
            this.Qntcse.Name = "Qntcse";
            this.Qntcse.Width = 85;
            // 
            // Qntyunt
            // 
            this.Qntyunt.HeaderText = "Quantity Unit";
            this.Qntyunt.Name = "Qntyunt";
            this.Qntyunt.Width = 85;
            // 
            // GrsVal
            // 
            this.GrsVal.HeaderText = "Gross Value";
            this.GrsVal.Name = "GrsVal";
            this.GrsVal.Width = 85;
            // 
            // CshDsct
            // 
            this.CshDsct.HeaderText = "Cash Discount";
            this.CshDsct.Name = "CshDsct";
            this.CshDsct.Width = 85;
            // 
            // Schme
            // 
            this.Schme.HeaderText = "Scheme Discount";
            this.Schme.Name = "Schme";
            this.Schme.Width = 85;
            // 
            // NtAmt
            // 
            this.NtAmt.HeaderText = "Net Amount";
            this.NtAmt.Name = "NtAmt";
            this.NtAmt.Width = 90;
            // 
            // VatAmt
            // 
            this.VatAmt.HeaderText = "VAT Amount";
            this.VatAmt.Name = "VatAmt";
            this.VatAmt.Width = 85;
            // 
            // TtlAmt
            // 
            this.TtlAmt.HeaderText = "Total Amount";
            this.TtlAmt.Name = "TtlAmt";
            this.TtlAmt.Width = 93;
            // 
            // SchUnt
            // 
            this.SchUnt.HeaderText = "Sch Unit";
            this.SchUnt.Name = "SchUnt";
            this.SchUnt.Width = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(748, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(831, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(911, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1011, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1095, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1181, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1278, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(593, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Less Amount Rs. :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(748, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1027, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 23);
            this.label13.TabIndex = 12;
            this.label13.Text = "Net Amount Rs. :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1181, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 477);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1354, 128);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(162, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(687, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Date : ";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(744, 94);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(41, 13);
            this.date.TabIndex = 9;
            this.date.Text = "label18";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1354, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mainStock);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Stock Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainStock.ResumeLayout(false);
            this.mainStock.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainStock;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox agency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox bilno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrdNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn RteUnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qntcse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qntyunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrsVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CshDsct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schme;
        private System.Windows.Forms.DataGridViewTextBoxColumn NtAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TtlAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchUnt;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label17;
    }
}

