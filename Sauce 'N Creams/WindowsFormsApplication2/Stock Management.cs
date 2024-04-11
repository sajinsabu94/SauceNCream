using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            dataGridView1.Rows.Add("1");
         }
        private void Form1_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            WindowState = FormWindowState.Maximized;
            //dataGridView1.Rows.Add("1");
            DataGridViewRow rowToSelect = this.dataGridView1.CurrentRow;
            rowToSelect.Selected = false;
            rowToSelect.Cells[1].Selected = true;
            this.dataGridView1.CurrentCell = rowToSelect.Cells[1];
        }

        private void mainStock_Paint(object sender, PaintEventArgs e)
        {
            //this.AutoSize = true;
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            dataGridView1.AllowUserToAddRows = false;
         }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
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
          
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count >= 1 && dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value == null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Index);
            }
            try
            {
                String ag = agency.Text;
                String ph = phno.Text;
                String tn = tin.Text;
                String blno = bilno.Text;
                string StrQuery1;
                string StrQuery2;
                string StrQuery3;
                String xy = date.Text;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
                        StrQuery1 = "INSERT INTO StockAgncy VALUES ('" + ag + "','" + tn + "','" + blno + "','" + ph + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + xy + "')";
                        StrQuery3 = "INSERT INTO MainStock VALUES ('" + blno + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[9].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[10].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[11].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[12].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[13].Value) + "','" + xy + "')";
                        SqlCommand cmd1 = new SqlCommand(StrQuery1, con);
                        SqlCommand cmd3 = new SqlCommand(StrQuery3, con);
                        cmd1.Connection.Open();
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        cmd3.Connection.Open();
                        cmd3.ExecuteNonQuery();
                        con.Close();
                    }
                    catch { }
                }
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        String ConnString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;";
                        SqlConnection conn = new SqlConnection(ConnString);
                        SqlCommand comm = new SqlCommand();
                        SqlDataReader dreader0;
                        SqlCommand cmd4 = new SqlCommand();
                        cmd4.CommandText = "select count(PdNam)as ct from StockDetls where PdNam = '" + dataGridView1.Rows[j].Cells["PrdNam"].Value.ToString() + "'";
                        cmd4.Connection = conn;
                        conn.Open();
                        dreader0 = cmd4.ExecuteReader();
                        dreader0.Read();
                       // MessageBox.Show(dreader0["ct"].ToString());
                        if (Convert.ToInt16(dreader0["ct"]) > 0)
                        {
                            dreader0.Close();
                            conn.Close();
                            conn.Open();
                            String Stt = "UPDATE StockDetls SET Mrp = '" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[2].Value) + "',Vat = '" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[3].Value) + "',Rate = '" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[4].Value) + "',Qca = '" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[5].Value) + "',Qun = Qun + '" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[6].Value) + "',Gross = '" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[7].Value) + "',CashDisc = '" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[8].Value) + "',SchDisc = '" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[9].Value) + "',NetAmt = '" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[10].Value) + "',VatAmt = '" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[11].Value) + "',TotalAmt = '" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[12].Value) + "',SchAmt = '" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[13].Value) + "',date = '" + xy + "'where PdNam = '" + dataGridView1.Rows[j].Cells["PrdNam"].Value.ToString() + "'";
                            comm.CommandText = Stt;
                            comm.Connection = conn;
                            comm.ExecuteNonQuery();
                            conn.Close();
                        }
                        else
                        {
                            conn.Close();
                            StrQuery2 = "INSERT INTO StockDetls VALUES ('" + dataGridView1.Rows[j].Cells[1].Value + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[2].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[3].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[4].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[5].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[6].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[7].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[8].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[9].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[10].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[11].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[12].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[13].Value) + "','" + xy + "')";
                            SqlCommand cmd2 = new SqlCommand(StrQuery2, conn);
                            cmd2.Connection.Open();
                            cmd2.Connection = conn;
                            cmd2.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                 MessageBox.Show("Saved..!");
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
          if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                SqlDataReader dreader;
                SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
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


                //ComboBox txtBusID = e.Control as ComboBox;
                TextBox txtBusID = e.Control as TextBox;
                if (txtBusID != null)
                {
                    txtBusID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtBusID.AutoCompleteCustomSource = acBusIDSorce;
                    txtBusID.AutoCompleteSource = AutoCompleteSource.CustomSource;

                }
            } 
        }

        private void agency_TextChanged(object sender, EventArgs e)
        {
            try
            {
                agency.AutoCompleteMode = AutoCompleteMode.Suggest;
                agency.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                addItems(DataCollection);
                agency.AutoCompleteCustomSource = DataCollection;
                //
                try
                {
                    String str = agency.Text;
                    SqlDataReader dreader;
                    SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Select Tan,phone from StockAgncy where Agency = '" + str + "'";
                    conn.Open();
                    dreader = cmd.ExecuteReader();
                    dreader.Read();
                    //MessageBox.Show(agx);
                    if (dreader.HasRows == true)
                    {
                        //MessageBox.Show(dreader4["phone"].ToString());
                        phno.Text = dreader["phone"].ToString();
                        tin.Text = dreader["Tan"].ToString();
                    }
                }
                catch { }
                
            }
            catch { }
        }

        private void addItems(AutoCompleteStringCollection dataCollection)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            connetionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;";
            string sql = "Select Agency from StockAgncy";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int clm = e.ColumnIndex;
                if (dataGridView1.Columns[clm].Name == "PrdNam")
                {
                    SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
                    SqlDataReader dreader4;
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = conn;
                    String it = "";
                    int row = dataGridView1.CurrentCell.RowIndex;
                    it = dataGridView1.Rows[row].Cells[clm].Value.ToString();
                    cmd2.CommandText = "Select Mrp,Vat,Rate,Qca,Gross,CashDisc,SchDisc,NetAmt,VatAmt,TotalAmt,SchAmt from StockDetls where PdNam = '" + it + "' ";
                    conn.Open();
                    dreader4 = cmd2.ExecuteReader();
                    if (dreader4.HasRows == true)
                    {
                        while (dreader4.Read())
                        {
                            var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                            cell.OwningRow.Cells["Mrp"].Value = (dreader4["Mrp"].ToString());
                            cell.OwningRow.Cells["Vat"].Value = (dreader4["Vat"].ToString());
                            cell.OwningRow.Cells["RteUnt"].Value = (dreader4["Rate"].ToString());
                            cell.OwningRow.Cells["Qntcse"].Value = (dreader4["Qca"].ToString());
                            cell.OwningRow.Cells["Qntyunt"].Value = 1;
                            cell.OwningRow.Cells["GrsVal"].Value = (dreader4["Gross"].ToString());
                            cell.OwningRow.Cells["CshDsct"].Value = (dreader4["CashDisc"].ToString());
                            cell.OwningRow.Cells["Schme"].Value = (dreader4["SchDisc"].ToString());
                            cell.OwningRow.Cells["NtAmt"].Value = (dreader4["NetAmt"].ToString());
                            cell.OwningRow.Cells["VatAmt"].Value = (dreader4["VatAmt"].ToString());
                            cell.OwningRow.Cells["TtlAmt"].Value = (dreader4["TotalAmt"].ToString());
                            cell.OwningRow.Cells["SchUnt"].Value = (dreader4["SchAmt"].ToString());
                        }

                        dreader4.Close();
                        conn.Close();
                    }
                    else 
                    {
                        var cell2 = dataGridView1[e.ColumnIndex, e.RowIndex];
                        cell2.OwningRow.Cells["Vat"].Value = 14.50;
                        cell2.OwningRow.Cells["Qntcse"].Value = 0;
                        cell2.OwningRow.Cells["Qntyunt"].Value = 1;
                        cell2.OwningRow.Cells["GrsVal"].Value = 1.00;
                        cell2.OwningRow.Cells["CshDsct"].Value = 0.00;
                        cell2.OwningRow.Cells["Schme"].Value = 0.00;
                        cell2.OwningRow.Cells["VatAmt"].Value = 0.00;
                        cell2.OwningRow.Cells["TtlAmt"].Value = 0.00;
                        cell2.OwningRow.Cells["SchUnt"].Value = 0;
                    }
                }
                if (dataGridView1.Columns[clm].Name == "Mrp")
                {
                    var cell2 = dataGridView1[e.ColumnIndex, e.RowIndex];
                    cell2.OwningRow.Cells["GrsVal"].Value = cell2.OwningRow.Cells["Mrp"].Value;                    
                    cell2.OwningRow.Cells["VatAmt"].Value = 0.00;
                    cell2.OwningRow.Cells["TtlAmt"].Value = 0.00;
                    cell2.OwningRow.Cells["SchUnt"].Value = 1;
                }
                if (dataGridView1.Columns[clm].Name == "Qntyunt")
                {
                    var cell2 = dataGridView1[e.ColumnIndex, e.RowIndex];
                    decimal ab = Convert.ToDecimal(cell2.OwningRow.Cells["Qntyunt"].Value) * Convert.ToDecimal(cell2.OwningRow.Cells["Mrp"].Value);
                    Decimal c = Convert.ToDecimal(cell2.OwningRow.Cells["Vat"].Value);
                    Decimal b = 100 / (100 + c) * ab;
                    cell2.OwningRow.Cells["VatAmt"].Value = Math.Round(100 - b,2);
                   // var cell2 = dataGridView1[e.ColumnIndex, e.RowIndex];
                    cell2.OwningRow.Cells["TtlAmt"].Value = Convert.ToDecimal(cell2.OwningRow.Cells["NtAmt"].Value) + Convert.ToDecimal(cell2.OwningRow.Cells["VatAmt"].Value);
                }
                if (dataGridView1.Columns[clm].Name == "GrsVal")
                {
                    var cell2 = dataGridView1[e.ColumnIndex, e.RowIndex];
                    cell2.OwningRow.Cells["NtAmt"].Value = cell2.OwningRow.Cells["GrsVal"].Value;

                    decimal grs = Convert.ToDecimal(0.00);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        grs += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);

                    }
                    label4.Text = grs.ToString();                    
                }
                if (dataGridView1.Columns[clm].Name == "NtAmt")
                {
                    var cell2 = dataGridView1[e.ColumnIndex, e.RowIndex];
                    cell2.OwningRow.Cells["TtlAmt"].Value = Math.Round(Convert.ToDecimal(cell2.OwningRow.Cells["NtAmt"].Value) + Convert.ToDecimal(cell2.OwningRow.Cells["VatAmt"].Value),2);
                    decimal cdisc = Convert.ToDecimal(0.00);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        cdisc += Convert.ToDecimal(dataGridView1.Rows[i].Cells[10].Value);

                    }
                    label7.Text = cdisc.ToString();
                }
                if (dataGridView1.Columns[clm].Name == "CshDsct")
                {                    
                    decimal cdisc = Convert.ToDecimal(0.00);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        cdisc += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);

                    }
                    label5.Text = cdisc.ToString();
                }
                if (dataGridView1.Columns[clm].Name == "Schme")
                {
                    decimal cdisc = Convert.ToDecimal(0.00);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        cdisc += Convert.ToDecimal(dataGridView1.Rows[i].Cells[9].Value);

                    }
                    label6.Text = cdisc.ToString();
                    var cell2 = dataGridView1[e.ColumnIndex, e.RowIndex];
                    cell2.OwningRow.Cells["TtlAmt"].Value = Convert.ToDecimal(cell2.OwningRow.Cells["NtAmt"].Value) + Convert.ToDecimal(cell2.OwningRow.Cells["VatAmt"].Value);
                }

                if (dataGridView1.Columns[clm].Name == "VatAmt")
                {
                    decimal cdisc = Convert.ToDecimal(0.00);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        cdisc += Convert.ToDecimal(dataGridView1.Rows[i].Cells[11].Value);

                    }
                    label8.Text = cdisc.ToString();
                }
                if (dataGridView1.Columns[clm].Name == "TtlAmt")
                {
                    decimal cdisc = Convert.ToDecimal(0.00);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        cdisc += Convert.ToDecimal(dataGridView1.Rows[i].Cells[12].Value);
                    }
                    label9.Text = cdisc.ToString();
                    label14.Text = cdisc.ToString();
                }
            }
            catch { }
        }

        private void agency_Leave(object sender, EventArgs e)
        {
           
        }

        private void agency_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
