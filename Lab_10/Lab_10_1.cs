using System;
class Program {
  static void Main() {
      
     Random rnd_num = new Random();
     int N; 
      
    Console.WriteLine("enter N:");
    N = int.Parse(Console.ReadLine());
    double [] mass = new double [N];
    double [] mas = new double [N];
    
    for (int j = 0; j < N; j++)       {         
        mass[j] = rnd_num.Next(-10, 10); 
        Console.Write($"{mass[j].ToString()}  \t");
        
     }
       Console.Write("\n");
    for(int i = 0; i < N; i++){
        if (mass[i]>=0){
            
           mas[i]= mass[i];
         
           Console.Write($"{mas[i].ToString()}  \t"); 
        }
        
    }
}
}