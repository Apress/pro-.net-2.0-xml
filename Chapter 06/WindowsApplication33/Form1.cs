using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

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
            xslt.Transform(textBox1.Text, textBox3.Text);
            if (checkBox1.Checked)
            {
                System.Diagnostics.Process.Start(textBox3.Text);
            }
        }
    }
}