// See https://aka.ms/new-console-template for more information
class person
{
    public string name="Arnove";
    public virtual void info()
    {
        Console.WriteLine($"Name:{name}");
    }
}
class inter:person
{
    public int id = 708;
    public override void info()
    {
        base.info();
        Console.WriteLine($"ID:{id}"); 
    }
}
class address : inter
{
    public String addre = "Vadodara";
    public override void info()
    {
        base.info();
        Console.WriteLine($"Address:{addre}");
    }

}
class basekeyword { 
    public static void Main(String[] args)
    {
        address i=new address();
        i.info();
        Console.ReadKey();
    }
}

