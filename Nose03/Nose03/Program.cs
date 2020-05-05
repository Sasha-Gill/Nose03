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

    static float RightTriangleArea (float b, float h)//en float för basen och en för höjden
        {
            float bh = b * h;//multiplicerar basen med hökden och lägger värdet i en ny float
            float area = bh / 2;//Tar det nya värdet dividerat på 2
            return area;//returnerar nytt värde
        }

        static double CircleArea (float o)
        {
            float radie = o / 2;
            Double Pi = 3.14;//använder mig av en double då vi har mer än en decimal
            Double area = radie * radie * Pi;//arean är r*r*pi
            return area;
        }
    static void Main(string[] args)
        {
            //();//kallade på metoden jag nyss skapat

            /*hello32();//kallar på metod 1

            Console.WriteLine(Square(4));//kallar på metod 2
            Console.ReadLine();

            Console.WriteLine(Multi(2.5f, 2f));//kallar på metod 3
            Console.ReadLine();

            Console.WriteLine(RightTriangleArea(2.5f,4f));
            Console.ReadLine();*/

            Console.WriteLine(CircleArea(6));
            Console.ReadLine();
        }
       

}
}
