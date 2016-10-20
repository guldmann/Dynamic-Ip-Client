using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Ip_Client
{
    public partial class NewProvider : Form
    {
        public NewProvider()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            var connectionString = textBoxUrl.Text.ProviderConvert(textBoxDomain.Text, textBoxIP.Text);
            ProviderConnect PC = new ProviderConnect();
            var result = PC.Open(connectionString, textBoxUser.Text, textBoxPassword.Text);
            richTextBoxResult.AppendText("Provider responded: " + result + Environment.NewLine); 
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Generate dialog result here and close form  
            //give nack object to main form 

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

       
    }
}
