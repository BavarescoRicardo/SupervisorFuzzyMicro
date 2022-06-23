using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SupervisorFuzzyMicro
{
    class Monitoramento
    {
        int velocidade;
        int setado;
        String mensagem;
        SerialPort portaS;
        Chart grafico;
        public void abrePorta(SerialPort portaSe)
        {
            this.portaS = portaSe;
        }

        public void iniciaGrafico(Chart grafico)
        {
            this.grafico = grafico;
        }
        public String leitura()
        {
            if (!portaS.IsOpen)
                return "!";

            String buffer = null;                
            buffer = portaS.ReadExisting();

            // codigo do exemplo do supervisor 

            //Sleep(30);

            // Armazena em buffer a resposta enviada pelo mestre com as temperaturas.
            // buffer1 = portaS.Read(buffer1, 0, 10);
            
            //portaS.Read(buffer1, 0, 10);

            //------------------------------------------------------------------------
            // AQUISIÇÃO DOS PACOTES DE DADOS DE MODO CONTÍNUO.
            //------------------------------------------------------------------------

            // Verificação e Validação do pacote de dados recebido.
            if (buffer.Length > 4 && buffer[0] == '#' && buffer[1] == '$' && buffer[2] == ':')
            {
                velocidade = (buffer[3] << 8) + (buffer[4]);
                velocidade /= 40;

                setado = (buffer[6] << 8) + (buffer[7]);

                mensagem = "Velocidade Atual: " + velocidade.ToString() + " Setado: " + setado.ToString();

                grafico.Invoke(new Action(() =>
                    grafico.Series["Series1"].Points.AddXY(grafico.Series["Series1"].Points.Count, velocidade)));
                return mensagem;
            }

            return "!";
        }
    }
}
