using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace WindowsApplication21
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

        private void button1_Click(object sender, EventArgs e)
        {
            XPathDocument doc = new XPathDocument(Application.StartupPath + @"\employees.xml");
            XPathNavigator navigator = doc.CreateNavigator();
            navigator.MoveToRoot();
            navigator.MoveToFirstChild();
            while (navigator.MoveToNext())
            {
                navigator.MoveToFirstChild();
                do
                {
                    string id = navigator.GetAttribute("employeeid", "");
                    if (id == textBox1.Text)
                    {
                        XmlTextWriter writer = new XmlTextWriter(textBox2.Text, null);
                        navigator.WriteSubtree(writer);
                        writer.Close();
                        if (MessageBox.Show("Do you want to see the file?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(textBox2.Text);
                        }
                    }
                }
                while (navigator.MoveToNext());
            }

        }
    }
}