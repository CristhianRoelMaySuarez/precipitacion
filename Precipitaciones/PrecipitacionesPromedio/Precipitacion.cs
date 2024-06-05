namespace PrecipitacionesPromedio
{
    public class Precipitacion
    {
        public int Mes { get; set; }
        public string NombreMes { get; set; }
        public double Promedio { get; set; }


        public Precipitacion(int mes, string nombreMes, double promedio)
        {
            Mes = mes;
            NombreMes = nombreMes;
            Promedio = promedio;
        }
    }
}
