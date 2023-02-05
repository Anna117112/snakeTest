// See https://aka.ms/new-console-template for more information

namespace Snake
{
    class Program
    {


        static void Main(string[] args)
        {

            int x1 = 1;
            int y1 = 3;
            String sym1 = "*";

            Draw(x1, y1, sym1);



            int x2 = 4;
            int y2 = 5;
            String sym2 = "#";

            Console.SetCursorPosition(x2, y2);
            Console.Write(sym2);

            Console.ReadLine();
        }


        static void Draw(int x, int y, String sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}





