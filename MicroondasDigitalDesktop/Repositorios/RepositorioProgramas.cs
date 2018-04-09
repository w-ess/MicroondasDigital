using MicroondasDigitalDesktop.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroondasDigitalDesktop.Repositorios
{
    
    public class RepositorioProgramas
    {
        private static List<Microondas> microondas;

        public List<Microondas> Microondas
        {
            get
            {
                CriarMicroondas();
                return microondas;
            }

        }
        

        public static void CriarMicroondas()
        {
            microondas = new List<Microondas>();

            microondas.Add(new Microondas
            {
                Nome = "Sobremesa",
                Segundos = 35,
                Potencia = 2,
                Identificacao = "!"
            });

            microondas.Add(new Microondas
            {
                Nome = "Pipoca",
                Segundos = 100,
                Potencia = 10,
                Identificacao = "@"
            });

            microondas.Add(new Microondas
            {
                Nome = "Carne",
                Segundos = 120,
                Potencia = 10,
                Identificacao = "#"
            });

            microondas.Add(new Microondas
            {
                Nome = "Chocolate",
                Segundos = 40,
                Potencia = 9,
                Identificacao = "%"
            });

            microondas.Add(new Microondas
            {
                Nome = "Legumes",
                Segundos = 50,
                Potencia = 6,
                Identificacao = "*"
            });
        }


    }
    
}
