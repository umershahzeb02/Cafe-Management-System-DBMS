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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
        private int mgr;
        public ManagerForm(int id)
        {
            InitializeComponent();
            mgr = id;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void staff_Click(object sender, EventArgs e)
        {
            manageStaff ms = new manageStaff(mgr);
            ms.Visible = true;
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            inventoryManagerForm frm = new inventoryManagerForm(mgr);
            frm.Visible = true;

        }

        private void menu_Click(object sender, EventArgs e)
        {
            makeMenu mk = new makeMenu(mgr);
            mk.Visible = true;
        }

        private void reports_Click(object sender, EventArgs e)
        {
            reportsform rf = new reportsform();
            rf.Visible = true;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Visible = true;
            this.Visible = false;
        }
    }
}
