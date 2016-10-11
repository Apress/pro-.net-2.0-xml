using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsApplication64.localhost;
using System.Net;

namespace WindowsApplication64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmployeesEndPoint proxy = new GetEmployeesEndPoint();
            proxy.Credentials = CredentialCache.DefaultCredentials;
            object[] results=proxy.GetEmployees();
            dataGridView1.DataSource = ((DataSet)results[0]).Tables[0].DefaultView;
        }
    }
}