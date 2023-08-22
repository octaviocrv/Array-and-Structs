


// Faça um procedimento que preencha um vetor com as notas de uma turma de 10 
// alunos. Faça um outro procedimento que receba um vetor preenchido com as notas, calcule 
// a média da turma e conte quantos alunos obtiveram nota acima da média. Esse procedimento 
// deve exibir a média e o resultado da  contagem.  Faça um programa que declare as devidas 
// variáveis e acione os procedimentos. 


class program {


    static void Procedimento() {  //  funcão notas
        
        double [] notas  = new double [10]; // array e vetor

        for( int i=0; i<10; i++) { // for para preencher o vetor
        Console.WriteLine("Digite suas notas");
        notas[i] = double.Parse(Console.ReadLine()); 
        }

        Procedimento2(notas);


    }

    static void Procedimento2(double [] notas) { //  funçao media

    double soma=0;  //  declarando variaveis
    int cont=0; //  declarando cont para media alunos

    for ( int i=0 ; i<10; i++) {  //  funçao para percorrer vetor notas

        if(notas[i]>6) {
 
            cont++; //  contador
        }

        soma += notas[i]; // pegando a variavel soma e somando com a primeira nota do vetor


    }

        double media=0;  // media da turma

        media = soma/10; //  conta da media
    
     Console.WriteLine("A media da turma é {0} e a quantidade de alunos acima da media são {1}", media,cont); //  imprima isso
   
    }



    public static void Main(string[] args) { //  main

      Procedimento(); //  chamando meu procedimento 

}
}