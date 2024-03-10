using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedioTransporte
{
    public class Moto : MedioTransporte
    {
        public bool CantCilindraje250 { get; }

        public Moto(string nom, int cap, int cant, bool cc250) : base(nom, cap, cant)
        {
            this.CantCilindraje250 = cc250;
        }

        public override int CalcularPersonas()
        {
            return 1;
        }

        public void MostrarMoto()
        {
            MostrarMedioTransporte();
            Console.WriteLine($"Cilindraje 250: {CantCilindraje250}");
            }
    }

}
