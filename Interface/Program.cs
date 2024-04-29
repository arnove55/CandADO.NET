// See https://aka.ms/new-console-template for more information
interface A
{
    public void display()
    {
        
    }
}



class c: A
{
    public void display()
    {
        Console.WriteLine("hello from class C");
    }
}

class Interface
{
    public static void Main(String[] args)
    {
        c c= new c();
        c.display();
        Console.ReadKey();  
    }
}
