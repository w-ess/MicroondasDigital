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

            microondas.Segundos--;
            // Mostra contador na tela através da Label
            Invoke(new MethodInvoker(delegate 
            {                
                lbCronometro.Text =  Convert.ToString(microondas.Segundos);
            }));

            
            //Incrmenta label de Aquecimento
            for (int i = 1; i <= Convert.ToInt32(numPotencia.Value); i++)
            {
                Invoke(new MethodInvoker(delegate { txtBoxString.Text = txtBoxString.Text + "."; }));
            }

            // Pausa time quando o encerrar a contagem
            if ( microondas.Segundos == 0 )
            {
                microondas.Parar();
                Invoke(new MethodInvoker(delegate { txtBoxString.Text = "aquecida"; }));
            }

            
        }


        // Botão Iniciar
        private void btnInicia_Click(object sender, EventArgs e)
        {
            try
            {                
                // Se textBox vazio recebe zero
                if (txtBoxString.TextLength <= 0) { txtBoxString.Text = "0"; }
                
                // verifica valores de entradas, para recebe valor de cozimento padrão                
                if (Convert.ToInt32(txtBoxString.Text) == 0) { numPotencia.Value = 8; }

                ValidaDados();
                lbCronometro.Text = txtBoxString.Text;                
                microondas.Segundos = Convert.ToInt32(txtBoxString.Text);
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


        // Validaçoes do Form
        public void ValidaDados()
        {
            int TempNumero;


            if (! (int.TryParse(txtBoxString.Text, out TempNumero)) ) 
            {
                throw new NullReferenceException("Insira um valor valido em Minutos e Segundos.");                
            }

            // Valida potência
            if (numPotencia.Value < 1 || numPotencia.Value > 10)
            {
                throw new NullReferenceException("A potência só permite valores de 1 a 10.");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numPotencia_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
