using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;

namespace WindowsApplication45
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
            Manager manager = new Manager();
            manager.EmployeeID = int.Parse(textBox1.Text);
            manager.FirstName = textBox2.Text;
            manager.LastName = textBox3.Text;
            manager.HomePhone = textBox4.Text;
            manager.Notes = textBox5.Text;
            manager.NoOfSubordinates = int.Parse(textBox6.Text);
            FileStream stream = new FileStream(Application.StartupPath + @"\employee.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Manager));
            serializer.Serialize(stream, manager);
            stream.Close();
            if (checkBox1.Checked)
            {
                Process.Start(Application.StartupPath + @"\employee.xml");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager manager;
            FileStream stream = new FileStream(Application.StartupPath + @"\employee.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(Manager));
            manager = (Manager)serializer.Deserialize(stream);
            stream.Close();
            textBox1.Text = manager.EmployeeID.ToString();
            textBox2.Text = manager.FirstName;
            textBox3.Text = manager.LastName;
            textBox4.Text = manager.HomePhone;
            textBox5.Text = manager.Notes;
            textBox6.Text = manager.NoOfSubordinates.ToString();
        }
    }
}