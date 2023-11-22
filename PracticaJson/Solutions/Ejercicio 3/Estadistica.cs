using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaJson.Solutions.Ejercicio_3
{
    internal class Estadistica
    {

        [JsonPropertyName("equipo")]
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public bool Campeon { get; set; }

        public Estadistica()
        {
            Jugadores = new List<Jugador>();
        }

    }
}
