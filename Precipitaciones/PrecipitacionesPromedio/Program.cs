using PrecipitacionesPromedio;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Demostración de las precipitaciones de cada mes. \n");

        string[] nombresMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        ListaDePrecipitaciones listaDePrecipitaciones = new ListaDePrecipitaciones();

        for (int i = 0; i < 12; i++)
        {
            double promedio = 0;
            bool esValido = false;
            while (!esValido)
            {
                Console.Write($"Ingrese la precipitación promedio para {nombresMeses[i]}: ");
                string input = Console.ReadLine();
                esValido = double.TryParse(input, out promedio);
                if (!esValido)
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }
            }

            listaDePrecipitaciones.AgregarPrecipitacion(new Precipitacion(i + 1, nombresMeses[i], promedio));
        }

        listaDePrecipitaciones.MostrarResultados();
    }
}
