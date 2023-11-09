using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class inmueble
    {

        public string? tipoInmueble { get; set; }
        public string? ubicacion {  get; set; }
        public double areaTerreno { get; set; }
        public double precio {  get; set; }

        public void vender()
        {
            Console.WriteLine(tipoInmueble + "Vendida por el perecio de L. " + precio);

        }

    }
}
