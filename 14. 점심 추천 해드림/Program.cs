using System;

namespace SetLaunchMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("무료로 점심 추천 해드립니다.(Y,y/N,n)?");
            string input = Console.ReadLine();

            if (input == "y" || input == "Y")
            {
                Console.WriteLine("종류를 고르십쇼.)");
                Console.WriteLine("1.한식 2.중식 3.일식 4.양식 5.기타");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string[] korean = { "김치찌개", "된장찌개", "비빔밥", "불고기", "제육볶음" };
                        int index_1 = rand.Next(korean.Length);
                        string selected_1 = korean[index_1];
                        Console.WriteLine("오늘의 메뉴는?: " + selected_1);
                        break;
                    case "2":
                        string[] chinese = { "짜장면", "짬뽕", "탕수육" , "취두부" };
                        int index_2 = rand.Next(chinese.Length);
                        string selected_2 = chinese[index_2];
                        Console.WriteLine("오늘의 메뉴는?: " + selected_2);
                        break;
                    case "3":
                        string[] japanese = { "초밥", "라멘", "우동", "돈카츠" };
                        int index_3 = rand.Next(japanese.Length);
                        string selected_3 = japanese[index_3];
                        Console.WriteLine("오늘의 메뉴는?: " + selected_3);
                        break;
                    case "4":
                        string[] western = { "스테이크", "파스타", "피자", "햄버거" };
                        int index_4 = rand.Next(western.Length);
                        string selected_4 = western[index_4];
                        Console.WriteLine("오늘의 메뉴는?: " + selected_4);
                        break;
                    case "5":
                        string[] etc = { "수르스트뢰밍", "푸딩", "아이스크림" };
                        int index_5 = rand.Next(etc.Length);
                        string selected_5 = etc[index_5];
                        Console.WriteLine("오늘의 메뉴는?: " + selected_5);
                        break;

                    default:
                        Console.WriteLine("1,2,3,4,5 중에서 입력하셔야 합니다.");
                        break;
                }
            }
            else if (input == "n" || input == "N")
            {
                Console.WriteLine("안 고를 거면 왜 실행하셨죠?? 잘못 킨거면 행운을 빌고요 아니면 에휴 쪼렙");
            }
            else if (input == "Donate")
            {
                Console.WriteLine("아이고, 또 0원 후원 감사합니다~!");
            }
            else if (input == "Show Me The Money")
            {
                Console.WriteLine("어차피 저 돈 없으니까 치트 쓸거면 나가세요.");
            }
            else
            {
                Console.WriteLine("y나 n을 누르셔야죠(대문자 됩니다)");
            }
        }
    }
}

// 인텔리 코드야 왜 안 돌아오니...