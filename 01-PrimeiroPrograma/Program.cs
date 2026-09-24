Console.Write("Insira sua nota: ");
int nota = Convert.ToInt32(Console.ReadLine());

if (nota  < 0 || nota > 10)
{
    Console.WriteLine("Nota inválida");
}
if (nota <= 4)
{
    Console.WriteLine("reprovado");
}
else if (nota <=6)
{
    Console.WriteLine("recuperando");
}
else
{
    Console.WriteLine("Aprovado");
}
