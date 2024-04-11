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
    public partial class Form3 : Form
    {
        public Form3(String daily)
        {
            InitializeComponent();
            if (daily == "one")
            {
                Load1();
            }
            else if (daily == "month")
            {
                Load2();
            }
            else if (daily == "year")
            {
                Load3();
            }
            
        }
        private void Load1()
        {
            String date = DateTime.Now.ToString("dd-MM-yyyy");
            string stmt = "SELECT COUNT(distinct Item) FROM Bill where Dat = '" + date + "'";
            int count = 0;
            using (SqlConnection thisConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            if (count > 0)
            {
            SqlDataReader dreader;
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //cmd.CommandText = "Select Item,sum(Qnty),Rate,Vat,Amount from (select distinct Item, first_value(Qnty) over(partition by Item order by Dat desc) Qnty from Bill) where Dat = '" + date + "'"; // group by Item where Dat = '" + date + "'";
            cmd.CommandText = "select tb1.Item,tb1.Qnty,tb2.Rate,tb2.Vat,(tb1.Qnty*tb2.Rate) as Amount from (Select Item,sum(Qnty) as Qnty from Bill where Dat = '" + date + "' Group By Item) AS tb1 inner join (Select PdNam,Rate,Vat from StockDetls) AS tb2 on tb1.Item = tb2.PdNam";
             
                conn.Open();
                //MessageBox.Show(count.ToString());
                
                int i, j;
                dreader = cmd.ExecuteReader();
                dataGridView1.Rows.Add(count);
                //if (dreader.HasRows == true)
                // {
               dreader.Read();
               //MessageBox.Show(dreader["Qnty"].ToString());
               
                for (i = 0; i < count; i++, dreader.Read())
                {
                   // MessageBox.Show(dreader["Item"].ToString());

                    // MessageBox.Show(dreader["BillNo"].ToString());
                    // dreader.Read();
                    //dataGridView1.Rows[i].Cells[1].Value = (dreader["BillNo"].ToString());
                    dataGridView1.Rows[i].Cells[1].Value = (dreader["Item"].ToString());
                    dataGridView1.Rows[i].Cells[2].Value = (dreader["Qnty"].ToString());
                    dataGridView1.Rows[i].Cells[3].Value = (dreader["Rate"].ToString());
                    dataGridView1.Rows[i].Cells[4].Value = (dreader["Vat"].ToString());
                    dataGridView1.Rows[i].Cells[5].Value = (dreader["Amount"].ToString());


                }
                Decimal sum = 0, vat = 0;
                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                    vat += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }
                label11.Text = sum.ToString();
                label5.Text = vat.ToString();
                label30.Text = sum.ToString();
                // }
                // else
                //  {
                //      MessageBox.Show("New Item..!");
                //  }
            }
            else 
            {
                MessageBox.Show("No Entries Found..!");
            }

        }
        private void Load2()
        {
            String date = DateTime.Now.Month.ToString();      //Now.ToString("dd-MM-yyyy");
            string stmt = "SELECT COUNT(Distinct Item) FROM Bill where Dat like '___"+date+"%'";
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

            cmd.CommandText = "select tb1.Item,tb1.Qnty,tb2.Rate,tb2.Vat,(tb1.Qnty*tb2.Rate) as Amount from (Select Item,sum(Qnty) as Qnty from Bill where Dat like '___" + date + "%' Group By Item) AS tb1 inner join (Select PdNam,Rate,Vat from StockDetls) AS tb2 on tb1.Item = tb2.PdNam";
            
            conn.Open();
            //MessageBox.Show(count.ToString());
            int i, j;
            //int row2 = 0;
            dreader = cmd.ExecuteReader();
            dataGridView1.Rows.Add(count);
            //if (dreader.HasRows == true)
            // {
            dreader.Read();
            for (i = 0; i < count; i++, dreader.Read())
            {

                // MessageBox.Show(dreader["BillNo"].ToString());
                // dreader.Read();
                //dataGridView1.Rows[i].Cells[1].Value = (dreader["BillNo"].ToString());
                dataGridView1.Rows[i].Cells[1].Value = (dreader["Item"].ToString());
                dataGridView1.Rows[i].Cells[2].Value = (dreader["Qnty"].ToString());
                dataGridView1.Rows[i].Cells[3].Value = (dreader["Rate"].ToString());
                dataGridView1.Rows[i].Cells[4].Value = (dreader["Vat"].ToString());
                dataGridView1.Rows[i].Cells[5].Value = (dreader["Amount"].ToString());


            }
            Decimal sum = 0, vat = 0;
            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                vat += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
            }
            label11.Text = sum.ToString();
            label5.Text = vat.ToString();
            label30.Text = sum.ToString();
            // }
            // else
            //  {
            //      MessageBox.Show("New Item..!");
            //  }

        }
        private void Load3()
        {
            String date = DateTime.Now.Year.ToString();      //Now.ToString("dd-MM-yyyy");
            string stmt = "SELECT COUNT(Distinct Item) FROM Bill where Dat like '______" + date + "%'";

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

            cmd.CommandText = "select tb1.Item,tb1.Qnty,tb2.Rate,tb2.Vat,(tb1.Qnty*tb2.Rate) as Amount from (Select Item,sum(Qnty) as Qnty from Bill where Dat like '______" + date + "%' Group By Item) AS tb1 inner join (Select PdNam,Rate,Vat from StockDetls) AS tb2 on tb1.Item = tb2.PdNam";
            conn.Open();
            //MessageBox.Show(count.ToString());
            int i, j;
            //int row2 = 0;
            dreader = cmd.ExecuteReader();
            dataGridView1.Rows.Add(count);
            //if (dreader.HasRows == true)
            // {
            dreader.Read();
            for (i = 0; i < count; i++, dreader.Read())
            {

                // MessageBox.Show(dreader["BillNo"].ToString());
                // dreader.Read();
                //dataGridView1.Rows[i].Cells[1].Value = (dreader["BillNo"].ToString());
                dataGridView1.Rows[i].Cells[1].Value = (dreader["Item"].ToString());
                dataGridView1.Rows[i].Cells[2].Value = (dreader["Qnty"].ToString());
                dataGridView1.Rows[i].Cells[3].Value = (dreader["Rate"].ToString());
                dataGridView1.Rows[i].Cells[4].Value = (dreader["Vat"].ToString());
                dataGridView1.Rows[i].Cells[5].Value = (dreader["Amount"].ToString());


            }
            Decimal sum = 0, vat = 0;
            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                vat += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
            }
            label11.Text = sum.ToString();
            label5.Text = vat.ToString();
            label30.Text = sum.ToString();
            // }
            // else
            //  {
            //      MessageBox.Show("New Item..!");
            //  }

        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
          dataGridView1.AllowUserToAddRows = false;
        }
    }
}
