using System;

namespace class10 {
    class Enumerador {

        enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado};
        //cada elemento tem sua posição relacionada ao indice
        // domingo = diassemana(0)

        static void Main() {
            DiasSemana ds = DiasSemana.Domingo;
            Console.WriteLine(ds);

            DiasSemana feriado = (DiasSemana)4;
            Console.WriteLine("Este dia sera feriado " + feriado);
        }
    }
}