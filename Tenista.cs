using System;
using System.Collections.Generic;
using System.Text;

namespace Deporte
{
    class Tenista : Deportista

    {
        public int ranking { get; set; }
        public override string Describirse()
        {
          return "Soy un tenista ";
        }
    }
}
