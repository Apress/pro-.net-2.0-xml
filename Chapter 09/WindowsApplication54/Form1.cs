using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsApplication54.localhost;

namespace WindowsApplication54
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
            proxy.GetEmployeesCompleted += new GetEmployeesCompletedEventHandler(proxy_GetEmployeesCompleted);
            proxy.GetEmployeesAsync();
        }

        void proxy_GetEmployeesCompleted(object sender, GetEmployeesCompletedEventArgs e)
        {
            DataSet ds = e.Result;
            dataGridView1.DataSource = ds.Tables["myemployees"].DefaultView;
        }
    }
}