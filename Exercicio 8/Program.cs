// Faça um programa para preencher uma matriz 4 x 4, em seguida apresentar na tela a soma 
// dos  elementos  abaixo  da  diagonal  principal.  Mostre  na  tela  os  elementos  da  diagonal 
// principal também.   
 



using System;

class Program
{
    public static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4];//declarando 

        int n = 4, soma = 0;//declarando variaveis
        Random r = new Random(); //numero aleatorio
        Console.WriteLine("Matriz");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)//loop
            {
                matriz[i, j] = r.Next(1, 10);//contas
                Console.Write("{0},", matriz[i, j]);
            }
            Console.WriteLine();//breack linha
        }

      string principal = "Diagonal Principal [|";//saida de dados
        for (int i = 0; i < 4; i++)//loop
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == j)
                  principal += matriz[i, i] + "|";
                if (i > j)
                    soma += matriz[i, j];
            }
        }
      principal+="]";
      Console.WriteLine(principal);//saida de dados
        Console.WriteLine("A soma dos numeros é: {0}",soma);//saida de dados
    }
}