using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        int N = 0;
        N = Convert.ToInt32(Console.ReadLine());
        int gemeo1 = 0;
        int gemeo2 = 0;
        
        int[] numeros = new int[N];
        List<int> primos = new List<int>();

        if(N >= 5){
            for (int i = 0; i < N; i++){
                numeros[i] = N - i;
                if (filtraPrimo(numeros[i])){
                    primos.Add(numeros[i]);
                }
            }
        }
        
        for(int j = 0; j < primos.Count; j++){
            if (primos.Count >= 2 && primos[j] - 2 == primos[j + 1]){
                gemeo1 = primos[j];
                gemeo2 = primos[j + 1];
                break;
            }
        }
        
        Console.Write($"{gemeo2} {gemeo1}\n");
    }
    
     static bool filtraPrimo(int n){
            if (n < 2){
                return false;
            }
            for(int i = 2; i<= Math.Sqrt(n); ++i){
                if (n % i == 0 && n != i){
                    return false;
                }
            }
            return true;
        }
}