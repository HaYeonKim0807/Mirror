using System;

namespace 답정너_거울아_거울아
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            do
            {
                Console.WriteLine("하연이는 예쁜가요? (y/n) : ");
                answer = Console.ReadLine();

            } while ( answer != "y" );

            Console.WriteLine("정답입니다 !");

        }
    }
}




//
