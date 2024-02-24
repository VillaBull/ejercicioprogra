using System;

namespace EjerciciosProgra
{
    class Program
    {

    static void main(string[args])
    {
        //ejercicio 1.1
        Console.WriteLine("Los primeros 5 numeros pares son: ");
        for (int i = 2; i<=10; i+=2)
        {
            Console.WriteLine(i);
        }

        
       
        //ejercicio 1.2

        int suma = 0;
        
        for (int i = 1; i <= 10; i++)
        {
            suma += i;
        }
        Console.WriteLine("La suma de los primeros 10 numeros naturales es: "+ suma);
        // ejercicio 3
        int suma1 = 0;
        int num;
        
        Console.WriteLine("Ingrese numeros eteros positivos (si se ingresa un numero negativo el programa se detiene): ");
        do
        {
            Console.Write("Numero: ");
            num = int.Parse(Console.ReadLine());

            if (num>=0)
            {
                suma1 += num;
            }
        } while (num>=0);
        Console.WriteLine("La suma es: "+ suma1);


        Console.readkey();
    }


    }//end
}
