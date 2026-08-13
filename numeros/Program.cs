// numeros inteiros
short numero1 = 9999;               // 16 bits
int   numero2 = 999999999;          // 32 bits
long  numero3 = 999999999999999999; // 64 bits

// numeros reais
float   real1 = 1.0F; // sufixo necessário
double  real2 = 1.0;  // "double precision" 
decimal real3 = 1.0M; // tipo explicito e preciso

Console.WriteLine($"short: {numero1}\nint: {numero2}\nlong: {numero3}");
Console.WriteLine($"\nfloat: {real1}\ndouble: {real2}\ndecimal: {real3}");