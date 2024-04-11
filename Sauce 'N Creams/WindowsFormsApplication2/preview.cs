using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;



namespace WindowsFormsApplication2
{
    public partial class preview : Form
    {
        sauce_n_cream s = new sauce_n_cream();
        //sauce_n_cream sp = new sauce_n_cream("ab");
        public Boolean Me;
        public String BillNo;
        public preview()
        {
            //ss = s;
            InitializeComponent();
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.preview_FormClosing);
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

                            if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "" || dataGridView1.Rows[i].Cells[1].Value.ToString() == "")
                            {
                                check = true;
                            }
                        }
                        if (check.Equals(false))
                        {
                            string StrQuery;
                            string StrQueryx;
                            String BillNo = bill_no.Text;
                            String datetxt = datepre.Text;
                            String ConnString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True;";
                            using (SqlConnection conn = new SqlConnection(ConnString))
                            {
                                using (SqlCommand comm = new SqlCommand())
                                {
                                    comm.Connection = conn;
                                    conn.Open();
                                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                    {
                                        StrQuery = @"INSERT INTO Bill VALUES ('" + BillNo + "','" + dataGridView1.Rows[i].Cells["item"].Value + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["qty"].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["rate"].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["vat"].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["amount"].Value) + "','" + datetxt + "')";
                                        comm.CommandText = StrQuery;
                                        comm.ExecuteNonQuery();
                                    }
                                    conn.Close();

                                    SqlDataReader dreader9;
                                    SqlCommand cmd3 = new SqlCommand();
                                    comm.Connection = conn;
                                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                                    {
                                        StrQueryx = @"UPDATE StockDetls SET Qun = Qun - '" + dataGridView1.Rows[j].Cells["qty"].Value.ToString() + "' where PdNam = '" + dataGridView1.Rows[j].Cells["item"].Value.ToString() + "'AND '" + dataGridView1.Rows[j].Cells["item"].Value.ToString() + "' NOT IN (select Item from Others)";
                                        comm.CommandText = StrQueryx;
                                       // MessageBox.Show(dataGridView1.Rows[j].Cells["item"].Value.ToString());
                                        comm.Connection.Open();
                                        comm.ExecuteNonQuery();
                                        String temp = DateTime.Now.Month.ToString();
                                        String temp2 = DateTime.Now.Month.ToString();
                                        cmd3.CommandText = "select count(PdNam) as ct from QBase where Dat like '___" + temp + "_" + temp2 + "'";
                                        cmd3.Connection = conn;
                                        dreader9 = cmd3.ExecuteReader();
                                        dreader9.Read();
                                        if (Convert.ToInt16(dreader9["ct"]) > 0)
                                        {
                                            conn.Close();
                                            dreader9.Close();
                                            SqlDataReader dreader0;
                                            SqlCommand cmd4 = new SqlCommand();
                                            cmd4.CommandText = "select count(PdNam) as ct from QBase where PdNam = '" + dataGridView1.Rows[j].Cells["item"].Value.ToString() + "'";
                                            cmd4.Connection = conn;
                                            conn.Open();
                                            dreader0 = cmd4.ExecuteReader();
                                            dreader0.Read();
                                            MessageBox.Show(dreader0["ct"].ToString());
                                            if (Convert.ToInt16(dreader0["ct"]) > 0)
                                            {
                                                dreader0.Close();
                                                String Stt = @"UPDATE QBase SET Qun = Qun + '" + dataGridView1.Rows[j].Cells["qty"].Value.ToString() + "',Dat = '" + temp + "' where PdNam = '" + dataGridView1.Rows[j].Cells["item"].Value.ToString() + "'";
                                                comm.CommandText = Stt;
                                                comm.ExecuteNonQuery();
                                            }
                                            else
                                            {
                                                String StrQuerymm = @"INSERT INTO QBase VALUES ('" + dataGridView1.Rows[j].Cells["item"].Value.ToString() + "','" + datetxt + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells["qty"].Value) + "');";
                                                comm.CommandText = StrQuerymm;
                                                comm.ExecuteNonQuery();
                                            }
                                            conn.Close();
                                            dreader0.Close();
                                        }
                                        else
                                        {
                                            String StrQuer = @"INSERT INTO QBase VALUES ('" + dataGridView1.Rows[j].Cells["item"].Value.ToString() + "','" + datetxt + "','" + Convert.ToDecimal(dataGridView1.Rows[j].Cells["qty"].Value) + "');";
                                            comm.CommandText = StrQuer;
                                            comm.ExecuteNonQuery();
                                            conn.Close();
                                        }
                                    }
                                    MessageBox.Show("Entry Saved..!");
                                    
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Check Your Entries..!");
                        }
                    }
                    catch (Exception sqe)
                    {
                        MessageBox.Show(sqe.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No Items in Cart..!");
                }
            }
            catch (Exception xxy)
            {
                MessageBox.Show("Check Your Entries..");
            }   
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt);
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }            
            dataGridView1.Rows.Clear();           
        }        
        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12); //must use a mono spaced font as the spaces need to line up
            float fontHeight = font.GetHeight();
            int startX = 110;
            int startY = 10;
            int offset = 60;
            graphic.DrawString("        Sauce 'N Cream", new Font("Courier New", 23), new SolidBrush(Color.Black), startX, startY);
            graphic.DrawString("           Kankathu Jn.", new Font("Courier New", 19), new SolidBrush(Color.Black), startX, startY+30);
            graphic.DrawString("Tin : 32020800456                                                   BillNo : " + bill_no.Text + "  ", new Font("Courier New", 10), new SolidBrush(Color.Black), 40, startY + 70);
            string top = "No.".PadRight(5) + "    Item".PadRight(15) + "             Quantity  ".PadRight(5) + "       Rate".PadRight(5) + "       Amount";
            offset = 80 + (int)fontHeight;
            graphic.DrawString(top, font, new SolidBrush(Color.Black), 40, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("-------------------------------------------------------------------", font, new SolidBrush(Color.Black), 40, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            decimal totalprice = Convert.ToDecimal(0.00);
            decimal cash = Convert.ToDecimal(0.00);
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {                
                String no = (j + 1).ToString();
                string product = dataGridView1.Rows[j].Cells["item"].Value.ToString();
                string qty = dataGridView1.Rows[j].Cells["qty"].Value.ToString();
                string rate = dataGridView1.Rows[j].Cells["rate"].Value.ToString();
                String amount = "  " + dataGridView1.Rows[j].Cells["amount"].Value.ToString();                
                String productLine = no.PadRight(9) + product;
                String remain = qty.PadRight(10);
                String rem1 = rate.PadRight(150);
                String rem2 = amount.PadRight(10);
                totalprice += Convert.ToDecimal(amount);
                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), 40, startY + offset);
                    graphic.DrawString(remain, font, new SolidBrush(Color.Black),380, startY + offset);
                    graphic.DrawString(rem1, font, new SolidBrush(Color.Black),555, startY + offset);
                    graphic.DrawString(rem2, font, new SolidBrush(Color.Black),650, startY + offset);
                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
            }
            offset = offset + 20; //make some room so that the total stands out.
            graphic.DrawString("Total :".PadRight(30) + String.Format("{0:c}", totalprice), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), 140, startY + offset);

            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("Rupees : ".PadRight(30) + String.Format("{0:c}", rs.Text), font, new SolidBrush(Color.Black), 140, startY + offset);
            offset = offset + 30;
            graphic.DrawString("              Thank-you for visiting...,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("                Please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 25; //make some room so that the total stands out.
            String dte = DateTime.Now.ToString();
            graphic.DrawString(dte, font, new SolidBrush(Color.Black), 40, startY + offset);
        }
        private void preview_Load(object sender, EventArgs e)
        {
            datepre.Text = DateTime.Now.ToString("dd-MM-yyyy");
            SqlDataReader dreader;
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\App_Data\\SauceCream.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select MAX(BillNo)BillNo from Bill";
            conn.Open();
            dreader = cmd.ExecuteReader();
            int c;
            c = 1;
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void datepre_Click(object sender, EventArgs e)
        {

        }

        private void bill_no_Click(object sender, EventArgs e)
        {

        }

        private void preview_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
           // MessageBox.Show(Me.ToString());
            if (Me)
            {
                // s.Dispose();
                //sauce_n_cream xx = new sauce_n_cream();                
                //String xx = "xxx";

                //MessageBox.Show(Me.ToString());
                //s.PerformRefresh();
                //MessageBox.Show(s.dataGridView1.Rows.Count.ToString());
                s.change();
                //this.itemCategoryBindingSource.EndEdit();
                //this.itemsTableAdapter.Fill(myDatabaseDataSet.Items);
                //  this.dataGridView1.Refresh();
            }
             * */            
        }

        private void preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
