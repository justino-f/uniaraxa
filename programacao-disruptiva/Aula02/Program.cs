string _ = "senhor";

char[] observable = {'s', 'r', 'a'}; 

Console.WriteLine(_.Where(c => observable.Contains(c)).ToArray());
