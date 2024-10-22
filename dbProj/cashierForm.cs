using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbProj
{
    public partial class cashierForm : Form
    {
        public cashierForm()
        {
            InitializeComponent();
        }
        private int id;
        public cashierForm(int cashierID)
        {
            InitializeComponent();
            id = cashierID;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void makeOrder_Click(object sender, EventArgs e)
        {
            orderForm of = new orderForm(id);
            //this.Visible = false;
            of.Visible = true;

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Visible = true;
            this.Visible = false;
        }

        private void cashierForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderForm of = new orderForm(id);
            //this.Visible = false;
            of.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Visible = true;
            this.Visible = false;
        }
    }
}
