namespace test
{
    public class Liskov
    {
        
    }

    public abstract class Product
    {
        public string product_name{get;set;}
        public abstract string getName();
        public string getProduct(Product product){
            
            return product.product_name;
        }
    }

    public abstract class FoodProduct:Product
    {
        public abstract void getExpired();
    }

    public class Vegetable:FoodProduct
    {
        public override string getName()
        {
            throw new System.NotImplementedException();
        }
        public override void getExpired()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Smartphone:Product
    {
        public override string getName()
        {
            throw new System.NotImplementedException();
        }
    }
}