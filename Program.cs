using System;

namespace LinMat4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj operację w formacie infix:");
            string input = Console.ReadLine();
            ParserONP tool = new ParserONP();
            string output = tool.ParseExample(input);
            
            Console.WriteLine(input);
            Console.WriteLine(output);
            Console.ReadKey();
        }

       
    }
}



/*Oper Prio
(  0
+ 1
-  1
* 2
/ 2
^ 3
*/
