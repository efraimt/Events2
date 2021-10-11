using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events2.UI
{
    public partial class frmMain : Form
    {

        Client client = new Client();
        public frmMain()
        {
            InitializeComponent();
            client.LongNameEntered += LongNameHandler;
            client.LongNameEntered2 += LongNameHandler;
            client.LongNameEntered3 += LongNameHandler3;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //(sender as System.Windows.Forms.Button).BackColor = System.Drawing.Color.Red;
            client.Name = txtName.Text;
        }

        private void LongNameHandler(string name)
        {
            MessageBox.Show(string.Format( "Let the client know how {0} is interesting!",name));
        }

        private void LongNameHandler(Person client)
        {
            MessageBox.Show(string.Format("Let the client know how {0} is interesting, and a great age {1}!", client.Name,client.Age ));
        }

        private void LongNameHandler3(object sender,EventArgs eventArgs)
        {
            MessageBox.Show(string.Format("Let the client know how {0} is interesting, and a great age {1}!", client.Name, client.Age));
        }

    }
}
