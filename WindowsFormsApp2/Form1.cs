using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog o = new OpenFileDialog();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter w = new StreamWriter(txt_path.Text, true);
            w.Write(txt_update.Text);
            w.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_Search_Click(object sender, EventArgs e)
        {
            o.Filter = "open file |*.txt";
            if (o.ShowDialog()==DialogResult.OK )
            {
                txt_path.Text = o.FileName;
            }
        }

        private void but_read_Click(object sender, EventArgs e)
        {
            if (txt_path.Text != "")
            {
                StreamReader r = new StreamReader(txt_path.Text);
                tex_read.Text = r.ReadToEnd();


                r.Close();
            }
            else
            {
                MessageBox.Show("Enter path");
            }
        }
    }
}
