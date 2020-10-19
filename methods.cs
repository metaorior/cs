using System;

class Program {
    static void Main() {
        Console.WriteLine("Ola Peach");

    BoasVindas();
    }

    static void BoasVindas() {
    //introduz
    int a = 0; 
    int b = 0;

    Console.WriteLine("Digite o primeiro numero"); 

    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero"); 
    b = Convert.ToInt32(Console.ReadLine());
    chamaSoma(a,b);


    }

    static void chamaSoma(int a, int b) {
        Soma(a,b);
        Console.WriteLine("A soma que veio da função Soma eh: " + Soma(a,b));
    }

    static int Soma( int x , int y) {
        int resultado = x + y;
        return resultado;

    }

   
}