using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WindowsApplication26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(@"D:\Bipin\Authoring\My Books\Pro XML\Code 1.0\WindowsApplication26\EmployeesExtSchema.xml");
            XmlValidatingReader r = new XmlValidatingReader(reader);
            r.ValidationType = ValidationType.Schema;
            r.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler(r_ValidationEventHandler);
            while (r.Read())
            {

            }
        }

        void r_ValidationEventHandler(object sender, System.Xml.Schema.ValidationEventArgs e)
        {
            MessageBox.Show(e.Message);
        }
    }
}