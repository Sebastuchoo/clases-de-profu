using System;

namespace POO_Unidad1
{
    public class Automovil
    {
        //Atributos
        public string Marca;
        public string Modelo;
        public int Anio;
        public double VelocidadActual;

        public void Acelerar(double inc) { VelocidadActual += inc; }

        public void Frenar(double dec)
        {
            if (VelocidadActual - dec >= 0) VelocidadActual -= dec;
            else VelocidadActual = 0;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Anio}");
            Console.WriteLine($"Velocidad Actual: {VelocidadActual} km/h");
        }
        }

    public class Program
    {
        public static void Main(string[] args)
        {
            Automovil miAuto = new Automovil();
            miAuto.Marca = "Toyota";
            miAuto.Modelo = " PRADO TXL";
            miAuto.Anio = 2026;
            miAuto.VelocidadActual = 25;
            miAuto.MostrarInformacion();
            miAuto.Acelerar(100);
            miAuto.Frenar(5);
            miAuto.MostrarInformacion();

        }
    }
}

