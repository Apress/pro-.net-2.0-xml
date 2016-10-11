using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsApplication52.localhost;

namespace WindowsApplication52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Service proxy = new Service();
            DataSet ds = proxy.GetEmployees();
            dataGridView1.DataSource = ds.Tables["myemployees"].DefaultView;
        }
    }
}