using System;

namespace Project
{
    class Program
    {
        static int var1;
        static int var2;

        static void Main(string[] args)
        {
            Console.WriteLine("테란 연합군의 수는?");
            while (!int.TryParse(Console.ReadLine(), out var1))
            {
                Console.WriteLine("숫자를 올바르게 입력하세요.");
            }

            Console.WriteLine("프로토스 연합군의 수는?");
            while (!int.TryParse(Console.ReadLine(), out var2))
            {
                Console.WriteLine("숫자를 올바르게 입력하세요.");
            }

            Console.WriteLine("전투를 시작합니다!");
            Console.WriteLine($"테란 연합군: {var1}, 프로토스 연합군: {var2}");
            Console.WriteLine($"도합: " + (var1 + var2));

            if (var1 > var2)
            {
                Console.WriteLine("테란 연합군이 승리했습니다.");
            }
            else if (var1 < var2)
            {
                Console.WriteLine("프로토스 연합군이 승리했습니다.");
            }
            else
            {
                Console.WriteLine("무승부입니다.");
            }

             Console.WriteLine("저그는 하지 말란 말이야");

        }
    }
}