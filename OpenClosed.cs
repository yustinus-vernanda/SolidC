namespace test
{
    public class OpenClosed
    {
        
    }

    public abstract class Pajak
    {
        public Pajak(int _harga){
            this.harga = _harga;
        }
        public int harga{get;set;}
        abstract public int hitungPajak();
    }

    public  class PajakPPN:Pajak{

        public PajakPPN(int _harga):base(_harga)
        {
            harga=_harga;
        }
        public override int hitungPajak(){
            return harga*10/100;
        }

    }

    public class PajakPPH23:Pajak{
        public PajakPPH23(int _harga):base(_harga){
            harga = _harga;
        }

        public override int hitungPajak()
        {
            return harga*20/100;
        }
    }
}