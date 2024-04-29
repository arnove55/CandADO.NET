// See https://aka.ms/new-console-template for more information
class A
{
    private int a;
    private int b;

    public A(int c, int d) {
        a = c;
        b = d;
    }
    public A()
    {
        a = 1;
        b = 2;
    }
    public int Add()
    {
        return a + b;
    }

}
class practice2
{
    public static void Main()
    {
        A a = new A();
        int result=a.Add();
        Console.WriteLine("default:"+result);
        
        A a2 = new A(3,4);
        int result2=a2.Add();  
        Console.WriteLine("Parameterized construtor:"+result2);
    }
}

