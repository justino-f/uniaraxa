int count = 0;
for (int i = 1; i <= 10; i++) {
	int n = int.Parse(Console.ReadLine()!);
	if (n > 0) count++;
}
Console.WriteLine(count);
