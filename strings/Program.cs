string nome1 = "    interesse";
string nome2 = "carros  ";
string frase = $"Eu tenho {nome1.Trim()} e gosto de {nome2.Trim()}";

Console.WriteLine(frase); // string original
Console.WriteLine("======================");
Console.WriteLine(frase.Replace("interesse", "dinheiro")); // string modificada, sem alterar a original

frase = frase.Replace("interesse","dinheiro"); // string origial, agora modificada pra sempre

Console.WriteLine("======================");
Console.WriteLine(frase); 