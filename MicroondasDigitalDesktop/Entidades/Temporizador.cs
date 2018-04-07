using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MicroondasDigitalDesktop.Entidades
{
   public class Temporizador : Form
    {
        public int Horas { get; set; }        
        public int Minutos { get; set; }
        public int Segundos { get; set; }


        private static System.Timers.Timer aTimer;

        // Construtor
        public Temporizador()
        {         
            aTimer = new System.Timers.Timer();            
            aTimer.Interval = 1000;
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
        }

        // Iniciar
        public void Inciar()
        {

            aTimer.Start();
        }

        // Pausa
        public void Parar()
        {
            aTimer.Stop();
        }


        // Play e Pausa
        public void Iniciar_Parar()
        {          

            if (aTimer.Enabled == false)
            {
                aTimer.Start();
            }
            else
            {
                aTimer.Stop();
            }
        }



        // Evento do timer
        public virtual void OnTimedEvent(Object source, ElapsedEventArgs e)
        {

        }



    }
}
