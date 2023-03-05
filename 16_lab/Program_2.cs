using System;
using System.Collections.Generic;

    
    namespace Myevent
    {
        
        delegate void EventHandler(ConsoleKeyInfo k);
        
        class ClassWithEvent
        {
            public event EventHandler AnyKeyPress; 
                                                     
            public void fire()
            {
                if (AnyKeyPress != null)
                {
                    ConsoleKeyInfo k = Console.ReadKey(true);
                    AnyKeyPress(k);
                }
            }
        }
        class Program
        {
            static void handler(ConsoleKeyInfo k)
            {
                char c = k.KeyChar;
                Console.WriteLine("Вiдбулася подiя: натискання клавiшi '{0}'", c);
            if (c == 'r') {
                Console.WriteLine("Roman Pletiuk ");
            }

            }
            static void Main()
            {
                
            ClassWithEvent evt = new ClassWithEvent(); 
                
            
                evt.AnyKeyPress += new EventHandler(handler);
               
                evt.fire();
                Console.ReadKey();
            }
        }
    }


