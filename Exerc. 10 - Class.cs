using System;

namespace Exerc_10{
  class Change{
    string diaS = "", mesS = "", anoS = "";
     int a, dia = 0, mes = 0, ano = 0;
     
    public bool Valid(string data){
      diaS = data.Substring(0,2);
      mesS = data.Substring(3,2);
      anoS = data.Substring(6,4);
      
      dia = int.Parse(diaS);
      mes = int.Parse(mesS);
      ano = int.Parse(anoS);
      
      if ( (data.Length == 10) && (Int32.TryParse(diaS,out a)) && (dia <= 31) && (data.Substring(2,1) == "/") && (Int32.TryParse(mesS,out a)) && (mes <= 12) && (data.Substring(5,1) == "/") && (Int32.TryParse(anoS,out a)) ){
        return true;
      } else return false;
    }
    
    public string Data(string data){
      
      switch (mesS){
        case "01": 
        {
                  return (" " + dia + "de janeiro de" + ano);
                  break;
        }          
        case "02":
                  return (" " + dia + " de fevereiro de " + ano);
                  break;
                  
        case "03":
                  return (" " + dia + " de março de " + ano);
                  break;
                  
        case "04":
                  return (" " + dia + " de abril de " + ano);
                  break;                  
                  
        case "05":
                  return (" " + dia + " de maio de " + ano);
                  break;
                  
        case "06":
                  return (" " + dia + " de junho de " + ano);
                  break;          
                  
        case "07":
                  return (" " + dia + " de julho de " + ano);
                  break;                
                  
        case "08":
                  return (" " + dia + " de agosto de " + ano);
                  break;          
                  
        case "09":
                  return (" " + dia + " de setembro de " + ano);
                  break;          
                  
        case "10":
                  return (" " + dia + " de outubro de " + ano);
                  break;
                  
        case "11":
                  return (" " + dia + " de novembro de " + ano);
                  break;          
                  
        case "12":
                  return (" " + dia + " de dezembro de " + ano);
                  break;          
        default :
                  return("ERROR");
                  break;
      }
      
    }
  }
}