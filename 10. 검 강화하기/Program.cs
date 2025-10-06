using System;

namespace StrengtheningTheSword
{
    class Program
    {
        static int Level = 1; // 첨 시작하니까 당연히 1레벨이지~
        static void Main(string[] args)
        {
            Console.WriteLine("당신의 검을 강화하세요!");
            Console.WriteLine("강화당 실패 확률은 무려 20%!");
            Console.WriteLine("강화에 성공하면 그냥 레벨이 오르는 거고 실패하면 검이 깨집니다.");

            while (true)
            {
                Console.WriteLine($"현재 검의 레벨은 {Level}레벨입니다.");
                Console.WriteLine("강화하시겠습니까? (y/n)");

                string input = Console.ReadLine();
                if (input?.ToLower() == "y")
                {
                    bool isSuccess = Upgrade();
                    if (isSuccess)
                    {
                        Console.WriteLine("띠로링!! 강화 성공!!!!!");
                        Level = Level + 1;
                    }
                    else
                    {
                        Console.WriteLine("강화에 실패하여 검이 깨졌습니다!!");
                        Console.WriteLine($"1레벨이 되었습니다!");
                        break;
                    }
                }
                else if (input?.ToLower() == "n")
                {
                    Console.WriteLine("강화를 끝냅니다.");
                    Console.WriteLine($"최종 검 레벨: {Level}레벨");
                    break;
                }
                else
                {
                    Console.WriteLine("질문에 답을 하지 않아서 화가 난 개발자가 당신의 검을 뿌셔버렸습니다!!");
                    Console.WriteLine($"최종 검 레벨: {Level}레벨");
                    break;
                }
            }
        }

        // 실패 확률 12%임 이거 적어보여도 나중 가면 실패한다(20%로 했는데 실패확률이 너무 높아서 12%로 바꿈)
        static bool Upgrade()
        {
            Random rand = new Random();
            int chance = rand.Next(100); // 0~99(100가지 경우의 수)
            return chance >= 12; // 0~11: 실패, 12~99: 성공(실패 확률 12%/성공 확률 88% 구현)
        }
    }
}