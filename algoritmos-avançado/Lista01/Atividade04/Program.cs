//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Crie um algoritmo que receba como entrada um número inteiro e analise se é um número ímpar ou par mostrando o resultado na tela.
using System;

internal class Program{

	static void Main(string[] args){
		Console.Write("Insira um número: ");
		int n = int.Parse(Console.ReadLine()!);
		if (n % 2 == 0) Console.WriteLine("Par!");
		else if (n % 2 != 0)Console.WriteLine("Ímpar!");
		else Console.WriteLine("Inválido!");
	}
}
