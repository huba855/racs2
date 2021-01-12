using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var streamReader = File.OpenText("kimenet.csv");
            streamReader.ReadLine();


            string line = "";
            int row = 0;
            while ((line = streamReader.ReadLine()) != null)
            {
                var tomb = line.Split(';');

                for (int i = 0; i < tomb.Length-1; i++)
                {
                    dataGridView1.Rows[row].Cells[i].Value = tomb[i];
                }
                row++;


            }

        }
    }

}       
    

