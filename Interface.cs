namespace test
{
    public class Interface
    {
        
    }

    interface VehicleInterface
    {
        void drive();
        void stop();
        void refuel();

    }

    interface DoorInterface
    {
        void door();
    }

    public class Motor:VehicleInterface{
        public void drive(){

        }
        public void stop(){
            
        }
        public void refuel(){
            
        }
    }

    public class Car:VehicleInterface,DoorInterface{
        public void drive(){

        }
        public void stop(){
            
        }
        public void refuel(){
            
        }
        public void door(){
            
        }
    }
}