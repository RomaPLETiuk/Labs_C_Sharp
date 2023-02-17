using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Flowers : IEquatable<Flowers>
{
    
    public virtual int Cost {get; set; } 
    
    public Flowers(){ Cost = 10; }
        
    
    public Flowers(int cost){
        
       Cost = cost; 
        
    }
    
    public override string ToString(){
        
        return string.Format("cost: {0}", Cost );
        
    }
    
    public int Salary() {
        
        return Cost;
        
    }
    
    public override bool Equals(object obj)
    {
        return Equals(obj as Flowers);
    }

    public bool Equals(Flowers other)
    {
        return other != null &&
               Cost == other.Cost;
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Cost);
    }
    
}    
 
public class Rose : Flowers {
    
    public Rose (int cost )
    : base(0)
    {
        
        Cost = cost;
    }
    
    public override string ToString(){
        
        return string.Format(" {0} {1} ", "Rose",  base.ToString()); ; 
        
    }
    
    
    
    
    
} 

public class Peony : Flowers {
    
    public Peony (int cost )
    : base(0)
    {
        
        Cost = cost;
    }
    
    public override string ToString(){
        
        return string.Format(" {0} {1} ", "Peony",  base.ToString()); ; 
        
    }
    
}  

public class Tulip : Flowers {
    
    public Tulip (int cost )
    : base(0)
    {
        
        Cost = cost;
    }
    
    public override string ToString(){
        
        return string.Format(" {0} {1} ", "Tulip",  base.ToString()); ; 
        
    }
    
}    

public class Zinnia : Flowers {
    
    public Zinnia (int cost )
    : base(0)
    {
        
        Cost = cost;
    }
    
    public override string ToString(){
        
        return string.Format(" {0} {1} ", "Zinnia",  base.ToString()); ; 
       
    }
    
}

   
    
    


class Program {
  static void Main() {
      
      Rose r1  = new Rose(120);
      Rose r2 = new Rose(120);
      
      Console.WriteLine (r1.Equals (r2)); // true
      Console.WriteLine (r1 == r2); // false
      
     Flowers[] flowers = new Flowers[5]
            {
                new Rose(120),
                new Zinnia(100),
                new Tulip(90),
                new Rose(150),
                new Peony(125)
            };
            
            
            
            int sum=0;
            Console.WriteLine("***** Букет квітів  *****\n");
            foreach (Flowers f in flowers)
            {
                Console.WriteLine(f.ToString());
                
                 sum  += f.Salary();
                
            }
            
            Console.Write($"\nВартість букет: {sum}  грн.");
            
            
    
  }
}