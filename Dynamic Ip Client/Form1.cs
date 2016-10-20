using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace Dynamic_Ip_Client
{
    public partial class Form1 : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // NOTE test logging  
            logger.Debug("Are we logging this ");
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {

        }

        private void buttonAddProvider_Click(object sender, EventArgs e)
        {
            // NOTE HERE FOR test NewProvider 
            NewProvider NP = new NewProvider();
            NP.Show(); 

        }
    }
}
