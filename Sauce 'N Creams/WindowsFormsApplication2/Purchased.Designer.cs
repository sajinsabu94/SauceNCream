namespace WindowsFormsApplication2
{
    partial class Purchased
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.agency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchased";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.agency);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 516);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(357, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 19);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // agency
            // 
            this.agency.Location = new System.Drawing.Point(96, 70);
            this.agency.Name = "agency";
            this.agency.Size = new System.Drawing.Size(205, 20);
            this.agency.TabIndex = 3;
            this.agency.TextChanged += new System.EventHandler(this.agency_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bill No :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1259, 403);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1262, 382);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // SlNo
            // 
            this.SlNo.DividerWidth = 2;
            this.SlNo.HeaderText = "Sl. No.";
            this.SlNo.Name = "SlNo";
            this.SlNo.ReadOnly = true;
            this.SlNo.Width = 35;
            // 
            // PrdNam
            // 
            this.PrdNam.HeaderText = "Product Name";
            this.PrdNam.Name = "PrdNam";
            this.PrdNam.Width = 210;
            // 
            // Mrp
            // 
            this.Mrp.HeaderText = "MRP";
            this.Mrp.Name = "Mrp";
            this.Mrp.Width = 80;
            // 
            // Vat
            // 
            this.Vat.HeaderText = "VAT %";
            this.Vat.Name = "Vat";
            this.Vat.Width = 80;
            // 
            // RteUnt
            // 
            this.RteUnt.HeaderText = "Rate/Unit";
            this.RteUnt.Name = "RteUnt";
            this.RteUnt.Width = 85;
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
            this.Qntyunt.Width = 80;
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
            this.TtlAmt.Width = 80;
            // 
            // SchUnt
            // 
            this.SchUnt.HeaderText = "Sch Unit";
            this.SchUnt.Name = "SchUnt";
            this.SchUnt.Width = 80;
            // 
            // Purchased
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 519);
            this.Controls.Add(this.panel1);
            this.Name = "Purchased";
            this.Text = "Purchased";
            this.Load += new System.EventHandler(this.Purchased_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox agency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button button1;
    }
}