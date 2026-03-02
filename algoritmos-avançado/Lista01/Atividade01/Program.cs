//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Construa um algoritmo que, tendo como dados de entrada dois pontos quaisquer no plano, P(x1,y1) e P(x2,y2), escreva a distância entre eles.

using System;

internal class Program {
	static void Main(string[] args){
		Console.Write("Determine as coordenadas X e Y. (x1 x2 y1 y2): ");
		var v = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
		var (x1, x2, y1, y2) = (v[0], v[1], v[2], v[3]);
		double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
		Console.WriteLine($"X1: {x1}, X2: {x2}, Y1 {y1}, Y2: {y2}");
		Console.WriteLine($"Distância: {distancia}");

		
	}
}
