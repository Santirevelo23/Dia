namespace Dias
{
    public class Program
    {
        public static void Main()
        {
            int dia = 0;
            int mes = 0;
            int anyo = 0;

            Console.WriteLine("Ingrese el año");
            anyo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el mes");
            mes = Convert.ToInt32(Console.ReadLine());
            if ( mes > 12)
            {
                Console.WriteLine(("El número ingresado ha excedido la cantidad de meses que tiene un año, por favor ingresar un número entre el 1-12"));
                mes = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el dia");
    }
}
