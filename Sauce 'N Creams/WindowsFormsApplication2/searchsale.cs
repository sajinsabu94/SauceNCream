using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class searchsale : Form
    {
        public searchsale(String x)
        {
            InitializeComponent();
            if (x.Equals("usr"))
            {
                button2.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void searchsale_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            try
            {
                string txt = textBox1.Text;
                dataGridView1.Rows.Clear();
                string stmt = "SELECT COUNT (Item) FROM Bill where BillNo = '" + txt + "'";
                int count = 0;
                using (SqlConnection thisConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True"))
                {
                    using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                    {
                        thisConnection.Open();
                        count = (int)cmdCount.ExecuteScalar();
                    }
                }
                dataGridView1.Rows.Clear();
                //String str = textBox1.Text;
                SqlDataReader dreader;
                SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select Item,Qnty,Rat,Amt from Bill where BillNo = '" + txt + "'";
                conn.Open();
                dreader = cmd.ExecuteReader();
                dreader.Read();
                dataGridView1.Rows.Add(count);
                decimal sum = Convert.ToDecimal(0.00);
                for (int i = 0; i < count; i++, dreader.Read())
                {
                   // dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[i].Cells[1].Value = (dreader["Item"].ToString());
                    dataGridView1.Rows[i].Cells[2].Value = (dreader["Rat"].ToString());
                    dataGridView1.Rows[i].Cells[3].Value = (dreader["Qnty"].ToString());
                    dataGridView1.Rows[i].Cells[4].Value = (dreader["Amt"].ToString());
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                }
                label4.Text = sum.ToString();
            }
            catch 
            {
                MessageBox.Show("Bill Number not Exist..!");
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string StrQuery;
            String BillNo = textBox1.Text;
            String ConnString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;";
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            conn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                StrQuery = @"UPDATE Bill Set Qnty = '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Column3"].Value) + "', Amt = '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Column3"].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells["rate"].Value) + "'";
                comm.CommandText = StrQuery;
                comm.ExecuteNonQuery();
            }
            MessageBox.Show("Bill Updated..!");
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int clm = e.ColumnIndex;
                var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                if (dataGridView1.Columns[clm].Name == "Column3")
                {
                    cell.OwningRow.Cells["Column4"].Value = Convert.ToDecimal(cell.OwningRow.Cells["rate"].Value) * Convert.ToDecimal(cell.OwningRow.Cells["Column3"].Value);
                }
            }
            catch { }
        }
    }
}
