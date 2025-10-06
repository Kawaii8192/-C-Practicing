using System;

namespace ChokChokChips
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안 촉촉한 초코칩 나라에 사는 안 촉촉한 초코칩은 촉촉한 초코칩이 되기 위해 자신에게 물을 뿌리기로 결심했다.");
            Console.WriteLine("최소 한 번은 물을 뿌린다. 촉촉해졌으면 Y, 촉촉해지지 않으면 N, 촉촉이가 됐으면 wallsu를 입력한다(단, 모든 영문입력은 대문자.).");
            string input;
            
            int i = 0;

            do
            {
                Console.Write("물을 뿌렸다! 촉촉해졌나요? (Y/N/WALLSU): ");
                input = Console.ReadLine().ToUpper();

                if (input == "Y")
                {
                    Console.WriteLine("촉촉해졌습니다!");
                    break;
                }
                else if (input == "N")
                {
                    i++;
                    Console.WriteLine($"촉촉해지지 않았습니다. {i}번 시도했습니다.");
                }
                else if (input == "WALLSU")
                {
                    Console.WriteLine("촉촉이가 되었습니다! 승리를 기념해서 빵빵 터뜨립시다!");
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.");
                }
            } while (input != "yes" && input != "wallsu");
        }
    }
}
