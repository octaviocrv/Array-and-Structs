// 4. Faça um procedimento que preencha 2 vetores X e Y com 10 elementos cada um (ocupando
// as posições de 0 a 9 em cada vetor).  Faça um outro procedimento que receba dois vetores
// preenchidos  e  gera  um  novo  vetor  com  os  elementos  desses  2  vetores  intercalados  de  tal
// forma que nas posições ímpares do novo vetor estejam os elementos do primeiro vetor e nas
// posições pares os elementos do segundo vetor recebido por parâmetro. Faça um
// procedimento  que  receba e  exiba  o  conteúdo  de  um  vetor.  Faça  um  programa  que  faça  as
// devidas declarações e acione os módulos para exemplificar o seu uso.


using System;
class Program {
static void Procedimento() {
        int [] x = new int [10]; //crio vetor x com 10 posicoes
        int [] y = new int [10]; //crio o vetor y com 10 posicoes
        for(int i=0;i<10;i++){ //loop que preenche o primeiro vetor (x) 
            Console.WriteLine("Digite 10 elementos para x");
            x[i]= int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < 10; i++){ //loop que preenche o segundo vetor (y)
            Console.WriteLine("Digite 10 elementos para y");
            y[i]= int.Parse(Console.ReadLine());
        }
        Procedimento2(x,y); //passo os vetores x e y como pararmetros para Procedimento2
}
static void Procedimento2 (int [] x, int [] y) {
    int k=0; //variavel para indicar as posicoes dos vetores x e y
    int [] novo = new int [20]; //crio um novo vetor com 20 posições
    for(int i=0;i<20;i+=2){ //loop para preencher posicoes pares do novo vetor
            novo[i] = y[k]; 
            k++; //aumento 1 a k, para assim mudar a posicao do vetor y 
    }
    k=0; // variavel k volta a valer zero para percorrer o vetor x desde sua primeira posicao
    for(int i=1;i<20;i+=2){ //loop para preencher posicoes impares do novo vetor
            novo[i] = x[k];
            k++; //aumento 1 a k, para assim mudar a posicao do vetor x 
    }
    Console.WriteLine(); // pular uma linha 
for (int i = 0; i < 20; i++){ //loop para percorrer todas as posicoes do novo vetor 
        Console.Write(novo[i] + " "); // imprimo na tela o novo vetor (com os valores do vetor x e y intercalados)
}
}
public static void Main(string[] args){
        Procedimento(); // chamo o procedimento para preencher os vetores 
}
}

