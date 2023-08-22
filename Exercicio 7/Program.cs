// 7. Faça um procedimento que preencha uma matriz M 5 x 5. Faça uma função que receba 
// uma matriz preenchida, calcule e retorne cada uma das somas a seguir (uma função 
// para cada item abaixo):  
 
// a) da linha 4 de M  
// b) da coluna 2 de M  
// c) da diagonal principal  
// d) da diagonal secundária  
// e) de todos os elementos da matriz. 
 
// Faça um programa que faça as devidas declarações e acione os módulos para exemplificar 
// o seu uso. 
 


 using System;

class Program {

  static void preenchematriz (int [,] matriz){//procedimento
    int n = 5;//declarando variaveis
    Random r = new Random();//numero aleatório
    Console.WriteLine("Matriz");//saida de dados
    for(int i = 0; i<n; i++){//loop
      for(int j = 0; j<n; j++){//loop
        matriz[i,j] = r.Next(1,10);//contas
        Console.Write("{0},",matriz[i,j]);//saida de dados
      }
      Console.WriteLine();//pular linha
    }
  }

  static int func1(int [,] matriz){//função
    int soma=0;//declarando variaveis
      for(int i =0; i<5; i++){//loop
        soma += matriz[3,i];//contas
      }
    return soma;
  }

  static int func2(int [,] matriz){//função
    int soma=0;//declarando variaveis
      for(int i =0; i<5; i++){//loop
        soma += matriz[i,1];//contas
      }
    return soma;
  }

  static int func3(int [,] matriz){//função
    int soma=0;//declarando variaveis
      for(int i =0; i<5; i++){//loop
        soma += matriz[i,i];//contas
      }
    return soma;
  }

  static int func4(int [,] matriz){//função
    int soma = 0;//declarando variaveis
    for (int i = 0; i < 5; i++){//loop
            for (int j = 0; j < 5; j++){//loop
                if(i+j == 5-1)//contas
                    soma+=matriz[i,j];
            }
        }
    return soma;
  }

  static int func5(int [,] matriz){//função
    int soma = 0;//declarando variaveis
    for (int i = 0; i < 5; i++){//loop
            for (int j = 0; j < 5; j++){//loop
                    soma+=matriz[i,j];//contas
        }
  }
    return soma;
  }
  
  public static void Main (string[] args) {//main
    int[,] matriz = new int[5,5];//declarando matriz
    preenchematriz(matriz);//chamando o procedimento
    Console.WriteLine("A: {0}\nB: {1}\nC: {2}\nD: {3}\nE: {4}",func1(matriz),func2(matriz),func3(matriz),func4(matriz),func5(matriz));//saida de dados
  }
}