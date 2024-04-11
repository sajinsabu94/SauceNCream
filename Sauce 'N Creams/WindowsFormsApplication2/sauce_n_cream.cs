using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace WindowsFormsApplication2
{
    public partial class sauce_n_cream : Form
    {
        public String mmm;
        preview cx = null;
        public sauce_n_cream(String xx)
        {
            InitializeComponent();
            currentStockToolStripMenuItem.Enabled = false;
            currentStockToolStripMenuItem.Visible = false;
            if (xx.Equals("usr"))
            {
                
                //stockToolStripMenuItem nw;
                stockToolStripMenuItem.Enabled = false;
                mmm = "usr";
            }
            else {
                mmm = "admn";
            }
           
        }
        public sauce_n_cream()
        {
           
        }
       private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
           
                if (dataGridView1.Rows.Count >= 1 && dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value == null)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Index);
                }

                try
                {

                    if (dataGridView1.Rows.Count >= 1 && dataGridView1.Rows[0].Cells[1].Value.ToString() != null)
                    {
                        preview f = new preview();
                        f.print.Click += new EventHandler(XEvent);
                        //f.MdiParent = this;
                        f.Show();
                        f.CopyDataGridView(this.dataGridView1);

                    }
                    else
                    {
                        MessageBox.Show("No Items in Cart..!");
                    }

                }
                catch (Exception sp)
                {
                    MessageBox.Show("No Items in Cart..!");
                }
            
            
            
        }

        private void sauce_n_cream_Load(object sender, EventArgs e)
        {
           // Login l = new Login();
            //l.Visible = false;
           // l.Close();
            WindowState = FormWindowState.Maximized;
            date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            dataGridView1.Rows.Add("1");
            DataGridViewRow rowToSelect = this.dataGridView1.CurrentRow;
            rowToSelect.Selected = false;
            rowToSelect.Cells[1].Selected = true;
            this.dataGridView1.CurrentCell = rowToSelect.Cells[1];
            SqlDataReader dreader1;
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select max(BillNo) as BillNo from Bill";
            conn.Open();
            dreader1 = cmd.ExecuteReader();
            int c;
            c = 1;
           // MessageBox.Show("x");
            //MessageBox.Show(dreader.ToString());
            if (dreader1.HasRows == true)
            {
                while (dreader1.Read())
                        bill_no.Text = Convert.ToInt32(Convert.ToInt32(dreader1["BillNo"])+Convert.ToInt32(c)).ToString();
            }
           // bill_no.Text = dreader[0].ToString();
            conn.Close();
            dreader1.Close();
            try
            {
                String mnth = DateTime.Now.Month.ToString();
                String yr = DateTime.Now.Year.ToString();
                SqlDataReader dreader2;
                SqlConnection conn2 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn2;
                cmd2.CommandText = "select max(date) from StockDetls where date like ___" + mnth + "_" + yr + "";
                conn2.Open();
                dreader2 = cmd2.ExecuteReader();
                dreader2.Read();
                if (dreader2.HasRows == false)
                {
                    String qry = "Insert into Remain values(select PdNam,Rate,Qun,date from StockDetls)";
                    SqlCommand cm = new SqlCommand(qry, conn2);
                    cm.Connection.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();

                }
                dreader2.Close();
            }
            catch (Exception xy)
            {
                //MessageBox.Show(xy.Message);
            }
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyData == Keys.Enter)
                {
                    int row2 = dataGridView1.CurrentRow.Index;
                   try
                    {
                        if (dataGridView1.Rows[row2].Cells[2].Value.ToString() == null || dataGridView1.Rows[row2].Cells[3].Value.ToString()==null)
                        {
                            MessageBox.Show("Check Your Entry..!");
                        }
                       else
                        {
                            int col = dataGridView1.CurrentCell.ColumnIndex;
                            int row = dataGridView1.CurrentCell.RowIndex;

                            if (col < dataGridView1.ColumnCount - 1)
                            {
                                col++;
                            }
                            else
                            {
                                col = 0;
                                row++;
                            }

                            if (row == dataGridView1.RowCount)
                                dataGridView1.Rows.Add();
                            dataGridView1.CurrentCell = dataGridView1[col, row];
                            e.Handled = true;
                         }
                        Decimal sum = 0,vat = 0;
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                            vat += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                        }
                        net_amt.Text = sum.ToString();
                        vt.Text = vat.ToString();
                    }
                    catch (Exception it)
                    {
                        //MessageBox.Show("Enter Quantities..!");
                    }
        }
            else if (e.KeyData == Keys.Tab)
                    {

                     }
            else
                     {
                      MessageBox.Show("Check Your Entries..!");
                     }
                
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            //this.dataGridView1.Rows[e.RowIndex].Cells[2].Value = 1;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void stockEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form1 f = new Form1();
           f.Show();
        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Purchased p = new Purchased();
            p.Show();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {                
                SqlDataReader dreader2;                
                SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
                SqlCommand cmd = new SqlCommand();
                SqlCommand cmd3 = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                AutoCompleteStringCollection acBusIDSorce = new AutoCompleteStringCollection();
                cmd.CommandText = "Select PdNam from StockDetls Union Select Item from Others";
                conn.Open();
                dreader2 = cmd.ExecuteReader();
                if (dreader2.HasRows == true)
                {
                    while (dreader2.Read())
                        acBusIDSorce.Add(dreader2["PdNam"].ToString());
                }
                else
                {
                    //MessageBox.Show("New Item..!");
                }
                
                TextBox txtBusID = e.Control as TextBox;
                if (txtBusID != null)
                {
                    txtBusID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtBusID.AutoCompleteCustomSource = acBusIDSorce;
                    txtBusID.AutoCompleteSource = AutoCompleteSource.CustomSource;

                }
                conn.Close();
                dreader2.Close();
                   
              }
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int clm = e.ColumnIndex;
                String sp = "nope";
                String itx = "";
                if (dataGridView1.Columns[clm].Name == "item")
                {
                    SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
                    SqlDataReader dreader4;
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = conn;
                    String it = "";
                    int row = dataGridView1.CurrentCell.RowIndex;
                    it = dataGridView1.Rows[row].Cells[clm].Value.ToString();
                    cmd2.CommandText = "Select Mrp,Vat from StockDetls where PdNam = '" + it + "' UNION Select Rate,Vat from Others where Item = '" + it + "' ";
                    conn.Open();
                    dreader4 = cmd2.ExecuteReader();
                    if (dreader4.HasRows == true)
                    {
                        while (dreader4.Read())
                        {
                            var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                            cell.OwningRow.Cells["Rate"].Value = (dreader4["Mrp"].ToString());
                            cell.OwningRow.Cells["vat"].Value = (dreader4["Vat"].ToString());
                            dataGridView1.Rows[row].Cells[2].Value = 1;

                            if (dataGridView1.Rows[row].Cells[2].Value.ToString().Equals(1))
                            {
                                Decimal amt = Convert.ToDecimal(dataGridView1.Rows[row].Cells[2].Value.ToString()) * Convert.ToDecimal(dataGridView1.Rows[row].Cells[3].Value.ToString());
                                dataGridView1.Rows[row].Cells[5].Value = amt;
                                cell.OwningRow.Cells["qty"].Value = 1;
                                int sum = 0;
                                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                {
                                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                                }
                                net_amt.Text = sum.ToString();
                            }
                            else if (Convert.ToInt16(dataGridView1.Rows[row].Cells[2].Value) > 0)
                            {
                                Decimal amt = Convert.ToDecimal(dataGridView1.Rows[row].Cells[2].Value.ToString()) * Convert.ToDecimal(dataGridView1.Rows[row].Cells[3].Value.ToString());
                                dataGridView1.Rows[row].Cells[5].Value = amt;
                                cell.OwningRow.Cells["qty"].Value = 1;
                            }
                        }

                        dreader4.Close();
                        conn.Close();
                    }
                    try
                    {
                        SqlConnection connx = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
                        SqlDataReader dreader4x;
                        SqlCommand cmd2x = new SqlCommand();
                        cmd2x.Connection = connx;

                        int rowx = dataGridView1.CurrentCell.RowIndex;
                        itx = dataGridView1.Rows[rowx].Cells[clm].Value.ToString();
                        cmd2x.CommandText = "Select Item,Rate from Others where Item = '" + itx + "' ";
                        connx.Open();
                        dreader4x = cmd2x.ExecuteReader();
                        if (dreader4x.HasRows == true)
                        {
                            sp = "pre";
                            while (dreader4x.Read())
                            {
                                dataGridView1.Rows[rowx].Cells["rate"].Value = dreader4x["Rate"].ToString();
                                dataGridView1.Rows[rowx].Cells["vat"].Value = 0;
                                dataGridView1.Rows[rowx].Cells["qty"].Value = 1;
                            }
                        }
                    }
                    catch { }
                }
                if (dataGridView1.Columns[clm].Name == "qty")
                {
                    int row = dataGridView1.CurrentCell.RowIndex;
                    String it = dataGridView1.Rows[row].Cells[clm - 1].Value.ToString();
                    SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
                    SqlDataReader dreader6;
                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.Connection = conn;
                    cmd3.CommandText = "Select Qun from StockDetls where PdNam= '" + it + "' AND PdNam NOT IN(select Item from Others)";
                    //conn.Open();
                    SqlDataReader dreaderx;
                    SqlCommand cmdx = new SqlCommand();
                    cmdx.Connection = conn;
                    cmdx.CommandText = "select Count(Item)as ct from Others where Item = '" + it + "'";
                    conn.Open();
                    dreaderx = cmdx.ExecuteReader();
                    dreaderx.Read();
                    // MessageBox.Show(dreaderx["ct"].ToString());
                    if (Convert.ToInt16(dreaderx["ct"]) < 1)
                    {
                        conn.Close();
                        conn.Open();
                        dreader6 = cmd3.ExecuteReader();
                        dreader6.Read();
                        int count3 = Convert.ToInt16(dreader6["Qun"].ToString());
                        if (count3 > 0)
                        {
                            String quantity = dataGridView1.Rows[row].Cells[clm].Value.ToString();
                            //MessageBox.Show(dataGridView1.Rows[row].Cells[clm].Value.ToString());
                            int available = Convert.ToInt32(dreader6["Qun"].ToString());

                            //MessageBox.Show(dreader2["Qun"].ToString());
                            try
                            {
                                available = available - Convert.ToInt16(quantity);
                            }
                            catch
                            {
                                MessageBox.Show("Invalid Entry..!");
                            }
                            //MessageBox.Show(available.ToString());
                            if (available >= 0)
                            {
                                try
                                {
                                    int row2 = dataGridView1.CurrentRow.Index;
                                    Decimal amt = Convert.ToDecimal(dataGridView1.Rows[row2].Cells[2].Value.ToString()) * Convert.ToDecimal(dataGridView1.Rows[row2].Cells[3].Value.ToString());
                                    dataGridView1.Rows[row2].Cells[5].Value = amt;
                                }
                                catch (Exception ae)
                                {
                                    MessageBox.Show("Enter Valid Number");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product Quanitiy is Greater Than Available Product..!");
                                dataGridView1.Rows[row].Cells[clm].Value = 0;
                            }
                            conn.Close();
                            dreader6.Close();
                        }

                        else
                        {
                            MessageBox.Show("Product is Empty..!");
                            dataGridView1.Rows[row].Cells[clm].Value = 0;
                        }

                    }
                    else
                    {
                        dataGridView1.Rows[row].Cells["amount"].Value = Convert.ToDecimal(dataGridView1.Rows[row].Cells[clm].Value) * Convert.ToDecimal(dataGridView1.Rows[row].Cells["rate"].Value);
                    }

                }
                if (dataGridView1.Columns[clm].Name == "amount")
                {
                    try
                    {
                        decimal sum = Convert.ToDecimal(0.00);
                        decimal vat = Convert.ToDecimal(0.00);
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                            vat += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);

                        }
                        vt.Text = vat.ToString();
                        net_amt.Text = sum.ToString();
                    }
                    catch { }
                }
                if (dataGridView1.Columns[clm].Name == "vat")
                {
                    try
                    {
                        decimal sum = Convert.ToDecimal(0.00);
                        decimal vat = Convert.ToDecimal(0.00);
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                            vat += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);

                        }
                        vt.Text = vat.ToString();
                        net_amt.Text = sum.ToString();
                    }
                    catch { }
                }
                if (dataGridView1.Columns[clm].Name == "rate")
                {
                    SqlDataReader dreader4xx;
                    SqlConnection connxx = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
                    //SqlDataReader dreader4xx;
                    SqlCommand cmd2xx = new SqlCommand();
                    cmd2xx.Connection = connxx;
                    int rowxx = dataGridView1.CurrentCell.RowIndex;
                    itx = dataGridView1.Rows[rowxx].Cells[clm].Value.ToString();
                    cmd2xx.CommandText = "Select Item,Rate from Others where Item = '" + itx + "' ";
                    connxx.Open();
                    dreader4xx = cmd2xx.ExecuteReader();
                    if (dreader4xx.HasRows == true)
                    {
                        sp = "pre";
                        while (dreader4xx.Read())
                        {
                            dataGridView1.Rows[rowxx].Cells["rate"].Value = dreader4xx["Rate"].ToString();
                            dataGridView1.Rows[rowxx].Cells["vat"].Value = 0;
                            dataGridView1.Rows[rowxx].Cells["qty"].Value = 1;

                        }
                    }
                    try
                    {
                        decimal sum = Convert.ToDecimal(0.00);
                        decimal vat = Convert.ToDecimal(0.00);
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                            vat += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);

                        }
                        vt.Text = vat.ToString();
                        net_amt.Text = sum.ToString();
                    }
                    catch { }
                }
            }
            catch 
            {
                MessageBox.Show("Give Valid Entries..!!");
            }
           }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
            int row = dataGridView1.RowCount;
            if (row < 1)
            {
                //MessageBox.Show("Row Deleted");
                dataGridView1.Rows.Add("1");
            }
        }
        public void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Want To Save This Entry?", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dataGridView1.Rows.Count > 1 && dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value == null)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Index);
                }
                try
                {
                    int row2 = dataGridView1.CurrentRow.Index;
                    if (dataGridView1.Rows.Count >= 1 && dataGridView1.Rows[0].Cells[1].Value.ToString() != null)
                    {
                        try
                        {
                            Boolean check = false;
                            // int ct = dataGridView1.CurrentRow.Index;
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {

                                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "" || dataGridView1.Rows[i].Cells[1].Value.ToString() == "") // || 
                                {
                                    check = true;
                                }
                            }
                            if (check.Equals(false))
                            {
                                string StrQuery;
                                string StrQueryx;
                                String BillNo = bill_no.Text;
                                String datetxt = date.Text;
                                String ConnString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;";
                                using (SqlConnection conn = new SqlConnection(ConnString))
                                {
                                    using (SqlCommand comm = new SqlCommand())
                                    {
                                        comm.Connection = conn;
                                        conn.Open();
                                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                        {
                                            StrQuery = @"INSERT INTO Bill VALUES ('" + BillNo + "','" + dataGridView1.Rows[i].Cells["item"].Value + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["qty"].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["rate"].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["vat"].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["amount"].Value) + "','" + datetxt + "')";
                                            comm.CommandText = StrQuery;
                                            comm.ExecuteNonQuery();
                                        }
                                        conn.Close();

                                        SqlDataReader dreader9;
                                        //SqlConnection conx = new SqlConnection(ConnString);
                                        SqlCommand cmd3 = new SqlCommand();
                                        //conn.Open();
                                        comm.Connection = conn;
                                        for (int j = 0; j < dataGridView1.Rows.Count; j++)
                                        {
                                            //MessageBox.Show(dataGridView1.Rows[j].Cells["item"].Value.ToString());
                                            //MessageBox.Show(dataGridView1.Rows[j].Cells["qty"].Value.ToString());
                                            StrQueryx = @"UPDATE StockDetls SET Qun = Qun - '" + dataGridView1.Rows[j].Cells["qty"].Value.ToString() + "' where PdNam = '" + dataGridView1.Rows[j].Cells["item"].Value.ToString() + "'AND '" + dataGridView1.Rows[j].Cells["item"].Value.ToString() + "' NOT IN (select Item from Others)";
                                            comm.CommandText = StrQueryx;
                                            //conn.Open();

                                            comm.Connection.Open();
                                            comm.ExecuteNonQuery();
                                            //conn.Close();
                                            String temp = DateTime.Now.Month.ToString();
                                            String temp2 = DateTime.Now.Month.ToString();
                                            //MessageBox.Show(temp);
                                            cmd3.CommandText = "select count(PdNam) as ct from QBase where Dat like '___" + temp + "_" + temp2 + "'";
                                            cmd3.Connection = conn;
                                            // conn.Open();
                                            dreader9 = cmd3.ExecuteReader();
                                            dreader9.Read();
                                            if (Convert.ToInt16(dreader9["ct"]) > 0)
                                            {
                                                conn.Close();
                                                dreader9.Close();
                                                SqlDataReader dreader0;
                                                SqlCommand cmd4 = new SqlCommand();
                                                cmd4.CommandText = "select count(PdNam) as ct from QBase where PdNam = '" + dataGridView1.Rows[j].Cells["item"].Value.ToString() + "'";
                                                cmd4.Connection = conn;
                                                conn.Open();
                                                dreader0 = cmd4.ExecuteReader();
                                                dreader0.Read();
                                                MessageBox.Show(dreader0["ct"].ToString());
                                                if (Convert.ToInt16(dreader0["ct"]) > 0)
                                                {
                                                    dreader0.Close();
                                                    String Stt = @"UPDATE QBase SET Qun = Qun + '" + dataGridView1.Rows[j].Cells["qty"].Value.ToString() + "',Dat = '" + temp + "' where PdNam = '" + dataGridView1.Rows[j].Cells["item"].Value.ToString() + "'";
                                                    comm.CommandText = Stt;
                                                    comm.ExecuteNonQuery();
                                                }
                                                else
                                                {
                                                    String StrQuerymm = @"INSERT INTO QBase VALUES ('" + dataGridView1.Rows[j].Cells["item"].Value.ToString() + "','" + datetxt + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells["qty"].Value) + "');";
                                                    comm.CommandText = StrQuerymm;
                                                    comm.ExecuteNonQuery();
                                                }
                                                conn.Close();
                                                dreader0.Close();
                                            }
                                            else
                                            {
                                                String StrQuer = @"INSERT INTO QBase VALUES ('" + dataGridView1.Rows[j].Cells["item"].Value.ToString() + "','" + datetxt + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells["qty"].Value) + "');";
                                                comm.CommandText = StrQuer;
                                                comm.ExecuteNonQuery();
                                                conn.Close();
                                            }

                                        }
                                        MessageBox.Show("Entry Saved..!");
                                        dataGridView1.Rows.Clear();
                                        net_amt.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Check Your Entries..!");
                            }
                        }
                        catch (Exception sqe)
                        {
                            MessageBox.Show(sqe.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Items in Cart..!");
                    }
                }
                catch (Exception xxy)
                {
                    MessageBox.Show("Check Your Entries..");
                }
                SqlDataReader dreader1;
                SqlConnection conn2 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn2;
                //cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select max(BillNo) as BillNo from Bill";
                conn2.Open();
                dreader1 = cmd.ExecuteReader();
                int c;
                c = 1;
                // MessageBox.Show("x");
                //MessageBox.Show(dreader.ToString());
                if (dreader1.HasRows == true)
                {
                    while (dreader1.Read())
                        bill_no.Text = Convert.ToInt32(Convert.ToInt32(dreader1["BillNo"]) + Convert.ToInt32(c)).ToString();
                }
                // bill_no.Text = dreader[0].ToString();
                conn2.Close();
                dreader1.Close();
            }
            
        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dailyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String day = "one";
            Form3 daily = new Form3(day);
            daily.Show();
        }

        private void monthlyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String month = "month";
            Form3 monthly = new Form3(month);
            monthly.Show();
        }

        private void annuallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String yr = "year";
            Form3 year = new Form3(yr);
            year.Show();
        }

        private void currentStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 xx = new Form2();
            xx.Show();
        }

        private void searchStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchstock st = new searchstock();
            st.Show();
        }

    
public  string StrQuery2 { get; set; }

        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String yr = "dte";
            Form4 year = new Form4(yr);
            year.Show();
        }

        private void salesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void stockToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void billDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchsale ss = new searchsale(mmm);
            ss.Show();
        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void othersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Others sp = new Others();
            sp.Show();
        }
        public void change()
        {
            /*
                //dataGridView1.Rows.Clear();
                //dataGridView1.DataSource = null;
                //MessageBox.Show(dataGridView1.Rows[0].Cells["qty"].Value.ToString());
                 DataTable DT = (DataTable)dataGridView1.DataSource;
                // DT.Clear();
                 if (DT != null)
                      DT.Clear();

                SqlDataReader dreader1;
                SqlConnection conn2 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn2;
                //cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select max(BillNo) as BillNo from Bill";
                conn2.Open();
                dreader1 = cmd.ExecuteReader();
                int c;
                c = 1;
                // MessageBox.Show("x");
                //MessageBox.Show(dreader.ToString());
                if (dreader1.HasRows == true)
                {
                    while (dreader1.Read())
                        bill_no.Text = Convert.ToInt32(Convert.ToInt32(dreader1["BillNo"]) + Convert.ToInt32(c)).ToString();
                }
                // bill_no.Text = dreader[0].ToString();
                conn2.Close();
                dreader1.Close();
                //sauce_n_cream_Load(null,null);
                // sauce_n_cream s = new sauce_n_cream();
                // s.Refresh();
                //MessageBox.Show("Work");
                /*
                dataGridView1.Refresh();
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(1);
                dataGridView1.AllowUserToAddRows = false;
                SqlDataReader dreader1;
                SqlConnection conn2 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn2;
                //cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select max(BillNo) as BillNo from Bill";
                conn2.Open();
                dreader1 = cmd.ExecuteReader();
                int c;
                c = 1;
                // MessageBox.Show("x");
                //MessageBox.Show(dreader.ToString());
                if (dreader1.HasRows == true)
                {
                    while (dreader1.Read())
                        bill_no.Text = Convert.ToInt32(Convert.ToInt32(dreader1["BillNo"]) + Convert.ToInt32(c)).ToString();
                }
                // bill_no.Text = dreader[0].ToString();
                conn2.Close();
                dreader1.Close();
                 * */
            
          
        }
        private void XEvent(object sender, EventArgs e)
        {
            SqlDataReader dreader1;
            SqlConnection conn2 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn2;
            //cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select max(BillNo) as BillNo from Bill";
            conn2.Open();
            dreader1 = cmd.ExecuteReader();
            int c;
            c = 1;
            // MessageBox.Show("x");
            //MessageBox.Show(dreader.ToString());
            if (dreader1.HasRows == true)
            {
                while (dreader1.Read())
                    bill_no.Text = Convert.ToInt32(Convert.ToInt32(dreader1["BillNo"]) + Convert.ToInt32(c)).ToString();
            }
            // bill_no.Text = dreader[0].ToString();
            conn2.Close();
            dreader1.Close();
            dataGridView1.Rows.Clear();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
