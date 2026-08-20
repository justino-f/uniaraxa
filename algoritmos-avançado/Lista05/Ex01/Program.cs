using System.Collections;

string input = Console.ReadLine();

Stack<char> texto = new Stack<char>();

for (int i = 0; i < input.Length; i++) texto.Push(input[i]);

for (int j = 0; j < input.Length; j++){
	char charactere = texto.Pop();
	Console.Write(charactere);
}
