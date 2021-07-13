using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValentinaCiriglianoEjercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadDeTemperaturas;
            double temperaturaIngresada, temperaturaConvertida;
            double mayorTemperatura = -70, promedioDeTemperatura = 0;

            Console.Write("Ingrese el valor de la cantidad de veces que va a convertir la temperatura:  ");
            cantidadDeTemperaturas = Convert.ToInt32(Console.ReadLine());

            for (int contador = 1; contador < cantidadDeTemperaturas + 1; contador++)
            {
                do
                {
                    Console.Write($"Ingrese el {contador}° valor en celsius: ");
                    temperaturaIngresada = Convert.ToDouble(Console.ReadLine());
                    if (temperaturaIngresada > 60 || temperaturaIngresada < -70)
                    {
                        Console.WriteLine("La temperatura no debe ser inferior a -70°c ni superior a 60°c ");
                        Console.WriteLine("Intente nuevamente");
                        Console.Clear();
                    }

                } while (temperaturaIngresada > 60 || temperaturaIngresada < -70);

                temperaturaConvertida = 1.8 * temperaturaIngresada + 32;
                Console.WriteLine($"{temperaturaIngresada}°C - {temperaturaConvertida}°F");
                promedioDeTemperatura = promedioDeTemperatura + temperaturaIngresada;

                if (temperaturaIngresada > mayorTemperatura)
                {
                    mayorTemperatura = temperaturaIngresada;
                }
                Console.WriteLine("");
            }

            promedioDeTemperatura = promedioDeTemperatura / cantidadDeTemperaturas;
            Console.WriteLine("");
            Console.WriteLine("RESULTADOS");
            Console.WriteLine($"Fahrenheit = 1.8 * celsius + 32");
            Console.WriteLine($"La mayor temperatura registrada es de: {mayorTemperatura}");
            Console.WriteLine($"El promedio de temperaturas es de: {promedioDeTemperatura}");
            Console.ReadLine();
        }
    }
}
