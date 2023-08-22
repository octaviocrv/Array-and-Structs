

// Faça um procedimento que preencha um vetor X de 10 elementos. A seguir faça uma função 
// que receba um vetor preenchido, teste e copie todos os valores negativos deste vetor para um 
// novo  vetor (sem deixar elementos vazios entre os valores copiados), retornando este vetor 
// como resultado. Faça um procedimento que recebe e exibe o conteúdo de um vetor. Faça um 
// programa que faça as devidas declarações e acione os módulos para exemplificar o seu uso. 


class Program
{

    static void Procedimento()
    {

        int[] elementos = new int[10];

        for (int i = 0; i < 3; i++)
        {

            Console.WriteLine("Digite 10 numeros aleatorios inteiros");
            elementos[i] = int.Parse(Console.ReadLine());

        }

        Procedimento2(elementos);

    }



    static void Procedimento2(int[] elementos)
    {

        int k = 0;

        int[] elementos2 = new int[10];
        for (int i = 0; i < 3; i++)
        {

            if (elementos[i] < 0)
            {

                elementos2[k] = elementos[i]; // igualando valores
                k++; // quantidade de negativos
            }
        }


        Console.WriteLine();



        for (int i = 0; i < 3; i++)
        {

            if (elementos2[i] != 0)

                Console.WriteLine("{0}", elementos2[i]);


        }

    }

    public static void Main(string[] args)
    {

        Procedimento();

    }







}
