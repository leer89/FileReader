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
        string datafilename;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Randy";
            label2.Text = "Lee";

            Stream myStream = null;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "c:\\";
            dialog.Filter = "dat Files (*.dat)|*.dat|All files(*.*) | *.* ";
            dialog.FilterIndex = 1;
            // dialog.RestoreDirectory = true;
           
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = dialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Read dat file here.
                            int counter = 0;
                            string line;
                            datafilename = dialog.FileName;
                            // Read the file and display it line by line.
                            System.IO.StreamReader file =
                                new System.IO.StreamReader(datafilename);
                            while ((line = file.ReadLine()) != null)
                            {
                                System.Console.WriteLine(line);
                                counter++;
                            }

                            file.Close();
                            System.Console.WriteLine("There were {0} lines.", counter); // test lines
                            // Suspend the screen.
                            System.Console.ReadLine();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk.\nCould not open file: " + datafilename + " Original error: " + ex); // read error
                }
            }
        }
    }
}
