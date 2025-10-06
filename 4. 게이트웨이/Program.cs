using System;

namespace Circle
{
    class Program
    {
        static int Zealot;

        static void Main(string[] args)
        {
            Console.WriteLine("여기는 게이트웨이입니다. 질럿을 몇 마리 생산하시겠습니까?");
            Zealot = int.Parse(Console.ReadLine());
            Console.WriteLine($"질럿 {Zealot}마리 생산 중.....");

            for (int i = 0; i < Zealot; i++)
            {
                Console.WriteLine("My life for Aiur!");
            }
        }
    }
}