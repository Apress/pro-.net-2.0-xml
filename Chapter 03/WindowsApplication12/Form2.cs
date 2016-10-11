using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WindowsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NameTable table = new NameTable();
            XmlTextReader reader1 = new XmlTextReader(Application.StartupPath + @"\employees1.xml",table);
            XmlTextReader reader2 = new XmlTextReader(Application.StartupPath + @"\employees2.xml",table);
            XmlTextReader reader3 = new XmlTextReader(Application.StartupPath + @"\employees3.xml",table);
            //process further

        }
    }
}