using System;
using System.Collections.Generic;
using System.Text;

namespace Deporte
{
    public abstract class Deportista
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public abstract string Describirse();
    }
}


 

