using System;

namespace Atelier3
{
    class Program
    {
        static void Main(string[] args)
        {    
            Transform.Dico();
            var horaire = new Transform(12, 55);
            
            Console.Write($"{Transform.dico[horaire.hour]}, {horaire.minute}");
        
            
               
        }
    }
}
