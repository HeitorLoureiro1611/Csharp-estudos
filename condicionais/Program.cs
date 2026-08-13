const int IDADE_MAX = 99;

Console.Write("Insira sua idade: ");

// é necessário parsear a string pra um int pois o readline apenas lê strings
int idade = Convert.ToInt32(Console.ReadLine()); 

if (idade < 0 || idade > IDADE_MAX)
{
    Console.WriteLine("Idade inválida");
}
else if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade");
}else if (idade < 18)
{
    Console.WriteLine("Você é MENOR de idade!");
}
