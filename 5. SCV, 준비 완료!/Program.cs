using System;

namespace MiracleOfSCV
{
    class Program
    {

        static int SCV;
        static int mineral = 500;
        static int CostPerSCV = 50;

        static void Main(string[] args)
        {
            Console.WriteLine($"SCV 몇 대를 생산하시겠습니까? (SCV 1대당 50 미네랄 소모, 현재 미네랄 잔량은 {mineral}.)");
            SCV = int.Parse(Console.ReadLine());

            for (int i = 0; i < SCV; i++)
            {
                if (mineral >= CostPerSCV)
                {
                    mineral -= CostPerSCV;
                    Console.WriteLine($"SCV, 준비 완료! (현재 미네랄 잔량: {mineral})");
                }
                else
                {
                    Console.WriteLine("Not enough minerals... Mine more minerals...");
                    break;
                }

            }
        }
    }
}
