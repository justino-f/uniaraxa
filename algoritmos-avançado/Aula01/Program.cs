using System;

class Program {
	static void Main(){
		int A, B, C, X;
		A = int.Parse(Console.ReadLine()!);
		B = int.Parse(Console.ReadLine()!);
		C = int.Parse(Console.ReadLine()!);
		X = A * (B + C);
		Console.WriteLine($"Resultado: {X}");
	}
}
