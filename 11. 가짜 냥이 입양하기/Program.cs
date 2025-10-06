using System;

namespace AdoptingMeows
{
    class Cat
    {
        public string Name;
        public int Age;
        public string Breed;

        public void Meow()
        {
            Console.WriteLine($"{Name}:야옹!");
        }

        public void Introduce()
        {
            Console.WriteLine($"이 고양이는 {Name}(이)고, {Age}살입니다. 품종은 {Breed}(이)구요.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("저희 고양이들을 소개합니다!");
            Console.WriteLine("제 컴퓨터 안을 돌아다니는(골칫거리) 녀석들이죠.");
            Console.WriteLine("품종만 알려주시면 제가 소개해드리겠습니다. (1. 페르시안, 2. 러시안 블루, 3. 프로토스 프로브, 4. 페르시안(?))");

            Cat Neko = new Cat();
            Neko.Name = "네코";
            Neko.Age = 3;
            Neko.Breed = "페르시안";

            Cat Blue = new Cat();
            Blue.Name = "블루";
            Blue.Age = 2;
            Blue.Breed = "러시안 블루";

            Cat Probius = new Cat();
            Probius.Name = "프로비우스";
            Probius.Age = 10;
            Probius.Breed = "프로토스 프로브";

            Cat DDangDDang = new Cat();
            DDangDDang.Name = "땅땅";
            DDangDDang.Age = 5;
            DDangDDang.Breed = "페르시안(?)";

            Console.Write("원하는 품종 번호를 입력하세요: ");
            string input = Console.ReadLine();

            Cat selectedCat = null;

            switch (input)
            {
            case "1":
                selectedCat = Neko;
                break;
            case "2":
                selectedCat = Blue;
                break;
            case "3":
                selectedCat = Probius;
                break;
            case "4":
                selectedCat = DDangDDang;
                break;
            default:
                Console.WriteLine("야임마, 그런 품종은 없어 임마!!");
                break;
            }

            if(selectedCat != null)
            {
                selectedCat.Introduce();
                selectedCat.Meow();
            }
        }
    }
}