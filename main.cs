using System;

class MainClass {
  public static void Main () {
    Pessoa Carlos = new Pessoa();
    //COLOQUEI ALTURA E IDADE DENTRO DOS PARENTERESES
    Console.WriteLine(Carlos.Crescer(1.85,20));
    //COLOQUE ALTURA E PESO DENTRO DOS PARENTES
    Console.WriteLine(Carlos.Emagrecer(1.85,90));
    Console.WriteLine(Carlos.Engordar(1.85,90));
  }
}