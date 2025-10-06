using System;

namespace SaraKerrigan
{
    class Program
    {
        static void Greet()
        {
            Console.WriteLine("사라 케리건에게 인사를 한다!");
            Console.WriteLine("인사를 했더니 찔려죽었습니다.");
            Console.WriteLine("[사망]");
            Environment.Exit(0);
        }

        static void RunAway()
        {
            Console.WriteLine("사라 케리건에게서 도망쳤습니다! 당신은 과거 학교에서 100m 달리기를 5초에 완주한 경1력이 있습니다.");
            Console.WriteLine("그러나 케리건의 달리기는 시속 1972km입니다!!");
            Console.WriteLine("도망치다 찔려죽었습니다.");
            Console.WriteLine("[사망]");
            Environment.Exit(0);
        }

        static void Revolver()
        {
            Console.WriteLine("리볼버를 꺼내 사라 케리건에게 발사합니다!");
            Console.WriteLine("근데 맞아도 안 아프죠? 망했죠? 총알이 한 발밖에 없어서 아무고토 못하죠?");
            Console.WriteLine("사라 케리건이 당신을 찔러 죽였습니다.");
            Console.WriteLine("[사망]");
            Environment.Exit(0);
        }

        static void Fist()
        {
            Console.WriteLine("당신의 주먹이 사라 케리건의 급소를 가격합니다!");
            Console.WriteLine("하지만 주먹따위는 케리건에게는 아무런 소용이 읎단 말이야.");
            Console.WriteLine("사라 케리건이 당신을 찔러 죽였습니다.");
            Console.WriteLine("[사망]");
            Environment.Exit(0);
        }

        static void PsionicBlade()
        {
            Console.WriteLine("My life for Aiur!");
            Console.WriteLine("진짜로 당신의 목숨이 아이어에 바쳐졌습니다!");
            Console.WriteLine("[사망]");
            Environment.Exit(0);
        }

        static void PsionicStorm()
        {
            Console.WriteLine("나는 정의를 위해 태어난 하이 템플러다.... 카사르 디 템플라리!!");
            Console.WriteLine("사라 케리건이 중2병에 걸린 당신을 그냥 무시하고 사라집니다.");
            Console.WriteLine("[생존]");
            Environment.Exit(0);
        }

        static void Apologize()
        {
            Console.WriteLine("사라 케리건에게 사과를 했습니다!");
            Console.WriteLine("잘못이 없는 데도 사과를 했더니 사라 케리건이 당황합니다!!");
            Console.WriteLine("[생존]");
            Environment.Exit(0);
        }

        static void Confess()
        {
            Console.WriteLine("사라 케리건에게 자신이 짐 레이너라고 고백을 했습니다!");
            Console.WriteLine("짐 레이너... 일리가 없쥬? 사라 케리건은 당신을 찔러 죽였습니다.");
            Console.WriteLine("[사망]");
            Environment.Exit(0);
        }

        static void Nuclear()
        {
            Console.WriteLine("Nuclear launch detected...");
            Console.WriteLine("핵을 맞고 사라 케리건은 뒤졌으나");
            Console.WriteLine("당신도 같이 뒤졌습니다.");
            Console.WriteLine("[사망]");
            Environment.Exit(0);
        }

        static void ZergPlay()
        {
            Console.WriteLine("저그로 플레이하기!!");
            Console.WriteLine("내가 저그 하지 말랬지!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("개발자가 당신을 찔러 죽였습니다.");
            Console.WriteLine("[사망]");
            Environment.Exit(0);
        }

        static void Bug()
        {
            Console.WriteLine("사라 케리건:난 버그(저그)를 만드는 데 뛰어난 재능이 있지.");
            Console.WriteLine("당신이 버그(BUG)로 인해 IDE와 함께 폭사했습니다.");
            Console.WriteLine("[사망]");
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("당신은 평범(?)하게 차 행성을 산책하시던 도중 사라 케리건과 조우했습니다.");
            Console.WriteLine("이 때 당신은 어떤 행동을 취하시겠습니까?");
            Console.WriteLine("1. 인사를 한다.");
            Console.WriteLine("2. 도망친다.");
            Console.WriteLine("3. 리볼버");
            Console.WriteLine("4. 주먹");
            Console.WriteLine("5. 사이오닉 검");
            Console.WriteLine("6. 사이오닉 스톰");
            Console.WriteLine("7. 사과한다.");
            Console.WriteLine("8. 고백한다.");
            Console.WriteLine("9. Nuclear launch detected...");
            Console.WriteLine("10. 저그로 플레이하기!!");
            Console.WriteLine("11. 버그");

            Console.Write("선택지를 입력하세요 (1~11): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Greet();
                    break;
                case "2":
                    RunAway();
                    break;
                case "3":
                    Revolver();
                    break;
                case "4":
                    Fist();
                    break;
                case "5":
                    PsionicBlade();
                    break;
                case "6":
                    PsionicStorm();
                    break;
                case "7":
                    Apologize();
                    break;
                case "8":
                    Confess();
                    break;
                case "9":
                    Nuclear();
                    break;
                case "10":
                    ZergPlay();
                    break;
                case "11":
                    Bug();
                    break;    
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }
}
//저그는 하지 말라고 했단 말이야