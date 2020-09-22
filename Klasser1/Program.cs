using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bil minBil = new Bil("Svart", "5", "Seat", "AAA 111", 180);//Här skapas en INSTANS av klassen Bil! En SPECIFIK bil. Min Seat i detta fall

            //Bil larsBil = new Bil();
            
            Console.WriteLine(minBil.Drive());


            //Ett annat sätt att instatsiera genom att tilldela världen direkt 
            Bil minAndraBil = new Bil("Silver Metallic", "5", "Hyundai", "BBB 222", 80);

            Console.WriteLine();//Lite extra space bara

            Console.WriteLine($"Min {minAndraBil.GetModel()} är inte lika snabb som min {minBil.GetModel()}. Den går bara i {minAndraBil.GetSpeed()}, " +
                $"men jag kan iaf ropa på Drive! {minAndraBil.Drive()}");

            //Bokens Random-exempel
            //Random rand = new Random();
            //int randomNumber = rand.Next();

            //Console.WriteLine($"Här kommer ett slumptal {randomNumber}");

            Console.ReadLine();
        }
    }
}
