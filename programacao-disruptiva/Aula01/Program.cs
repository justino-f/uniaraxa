string alfabeto = "abcdefghijklmnopqrstuvwxyz";
string alfabetoUpper = alfabeto.ToUpper();
string alfabetoCriptografado = "@?(¬¹²³£¢¬{[]}0!#$%&*)^]{;";

string conteudo = Console.ReadLine();
string conteudoCriptografado = "";

for (int i = 0; i < conteudo.Length; i++){	
	for (int j = 0; j < alfabeto.Length; j++){
		if (alfabeto[j] == conteudo[i] || alfabetoUpper[j] == conteudo[i]){
			conteudoCriptografado += alfabetoCriptografado[j];
		}
	}
}

Console.WriteLine(conteudoCriptografado);
