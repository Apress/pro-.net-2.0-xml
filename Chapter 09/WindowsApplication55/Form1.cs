using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsApplication55.localhost;
using System.Web.Services.Protocols;

namespace WindowsApplication55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service proxy = new Service();
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                User currentuser = new User();
                currentuser.UserID = textBox1.Text;
                currentuser.Password = textBox2.Text;
                proxy.UserValue = currentuser;
            }
            try
            {
                DataSet ds = proxy.GetEmployees();
                dataGridView1.DataSource = ds.Tables["myemployees"].DefaultView;
            }
            catch (SoapHeaderException ex2)
            {
                MessageBox.Show(ex2.Message + "[" + ex2.Code + "]");
            }
            catch (SoapException ex1)
            {
                MessageBox.Show(ex1.Message + "[" + ex1.Code + "]");
            }
        }
    }
}