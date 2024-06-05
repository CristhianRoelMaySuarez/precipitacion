namespace PrecipitacionesPromedio
{
    public class ListaDePrecipitaciones
    {
        private List<Precipitacion> precipitaciones;

        public ListaDePrecipitaciones()
        {
            precipitaciones = new List<Precipitacion>();
        }

        public void AgregarPrecipitacion(Precipitacion p)
        {
            precipitaciones.Add(p);
        }

        public double CalcularPromedioAnual()
        {
            return precipitaciones.Average(p => p.Promedio);
        }

        public void MostrarResultados()
        {
            double promedioAnual = CalcularPromedioAnual();
            Console.WriteLine($"Precipitación promedio anual: {promedioAnual:F2} mm.\n");
            Console.WriteLine("Mes        Promedio  Variación");

            foreach (var p in precipitaciones)
            {
                double variacion = Math.Abs(p.Promedio - promedioAnual);
                Console.WriteLine($"{p.NombreMes.PadRight(10)} {p.Promedio,7} {variacion,10:F2}");
            }
        }
    }
}

