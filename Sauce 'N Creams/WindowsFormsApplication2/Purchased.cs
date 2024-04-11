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
    public partial class Purchased : Form
    {
        public Purchased()
        {
            InitializeComponent();
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
            string sql = "Select Bill from MainStock";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String itx = agency.Text;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Rows.Clear();
                string stmt = "SELECT COUNT (PdNam) FROM MainStock where Bill = '" + itx + "'";
                int count = 0;
                using (SqlConnection thisConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True"))
                {
                    using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                    {
                        thisConnection.Open();
                        count = (int)cmdCount.ExecuteScalar();
                        dataGridView1.Rows.Add(count);
                    }
                }
                SqlConnection connx = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
                SqlDataReader dreader4x;
                SqlCommand cmd2x = new SqlCommand();
                cmd2x.Connection = connx;
                int rowx = dataGridView1.CurrentCell.RowIndex;
                cmd2x.CommandText = "Select PdNam,Mrp,Vat,Rate,Qca,Qun,Gross,CashDisc,SchDisc,NetAmt,VatAmt,TotalAmt,SchAmt from MainStock where Bill = '" + itx + "' ";
                connx.Open();
                dreader4x = cmd2x.ExecuteReader();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dreader4x.HasRows == true)
                    {
                        while (dreader4x.Read())
                        {
                            dataGridView1.Rows[i].Cells[1].Value = (dreader4x["PdNam"].ToString());
                            dataGridView1.Rows[i].Cells[2].Value = (dreader4x["Mrp"].ToString());
                            dataGridView1.Rows[i].Cells[3].Value = (dreader4x["Vat"].ToString());
                            dataGridView1.Rows[i].Cells[4].Value = (dreader4x["Rate"].ToString());
                            dataGridView1.Rows[i].Cells[5].Value = (dreader4x["Qca"].ToString());
                            dataGridView1.Rows[i].Cells[6].Value = (dreader4x["Qun"].ToString());
                            dataGridView1.Rows[i].Cells[7].Value = (dreader4x["Gross"].ToString());
                            dataGridView1.Rows[i].Cells[8].Value = (dreader4x["CashDisc"].ToString());
                            dataGridView1.Rows[i].Cells[9].Value = (dreader4x["SchDisc"].ToString());
                            dataGridView1.Rows[i].Cells[10].Value = (dreader4x["NetAmt"].ToString());
                            dataGridView1.Rows[i].Cells[11].Value = (dreader4x["VatAmt"].ToString());
                            dataGridView1.Rows[i].Cells[12].Value = (dreader4x["TotalAmt"].ToString());
                            dataGridView1.Rows[i].Cells[13].Value = (dreader4x["SchAmt"].ToString());
                        }
                    }
                }
            }
            catch
            {
                dataGridView1.Rows.Clear();
                dataGridView1.AllowUserToAddRows = false;
                MessageBox.Show("No Items Found..!");
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            //this.dataGridView1.Rows[e.RowIndex].Cells[2].Value = 1;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Purchased_Load(object sender, EventArgs e)
        {

        }
    }
}
