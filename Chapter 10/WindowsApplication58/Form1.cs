using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlXml;
using System.IO;

namespace WindowsApplication56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = @"Provider=SQLOLEDB;server=.\sqlexpress;database=northwind;integrated security=SSPI";
            string sql = "select employeeid,firstname,lastname from employees where employeeid=? for xml auto,root('MyRoot')";
            SqlXmlCommand cmd = new SqlXmlCommand(strConn);
            cmd.CommandText = sql;
            SqlXmlParameter param = cmd.CreateParameter();
            param.Value = textBox1.Text;
            StreamWriter writer = File.CreateText(Application.StartupPath + @"\sqlxmlresults.xml");
            cmd.ExecuteToStream(writer.BaseStream);
            writer.Close();
            webBrowser1.Navigate(Application.StartupPath + @"\sqlxmlresults.xml");
        }
    }
}