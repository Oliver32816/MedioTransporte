using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedioTransporte
{
    public abstract class MedioTransporte
    {
        public string Nombre { get; }
        public int CapacidadPasajeros { get; }
        public int Cantidad { get; }

        protected MedioTransporte(string nom, int cap, int cant)
        {
            this.Nombre = nom;
            this.CapacidadPasajeros = cap;
            this.Cantidad = cant;
        }

        public abstract int CalcularPersonas();

        public void MostrarMedioTransporte()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Capacidad de pasajeros: {CapacidadPasajeros}");
            Console.WriteLine($"Cantidad: {Cantidad}");
        }
    }

}
