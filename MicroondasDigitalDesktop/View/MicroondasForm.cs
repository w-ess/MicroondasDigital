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

            microondas.Segundos--;
            label1.Invoke(new MethodInvoker(delegate { label1.Text = Convert.ToString(microondas.Segundos); }));
            if (microondas.Segundos <= 0)
            {
                microondas.Parar();
            }
        }


    }
}
