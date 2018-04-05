using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CRUD : Form
    {

        AshikaEntities ashika;

        public CRUD()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        { 

        }

        private void btnNew1_Click(object sender, EventArgs e)
        {

            try {
                panel1.Enabled = true;
                txtCustomerId.Focus();
                Customer c = new Customer();
                ashika.Customers.Add(c);
                customerBindingSource.Add(c);
                customerBindingSource.MoveLast();



            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtCustomerId.Focus();

        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            customerBindingSource.ResetBindings(false);
            //foreach(DbEn)



        }

        private void btnSave1_Click(object sender, EventArgs e)
        {

            try {
                customerBindingSource.EndEdit();
                ashika.SaveChangesAsync();
                panel1.Enabled = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerBindingSource.ResetBindings(false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Enabled=false;
            ashika = new AshikaEntities();
            //customerBindingSource.DataSource = test.Customers.ToList();
            customerBindingSource.DataSource = ashika.Customers.ToList();
             



        }

        private void btnCustomerId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
