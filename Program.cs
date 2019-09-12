using System;

namespace opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("#############################################################################################");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-----Welkom bij - STEEN PAPIER SCHAAR-----=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-----Klaar om het geweldige avondtuur te beginnen?-----=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("#############################################################################################");
        
        }
        public int RandomNumber(int min, int max)  
{  
    Random random = new Random();  
    return random.Next(min, max);  
}  
    }
}
