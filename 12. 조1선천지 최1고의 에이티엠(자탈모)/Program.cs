using System;

namespace ChosunCheonJiGOAT.ATM
{
    class Program
    {
        static int MoneyMoney = 0;
        static int ShowMeTheMoney = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("조1선천지 최1고의 에이티엠(자탈모)에 온 것을 환영 안하고 빵빵 터뜨릴 준비나 해라!");

            while (true)
            {
                Console.WriteLine("내 에이티엠(자탈모)에 돈을 넣겠나? (y/n)");
                string input = Console.ReadLine();

                if (input == "y")
                {
                    Console.WriteLine("허허.. (츄릅)얼마를 넣겠나? (숫자만 입력해라, 안 그러면 빵빵 터뜨려버릴거야, 으하하하!!!)");
                    ShowMeTheMoney = int.Parse(Console.ReadLine());
                    MoneyMoney += ShowMeTheMoney;
                    Console.WriteLine($"삐비빅... 현재 잔액은 {MoneyMoney}원입니다. 항상 감사합니다.");
                    Console.WriteLine("으하하하!!!!!!!!!!! 돈이 들어오니까 기부니가 좋구만... 어? 으어억!!!! (고혈압으로 사망)");
                    Console.WriteLine($"[축하합니다! 비록 {MoneyMoney}원을 잃었지만 당신은 승리했습니다!]");
                    break;
                }

                else if (input == "n")
                {
                    Console.WriteLine("아... 안타까운 얘기구만, 어서 가보게나.");
                    continue;
                }
                else
                {
                    Console.WriteLine("야임마!! 내가 y나 n을 입력하라고 했잖아!! 이 미련한 놈아!! 다시 입력하라고!! (y/n)");
                    continue;
                }
            }
        }
    }
}