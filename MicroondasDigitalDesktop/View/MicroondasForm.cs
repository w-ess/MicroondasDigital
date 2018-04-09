using MicroondasDigitalDesktop.Entidades;
using MicroondasDigitalDesktop.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
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
        List<Microondas> var1_microondas = new RepositorioProgramas().Microondas;



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
                lbCronometro.Text = Convert.ToString(microondas.Segundos);
            }));


            //Incrementa Aquecimento
            for (int i = 1; i <= Convert.ToInt32(numPotencia.Value); i++)
            {
                Invoke(new MethodInvoker(delegate { txtBoxString.Text = txtBoxString.Text + microondas.Identificacao; }));
            }

            // Pausa time quando o encerrar a contagem
            if (microondas.Segundos == 0)
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



                // verifica valores de entradas, para recebe valor de cozimento padrão ou programa                               
                if ((int.TryParse(txtBoxString.Text, out var TempNumero)))
                {
                    // Verificar se é tempo padrão
                    if (TempNumero == 0)
                    {
                        microondas.Potencia = 8;
                        microondas.Segundos = 30;
                        microondas.Identificacao = ".";
                    }
                    else
                    {
                        microondas.Potencia = Convert.ToInt32(numPotencia.Value);
                        microondas.Segundos = TempNumero;
                        microondas.Identificacao = ".";
                    }


                }
                else {

                    // Verica programa de aquecimento                         
                    if (var1_microondas.Find(m => m.Nome.Equals(txtBoxString.Text)) == null)
                    {
                        throw new NullReferenceException("alimento incompatível com o programa.");
                    }
                    else
                    {
                        microondas = var1_microondas.Find(m => m.Nome.Equals(txtBoxString.Text));
                    }

                }



                txtBoxString.Text = Convert.ToString(microondas.Segundos);
                numPotencia.Value = microondas.Potencia;

                ValidaDados();
                lbCronometro.Text = txtBoxString.Text;
                microondas.Inciar();
            }
            catch (NullReferenceException ex)
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


            if (!(int.TryParse(txtBoxString.Text, out TempNumero)))
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            listBoxProgramas.Items.Clear();

            if (txtBoxPesquisa.TextLength <= 0)
            {

                foreach (var i in var1_microondas)
                {
                    listBoxProgramas.Items.Add("Programa: " + i.Nome +
                    ", Segundos: " + i.Segundos + ", Potência: " + i.Potencia + ", Caractere: " + i.Identificacao);
                }

            }
            else
            {
                if (var1_microondas.Find(m => m.Nome.Equals(txtBoxPesquisa.Text)) == null)
                {
                    throw new NullReferenceException("Programa não encontrado.");
                }
                else
                {
                    var result = var1_microondas.Find(m => m.Nome.Equals(txtBoxPesquisa.Text));

                    listBoxProgramas.Items.Add("Programa: " + result.Nome +
                    ", Segundos: " + result.Segundos + ", Potência: " + result.Potencia + ", Caractere: " + result.Identificacao);

                }
            }
            
        }

        private void listBoxProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
