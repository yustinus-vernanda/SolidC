using System;

namespace test
{
    public class Dependency
    {
        
    }

    public class CarDep
    {
        public void start(Engine InterfaceEngine)
        {
            InterfaceEngine.start();
        }

    }

    public interface Engine{
        void start();
    }

    public class DieselEngine:Engine
    {
        public void start(){
            Console.WriteLine("Diesel");
        }
    }

    
    public class GasEngine:Engine
    {
        public void start(){
            Console.WriteLine("Gas");
        }
    }

}