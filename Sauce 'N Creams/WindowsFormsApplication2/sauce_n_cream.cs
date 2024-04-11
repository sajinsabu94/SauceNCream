using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace WindowsFormsApplication2
{
    public partial class sauce_n_cream : Form
    {

        public sauce_n_cream()
        {
            InitializeComponent();

        }
       /*
        public string send1()
        {
            String vaat = bill_no.Text;
            return vaat;
        }
       /*
        * public String send2()
        {
            //decimal ammt = Convert.ToDecimal(net_amt.Text);
            return (net_amt.Text);
        }
        * */
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
            WindowState = FormWindowState.Maximized;
            date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            dataGridView1.Rows.Add("1");
            DataGridViewRow rowToSelect = this.dataGridView1.CurrentRow;
            rowToSelect.Selected = false;
            rowToSelect.Cells[1].Selected = true;
            this.dataGridView1.CurrentCell = rowToSelect.Cells[1];
            SqlDataReader dreader;
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select MAX(BillNo)BillNo from Bill";
            conn.Open();
            dreader = cmd.ExecuteReader();
            int c;
            c = 1;
            //MessageBox.Show("dreader[0].ToString()");
            if (dreader.HasRows == true)
            {
                while (dreader.Read())
                        bill_no.Text = Convert.ToInt32(Convert.ToInt32(dreader["BillNo"])+Convert.ToInt32(c)).ToString();
            }
           // bill_no.Text = dreader[0].ToString();
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

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {                
                SqlDataReader dreader;
                SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                AutoCompleteStringCollection acBusIDSorce = new AutoCompleteStringCollection();
                cmd.CommandText = "Select PdNam from StockDetls";
                conn.Open();
                dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    while (dreader.Read())
                        acBusIDSorce.Add(dreader["PdNam"].ToString());
                }
                else
                {
                    MessageBox.Show("New Item..!");
                }
                dreader.Close();
                TextBox txtBusID = e.Control as TextBox;
                if (txtBusID != null)
                {
                    txtBusID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtBusID.AutoCompleteCustomSource = acBusIDSorce;
                    txtBusID.AutoCompleteSource = AutoCompleteSource.CustomSource;

                }
              }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
                int clm = e.ColumnIndex;                
                if (dataGridView1.Columns[clm].Name == "item")
                {
                    SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
                    SqlDataReader dreader2;
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = conn;
                    String it = "";
                    int row = dataGridView1.CurrentCell.RowIndex;
                    it = dataGridView1.Rows[row].Cells[clm].Value.ToString();
                    cmd2.CommandText = "Select Rate,Vat from StockDetls where PdNam = '"+it+"' ";
                    conn.Open();
                    dreader2 = cmd2.ExecuteReader();
                    if (dreader2.HasRows == true)
                    {
                        while (dreader2.Read())
                        {
                            var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                            cell.OwningRow.Cells["Rate"].Value = (dreader2["Rate"].ToString());
                            cell.OwningRow.Cells["vat"].Value = (dreader2["Vat"].ToString());
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
                            else if(Convert.ToInt16(dataGridView1.Rows[row].Cells[2].Value)>0)
                            {
                                Decimal amt = Convert.ToDecimal(dataGridView1.Rows[row].Cells[2].Value.ToString()) * Convert.ToDecimal(dataGridView1.Rows[row].Cells[3].Value.ToString());
                                dataGridView1.Rows[row].Cells[5].Value = amt;
                                cell.OwningRow.Cells["qty"].Value = 1;
                            }
                     }
                        
                        dreader2.Close();
                        conn.Close();
                    }
                  
                }
                if (dataGridView1.Columns[clm].Name == "qty")
                {
                    int row = dataGridView1.CurrentCell.RowIndex;
                    String it = dataGridView1.Rows[row].Cells[clm-1].Value.ToString();
                    SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
                    SqlDataReader dreader2;
                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.Connection = conn;
                    cmd3.CommandText = "Select Qun from StockDetls where PdNam = '" + it + "' ";
                    conn.Open();
                    dreader2 = cmd3.ExecuteReader();
                    dreader2.Read();
                    int count3 = Convert.ToInt16(dreader2["Qun"].ToString());
                    if (count3 > 0)
                    {
                    String quantity = dataGridView1.Rows[row].Cells[clm].Value.ToString();
                    int available = Convert.ToInt16(dreader2["Qun"].ToString());
                    available = available - Convert.ToInt16(quantity);
                       if (available > 0)
                        {
                            try
                            {
                                int row2 = dataGridView1.CurrentRow.Index;
                                Decimal amt = Convert.ToDecimal(dataGridView1.Rows[row2].Cells[2].Value.ToString()) * Convert.ToDecimal(dataGridView1.Rows[row2].Cells[3].Value.ToString());
                                //MessageBox.Show(amt.ToString());
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
                    }
                    else
                    {
                        MessageBox.Show("Product is Empty..!");
                        dataGridView1.Rows[row].Cells[clm].Value = 0;
                    }
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
                            if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "" || Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value) == 0)
                            {
                                check = true;
                            }
                        }
                        if (check.Equals(false))
                        {
                            string StrQuery;
                            String BillNo = bill_no.Text;
                            String datetxt = date.Text;
                            String ConnString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True";
                            using (SqlConnection conn = new SqlConnection(ConnString))
                            {
                                using (SqlCommand comm = new SqlCommand())
                                {
                                    comm.Connection = conn;
                                    conn.Open();
                                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                    {
                                        StrQuery = @"INSERT INTO Bill VALUES ('" + BillNo + "','" + dataGridView1.Rows[i].Cells["item"].Value + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["qty"].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["rate"].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["vat"].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["amount"].Value) + "','" + datetxt + "');";
                                        comm.CommandText = StrQuery;
                                        comm.ExecuteNonQuery();
                                    }
                                    MessageBox.Show("Entry Saved..!");
                                    dataGridView1.Rows.Clear();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Check Your Entries..!");
                        }
                    }
                    catch (SqlException sqe)
                    {
                        MessageBox.Show(sqe.Message, "..!");
                    }
                }
                else
                {
                    MessageBox.Show("No Items in Cart..!");
                }
            }
            catch 
            {
                MessageBox.Show("No Items in Cart..!");
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
        }}
}
