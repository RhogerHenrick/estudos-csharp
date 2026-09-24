Console.Write("Insira sua nota: ");
int nota = Convert.ToInt32(Console.ReadLine());
if (nota < 4)
{
    Console.WriteLine("reprovado");
}
else if (nota == 5 || nota == 6)
{
    Console.WriteLine("recuperando");
}
else if ( nota >= 7 && nota <= 10 )
{
    Console.WriteLine("Aprovado");
}

else if ( nota >= 11 )
{
    Console.WriteLine("Nota inválida");
}