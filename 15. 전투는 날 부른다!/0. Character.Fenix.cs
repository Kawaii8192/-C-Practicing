namespace CHARACTER
{
    public static class Fenix
    {
        public static int HP = 250;
        public static int SHIELD = 250;
        public static int ENERGY = 600;
        public static int DAMAGE;
        public static bool SkillUsed = false;
        public static bool Death = false;

        public static void RESET()
        {
            Fenix.HP = 250;
            Fenix.SHIELD = 250;
            Fenix.ENERGY = 600;
            Fenix.SkillUsed = false;
            Fenix.Death = false;
        }
        public static void PsionicBladeAttack()
        {
            Console.WriteLine("피닉스 공격! [사이오닉 검](16/0)");
            Kerrigan.DAMAGE = 16;
        }

        public static void WarpBladeAttack()
        {
            if (Fenix.ENERGY >= 30)
            {
                Console.WriteLine("피닉스 공격! [차원 변형 검](40/30)");
                Kerrigan.DAMAGE = 40;
                Fenix.ENERGY -= 30;
            }

            else
            {
                Console.WriteLine("에너지가 부족합니다.");
                Kerrigan.DAMAGE = 0;
            }
        }

        public static void PsionicStormAttack()
        {
            if (Fenix.ENERGY >= 100)
            {
                if (Fenix.SkillUsed == false)
                {
                    Console.WriteLine("피닉스 공격! [사이오닉 폭풍](200/100)");
                    Kerrigan.DAMAGE = 200;
                    Fenix.ENERGY -= 100;
                    SkillUsed = true;
                }

                else
                {
                    Console.WriteLine("이미 사용된 기술입니다.");
                    Kerrigan.DAMAGE = 0;
                }
            }

            else
            {
                Console.WriteLine("에너지가 부족합니다.");
                Kerrigan.DAMAGE = 0;
            }
        }

        public static void FeedBackAttack()
        {
            if (Fenix.SHIELD > 0)
            {
                Console.WriteLine("피닉스 공격! [환류](피닉스의 실드값/피닉스의 모든 실드 소모)");
                Kerrigan.DAMAGE = Fenix.SHIELD;
                Fenix.SHIELD = 0;
            }

            else
            {
                Console.WriteLine("실드가 없습니다.");
                Kerrigan.DAMAGE = 0;
            }
        }

        public static void DamageConvertor()
        {
            if (Fenix.SHIELD > 0)
            {
                Fenix.SHIELD -= Fenix.DAMAGE;
            }

            else
            {
                Fenix.HP -= Fenix.DAMAGE;
            }
        }
    }
}