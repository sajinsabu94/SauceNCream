using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication2
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            
         }
           
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Increment(10);
            if (progressBar1.Value == 10)
            {
                label3.Text = "Reading modules..";                
            }
            else if (progressBar1.Value == 20)
            {
                label3.Text = "Turning on modules.";
                // label3.Refresh();
            }
            else if (progressBar1.Value == 40)
            {

                label3.Text = "Starting modules..";
                //  label3.Refresh();
            }
            else if (progressBar1.Value == 60)
            {
                label3.Text = "Loading modules..";
                // label3.Refresh();
            }
            else if (progressBar1.Value == 80)
            {
                label3.Text = "Finished...";
                // label3.Refresh();
            }
            else if (progressBar1.Value == 100)
            {
                timer1.Stop();                
            }     
            //Login me = new Login();
           // me.ShowDialog();
            
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
