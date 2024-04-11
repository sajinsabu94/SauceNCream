using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication2
{
    public partial class preview : Form
    {
        public preview()
        {
            InitializeComponent();
        }

        public DataGridView CopyDataGridView(DataGridView dgv_org)
        {
            try
            {
                if (dataGridView1.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                    {
                        dataGridView1.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv_org.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dataGridView1.Rows.Add(row);
                }
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                Decimal sum = 0, vat = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                    vat += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }
                net_amt.Text = sum.ToString();
                vt.Text = vat.ToString();
                String words;
                words = NumbersToWords(Convert.ToInt32(sum));
                rs.Text = words;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Copy DataGridViw " + ex);
            }
            return dataGridView1;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void print_Click(object sender, EventArgs e)
        {
            
            try
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
                            StrQuery = @"INSERT INTO Bill VALUES ('" + BillNo + "','" + dataGridView1.Rows[i].Cells["item"].Value + "','" + dataGridView1.Rows[i].Cells["qty"].Value + "','" + dataGridView1.Rows[i].Cells["rate"].Value + "','" + dataGridView1.Rows[i].Cells["vat"].Value + "','" + dataGridView1.Rows[i].Cells["amount"].Value + "','" + datetxt + "');";
                            comm.CommandText = StrQuery;
                            comm.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show("Billing Entry Failed..!");
            }
        }
        private void preview_Load(object sender, EventArgs e)
        {
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
                    bill_no.Text = Convert.ToInt32(Convert.ToInt32(dreader["BillNo"]) + Convert.ToInt32(c)).ToString();
            }
            
        }
        public static string NumbersToWords(int number)
        {
            if (number == 0)
                return "ZERO";
            if (number < 0)
                return "minus " + NumbersToWords(Math.Abs(number));
            string words = "";
            if ((number / 1000000) > 0)
            {
                words += NumbersToWords(number / 1000000) + " MILLION ";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                words += NumbersToWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += NumbersToWords(number / 100) + " HUNDRED ";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "")
                    words += "AND ";
                var unitsMap = new[] { "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN" };
                var tensMap = new[] { "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }
            return words;
        }
        private void tin_Click(object sender, EventArgs e)
        {

        }
    }
}
