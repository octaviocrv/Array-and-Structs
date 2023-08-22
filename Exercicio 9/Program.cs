// Faça um procedimento que preencha 2 matrizes, A 4 x 6 e B 4 x 6. Faça uma função para 
// cada uma das situações a seguir, que recebe duas matrizes preenchidas, calcula e retorna as 
// matrizes indicadas :  
 
// a) uma matriz S que seja a soma de A e B.  
// b) uma matriz D que seja a diferença de A e B. (A - B).  
 
// Faça um programa que faça as devidas declarações e acione os módulos para exemplificar 
// o seu uso. Escreva as matrizes resultantes do acionamento de cada uma das funções. 






using System;

class Program{

    static void preenche(int[,] matriz1, int[,] matriz2){//procedimento
        Random r = new Random();//numero aleatorio
        for (int i = 0; i < 4; i++){//loop
            for (int j = 0; j < 6; j++){//loop
                matriz1[i,j] = r.Next(0,10);//contas
                matriz2[i,j] = r.Next(0,10);
            }
        }
    }

    static int[,] soma(int[,] matriz1, int[,] matriz2){//função

        int[,] temp = new int[4,6];

        for (int i = 0; i < 4; i++){

            for (int j = 0; j < 6; j++)
                temp[i,j] = matriz1[i,j] + matriz2[i,j];
        }
        return temp;
    }

    static int[,] subtrai(int[,] matriz1, int[,] matriz2){

        int[,] temp = new int[4,6];

        for (int i = 0; i < 4; i++){

            for (int j = 0; j < 6; j++)
                temp[i,j] = matriz1[i,j] - matriz2[i,j];
            
        }
        return temp;
    }

     static void showmatriz(int[,] matriz, string mensagem){
        Console.WriteLine(mensagem);
        for (int i = 0; i < 4; i++){

            for (int j = 0; j < 6; j++){
                Console.Write("{0}|",matriz[i,j]);
            }
            Console.WriteLine();
        }
    }
  
    static void Main (){
        int[,] matriz1 = new int[4,6], matriz2 = new int[4,6];
        preenche(matriz1,matriz2);
        int[,] MatrizS = soma(matriz1, matriz2);
        int[,] MatrizD = subtrai(matriz1, matriz2);
        showmatriz(matriz1, "\nMatriz A");
        showmatriz(matriz2, "\nMatriz B");
        showmatriz(MatrizS, "\nMatriz S");
        showmatriz(MatrizD, "\nMatriz D");
    }
}