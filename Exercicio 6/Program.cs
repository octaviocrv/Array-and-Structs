
// Em uma cidade, sabe-se hipoteticamente que, em outubro de 2022, não ocorreu temperatura 
// inferior a 15°C, nem superior a 40°C. Faça um programa que armazene as temperaturas de 
// cada dia de outubro em um vetor (de 31 posições), calcule e imprima: 
//  A menor e a maior temperatura ocorrida; 
//  A temperatura média; 
//  O número de dias nos quais a temperatura foi inferior a temperatura média. 




using System;

class Program {
  public static void Main (string[] args) {//main
    int [] temp = new int [31];//declarando vetor
    double TempoDoMaior = 0, NumeroDia=0, cont=0, TempoDaSoma=0,MediaDoTempo = 0;//declarando variaveis
    for(int i = 0; i<31;i++){//loop
      Random r = new Random();//numero aleatorio
      temp[i] = r.Next(15,40);
      cont++;//contas
      TempoDaSoma += temp[i];
      if (temp[i]>TempoDoMaior){//se
        TempoDoMaior = temp[i];
      }
      Console.Write("{0},",temp[i]);
    }//contas
    MediaDoTempo = TempoDaSoma/cont;
    for(int i = 0; i<31;i++){//loop
      if (temp[i]<MediaDoTempo){//se
        NumeroDia++;//contas
      }
    }
    
    Console.WriteLine("\nA maior temperatura : {0}°C",TempoDoMaior);
    Console.WriteLine("Dias com a temperatura abaixo da média: {0} dias",NumeroDia);//saida de dados
    Console.WriteLine(" média de temperatura foi: {0:f2}°C",MediaDoTempo);
  }
}