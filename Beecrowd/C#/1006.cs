using System; 

class URI {

    static void Main(string[] args) { 

            float a, b, c;
            a = Convert.ToSingle(Console.ReadLine());
            b = Convert.ToSingle(Console.ReadLine());
            c = Convert.ToSingle(Console.ReadLine());

            float media = (a * 2f + b * 3f + c * 5f) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("0.0"));
            Console.ReadKey();

    }

}