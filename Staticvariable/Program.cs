// See https://aka.ms/new-console-template for more information
class A
{
    public static float pi = 3.14f;

    public float area(float r)
    {
        return pi * r * r;
    }
   
   

   
}
class StaticVariable
{
    public static void Main(String[] args)
    {
        A a = new A();
        float c=a.area(2);
        Console.WriteLine(c);

        int d=(int)a.area(4);
        Console.WriteLine(d);   


    }
}
