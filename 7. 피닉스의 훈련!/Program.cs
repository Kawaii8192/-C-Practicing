using System;

namespace Fenix.s.Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainingCount = 0;
            int hp = 200;
            int Plasmashield = 200;
            int attack = 20;

            Random rand = new Random();

            Console.WriteLine("피닉스는 자신의 신체 능력을 극대화하기 위해 훈련을 했다.");
            Console.WriteLine($"초기 능력치 → 체력: {hp}, 플라스마 실드: {Plasmashield}, 지상 공격력: {attack}");

            while (true)
            {
                string emphasis = new string(' ', 0);
                for (int i = 0; i < trainingCount; i++)
                {
                    emphasis += "정말";
                }

                Console.WriteLine($"\n피닉스는 {emphasis} 강해졌는가? (y/n)");
                var input = Console.ReadLine()?.Trim().ToLower();

                if (input == "y")
                {
                    Console.WriteLine("\n훈련을 끝낸다.");
                    Console.WriteLine($"총 훈련 횟수: {trainingCount}");
                    Console.WriteLine($"최종 능력치 → 체력: {hp}, 플라스마 실드: {Plasmashield}, 지상 공격력: {attack}");
                    break;
                }
                else if (input == "n")
                {
                    trainingCount++;

                    int hpGain = rand.Next(0, 21);
                    int shieldGain = rand.Next(0, 21);
                    int attackGain = rand.Next(0, 6);

                    hp += hpGain;
                    Plasmashield += shieldGain;
                    attack += attackGain;

                    Console.WriteLine($"훈련을 더한다!!!!. 현재 훈련 횟수: {trainingCount}");
                    Console.WriteLine($"이번 훈련 결과 → 체력 +{hpGain}, 플라스마 실드 +{shieldGain}, 지상 공격력 +{attackGain}");
                    Console.WriteLine($"현재 능력치 → 체력: {hp}, 플라스마 실드: {Plasmashield}, 지상 공격력: {attack}");
                }
                else
                {
                    Console.WriteLine("올바르지 않은 프로토콜. 'y' 또는 'n'을 입력해라. 또 이러면 너도 드라군으로 만들어 주겠다!");
                }
            }
        }
    }
}
// 근데 저그는 진짜 제발 하지 말란 말이야.