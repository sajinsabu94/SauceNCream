using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            string stmt = "SELECT COUNT (PdNam) FROM StockDetls";
            int count = 0;
            using (SqlConnection thisConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            //

            String temp = DateTime.Now.AddMonths(-2).ToString();
            String temp2 = DateTime.Now.AddMonths(-1).ToString();
            String yr = DateTime.Now.Year.ToString();
            MessageBox.Show(temp);
            string StrQuery;
            string StrQueryx;
            //String BillNo = bill_no.Text;
            //String datetxt = date.Text;
            String ConnString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True";
            using (SqlConnection conn = new SqlConnection(ConnString))
                   {
                       using (SqlCommand comm = new SqlCommand())
                       {
                           try
                           {
                               comm.Connection = conn;
                               conn.Open();
                               SqlCommand cmd3 = new SqlCommand();
                               SqlDataReader dreader9;

                               SqlCommand cmd4 = new SqlCommand();
                               SqlDataReader dreader4;

                               SqlCommand cmd5 = new SqlCommand();
                               SqlDataReader dreader5;

                               SqlCommand cmd6 = new SqlCommand();
                               SqlDataReader dreader6;

                               SqlCommand cmd7 = new SqlCommand();
                               SqlDataReader dreader7;

                               SqlCommand cmd8 = new SqlCommand();
                               SqlDataReader dreader8;
                               cmd8.CommandText = "select PdNam from MainStock where Date like '___" + temp2 + "" + yr + "'";
                               cmd8.Connection = conn;
                               dreader8 = cmd8.ExecuteReader();
                               // dreader8.Read();
                               for (int j = 0; j < dataGridView1.Rows.Count; j++, dreader8.Read())
                               {
                                   dataGridView1.Rows[j].Cells[1].Value = (dreader8["PdNam"].ToString());
                               }
                               conn.Close();
                               dreader8.Close();
                               Decimal vat_tot = Convert.ToDecimal(0.00);
                               Decimal tot = Convert.ToDecimal(0.00);

                               for (int i = 0; i < dataGridView1.Rows.Count; i++)
                               {
                                   String prd = dataGridView1.Rows[i].Cells["PrdNam"].Value.ToString();
                                   cmd3.CommandText = "select Qun from Remain where Date like '___" + temp + "" + yr + "' && PdNam = '" + prd + "'";
                                   cmd3.Connection = conn;
                                   dreader9 = cmd3.ExecuteReader();
                                   dreader9.Read();
                                   dataGridView1.Rows[i].Cells["opbal"].Value = dreader9["Qun"].ToString();
                                   String op = dreader9["Qun"].ToString();
                                   conn.Close();

                                   cmd4.CommandText = "select Agency from StockAgncy where PdNam = '" + prd + "'";
                                   cmd4.Connection = conn;
                                   dreader4 = cmd4.ExecuteReader();
                                   dreader4.Read();
                                   dataGridView1.Rows[i].Cells["agncy"].Value = dreader9["Agency"].ToString();
                                   conn.Close();

                                   cmd5.CommandText = "select Qun from QBase where PdNam = '" + prd + "' && Dat like ___" + temp2 + "_" + yr + "";
                                   cmd5.Connection = conn;
                                   dreader5 = cmd5.ExecuteReader();
                                   dreader5.Read();
                                   dataGridView1.Rows[i].Cells["sold"].Value = dreader9["Qun"].ToString();
                                   String sold = dreader9["Qun"].ToString();
                                   conn.Close();

                                   cmd6.CommandText = "select Sum(Qun) from MainStock where PdNam = '" + prd + "' && date like ___" + temp2 + "_" + yr + "";
                                   cmd6.Connection = conn;
                                   dreader6 = cmd6.ExecuteReader();
                                   dreader6.Read();
                                   dataGridView1.Rows[i].Cells["puchd"].Value = dreader9["Qun"].ToString();
                                   String pchd = dreader9["Qun"].ToString();
                                   conn.Close();

                                   String cls = ((Convert.ToInt32(op) + Convert.ToInt32(pchd)) - Convert.ToInt32(sold)).ToString();
                                   dataGridView1.Rows[i].Cells["puchd"].Value = cls;

                                   cmd7.CommandText = "select Vat,Rate from MainStock where PdNam = '" + prd + "' && date like ___" + temp2 + "_" + yr + "";
                                   cmd7.Connection = conn;
                                   dreader7 = cmd7.ExecuteReader();
                                   dreader7.Read();

                                   dataGridView1.Rows[i].Cells["Vat"].Value = dreader9["Vat"].ToString();
                                   dataGridView1.Rows[i].Cells["NtAmt"].Value = dreader9["Rate"].ToString();
                                   vat_tot += Convert.ToDecimal(dreader9["Vat"].ToString());

                                   String rte = dreader9["Rate"].ToString();
                                   conn.Close();

                                   dataGridView1.Rows[i].Cells["TtlAmt"].Value = (Convert.ToInt32(sold) * Convert.ToInt32(rte)).ToString();
                                   tot += Convert.ToDecimal(dataGridView1.Rows[i].Cells["TtlAmt"].Value);
                               }
                               label28.Text = vat_tot.ToString();
                               dataGridView1.Rows.Add(1);
                               dataGridView1.Rows[dataGridView1.Rows.Count].Cells["TtlAmt"].Value = tot;
                               label30.Text = tot.ToString();
                               decimal vv = Convert.ToDecimal(0.00);
                               for (int sp = 0; sp < dataGridView1.Rows.Count; sp++)
                               {
                                   vv += Convert.ToDecimal(dataGridView1.Rows[dataGridView1.Rows.Count].Cells["Vat"].Value);
                               }
                               label28.Text = vv.ToString();
                               dataGridView1.Rows[dataGridView1.Rows.Count].Cells["Vat"].Value = vv;
                               
                           }
                           catch 
                           {
                               MessageBox.Show("No Available Records..!");
                           }
                       }
                   }


            //
            SqlDataReader dreader;
            SqlConnection conn2 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn2;
            cmd.CommandText = "select PdNam,Qun,Rate from StockDetls where Qun >= 0";
            conn2.Open();
            
            dreader = cmd.ExecuteReader();
            dataGridView1.Rows.Add(count);
            dreader.Read();
            for (int i = 0; i < count; i++, dreader.Read())
            {
                dataGridView1.Rows[i].Cells[1].Value = (dreader["PdNam"].ToString());
                dataGridView1.Rows[i].Cells[2].Value = (dreader["Qun"].ToString());
                dataGridView1.Rows[i].Cells[3].Value = (dreader["Rate"].ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mainStock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            String de = DateTime.Now.ToString("dd-MM-yyyy");
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs("record"+de+".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created..!");

            printDocument1.Print();


        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);

            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(bm, 0, 0);

        }
    }
}
