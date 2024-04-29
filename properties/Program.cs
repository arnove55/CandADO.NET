// See https://aka.ms/new-console-template for more information
class Pro {
    private int a;

    public int A{
        get {return a;}
        set {a = value;}

    }
    public Pro() { 
    
    }
}
class properties {
    public static void Main(String[] args)
    {
        Pro p=new Pro();
        p.A=1;
        Console.WriteLine(p.A);

    }
}

