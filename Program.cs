/*using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("숫자를 입력해주세요");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;

            for (int i = 2; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime == false || num == 1)
            {
                Console.WriteLine("소수가 아닙니다");
            }
            else
            {
                Console.WriteLine("소수입니다");
            }


            //3의 배수 출력
            int num1 = 100;

            for(int j = 0; j<num1; j++)
            {
                if(j%3 !=0)
                {
                    continue;
                }
                Console.WriteLine( "3의 배수는{j} ");
            }
        }
    }
}
*/