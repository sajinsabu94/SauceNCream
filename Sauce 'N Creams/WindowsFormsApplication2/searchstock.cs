using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data;

namespace WindowsFormsApplication2
{
    public partial class searchstock : Form
    {
        public searchstock()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            string stmt = "SELECT COUNT(PdNam) FROM StockDetls where Qun >= 0";
            int count = 0;
            using (SqlConnection thisConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            SqlDataReader dreader;
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select PdNam,Qun,Rate from StockDetls where Qun >= 0";
            conn.Open();
            int i, j;
            dreader = cmd.ExecuteReader();
            if (count == 0)
            {
                dataGridView1.Rows.Add(1);
            }
            else
            {
                dataGridView1.Rows.Add(count);
            }
            dreader.Read();
            for (i = 0; i < count; i++, dreader.Read())
            { 
                dataGridView1.Rows[i].Cells[1].Value = (dreader["PdNam"].ToString());
                dataGridView1.Rows[i].Cells[2].Value = (dreader["Qun"].ToString());
                dataGridView1.Rows[i].Cells[3].Value = (dreader["Rate"].ToString());
            }
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            addItems(DataCollection);
            textBox1.AutoCompleteCustomSource = DataCollection;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void addItems(AutoCompleteStringCollection dataCollection)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            connetionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True";
            string sql = "Select PdNam from StockDetls";
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                String str = textBox1.Text;
                SqlDataReader dreader;
                SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select PdNam,Qun,Rate from StockDetls where Qun >= 0 AND PdNam = '" + str + "'";
                conn.Open();
                dreader = cmd.ExecuteReader();
                dreader.Read();
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[0].Cells[1].Value = (dreader["PdNam"].ToString());
                dataGridView1.Rows[0].Cells[2].Value = (dreader["Qun"].ToString());
                dataGridView1.Rows[0].Cells[3].Value = (dreader["Rate"].ToString());
            }
            catch { }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    dataGridView1.Rows.Clear();
                    string stmt = "SELECT COUNT (PdNam) FROM StockDetls where Qun = 0";
                    int count = 0;
                    using (SqlConnection thisConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True"))
                    {
                        using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                        {
                            thisConnection.Open();
                            count = (int)cmdCount.ExecuteScalar();
                        }
                    }
                    SqlDataReader dreader;
                    SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select PdNam,Qun,Rate from StockDetls where Qun = 0";
                    conn.Open();
                    int i, j;
                    dreader = cmd.ExecuteReader();
                    dataGridView1.Rows.Add(count);
                    dreader.Read();
                    for (i = 0; i < count; i++, dreader.Read())
                    {
                        dataGridView1.Rows[i].Cells[1].Value = (dreader["PdNam"].ToString());
                        dataGridView1.Rows[i].Cells[2].Value = (dreader["Qun"].ToString());
                        dataGridView1.Rows[i].Cells[3].Value = (dreader["Rate"].ToString());
                    }
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    string stmt = "SELECT COUNT (PdNam) FROM StockDetls where Qun >= 0";
                    int count = 0;
                    using (SqlConnection thisConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True"))
                    {
                        using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                        {
                            thisConnection.Open();
                            count = (int)cmdCount.ExecuteScalar();
                        }
                    }
                    SqlDataReader dreader;
                    SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select PdNam,Qun,Rate from StockDetls where Qun >= 0";
                    conn.Open();
                    int i, j;
                    dreader = cmd.ExecuteReader();
                    dataGridView1.Rows.Add(count);
                    dreader.Read();
                    for (i = 0; i < count; i++, dreader.Read())
                    {
                        dataGridView1.Rows[i].Cells[1].Value = (dreader["PdNam"].ToString());
                        dataGridView1.Rows[i].Cells[2].Value = (dreader["Qun"].ToString());
                        dataGridView1.Rows[i].Cells[3].Value = (dreader["Rate"].ToString());
                    }
                    textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                    textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                    addItems(DataCollection);
                    textBox1.AutoCompleteCustomSource = DataCollection;
                }

            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
