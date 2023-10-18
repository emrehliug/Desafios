using System; 

class URI {

    static void Main(string[] args) { 

            float a = Convert.ToSingle(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());

            float media = (a*3.5f + b*7.5f) / 11;

            Console.WriteLine("MEDIA = "+ media.ToString("0.00000"));
            Console.ReadKey();

    }

}