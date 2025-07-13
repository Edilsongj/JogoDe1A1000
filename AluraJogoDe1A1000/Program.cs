using System;

class Program {
    static void Main() {
        // Máquina” de sorteio com um número aleatório.
        Random Sorteador = new Random();
        //variável pra guardar o número sorteado
        int NumeroSecreto = Sorteador.Next(1, 1001);
        //variável para guardar o chute do usuário
        int chutes = 0;

        do
        {

            Console.WriteLine("Digite seu palpite" );
            string entrada = (Console.ReadLine()!);
            chutes = int.Parse(entrada);

            // Verifica se o chute é válido
            if (chutes > NumeroSecreto)
            {
                Console.WriteLine("É menor");
            }
            else if (chutes < NumeroSecreto)
            {
                Console.WriteLine("É maior");

            }
            else {
                Console.WriteLine("Parabéns! Você acertou.");
            }
                        

        }while (chutes != NumeroSecreto);

    }
}