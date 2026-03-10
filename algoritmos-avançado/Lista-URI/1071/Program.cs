using System; 
class URI {

    static void Main(string[] args) { 
        int X  = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        int Soma = 0;
        for (int i = X - 1; i > Y; i--) {
            if (i % 2 != 0) Soma += i;
        }
        Console.WriteLine(Soma);
    }
}