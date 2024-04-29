// See https://aka.ms/new-console-template for more information
using System;
class A {
    public void start() {
        Console.WriteLine("start");
    }
    public void stop()
    {
        Console.WriteLine("Stop");
    }
}
class B
{
    private A a;
    public B() {
        a = new A();
    }
    public void bstart()
    {
        a.start();
        Console.WriteLine("B started");
    }
    public void bstop()
    {
        a.stop();
        Console.WriteLine("B stop");
    }
}
class hasArelationship {

    public static void main(String[] args)
    {
        B b = new B();
        b.bstart();
        b.bstop();
    }
}
