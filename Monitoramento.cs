using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace SupervisorFuzzyMicro
{
    class Monitoramento
    {
        int rotacao;
        SerialPort portaS;
        public void abrePorta(SerialPort portaSe)
        {
            this.portaS = portaSe;
        }
        public String leitura()
        {
            if (!portaS.IsOpen)
                return "!";

            String rpm = null;                
            rpm = portaS.ReadExisting();

            // codigo do exemplo do supervisor 

            //Sleep(30);

            // Armazena em buffer a resposta enviada pelo mestre com as temperaturas.
            // buffer1 = portaS.Read(buffer1, 0, 10);
            
            //portaS.Read(buffer1, 0, 10);

            //------------------------------------------------------------------------
            // AQUISIÇÃO DOS PACOTES DE DADOS DE MODO CONTÍNUO.
            //------------------------------------------------------------------------

            // Verificação e Validação do pacote de dados recebido.
            if (rpm.Length > 4 && rpm[0] == '#' && rpm[1] == '$' && rpm[2] == ':')
            {
                // return rpm.Substring(2, 10);

                rotacao = (rpm[3] << 8) + (rpm[4]);

                return rotacao.ToString();
            }

            // return rpm.Substring(5,15);
            return "!";
        }
    }
}
