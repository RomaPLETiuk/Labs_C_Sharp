
using System;

class Program
{
    static void Main() {
        
        double  x;
        do{
        Console.Write("\n\nВведіть х: ");
        x =   double.Parse(Console.ReadLine());
        Console.Write("\nВведіть y: ");
        double  y =  double.Parse(Console.ReadLine());
        Console.Write("\nВведіть z: ");
        double z =  double.Parse(Console.ReadLine());
        double a = x + ((Math.Pow(y, 3))/(z+(z*z)+(z+(y*y))));
      
       string rangeX =" від  -1 до 1";
       
       if(x<0){
        if(x<-1){
             rangeX = "менш за -1";
               if(x<-10){
             rangeX = "менш за -10";
             }
        }
       }
       else{
          if(x>1){
             rangeX = "більш за 1";
             if(x>10){
             rangeX = "більш за 10";
             }
          } 
       }
       Console.Write($"\nrange for X is {rangeX}"); 
     
        Console.Write("\n\nRezult:"+ a);
        Console.Write("\n\n*********//*********");
        
        /*if(a>0){
            Console.Write("\nRezult is positive! It is cool ");
         }
          else if(a<0){
            Console.Write("\nRezult is negative! It is't cool ");
          }
           else(a=0){
            Console.Write("\nRezult null ");
           }*/
           
        string rez = (a<0) ?  "negative" :  "positive";
        Console.WriteLine($"\nRezult is {rez}");
        
        
        
        }while(x!=0);
        
        
        
    }
}