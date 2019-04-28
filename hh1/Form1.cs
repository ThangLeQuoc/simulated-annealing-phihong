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

namespace hw2
{
    public partial class hw2 : Form
    {
        public double Optimal;
        public double Optimal_x;
        public double Optimal_y;

        public hw2()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Browse";
            saveFileDialog1.Filter = "Scheduling Document (*.*) | *.*";

            saveFileDialog1.FileName = " ";
            saveFileDialog1.ShowDialog();

            string sFilePath = saveFileDialog1.FileName;
            if (sFilePath == "") return;

            Run_Simulated_Annealing_Method(sFilePath);
        }

        private void Run_Simulated_Annealing_Method(string FileName)
        {
            StreamWriter sw = new StreamWriter(FileName + ".txt");
            Run_SA();

            sw.WriteLine("f(x,y) = " + Optimal);
            sw.WriteLine("x = " + Optimal_x);
            sw.WriteLine("y = " + Optimal_y);

            sw.Close();
        }

        private void Run_SA()
        {
            Algorithms AG = new Algorithms();

            AG.Run_Simulated_Annealing_Method();
            Optimal = AG.Optimal;
            Optimal_x = AG.Optimal_x;
            Optimal_y = AG.Optimal_y;

            x.Text = Convert.ToString(Optimal_x);
            y.Text = Convert.ToString(Optimal_y);
            txtf.Text = Convert.ToString(Optimal);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtx_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
