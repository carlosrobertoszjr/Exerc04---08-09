using System;

class MainClass {
  public static void Main () {
    Pessoa Carlos = new Pessoa();
    //COLOQUE SUA IDADE DENTRO DOS PARENTESES
    Console.WriteLine(Carlos.Envelhecer(20));

    //COLOQUE ALTURA E IDADE DENTRO DOS PARENTESES
    Console.WriteLine(Carlos.Crescer(1.85,20));

    //COLOQUE ALTURA E PESO DENTRO DOS PARENTESES
    Console.WriteLine(Carlos.Emagrecer(1.85,90));
    Console.WriteLine(Carlos.Engordar(1.85,90));
  }
}