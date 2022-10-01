namespace Dia
{
    public class Program
    {
        public static void Main()
        {
            int dia = 0;
            int mes = 0;
            int anyo = 0;
            double anyoBisiesto = anyo % 4;

            Console.WriteLine("Ingrese el año");
            anyo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el mes");
            mes = Convert.ToInt32(Console.ReadLine());
            if (mes > 12)
            {
                Console.WriteLine(("El número ingresado ha excedido la cantidad de meses que tiene un año, por favor ingresar un número entre el 1-12"));
                mes = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el dia");
            dia = Convert.ToInt32(Console.ReadLine());

            Convert.ToDouble(dia);
            Convert.ToDouble(mes);

            if (anyoBisiesto == 0 && mes == 2 && dia > 29)
            {
                Console.WriteLine(("El numero ingresado excede la cantidad de dias con las que cuenta el mes, por favir inserte un numero valido"));
                dia = Convert.ToInt32(Console.ReadLine());
            }


            if (anyoBisiesto != 0 && mes == 2 && dia > 28)
            {
                Console.WriteLine(("El numero ingresado excede la cantidad de dias con las que cuenta el mes, por favir inserte un numero valido"));
                dia = Convert.ToInt32(Console.ReadLine());
            }

            if (mes == 4 || mes == 6 || mes == 9 || mes == 11 && dia > 30)
            {
                Console.WriteLine(("El numero ingresado excede la cantidad de dias con las que cuenta el mes, por favir inserte un numero valido"));
                dia = Convert.ToInt32(Console.ReadLine());
            }

            if (mes == 1 && mes == 3 || mes == 5 || mes == 7 && mes == 8 || mes == 10 || mes == 12 && dia > 31)
            {
                Console.WriteLine(("El numero ingresado excede la cantidad de dias con las que cuenta el mes, por favir inserte un numero valido"));
                dia = Convert.ToInt32(Console.ReadLine());
            }

            DateTime  numFecha= new DateTime(anyo, mes, dia);
            numFecha = numFecha.AddDays(1);

            Console.WriteLine(numFecha);


        }
    }
}