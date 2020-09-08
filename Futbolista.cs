using System;
using System.Collections.Generic;
using System.Text;

namespace Deporte
{
    class Futbolista : Deportista
    {
        public string equipo { get; set; }
        public override string Describirse()
        {
            return "Soy un futbolista ";
        }
    }
}
