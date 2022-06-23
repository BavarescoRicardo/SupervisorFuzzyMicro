﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisorFuzzyMicro
{
    public partial class Form : System.Windows.Forms.Form
    {
        Monitoramento monitoramento = new Monitoramento();

        char[] buffer = new char[1];
        char[] bufferCruzeiro = new char[1];
        public Form()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
            if (!portaSerial.IsOpen)
            {
                portaSerial.Open();
                MessageBox.Show("Rodando");
            }            
            
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
                MessageBox.Show("Encerrada");
            }
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Maximum = 500;
            chart1.ChartAreas[0].AxisY.Maximum = 220;

            monitoramento.abrePorta(portaSerial);
            monitoramento.iniciaGrafico(chart1);
            // dispara uma nova thread para executar
            Thread t = new Thread(printaLista);
            t.Start();

        }

        private void printaLista()
        {
            while (portaSerial.IsOpen)
            {
                buffer[0] = 'X';
                portaSerial.Write(buffer, 0,1);
                Thread.Sleep(200);
                String buffPic = monitoramento.leitura();
                if (listaDadosPic.Items.Count > 15)
                {                    
                    listaDadosPic.Invoke(new Action(() => listaDadosPic.Items.RemoveAt(0)));
                }
                if (buffPic.Length > 0 && buffPic != "!")
                {
                    listaDadosPic.Invoke(new Action(() => listaDadosPic.Items.Add(buffPic)));
                }

            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            bufferCruzeiro = new char[] { 'R' };
            portaSerial.Write(bufferCruzeiro, 0, 1);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            bufferCruzeiro = new char[] { 'S' };
            portaSerial.Write(bufferCruzeiro, 0, 1);
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
