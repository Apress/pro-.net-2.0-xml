using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using EmployeeServer;


namespace WindowsApplication65
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RemotingConfiguration.Configure(Environment.CurrentDirectory + @"\EmployeeClient.config", false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            EmployeeDetails ed= emp.GetEmployee(int.Parse(textBox1.Text));
            label7.Text = ed.EmployeeID.ToString();
            label8.Text = ed.FirstName;
            label9.Text = ed.LastName;
            label10.Text = ed.HomePhone;
            label11.Text = ed.Notes;
        }
    }
}