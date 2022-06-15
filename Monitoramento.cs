using System;
using System.Collections.Generic;
using System.IO.Ports;


namespace SupervisorFuzzyMicro
{
    class Monitoramento
    {
        SerialPort portaS;
        public void abrePorta(SerialPort portaSe)
        {
            this.portaS = portaSe;
        }
        public String leitura()
        {
            String rpm = null;                
            rpm = portaS.ReadExisting();

            return rpm;          
        }
    }
}
