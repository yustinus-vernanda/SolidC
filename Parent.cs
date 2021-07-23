using System;

namespace test
{
     interface  Parent
    {
        void fun();

    }

    public class Child:Parent
    {
        public  void fun(){
            Console.WriteLine("Child") ;   
        }
    }

    public class Child1:Child{
        
    }


}