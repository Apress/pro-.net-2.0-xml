using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using System.IO;

namespace WindowsApplication31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XsltSettings settings = new XsltSettings();
            settings.EnableScript = true;
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(textBox2.Text,settings,null);

            XsltArgumentList arguments = new XsltArgumentList();
            Employee employee = new Employee();
            arguments.AddExtensionObject("urn:myscripts", employee);

            FileStream stream = new FileStream(textBox3.Text, FileMode.Create);
            xslt.Transform(textBox1.Text, arguments,stream);
            stream.Close();
            if (checkBox1.Checked)
            {
                System.Diagnostics.Process.Start(textBox3.Text);
            }
        }
    }
}