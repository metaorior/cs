using System;

class Program {
    static void Main() {
        Console.WriteLine("Ola Peach");

        void BoasVindas();

    }

    static void BoasVindas() {
    //introduz
    Console.WriteLine("Digite 2 numeros");
    //declara as variaveis vazias
    int a = 0;
    int b = 0;

    // le a input como um scanf e armazena
    Console.Read(&a,&b);

    chamaSoma(a,b);


    }

    int chamaSoma(int a, int b) {
        Soma(a,b);
        Console.WriteLine("A soma que veio da função Soma eh:" + resultado);
    }

    static int Soma( int x , int y) {
        int resultado = x + y;
        return resultado;

    }

   
}




// method is a block of code which only runs when its called
//methods are c# functions

