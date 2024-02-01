namespace Task1;

public class Computer
{
    int Ram;
    int Storage;
    string Keyboard;

    public Computer(){}
    public Computer(int ram,int storage,string keyboard)
    {
        Ram = ram;
        Storage = storage;
        Keyboard = keyboard;
    }
    public void AddRam(int ram)
    {
        Ram += ram;
        System.Console.WriteLine($"Add Ram: {Ram}");
    }
    public void AddStorage(int storage)
    {
            Storage += storage;
            System.Console.WriteLine($"Adding Storage :{Storage}");
        
    }
    public void GetInfo()
    {
        System.Console.WriteLine($" {Ram} {Storage} {Keyboard}");
    }

}
