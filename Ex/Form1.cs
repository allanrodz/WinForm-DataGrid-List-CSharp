using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Customer> mylist = new List<Customer>();

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBank.DataSource = Enum.GetValues(typeof(bank));
            cmbCounty.DataSource = Enum.GetValues(typeof(counties));
        }

        private void btnNextPD_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabBanking);
        }

        private void btnBackBD_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPersonalDetails);
        }

        private void btnNextBD_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabSubmit);

            
        }

        private void btnBackS_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabBanking);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fn = txtFn.Text;
            string sn = txtSn.Text;
            string cy = cmbCounty.SelectedItem.ToString();
            string dob = dtpDOB.Text;
            int ac = int.Parse(txtACC.Text);
            string bk = cmbBank.SelectedItem.ToString();

            Customer c = new Customer(fn, sn, cy, dob, ac, bk);
            mylist.Add(c);

            MessageBox.Show("Data Added", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtACC.Clear();
            txtFn.Clear();
            txtSn.Clear();
        }

        private void btnNextS_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabDataGrid);
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            dgv.DataSource = false;
            dgv.DataSource = mylist;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPersonalDetails);
        }

       
    }
}
