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
            int Result = x * x;
            return Result;//returnerar värdet gånger sig själv.
        }

    static float Multi(float c, float z)//en metod med 2 floats
        {
            //c = 2.5f;
            //z = 1f;
            float Result = c * z;
            return Result;//returnerar c multiplicerat med z.
        }
    static void Main(string[] args)
        {
            //();//kallade på metoden jag nyss skapat

           // int i = Square(4);//kallar på denna metod.  
            //float e = Multi(2.5f, 1f);

            Console.WriteLine(Square(4));
            Console.ReadLine();

            Console.WriteLine(Multi(2.5f, 2f));
            Console.ReadLine();
        }
       

}
}
