// See https://aka.ms/new-console-template for more information
using A;
namespace A
{
    class aa
    {
        public void show()
        {
            Console.WriteLine("Hello from namespace A");
        }
    }

}

namespace B
{
    class BB
    {
        public void display()
        {
            Console.WriteLine("Hello from namespace B");
        }
    }
    class namespaces
    {
        public static void Main()
        {
            aa a=new aa();
            a.show();
            BB bb=new BB();
            bb.display();
        }
    }
}
