using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace WindowsApplication43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDataDocument doc = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Application.StartupPath + @"\employees.xml");
            doc = new XmlDataDocument(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(Application.StartupPath + @"\employees.xslt");
            XmlTextWriter writer = new XmlTextWriter(Application.StartupPath + @"\employees.html", null);
            xslt.Transform(doc, writer);
            writer.Close();
        }

    }
}