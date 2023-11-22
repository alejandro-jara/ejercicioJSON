using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaJson.Solutions.Ejercicio_4
{
    internal class Productos
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public long Existencias { get; set; }
        public bool DescuentoDisponible { get; set; }
        public List<string> Etiquetas { get; set; }
        public Detalles Detalles { get; set; }
    }
}
