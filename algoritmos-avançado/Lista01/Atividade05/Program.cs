//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Criar um projeto utilizando a linguagem C# que receba os valores inteiros A, B e C e mostre na tela qual o maior valor entre os três valores digitados. Considere que os valores digitados sempre serão diferentes. Além disso, mostre na tela se a soma de A+B+C é um número par ou ímpar.
using System;

internal class Program{

	static void Main(string[] args){
		Console.Write($"Determine os valores A B e C. (A B C): ");
		var v = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
		Console.WriteLine($"Maior: {v.Max()}");
		if ((v[0] + v[1] + v[2]) % 2 == 0) Console.WriteLine("A soma dos valores é par!");
		else Console.WriteLine("A soma dos valores é ímpar!");
	}
}
