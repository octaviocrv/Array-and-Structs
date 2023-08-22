// Escrever um procedimento que preenche uma matriz M(10,10) e a escreve. Faça outros 
// procedimentos que recebam uma matriz preenchida, realize as trocas indicadas a seguir 
// (um procedimento para cada uma delas) e exiba a matriz resultante da troca:  
 
// a) a linha 2 com a linha 8  
// b) a coluna 4 com a coluna 10  
// c) a diagonal principal com a diagonal secundária  
// d) a linha 5 com a coluna 10.  
 
// Faça um programa que faça as devidas declarações e acione os módulos para exemplificar 
// o seu uso. 7



using System;

class Program{
    static void preenche(int[,] matriz, int size){
        Random r = new Random();
        for (int i = 0; i < size; i++){
            for (int j = 0; j < size; j++){
                matriz[i,j] = r.Next(0,10);
            }  
        }
        Console.WriteLine("Matriz Inicial");
        for (int i = 0; i < size; i++){
            for (int j = 0; j < size; j++){
                Console.Write("{0}|",matriz[i,j]);
            }
            Console.WriteLine();
        }
    }
  
    static void matriza(int[,] matriz){
        Console.WriteLine("\nMatriz A");
        for (int i = 0; i < 10; i++){
            for (int j = 0; j < 10; j++){
                if(i==1)
                    Console.Write("{0}|",matriz[7,j]);
                else if(i==7)
                    Console.Write("{0}|",matriz[1,j]);
                else
                Console.Write("{0}|",matriz[i,j]);
            }
            Console.WriteLine();
        }
    }
  
    static void matrizb(int[,] matriz){
        Console.WriteLine("\nMatriz B");
        for (int i = 0; i < 10; i++){

            for (int j = 0; j < 10; j++){

                if(j==3)
                    Console.Write("{0}|",matriz[i,9]);
                else if(j==9)
                    Console.Write("{0}|",matriz[i,3]);
                else
                Console.Write("{0}|",matriz[i,j]);
            }
            Console.WriteLine();
        }

    }

    static void matrizc(int[,] matriz){
        Console.WriteLine("\nMatriz C");
        for (int i = 0; i < 10; i++){
            for (int j = 0; j < 10; j++){
                if(j==i)
                    Console.Write("{0}|",matriz[i,9-j]);
                else if(j+i == 9)
                    Console.Write("{0}|",matriz[i,i]);
                else
                Console.Write("{0}|",matriz[i,j]);
            }
            Console.WriteLine();
        }
    }

    static void matrizd(int[,] matriz){
        Console.WriteLine("\nMatriz D");
        for (int i = 0; i < 10; i++){
            for (int j = 0; j < 10; j++){
                if(i==4)
                    Console.Write("{0}|",matriz[j,9]);
                else if(j == 9)
                    Console.Write("{0}|",matriz[4,i]);
                else
                Console.Write("{0}|",matriz[i,j]);
            }
            Console.WriteLine();
        }
    }
  
    static void Main(){
        int[,] matriz10 = new int[10,10];
        preenche(matriz10, 10);
        matriza(matriz10);
        matrizb(matriz10);
        matrizc(matriz10);
        matrizd(matriz10);
    }
}