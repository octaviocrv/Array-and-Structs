// Faça uma função que sorteie 3 números (entre 10 e 50) e retorne em um vetor. Depois crie 
// um  procedimento  que  leia  as  tentativas  do  usuários. O programa só deve parar quando o usuário acertar um número sorteado.  PROBLEMA BREACK



class Program
{



    static void Sorteio()
    { // funcao sorteio

        Random numAleatorio = new Random(); // random

        int[] numeros = new int[3]; // declarando meu vetor

        for (int i = 0; i < 3; i++)
        { // preechendo o vetor
            numeros[i] = numAleatorio.Next(10, 50);
        }

        Tentativas(numeros); // chamando minha funcao tentaivas

    }



    static void Tentativas(int[] numeros) // funcao para ver as tentativas do usuario
    {

        int numTentativa = 0; // variavell tentativa
        string acertou = "Não"; // condiçao para o do while parar

        do
        {
            // Console.WriteLine("Os números são: "+numeros[0]+", "+numeros[1]+" e "+numeros[2]); ** Como ver qual o numero selecionado pelo Random (duvida a parte)
            Console.WriteLine("Digite um numero entre 10 e 50 inteiro."); // entrada de dados
            numTentativa = int.Parse(Console.ReadLine()); // guardando dados

            for (int i = 0; i < 3; i++)
            { // Percorrer o vetor para comparar o numTentativa

                if (numeros[i] == numTentativa) // criando a condição para mostrar o resultado certo
                {
                    Console.WriteLine("Voce encontrou o numero," + numeros[i]);
                    acertou = "Sim";
                    break; // parar o programa
                }
            }

        } while (acertou == "Não"); // condicao do loop infinito ate acertar

    }





    public static void Main(string[] args)
    {


        Sorteio();




    }
}











