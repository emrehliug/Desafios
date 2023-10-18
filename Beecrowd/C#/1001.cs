using System; 

class URI {

    static void Main(string[] args) { 
    
    int A;
    int B;
    int X;
    
    A = Convert.ToInt32(Console.ReadLine());
    B = Convert.ToInt32(Console.ReadLine());
    X = A+B;
    
    Console.WriteLine(string.Format("X = {0}", X)); 
    }

}