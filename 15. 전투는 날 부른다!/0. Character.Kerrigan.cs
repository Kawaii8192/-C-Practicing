namespace CHARACTER
{
    public static class Kerrigan
    {
        public static int HP = 600;
        public static int SHIELD = 0;
        public static int ENERGY = 750;
        public static int DAMAGE;
        public static bool SkillUsed1 = false;
        public static bool SkillUsed2 = false;
        public static bool Death = false;
        public static int Choice1;
        public static int Choice2;
        
        public static void RESET()
        {
            Kerrigan.HP = 600;
            Kerrigan.SHIELD = 0;
            Kerrigan.ENERGY = 750;
            Kerrigan.SkillUsed1 = false;
            Kerrigan.SkillUsed2 = false;
            Kerrigan.Death = false;
        }
        public static void SpikedTentacleAttack()
        {
            Console.WriteLine("케리건 공격! [가시 촉수](25/0)");
            Fenix.DAMAGE = 25;
        }

        public static void HellThornAttack()
        {
            if (Kerrigan.ENERGY >= 50)
            {
                Console.WriteLine("케리건 공격! [가시 지옥](60/50)");
                Fenix.DAMAGE = 60;
                Kerrigan.ENERGY -= 50;
            }

            else
            {
                Console.WriteLine("에너지가 부족합니다.");
                Fenix.DAMAGE = 0;
            }
        }

        public static void BionicPulseAttack()
        {
            if (Kerrigan.ENERGY >= 200)
            {
                if (Kerrigan.SkillUsed1 == false)
                {
                    Console.WriteLine("케리건 공격! [바이오닉 펄스](실드 무력화/200)");
                    Fenix.SHIELD = 0;
                    Kerrigan.ENERGY -= 200;
                    SkillUsed1 = true;
                }

                else
                {
                    Console.WriteLine("이미 사용된 기술입니다.");
                    Fenix.DAMAGE = 0;
                }
            }

            else
            {
                Console.WriteLine("에너지가 부족합니다.");
                Fenix.DAMAGE = 0;
            }
        }

        public static void AcidSprayAttack()
        {
            if (Kerrigan.ENERGY >= 100)
            {
                if (Kerrigan.SkillUsed2 == false)
                {
                    Console.WriteLine("케리건 공격! [산성액 발사](150/80)");
                    Fenix.DAMAGE = 150;
                    Kerrigan.ENERGY -= 80;
                    SkillUsed2 = true;
                }

                else
                {
                    Console.WriteLine("이미 사용된 기술입니다.");
                    Fenix.DAMAGE = 0;
                }
            }

            else
            {
                Console.WriteLine("에너지가 부족합니다.");
                Fenix.DAMAGE = 0;
            }
        }

        public static void RandomChoosing()
        {
            if (Kerrigan.ENERGY > 200)
            {
                Random A = new Random();
                Choice1 = A.Next(0, 4);

                if (Choice1 == 0)
                {
                    SpikedTentacleAttack();
                }

                else if (Choice1 == 1)
                {
                    HellThornAttack();
                }

                else if (Choice1 == 2)
                {
                    BionicPulseAttack();
                }

                else if (Choice1 == 3)
                {
                    AcidSprayAttack();
                }
            }

            else if (Kerrigan.ENERGY < 50)
            {
                SpikedTentacleAttack();
            }

            else
            {
                Random B = new Random();
                Choice2 = B.Next(0, 3);

                if (Choice2 == 0)
                {
                    SpikedTentacleAttack();
                }

                else if (Choice2 == 1)
                {
                    HellThornAttack();
                }

                else if (Choice2 == 2)
                {
                    AcidSprayAttack();
                }
            }
        }
    }
}