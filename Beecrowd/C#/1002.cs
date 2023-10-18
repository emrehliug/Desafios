using System; 

class URI {

    static void Main(string[] args) { 

            double area, raio = Convert.ToDouble(Console.ReadLine());

            area = 3.14159 * (raio * raio);

            Console.WriteLine("A="+ area.ToString("0.0000"));
            Console.ReadKey();
    }

}