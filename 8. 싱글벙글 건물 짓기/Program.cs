using System;

namespace BulidingStructures
{
    class Program
    {
        static int Minerals = 200;
        static int SD = 100;
        static int RF = 100;
        static int BR = 150;
        static int EB = 125;
        static int CC = 400;

        // input의 타입을 string으로 지정하는 건데 이거 몰라서 고생 좀 했다~
        static void Build(string input)
        {
            switch (input)
            {
                case "SD":
                    if (Minerals >= SD)
                    {
                        Minerals -= SD;
                        Console.WriteLine("서플라이 디포를 건설했습니다.");
                    }
                    else
                    {
                        Console.WriteLine("미네랄이 부족합니다.");
                    }
                    break;

                case "RF":
                    if (Minerals >= RF)
                    {
                        Minerals -= RF;
                        Console.WriteLine("리파이너리를 건설했습니다.");
                    }
                    else
                    {
                        Console.WriteLine("미네랄이 부족합니다.");
                    }
                    break;

                case "BR":
                    if (Minerals >= BR)
                    {
                        Minerals -= BR;
                        Console.WriteLine("배럭을 건설했습니다.");
                    }
                    else
                    {
                        Console.WriteLine("미네랄이 부족합니다.");
                    }
                    break;

                case "EB":
                    if (Minerals >= EB)
                    {
                        Minerals -= EB;
                        Console.WriteLine("엔지니어링 베이를 건설했습니다.");
                    }
                    else
                    {
                        Console.WriteLine("미네랄이 부족합니다.");
                    }
                    break;

                case "CC":
                    if (Minerals >= CC)
                    {
                        Minerals -= CC;
                        Console.WriteLine("커맨드 센터를 건설했습니다.");
                    }
                    else
                    {
                        Console.WriteLine("미네랄이 부족합니다.");
                    }
                    break;

                case "ZERG":
                    Console.WriteLine("내가 저그 하라고 했어 하지 말라고 했어? 야이 미련한 놈아!! 불구속 수사로 기소하란 말이야!! 야임마! 나 조병옥이야!!!!!!!");
                    break;

                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 시도하세요.");
                    break;
            }
            // 잔여 미네랄 수도 출력 가능하게 했단 말이야
            Console.WriteLine("남은 미네랄 : " + Minerals);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("SCV : SCV, 준비 완료!");
            Console.WriteLine("서플라이 디포 = 100 미네랄");
            Console.WriteLine("리파이너리 = 100 미네랄");
            Console.WriteLine("배럭 = 150 미네랄");
            Console.WriteLine("엔지니어링 베이 = 125 미네랄");
            Console.WriteLine("커맨드 센터 = 400 미네랄");
            Console.WriteLine("저그로 플레이하기 = 0 미네랄이긴 한데 하지 말라고 했지!!!!!!!!!!");
            Console.WriteLine("미네랄 : " + Minerals);

            // 또 지을 수 있게 와일도 넣어주고~
            while (true)
            {
                Console.WriteLine("어떤 건물을 짓겠습니까? (SD, RF, BR, EB, CC, ZERG, 종료: exit)");
                string input = Console.ReadLine().ToUpper();

                if (input == "EXIT")
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                    break;
                }

                Build(input);
                // 레전드 함su.....가 아니라 메서드 드드등장!
            }
        }
    }
}
//근데 저그는 진짜 하지 말란 말이야