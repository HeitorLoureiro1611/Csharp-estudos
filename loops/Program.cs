int doWhileCont = 0;
int whileCount = 0;

Console.WriteLine("\nDo While:");
do
{
    doWhileCont++;
    Console.WriteLine(doWhileCont);
} while (doWhileCont < 5);

Console.WriteLine("\nWhile:");
while(whileCount < 10)
{
    whileCount++;
    Console.WriteLine(whileCount);
}

Console.WriteLine("\nFor:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(i);
}