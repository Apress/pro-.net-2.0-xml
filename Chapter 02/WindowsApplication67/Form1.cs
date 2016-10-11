using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WindowsApplication67
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\sample.xml";
            XmlDocument doc = new XmlDocument();
            XmlElement root= doc.CreateElement("root");
            XmlElement fullname = doc.CreateElement("fullname");
            XmlElement address = doc.CreateElement("address");

            XmlText fullnametext= doc.CreateTextNode(textBox1.Text);
            XmlText street1 = doc.CreateTextNode(textBox2.Text);
            XmlText street2 = doc.CreateTextNode(textBox3.Text);
            XmlText city = doc.CreateTextNode(textBox4.Text);
            XmlText state = doc.CreateTextNode(textBox5.Text);
            XmlText country = doc.CreateTextNode(textBox6.Text);

            XmlSignificantWhitespace sws1 = doc.CreateSignificantWhitespace("\r\n");
            XmlSignificantWhitespace sws2 = doc.CreateSignificantWhitespace("\r\n");
            XmlSignificantWhitespace sws3 = doc.CreateSignificantWhitespace("\r\n");
            XmlSignificantWhitespace sws4 = doc.CreateSignificantWhitespace("\r\n");
            XmlSignificantWhitespace sws5 = doc.CreateSignificantWhitespace("\r\n");

            fullname.AppendChild(fullnametext);

            address.AppendChild(street1);
            address.AppendChild(sws1);
            address.AppendChild(street2);
            address.AppendChild(sws2);
            address.AppendChild(city);
            address.AppendChild(sws3);
            address.AppendChild(state);
            address.AppendChild(sws4);
            address.AppendChild(country);
            address.AppendChild(sws5);

            doc.AppendChild(root);
            root.AppendChild(fullname);
            root.AppendChild(address);
            doc.Save(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\sample.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            MessageBox.Show(doc.DocumentElement.ChildNodes[1].ChildNodes.Count.ToString());
        }
    }
}