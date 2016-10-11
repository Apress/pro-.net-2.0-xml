using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WindowsApplication44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index=dataGridView1.CurrentCell.RowIndex;
            XmlElement element = doc.GetElementFromRow(doc.DataSet.Tables[0].Rows[index]);
            MessageBox.Show(element.OuterXml);
        }

        XmlDataDocument doc = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Application.StartupPath + @"\employees.xml");
            doc = new XmlDataDocument(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}