using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaJson.Solutions.Ejercicio_4
{
    internal class Catalogo
    {
        public List<Productos> Productos { get; set; }

        public Catalogo()
        {
            Productos = new List<Productos>();
        }
    }
}
