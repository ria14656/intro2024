using System;
using System.Collections.Generic;
using System.IO;

namespace PolimorfismoCurso
{
    class Auto
    {
        // Propiedades
        public int HP { get; set; }
        public string Color { get; set; }
        public List<string> HistoriaDeReparaciones { get; } = new List<string>();

        // Constructor parametrizado
        public Auto(int hp, string color)
        {
            HP = hp;
            Color = color;
        }

        // Métodos
        public void MostrarDetalles()
        {
            Console.WriteLine($"HP: {HP} - Color: {Color}");
        }

        public virtual void Reparar(string descripcion)
        {
            HistoriaDeReparaciones.Add(descripcion);
            Console.WriteLine("El auto está reparado");
        }
    }

    class BMW : Auto
    {
        // Variables
        private readonly string marca = "BMW";

        // Propiedad
        public string Modelo { get; set; }

        // Constructor
        public BMW(int hp, string color, string modelo) : base(hp, color)
        {
            Modelo = modelo;
        }

        // Métodos
        public new void MostrarDetalles()
        {
            Console.WriteLine($"Marca: {marca} - Modelo: {Modelo} - HP: {HP} - Color: {Color}");
        }

        public override void Reparar(string descripcion)
        {
            HistoriaDeReparaciones.Add(descripcion);
            Console.WriteLine($"El BMW {Modelo} está reparado");
        }
    }

    class Program
    {
        static void Main()
        {
            var auto = new Auto(hp: 150, color: "amarillo");
            auto.Reparar("Cambio de aceite");

            var bmw = new BMW(hp: 300, color: "Negro", modelo: "X5");
            bmw.Reparar("Reemplazo de fricciones");

            Console.WriteLine("\nHistoria de reparaciones del BMW:");
            foreach (var reparacion in bmw.HistoriaDeReparaciones)
            {
                Console.WriteLine(reparacion);
            }
        }
    }
}