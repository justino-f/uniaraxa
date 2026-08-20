using System.Collections;
using System.Linq;

string expressao = Console.ReadLine()!;

Stack<char> pilha = new Stack<char>();

char[] abr = ['[', '{','('];
char[] lim = [']', '}', ')'];

foreach (char c in expressao){
	if (c == abr[0] || c == abr[1] || c == abr[2]){
		pilha.Push(c);
	} else if (c == lim[0] || c == lim[1] || c == lim[2]){
		int index = 0;
		for (int i = 0; i < lim.Length; i++) if (c == lim[i]) index = i;
		if (pilha.Contains(abr[index])) pilha.Pop();
		else continue;
	}
}

Console.WriteLine(pilha.Count);
