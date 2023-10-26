using System; 

class URI {

    static void Main(string[] args) { 

            double volume, raiodaEsfera = Convert.ToDouble(Console.ReadLine());
            volume = (4 / 3.0) * 3.14159 * (raiodaEsfera * raiodaEsfera * raiodaEsfera);

            Console.WriteLine("VOLUME = " + volume.ToString("0.000"));
            Console.ReadKey();

    }

}