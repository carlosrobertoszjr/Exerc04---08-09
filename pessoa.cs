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

  
  public void Envelhecer(){
        
  }
        

  public double Engordar(double altura, double peso){
    double imc = (peso/(altura*altura));
    if (imc < 18.5) {
      Console.WriteLine("Você está abaixo do peso. Precisa engordar um pouco..");
    }
    else if (imc > 18.5 && imc < 24.9){
      Console.WriteLine("Seu peso está bom!");
    }
    else{
      
    }
    return imc;
    
  }

  public double Emagrecer(double altura, double peso){
    double imc = (peso/(altura*altura));
    if (imc > 24.9 && imc < 29.9){
      Console.WriteLine("Você está com sobrepeso. Necessita emagrecer..");
    }
    else if (imc > 29.9){
      Console.WriteLine("Você está obeso. Procure um médico para avaliar sua saúde..");
    }
    else{

    }
    return imc;
  }

  public double Crescer(double altura, int idade){
    double alturaFutura;
    if (idade <= 21) {
      alturaFutura = altura+((21-idade)*0.005);
    }  
    else{
      alturaFutura = altura;
      Console.WriteLine("Sua altura não se alterará");
    }
    return alturaFutura;
  }
}
        
   

