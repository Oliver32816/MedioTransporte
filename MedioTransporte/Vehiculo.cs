using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedioTransporte
{
    public class Vehiculo : MedioTransporte
    {
        public int CantidadGas { get; }
        public int CantidadGasolina { get; }

        public Vehiculo(string nom, int cap, int cant, int cgas, int cgaso) : base(nom, cap, cant)
        {
            this.CantidadGas = cgas;
            this.CantidadGasolina = cgaso;
        }

        public override int CalcularPersonas()
        {
            return Cantidad;
        }

        public void MostrarVehiculo()
        {
            MostrarMedioTransporte();
            Console.WriteLine($"Cantidad de gas: {CantidadGas}");
            Console.WriteLine($"Cantidad de gasolina: {CantidadGasolina}");
        }
    }

}
