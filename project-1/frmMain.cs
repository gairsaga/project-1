//frmMain.cs
// CS-1181
// Sagar Gaire
// 9/5/2017
// Anil Mandal
// From this project we can learn to change and display any name on Text box
// WOW: I have created a new bottom Good Bye. If we type somethings in text box than it will show somethings good bye in a message box.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
         MessageBox.Show("Hello " + txtName.Text);
        }

        private void btnGoodBye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good Bye " + txtName.Text);
        }
    }
}
