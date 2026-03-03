//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Faça um algoritmo que leia as 3 notas de um aluno e calcule a média final deste aluno. Considerar que a média é ponderada e que o peso das notas são: 2, 3 e 5.
using System;

internal class Program{

	static void Main(string[] args){
		Console.Write("Insira as notas do aluno. (n1 n2 n3): ");
		var v = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
		var (n1, n2, n3) = (v[0], v[1], v[2]);
		double media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;
		Console.WriteLine($"Média: {media}");
	}
}
