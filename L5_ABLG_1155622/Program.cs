using System;

namespace L12_ABLG_1155622
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] Nombre = new string[5];
            int[] Fecha = new int[5];
            int[] Edad = new int[5];
            string[] Puesto = new string[5];
            string[] NP = new string[5];
            double[] sueldo = new double[5];
            string[] PUESTO = new string[5];
            string opcion;

            Console.WriteLine("Escribe 1, 2 o 3");
            opcion= Console.ReadLine ();

            switch (opcion)
            {
                case "1":
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Ingresa el nombre: ");
                        Nombre [i] = Console.ReadLine();

                        Console.WriteLine("Ingresa el año de nacimiento: ");
                        Fecha[i] = int.Parse (Console.ReadLine());

                        Console.WriteLine("La edad del empleado es: " + (Edad[i] = 2022 - Fecha[i]));
                    }
                    break; 
                    case "2":
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Ingresa el nombre de un empleado");
                            NP[i] = Console.ReadLine();

                            Console.WriteLine("Ingresa el puesto de el o la empleada");
                            PUESTO[i] = Console.ReadLine();


                            Console.WriteLine("Ingresa el sueldo de esta persona:");
                            sueldo[i] = int.Parse(Console.ReadLine());

                            Console.WriteLine("El sueldo de " + Nombre[i] + "quien tiene el puesto de " + PUESTO[i] + "es de" + sueldo[i]);
                        }
                        break;
                    }

                        case "3":
                    {
                        Environment.Exit (0);
                    }
                    break; 

                    default:
                    {
                        Console.WriteLine("Solo se aceptan los nùmero 1,2 o 3"); 
                    }
                    break;
                    }
                    
                         
            }

        }
            
    }

