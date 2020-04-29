using System;

namespace Nose03
{
    class Program
    {
    static void hello32()//Metoden döps till Hello32 och är en static void. Static för att den är i Main och void för att den inte returnerar nått
        {
            for (int i = 0; i < 32; i++)//for loop som kör som 32 ggr
            {
                Console.WriteLine("Hello "+i);//lade till i för att hålla räkning på hur många gånger.
                Console.ReadLine();
            }
        }
    static int Square(int x)//skapar en int metod med parametern int. Värdet är X då man själv kan välja värdet.
        {
            return x * x;//returnerar värdet gånger sig själv.
        }

        static void Main(string[] args)
        {
            hello32();//kallade på metoden jag nyss skapat

            Square(4);//kallar på denna metod.  
        }
       

}
}
