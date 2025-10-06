using System; // bool ThisFuckin'CompilerDoNotShutUp = true; 라고 할 뻔 나중에 복잡한 거 할 떄나 쓰잔 말이야(여기는 코드가 간단함)

namespace DonatingTo.Me
{
    class Program
    {
        static int MyMoney = 0;
        static int Donate()
        {
            Console.WriteLine("얼마를 후원하시겠습니까?(원 빼고 입력하세용)");
            int MoneyMoney = int.Parse(Console.ReadLine());
            return MoneyMoney;
        }
        static void Main(string[] args)
        {

            string input = null;

            do
            {
                Console.WriteLine("개발자 후원하기(y/n)");
                input = Console.ReadLine(); 

                if (input == "y")
                {
                    int ShowMeTheMoney = Donate();
                    MyMoney += ShowMeTheMoney;
                    Console.WriteLine($"{ShowMeTheMoney}원을 후원해주셔서 감사합니다!");
                    Console.WriteLine($"현재 후원금: {MyMoney}원");
                }
                else if (input == "n")
                {
                    Console.WriteLine("괜찮습니다! (꼬르륵 꼬르륵)");
                    break;
                }
                else
                {
                    Console.WriteLine("(y/n) 중에서 입력하세요."); 
                }

            } while (input != "n");
        }
    }
}