using System;

class Program
 {
    static void Main(string[] args)
    {
        string name;
        Console.WriteLine("안녕하세요! 당신의 이름을 알려주세요:");
        name = Console.ReadLine();
        Console.WriteLine($"당신의 이름은 {name}(이)군요.");
     }
 }