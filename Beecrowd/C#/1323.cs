using System; 

class URI {

    static void Main(string[] args) { 

            while (true)
            {
                int quadrado = Convert.ToInt32(Console.ReadLine());
                int resultado = 0;

                if (quadrado == 0)
                    break;

                resultado = (quadrado * (quadrado + 1) * (2 * quadrado + 1)) / 6;

                Console.WriteLine(resultado);
            }
    }

}