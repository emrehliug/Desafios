using System; 

class URI {

    static void Main(string[] args) { 

            String nomeVendedor;
            float salarioFixo,totalVendas,total;

            nomeVendedor = Console.ReadLine();
            salarioFixo = Convert.ToSingle(Console.ReadLine());
            totalVendas = Convert.ToSingle(Console.ReadLine());

            total = salarioFixo + (totalVendas *0.15f);

            Console.WriteLine("TOTAL = R$ " + total.ToString("#.00"));
            Console.ReadKey();

    }

}