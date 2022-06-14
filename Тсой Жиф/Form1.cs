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

namespace Тсой_Жиф
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists("f.txt")) { File.Create("f.txt"); }
            if (!File.Exists("g.txt")) { File.Create("g.txt"); }
        }

        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter streamwriter = new StreamWriter("f.txt");
            string text = "";
            for (int i = 0; i < 100; i++)
            {
                text += $"{random.Next(100)} ";
            }
            streamwriter.WriteLine(text);
            MessageBox.Show(text);
            streamwriter.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader streamreader = new StreamReader("f.txt");
            string text = streamreader.ReadToEnd();
            string[] num = text.Split();
            string text1 = "";
            for (int i = 0; i < 100; i++)
            {
                int a = int.Parse(num[i]);
                if (a % (int)m.Value == 0 & a % (int)n.Value != 0)
                {
                    text1 += a.ToString() + " ";
                }
            }
            streamreader.Close();
            StreamWriter streamwriter = new StreamWriter("g.txt");
            streamwriter.WriteLine(text1);
            streamwriter.Close();
            MessageBox.Show(text1);
        }
    }
}
