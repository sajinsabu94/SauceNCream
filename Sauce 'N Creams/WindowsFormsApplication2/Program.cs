﻿using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                //Application.Run(new SplashScreen());
                Application.Run(new Login());
            }
            catch (ExecutionEngineException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
