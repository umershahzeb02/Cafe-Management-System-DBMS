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
    public partial class reportsform : Form
    {
        public reportsform()
        {
            InitializeComponent();
        }

        private void StaffPerfReport_Click(object sender, EventArgs e)
        {
            report_staffPerform rp = new report_staffPerform();
            rp.Visible = true;
        }

        private void SalesAndRevreport_Click(object sender, EventArgs e)
        {
            SalesAndRev sv = new SalesAndRev();
            sv.Visible = true;
        }

        private void transacReport_Click(object sender, EventArgs e)
        {
            transacreport report = new transacreport();
            report.Visible = true;
        }

        private void custLoyality_Click(object sender, EventArgs e)
        {
            customerLoyality sf = new customerLoyality();
            sf.Visible = true;
        }

        private void mostOrdered_Click(object sender, EventArgs e)
        {
            mostOrderedForm ms = new mostOrderedForm();
            ms.Visible = true;
        }
    }
}
