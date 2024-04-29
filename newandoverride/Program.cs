// See https://aka.ms/new-console-template for more information
class A
{
    public virtual void show()
    {
        Console.WriteLine("base class method");
    }
}
class B : A
{
    public new void show()
    {
        Console.WriteLine("derived B class method");
    }
}
class C : A
{
    public override void show()
    {
        Console.WriteLine("Derived C class method");

    }
}
class newandoverride
{
    public static void Main(String[] args)
    {
        A a = new A();
        a.show();  
        B b= new B();   
        b.show();

        A b1 = new B();
        b1.show();

        C c= new C();
        c.show();
        Console.ReadKey();
    }
}