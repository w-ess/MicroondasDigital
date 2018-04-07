using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using MicroondasDigitalDesktop.Entidades;

namespace MicroondasDigitalDesktop
{
    public partial class Form1 : Temporizador
    {

        public Form1()
        {
            InitializeComponent();
        }

        Microondas microondas = new Microondas();
        



        private void btnIniciaPausa_Click(object sender, EventArgs e)
        {
            microondas.Segundos = 5;
            microondas.Iniciar_Parar();            
        }



        public override void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            base.OnTimedEvent(source, e);

            // Mostra contador na tela através da Label
            Invoke(new MethodInvoker(delegate 
            {                
                lbCronometro.Text = "00:" + Convert.ToString(microondas.Minutos) + ":" + Convert.ToString(microondas.Segundos);
            }));



            // Pausa time quando o encerrar a contagem
            if ( microondas.Minutos <= 0 && microondas.Segundos == 0)
            {
                microondas.Parar();
            }
            else if (microondas.Segundos == 0)
            {
                microondas.Minutos -= microondas.Minutos;
                microondas.Segundos = 60;
            }


            microondas.Segundos--;
        }



        private void btnInicia_Click(object sender, EventArgs e)
        {
            microondas.Minutos  = Convert.ToInt32(numMinutos.Value);
            microondas.Segundos = Convert.ToInt32(numSegundos.Value);
            microondas.Inciar();
        }

        private void lbCronometro_Click(object sender, EventArgs e)
        {

        }
    }
}
