using System;

namespace Exerc_10{
  class Program{
    static void Main (string[] args){
      
      byte count = 0;
      string data;
      Change Enter = new Change();
      
      do{
        if (count > 0){
          Console.WriteLine("Informe um valor válido");
          Console.WriteLine();
        } else {
          Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
        }
        data = Console.ReadLine();
        count++;
      } while(Enter.Valid(data) == false);
      
      Console.WriteLine("Data: " + Enter.Data(data));
      
    }
  }
}