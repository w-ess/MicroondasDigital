using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroondasDigitalDesktop.Entidades
{
    public class Microondas : Temporizador
    {
        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // Microondas
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "Microondas";
        //    this.Load += new System.EventHandler(this.Microondas_Load);
        //    this.ResumeLayout(false);

        //}

        //private void Microondas_Load(object sender, EventArgs e)
        //{

        //}

        public override void Inciar()
        {
            //Valida se o tempo é entre 1 segundo a 2 minutos           
            if (this.Segundos < 1 || this.Segundos > 120 )
            {
                throw new NullReferenceException("O tempo máximo de cozimentos é de 2 minutos e no mínimo 1 segundo.");
            }

            base.Inciar();            
        }
    }
}
