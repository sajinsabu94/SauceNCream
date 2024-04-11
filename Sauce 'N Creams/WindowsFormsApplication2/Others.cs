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
    public partial class Others : Form
    {
        public Others()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
                String ConnString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;";
                SqlConnection conn = new SqlConnection(ConnString);
                SqlCommand comm = new SqlCommand();
                SqlDataReader dreader0;
                SqlCommand cmd4 = new SqlCommand();
                cmd4.CommandText = "select count(Item)as ct from Others where Item = '" + dataGridView1.Rows[j].Cells["item"].Value.ToString() + "'";
                cmd4.Connection = conn;
                conn.Open();
                dreader0 = cmd4.ExecuteReader();
                dreader0.Read();
                if (Convert.ToInt16(dreader0["ct"]) > 0)
                {
                    dreader0.Close();
                    String Stt = "UPDATE Others SET Rate = '" + dataGridView1.Rows[j].Cells[1].Value + "',Vat = 0.00";
                    comm.CommandText = Stt;
                    comm.Connection = conn;
                    comm.ExecuteNonQuery();
                }
                else
                {
                    String StrQuery2 = "INSERT INTO Others VALUES ('" + dataGridView1.Rows[j].Cells[0].Value + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells[1].Value) + "',0.00)";
                    SqlCommand cmd2 = new SqlCommand(StrQuery2, con);
                    cmd2.Connection.Open();
                    cmd2.Connection = conn;
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Updated..!");
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                SqlDataReader dreader2;
                SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;");
                SqlCommand cmd = new SqlCommand();
                SqlCommand cmd3 = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                AutoCompleteStringCollection acBusIDSorce = new AutoCompleteStringCollection();
                cmd.CommandText = "Select Item from Others";
                conn.Open();
                dreader2 = cmd.ExecuteReader();
                if (dreader2.HasRows == true)
                {
                    while (dreader2.Read())
                        acBusIDSorce.Add(dreader2["Item"].ToString());
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
                try
                {
                    String ConnString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;";
                    SqlConnection connx = new SqlConnection(ConnString);
                    SqlCommand comm = new SqlCommand();
                    SqlDataReader dreader0;
                    comm.CommandText = "select Rate from Others where Item = '" + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["item"].Value.ToString() + "'";
                    comm.Connection = connx;
                    connx.Open();
                    dreader0 = comm.ExecuteReader();
                    dreader0.Read();
                    if (dreader0.HasRows == true)
                    {
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["rate"].Value = dreader0["Rate"].ToString();
                    }
                }
                catch { }
            }
        }

        private void Others_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;            
            String ConnString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;";
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand comm = new SqlCommand();
            SqlDataReader dreader0;            
            comm.CommandText = "select count(Item)as ct from Others where Item = '" + dataGridView1.Rows[row].Cells["item"].Value.ToString() + "'";
            comm.Connection = conn;
            conn.Open();
            dreader0 = comm.ExecuteReader();
            dreader0.Read();
            if (Convert.ToInt16(dreader0["ct"]) > 0)
            {
                dreader0.Close();
                String Stt = "DELETE From Others where Item = '" + dataGridView1.Rows[row].Cells[0].Value + "'";
                comm.CommandText = Stt;
                comm.Connection = conn;
                comm.ExecuteNonQuery();
                MessageBox.Show("Deleted..!");
            }
            else
            {
                MessageBox.Show("Invalid Deletion..!");
            }
        }
    }
}
