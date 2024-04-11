namespace WindowsFormsApplication2
{
    partial class Stock_report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 156);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 292);
            this.panel2.TabIndex = 4;
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(505, 100);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.PrdNam.Width = 275;
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
            this.RteUnt.Width = 95;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Retail Invoice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "      Kangath  jn, \r\n       Kollam- 12\r\nPh. No : 9847091294\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "sauce \'N creams";
            // 
            // Stock_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stock_report";
            this.Text = "Retail Invoice";
            this.Load += new System.EventHandler(this.Stock_report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Panel panel2;
    }
}