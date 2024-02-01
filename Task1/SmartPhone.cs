namespace Task1;

public class SmartPhone :Computer
{
    int NumberOfSelfies;

    public SmartPhone(int num,int ram,int storage,string keyboard) :base(ram,storage,keyboard)
    {
        NumberOfSelfies = num;
    }
    public void TakeSelfies()
    {
        if(NumberOfSelfies >= 0)
        {
            NumberOfSelfies++;
        }else{
            System.Console.WriteLine("You need take a selfie");
        }
    }
}
