using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakciProq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text =="proAdmin" && txtParol.Text == "proParol")
            {
                Form2 homeRegister = new Form2();
                homeRegister.Show();
                this.Hide();

            }
        }
    }
}
