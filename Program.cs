using System;

public class Program{
     public static void Main(){

     int nota;
     string resultado;
    
     //<40 reprovado
     //<=59 recuperaçã0
     //>=60 aprovado 
    
     Console.WriteLine("Digite a nota");
     nota = Convert.ToInt32 (Console.ReadLine());

     if (nota <40){

             resultado = "Reprovado";

             }else if (nota  <= 59){
 
             resultado = "Recuperação";

            }else{

              resultado = "Aprovado";


     }

      Console.WriteLine("Será {0}", resultado);


    }
}




    



     


        
    






    
