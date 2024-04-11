using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {
        public String me;
        public Login()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            Thread.Sleep(4000);
            //SplashScreen.Close(Timespan.FromMilliseconds(int));            
            InitializeComponent();
            t.Abort();            
        }
        public static void Splash()
        {
            using (SplashScreen splash = new SplashScreen())
            {
                splash.ShowDialog();
            }
            //Application.Run(new SplashScreen());            
        } 
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String unm = UN.Text;
            String pass = PS.Text;
            if(unm.Equals("admin")&&pass.Equals("klmapsara"))
            {

                 me = "admn";
                 sauce_n_cream sp = new sauce_n_cream(me);
                //this.Visible = false;
               sp.ShowDialog();
                 //sp.Show();
               this.Close();
                 //    this.Close();
                //this.Show();
            }
            else if (unm.Equals("user") && pass.Equals("kannan"))
            {
                me = "usr";
                
                sauce_n_cream sp2 = new sauce_n_cream(me);
                //this.Visible = false;
                //this.Close();
                sp2.ShowDialog();
                //sp2.Show();
                this.Close();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Login Error..!");
                UN.Clear();
                PS.Clear();
            }
        }
    }
}
