using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;
using EmployeeLibrary;

namespace EmployeeServiceClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(textBox1.Text);
            ServiceEndpointCollection endpts = MetadataResolver.Resolve(typeof(IEmployeeService), uri, MetadataExchangeClientMode.HttpGet);
            foreach (ServiceEndpoint obj in endpts)
            {
                IEmployeeService proxy = new ChannelFactory<IEmployeeService>(obj.Binding, obj.Address).CreateChannel();
                DataSet ds = proxy.GetEmployees();
                listBox1.DataSource = ds.Tables[0].DefaultView;
                listBox1.DisplayMember = "FirstName";
                listBox1.ValueMember = "EmployeeID";
                ((IChannel)proxy).Close();
            }

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            //Comment one of the URLs
            //Uri uri = new Uri("http://localhost:8000/EmployeeService?wsdl");
            //Uri uri = new Uri("http://Localhost/EmployeeServiceHostWeb/EmployeeServicerHost.svc?wsdl");

            Uri uri = new Uri(textBox1.Text);
            ServiceEndpointCollection endpts = MetadataResolver.Resolve(typeof(IEmployeeService), uri, MetadataExchangeClientMode.HttpGet);
            foreach (ServiceEndpoint obj in endpts)
            {
                IEmployeeService proxy = new ChannelFactory<IEmployeeService>(obj.Binding, obj.Address).CreateChannel();
                Employee emp = proxy.GetEmployee(int.Parse(listBox1.SelectedValue.ToString()));
                label5.Text = emp.EmployeeID.ToString();
                label6.Text = emp.FirstName;
                label7.Text = emp.LastName;
                ((IChannel)proxy).Close();
            }
        }
    }
}