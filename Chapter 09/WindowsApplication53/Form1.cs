using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsApplication53.localhost;
using System.Net;

namespace WindowsApplication53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        CookieContainer cookiecontainer = new CookieContainer();

        private void button1_Click(object sender, EventArgs e)
        {
            Service proxy = new Service();
            proxy.CookieContainer = cookiecontainer;
            proxy.PutNameInSession(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service proxy = new Service();
            proxy.CookieContainer = cookiecontainer;
            MessageBox.Show(proxy.GetNameFromSession());
        }
    }
}