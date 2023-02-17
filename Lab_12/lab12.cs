// 1. Створити клас з прихованими полями, конструкторами з параметрами та 
// без параметрів, методами, властивостями і перевантаженими операціями 
// відповідно варіанту.
// 2. Розроблена програма повинна містити перевірку усіх розроблених 
// елементів класу.
// 3. Необхідно також перевизначити метод ToString() та метод Equals().
//
//                         Варіант 16 (1).
// Створити базовий клас «комплексне число», такий, що:
// a) його екземпляр містить дійсну і уявну частину - змінні з плаваючою 
// точкою.
// b) його конструктор без параметра створює екземпляр зі значенням 0.0 + 
// i0 .0, а конструктор з параметрами створює екземпляр з відповідною 
// дійсної та уявної частиною.
// c) його властивості дозволяють отримувати і присвоювати значення дійсної 
// та уявної частини.
// d) метод ToString() повертає рядок у вигляді 0.00 ± i0.00.
// e) операція «+» перевантажена: для двох комплексних чисел обчислює 
// суму, складаючи окремо дійсні частини і окремо - уявні частини; при
// додаванні з дійсним числом збільшується тільки дійсна частина.
// Скласти програму, яка перевіряє виконання перерахованих функцій.

using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Complex {
    
    private double r, i;
    
    public double I {get => i; set => i = value; }
    public double R {get => r; set => r = value;}
    
    public Complex(){
        this.R = 0.0;
        this.I = 0.0;
    }
    
    
    public Complex(double a, double b ){
        R = a;
        I = b;
        
    }
    
    public static Complex operator +(Complex a, Complex b ) {
        
       return new Complex(a.R+b.R, a.I+b.I); 
        
    }
    
    public override string ToString(){
        
        return String.Format("{0} + i {1}", this.R, this.I);
        
        
    }
    
    public void PrintLine(Complex a){
        
        Console.WriteLine(a);
        
    }
 
}


class Program {
  static void Main() {
    Complex c1= new Complex(1.2, 2.2);
    Complex c2 = new Complex();
    
   // c1.R=1.2; c1.I = 2.2;
    
    c2.R=1.4; c2.I=3.1;
    
    c1.PrintLine(c1);
    c2.PrintLine(c2);
    
    Console.WriteLine("<+>:   {0}+{1}i", c1.R+c2.R, c1.I+c2.I);
    
    
  }
}