// Faça um algorirtmo que leia um vetor n{20}. A seguir encontre o menor elemento do vetor N e a sua posição
// dentro do vetor, mostrando : " O menor elemento de N é ", M e sua posição dentro do vetor é: "P.

class Program {



public static void Main(string[] args)
{

    int menor=0, posicao=0;

int [] numero = new int [3]; // criando o vetor 


for ( int i=0; i<3; i++ ) { // criando o for para criar posições para o vetor

Console.WriteLine("--------inicio-------"); // iniciando o programa
Console.WriteLine("Digite um numero"); // recebendo dados do usuario
numero[i] = int.Parse(Console.ReadLine()); // coletando todas as posições dos vetores que o usuario digitar 

}

menor=numero[0]; 

for ( int i=0; i<3; i++ ) { // criando o for para percorrer vetor

if(numero[i]< menor){  // verificando qual é o menor numero,,, se sim =
       
        menor=numero[i]; // atribuir valor do vetor na variavel '' Menor''
        posicao=i; // atribuir posicao dov vetor a variavel  '' Posicao''
}
}

    Console.WriteLine("O menor numero é {0} e está na posição {1}",menor,posicao ); // achando o menor numero e achando sua posição



}
}


