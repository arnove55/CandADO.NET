// See https://aka.ms/new-console-template for more information
interface A
{
    void show();
}
interface B
{
    void show();
}

class C : A, B
{
    void A.show()
    {
        Console.WriteLine("Calling show method of A");
    }

    void B.show()
    {
        Console.WriteLine("Calling show method of B");
    }
}
class implecitandexplicitinterface
{
    public static void Main()
    {
        C c = new C();
        ((A)c).show();
        ((B)c).show();
        A c1 = new C();
        c1.show();
        Console.ReadLine(); 

        
    }
}