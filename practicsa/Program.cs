namespace programa
{
    public class program
    {
        public static void Main()
        {
            int dias = 0;
            int mes = 0;
            int anyo = 0;

            double bisiesto = anyo % 4;

            Console.WriteLine("ingrese el año");
            anyo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el mes");
            mes = Convert.ToInt32(Console.ReadLine());

            if (mes == 2)
            {
                Console.WriteLine("ingrese el dia");
                dias = Convert.ToInt32(Console.ReadLine());
                if (dias > 29 && bisiesto == 0)
                {
                    Console.WriteLine("Error, ingrese otro numero");
                }
                else
                {
                    if (dias > 28)
                    {
                        Console.WriteLine("Error, ingrese otro numero");
                    }
                }
            }

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                Console.WriteLine("ingrese el dia");
                dias = Convert.ToInt32(Console.ReadLine());
                if (dias > 31)
                {
                    Console.WriteLine("Error, ingrese otro numero");
                }
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                Console.WriteLine("ingrese el dia");
                dias = Convert.ToInt32(Console.ReadLine());
                if (dias > 30)
                {
                    Console.WriteLine("error, ingrese otro numero");
                }
            }

            DateTime mifecha = new DateTime(anyo, mes, dias);
            mifecha = mifecha.AddDays(1);

            Console.WriteLine(mifecha);
        }
    }
}