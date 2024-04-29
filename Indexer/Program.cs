// See https://aka.ms/new-console-template for more information

    class A
{
    private string[] name = new string[3];
    public string this[int i]
    {
        get
        {
            return name[i];
        }
        set
        {
            name[i] = value;
        }

    }
}
class Indexer
{

    public static void Main(String[] args) { 
        A a=new A();
        a[0] = "A";
        a[1] = "B";
        a[2] = "C";
        for(int i=0; i<5; i++)
        {
            Console.WriteLine(a[i]);
        }
        Console.ReadKey();
    }
}

