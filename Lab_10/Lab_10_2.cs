using System;
using System.Linq;
class Program {
    
 static void getMin(double [,] mass) {
       
  double minValue = double.PositiveInfinity;
  int minFirstIndex = -1;
  int minSecondIndex = -1;

  
  for (int i = mass.GetLength(0) - 1; i >= 0; --i)
    for (int j = mass.GetLength(1) - 1; j >= 0; --j) {
      double value = mass[i, j];

      if (value <= minValue) {
        minFirstIndex = i;
        minSecondIndex = j;

        minValue = value;
      }}
     Console.Write("\n Min element:  ");
     Console.Write(minValue);
     Console.Write("\n her indexs:  ");
     Console.Write(minFirstIndex+ " x  "  +minSecondIndex );
    
   }
   
  static void  multiplication(double [,] mass){
      double rez = 1;
    for (int i = mass.GetLength(0) - 1; i >= 0; --i)
    for (int j = mass.GetLength(1) - 1; j >= 0; --j){
        if(mass[i,j]<0){
             rez *= mass[i,j];
        }
    }
     Console.Write("\n multiplication:  ");
     Console.Write(rez);
  }
   
  static void Main() {
      
     Random rnd_num = new Random();  
     int N;
     int M;
     Console.WriteLine("enter row N:");
     N = int.Parse(Console.ReadLine());
     Console.WriteLine("enter col M:");
     M = int.Parse(Console.ReadLine()); 
     
     double [,] mass = new double [N, M];
     
     
     for (int i = 0; i < N; i++) 
     {      
         for (int j = 0; j < M; j++)       
       {           
         mass[i, j] = rnd_num.Next(-100, 100);      
          Console.Write($"\t{mass[i, j].ToString()}  \t");
           
       }
       Console.Write("\n  ");
       
     }
     
    getMin(mass);
    multiplication(mass) ;

 }
}