// See https://aka.ms/new-console-template for more information

//class A & B showing is a relationship
class A
{
    public int a;
    public int b;

    public int area()
    {
        return a * b;
    }
    public int perimeter()
    {
        return 2 * (a + b);
    }
}
class B : A
{
    public int c;
    public B(int e,int f,int g)
    {
        a=e;
        b=f;
        c=g;
    }
    public int volume()
    {
        return a * b * c;
    }
}

class address
{
    public String Address, city, state;
    

    public address(string ad, string ci, string st)
    {
        Address = ad;
        city = ci;
        state = st;
    }
}
    class inter
    {
        public address addre;
        public int Id;
        public string Name;

        public inter(address addres,int id, string name)
        {
            addre = addres;
            Id = id;    
            Name = name;    
        }
        public void display()
        {
            Console.WriteLine($"Name:{ Name}");
            Console.WriteLine($"ID:{Id}");
            Console.WriteLine($"Address:{addre}");
        }

    }
class isAhasArelation
{
    public static void Main(String[] args)
    {
        B b = new B(1, 2, 3);
        int h=b.volume();
        Console.WriteLine(h);
       
        address a = new address("M", "Vadodara", "Gujarat");
        inter i = new inter(a,1,"Arnove");
        i.display();
        Console.ReadKey();
        
    }
}