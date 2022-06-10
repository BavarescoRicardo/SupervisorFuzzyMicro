using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisorFuzzyMicro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
            if (!portaSerial.IsOpen)
            {
                portaSerial.Open();
            }            
            //MessageBox.Show(charPic.ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("2");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("3");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("4");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("5");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("6");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("7");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("8");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("9");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("0");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            portaSerial.Write("0");
            if (portaSerial.IsOpen)
            {
                portaSerial.Close();
            }
        }
    }
}
