using MicroondasDigitalDesktop.Entidades;
using System;
using System.Timers;
using System.Windows.Forms;


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
            try
            {
                ValidaDados();
                microondas.Minutos = Convert.ToInt32(txtMinutos.Text);
                microondas.Segundos = Convert.ToInt32(txtSegundos.Text);
                microondas.Inciar();
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void lbCronometro_Click(object sender, EventArgs e)
        {

        }

        public void ValidaDados()
        {
            int TempNumero;

            if (! (int.TryParse(txtMinutos.Text, out TempNumero) && (int.TryParse(txtSegundos.Text, out TempNumero))) )
            {
                throw new NullReferenceException("Somente é permitido valores numericos para Minutos e Segundos");                
            }


        }

    }
}
