using System; 

class URI {

    static void Main(string[] args) { 

        int a, b, c;
        int.TryParse(Console.ReadLine(), out a);
        int.TryParse(Console.ReadLine(), out b);
        int.TryParse(Console.ReadLine(), out c);
        
        int maiorAB = (a + b + Math.Abs(a - b)) / 2;
        int maiorABC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;
        
        Console.WriteLine($"{maiorABC} eh o maior");
    }

}