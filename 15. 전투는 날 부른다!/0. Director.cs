using System;
using CHARACTER;

namespace DIRECTOR
{
    public static class Director
    {
        public static void BattleGround()
        {
            Console.WriteLine("사라 케리건과 피닉스가 조우했다!");
            Console.WriteLine("전투 시작!!!(전에 상태창부터 표시할 거임)");

            Kerrigan_Indicator();
            Fenix_Indicator();
            
            Console.WriteLine("플레이어가 먼저 공격합니다!(피닉스=플레이어)");

            while (!Kerrigan.Death == true && !Fenix.Death == true)
            {
                
            }
        }
        public static void Calculate_Kerrigan_DAMAGE()
        {
            Kerrigan.HP -= Kerrigan.DAMAGE;

            if (Kerrigan.HP <= 0)
            {
                Kerrigan.HP = 0;
                Kerrigan.Death = true;
            }
        }

        public static void Calculate_Fenix_DAMAGE()
        {
            Fenix.DamageConvertor();

            if (Fenix.HP <= 0)
            {
                Fenix.HP = 0;
                Fenix.Death = true;
            }

        }
        public static void Determination_Result()
        {
            if (Kerrigan.Death == true)
            {
                Console.WriteLine("케리건은 마참내 오렌지병으로 인해 쓰러졌다.");
            }

            else
            {
                if (Fenix.Death == true)
                {
                    Console.WriteLine("피닉스는 마참내 오렌지병으로 인해 쓰러졌다.");
                }

                else
                {
                    Console.WriteLine("게임 진행 중...");
                }
            }
        }
        public static void Kerrigan_Indicator()
        {
            Console.WriteLine("[케리건 상태]");
            Console.WriteLine($"체력: {Kerrigan.HP}");
            Console.WriteLine($"실드: 있겠냐?");
            Console.WriteLine($"에너지: {Kerrigan.ENERGY}");

            if (Kerrigan.SkillUsed1 == false)
            {
                Console.WriteLine("바이오닉 펄스: 사용 가능");
            }

            else if (Kerrigan.SkillUsed1 == true)
            {
                Console.WriteLine("바이오닉 펄스: 사용 불가능");
            }

            if (Kerrigan.SkillUsed2 == false)
            {
                Console.WriteLine("산성액 발사: 사용 가능");
            }

            else if (Kerrigan.SkillUsed2 == true)
            {
                Console.WriteLine("산성액 발사: 사용 불가능");
            }
        }

        public static void Fenix_Indicator()
        {
            Console.WriteLine("[피닉스 상태]");
            Console.WriteLine($"체력: {Fenix.HP}");
            Console.WriteLine($"실드: {Fenix.SHIELD}");
            Console.WriteLine($"에너지: {Fenix.ENERGY}");

            if (Fenix.SkillUsed == false)
            {
                Console.WriteLine("사이오닉 폭풍: 사용 가능");
            }

            else if (Fenix.SkillUsed == true)
            {
                Console.WriteLine("사이오닉 폭풍: 사용 불가능");
            }
        }
    }
}