using System; 

class URI {

    static void Main(string[] args) { 

            int numeroFunc;
            int qtdHoras;
            float valorHora;

            numeroFunc = Convert.ToInt32(Console.ReadLine());
            qtdHoras = Convert.ToInt32(Console.ReadLine());
            valorHora = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("NUMBER = " + numeroFunc + "\nSALARY = U$ " + (qtdHoras * valorHora).ToString("0.00"));
            Console.ReadKey();

    }

}