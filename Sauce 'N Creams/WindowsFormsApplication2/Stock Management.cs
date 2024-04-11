using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
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
                string StrQuery;
                String xy = date.Text;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
                    StrQuery = "INSERT INTO StockDetls VALUES ('" + ag + "','" + ph + "','" + tn + "','" + blno + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[9].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[10].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[11].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[12].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells[13].Value) + "','"+xy+"')";
                    SqlCommand cmd = new SqlCommand(StrQuery, con);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(StrQuery);
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

        
       
    }
}
