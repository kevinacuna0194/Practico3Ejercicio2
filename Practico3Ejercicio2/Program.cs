namespace Practico3Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Marca marca = new Marca("Toyota", "Japón");

                Auto auto = new Auto(marca, "Corolla", 2020, TipoAuto.Nuevo, "ABC123", new DateTime(2023, 1, 1));

                marca.Validar();

                auto.Validar();

                Console.WriteLine(auto.ToString());

                DateTime proximoServicio = auto.CalcularProximoServicio();
                Console.WriteLine($"Próxima Fecha de Servicio: {proximoServicio}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
