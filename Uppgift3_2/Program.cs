using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel.Design;

namespace uppgift3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet, skriva j för ja eller n för nej");
            string svar=Console.ReadLine().ToUpper();
            Console.WriteLine("Hur gammal är du");
            int gammal=int.Parse(Console.ReadLine());
            if(svar == "J" &&  gammal < 22) 
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }
            Console.ReadKey();
        }
    }
}
