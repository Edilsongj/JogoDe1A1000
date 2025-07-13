
Random Sorteador = new Random();
int NumeroSecreto = Sorteador.Next(1, 1001);
int chutes = 0;

do
{

    Console.WriteLine("Digite seu palpite");
    string entrada = (Console.ReadLine()!);
    chutes = int.Parse(entrada);

    if (chutes > NumeroSecreto)
    {
        Console.WriteLine("É menor");
    }
    else if (chutes < NumeroSecreto)
    {
        Console.WriteLine("É maior");

    }
    else
    {
        Console.WriteLine("Parabéns! Você acertou.");
    }

} while (chutes != NumeroSecreto);


