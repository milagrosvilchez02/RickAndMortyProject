using System;

namespace RickAndMortyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero del 1 al 670");
            string userInput = Console.ReadLine();
            InfoProcessor infoProcessor = new InfoProcessor();
            bool result = infoProcessor.LoadCharacter(userInput).Result;
            Console.WriteLine("Mi programa termino sin errores");
        }
    }
}
