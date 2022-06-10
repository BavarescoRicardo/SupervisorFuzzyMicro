using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisorFuzzyMicro
{
    class Monitoramento
    {
        public void leitura(SerialPort portaS)
        {
            if(!portaS.IsOpen)
            {
                return;                
            }
            // Declaracao das variaveis utilizadas pelo supervisonamento
            String rpm;

            MessageBox.Show("Rodando");
            rpm = portaS.ReadLine();

            MessageBox.Show(rpm);

        }
    }
}
