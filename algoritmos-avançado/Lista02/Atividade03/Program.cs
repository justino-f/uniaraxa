//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Escreva um algoritmo que leia três números inteiros e positivos (A, B, C) e calcule a seguinte expressão.
using System;

internal class Program {
	static void Main(string[] args) {
		int A = int.Parse(Console.ReadLine()!);
		int B = int.Parse(Console.ReadLine()!);
		int C = int.Parse(Console.ReadLine()!);
		double R = Math.Pow(A + B, 2);
		double S = Math.Pow(B + C, 2);
		double D = (R + S) / 2;
		Console.WriteLine($"Resultado: {D}");
	}

}
