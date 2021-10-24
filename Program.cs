using System;

namespace PruebaDesarrolloNet
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //PuntoUno();
            //PuntoDos();
            //PuntoTrees();
        }

        public static void PuntoUno()
        {
            int valorMax = 0, a = 0, b = 0;
            int[] arrayNumber = new int[5];
            
            Random aleatorio = new Random();

            for (int i = 0; i < 5; i++)
            {
                arrayNumber[i] = aleatorio.Next(1, 100);
            }
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                a = arrayNumber[i];

                if (a > valorMax)
                {
                    valorMax = a;
                }

            }
            Console.WriteLine("Punto 1. ");
            Console.WriteLine( valorMax );
        }

        public static void PuntoDos()
        {
            int[] myArray = new int[10];
            string text1 = "1: ", text2 = "2: ", text3 = "3: ", text4 = "4: ", text5 = "5: ";
            int vart, i = 0;
            Console.WriteLine("Punto 2. ");
            while (i < 10)
            {
                if (myArray[i] == 0)
                {
                    Console.WriteLine("Introduzca un valor de 1 a 5");
                    vart = Int32.Parse( Console.ReadLine() );
                    if (vart > 0 && vart <=5)
                    {
                        myArray[i] = vart;
                        if (vart == 1)
                        {
                            text1 += "*";
                        }else if (vart == 2)
                        {
                            text2 += "*";
                        }
                        else if (vart == 3)
                        {
                            text3 += "*";
                        }
                        else if (vart == 4)
                        {
                            text4 += "*";
                        }
                        else
                        {
                            text5 += "*";
                        }
                        i += 1;
                        Console.Write(text1 + "\n" + text2 + "\n" + text3 + "\n" + text4 + "\n" + text5 + "\n");
                    }
                }
            }
            Console.Write("Los valores uzados son: " + String.Join(", ", myArray));
        }
        public static void PuntoTrees()
        {
            int[] addArray = { 1, 8, 6, 7, 2, 5 };
            int arrayLength = addArray.Length;
            string text="";
           

            for (int i=0; i < arrayLength; i++)
            {
            int a = 0;

                while( a < arrayLength)
                {
                    if (a > i )
                    {
                        a += 1;
                    }else
                    {
                        a = i + 1;
                    }
                    if (a < arrayLength)
                    {
                        if ((addArray[i] + addArray[a]) == 10)
                        {
                            text = addArray[i] + " " + addArray[a];
                        }
                    }
                }
            }
            Console.WriteLine("los valores son: " + text);
        }
    }
}
