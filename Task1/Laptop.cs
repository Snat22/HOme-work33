namespace Task1;

public class Laptop : Computer
{
     int _weight ;

    public Laptop(int weight , int ram,int storage,string keyboard) :base(ram,storage,keyboard)
    {
        _weight =weight;
    }    
    public void WeightCheck() 
    {
        System.Console.WriteLine(_weight);
    }
}
