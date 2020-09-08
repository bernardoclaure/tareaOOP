using System;

namespace Deporte
{
    class Program
    {
        static void Main(string[] args)
        {
            var tenista = new Tenista();
            tenista.ranking = 3;
            tenista.nombre = "Rafael Nadal";
            tenista.edad = 35;
            var futbolista = new Futbolista();
            futbolista.edad = 32;
            futbolista.nombre = "Lionel Messi";
            futbolista.equipo = "Barcelona";
            Console.WriteLine($"Me llamo {futbolista.nombre}, juego en {futbolista.equipo}, y {futbolista.Describirse()}");
            Console.WriteLine($"Me llamo {tenista.nombre}, soy el ranking {tenista.ranking}, y {tenista.Describirse()}");
        }
    }
}
