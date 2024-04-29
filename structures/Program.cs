// See https://aka.ms/new-console-template for more information

class A
{
    public struct intern
    {
        public String name;
        public int id;
        public String address;
    };
    public void display()
    {
        intern i;
        i.name = "Arnove";
        i.id = 708;
        i.address = "Vadodara";
        Console.WriteLine("Id:{0}", i.id);
        Console.WriteLine("Name:{0}", i.name);
        Console.WriteLine("Address:{0}", i.address);
    }

}
class structures
{
    public static void Main(String[] args)
    {
        A a = new A();
        a.display();
        Console.ReadLine();
       
        
    }
}

