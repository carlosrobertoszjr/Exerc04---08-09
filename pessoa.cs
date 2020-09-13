/***
4) 
Classe Pessoa: Crie uma classe que modele uma pessoa:

Atributos: nome, idade, peso e altura
Métodos: Envelhercer, engordar, emagrecer, crescer. Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.
***/
using System;

class Pessoa {
  //METODO DE ACESSO - PUBLIC, PRIVATE e PROTECTED
  public string nome; 
  public int idade;
  public float peso;
  public double altura;

  
  public string Envelhecer(int idade){
    string estagio;
    if (idade >= 0 && idade < 12){
      estagio = "infância";
    }
    else if (idade >= 12 && idade < 21){
      estagio = "adolescência";
    }
    else if (idade >= 21 && idade < 31){
      estagio = "juventude";
    }
    else if (idade >= 31 && idade < 60){
      estagio = "meia ideia";
    }
    else if (idade >= 60){
      estagio = "velhice";
    }
    else{
      estagio = ". Sua idade não foi compreendida pelo sistema.";
    }
    Console.Write("Você está na fase da >> ");
    return estagio;
  }
        
  string r;
  public string Engordar(double altura, double peso){
    double imc = (peso/(altura*altura));
    //string r;
    if (imc < 18.5) {
      r = "Você está abaixo do peso. Precisa engordar um pouco..";
      //Console.WriteLine(r);
    }
    else if (imc > 18.5 && imc < 24.9){
      r = "Seu peso está bom!";
      //Console.WriteLine(r);
    }
    else{
      r = "";
    }
    return r;
    
  }
  

  public string Emagrecer(double altura, double peso){
    double imc = (peso/(altura*altura));
    if (imc > 24.9 && imc < 29.9){
      r=("Você está com sobrepeso. Necessita emagrecer..");
    }
    else if (imc > 29.9){
      r=("Você está obeso. Procure um médico para avaliar sua saúde..");
    }
    else{
      r = "";
    }
    Console.WriteLine("Seu IMC é de "+imc);
    return r;
  }
  

  public double Crescer(double altura, int idade){
    double alturaFutura;
    if (idade <= 21) {
      alturaFutura = altura+((21-idade)*0.005);
      Console.Write("Sua altura será de >> ");
    }  
    else{
      alturaFutura = altura;
      Console.Write("Sua altura não se alterará >> ");
    }
    return alturaFutura;
  }
}
        
   

