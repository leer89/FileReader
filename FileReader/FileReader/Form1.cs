using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Randy";
            label2.Text = "Lee";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "g:\\";
            ofd.Title = "SampleMaker - Browse For .DAT Files";
            ofd.Filter = "DAT files (*.DAT)|*.DAT*"; // text with file extension seperated with | 
            ofd.RestoreDirectory = true;
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                label1.Text = ofd.FileName;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            label5.Text = label1.Text;
            using (StreamReader sr = new StreamReader(label5.Text))
            {
                String line = await sr.ReadToEndAsync();
                Console.WriteLine(line);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

        }
    }
}
