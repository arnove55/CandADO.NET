// See https://aka.ms/new-console-template for more information
class Nullable {

    public static void Main(String[] args)
    {
        int? a = null;
        if (a.HasValue)
        {
            Console.WriteLine(a.Value);
        }
        else
        {
            Console.WriteLine("null value");
        }
        int? b = null;
        int c = b ?? 26;
        Console.WriteLine(c);

        int? d = null;
        int e=d.GetValueOrDefault();
        Console.WriteLine(e);


        int ? f = 2;
        int g = 3;

        int h = Nullable.Compare<int>(f, g);

        if (h > 0)
        {
            Console.WriteLine("f is greater than g");
        }
        else if (h < 0)
        {
            Console.WriteLine("f is less than g");
        }
        else
        {
            Console.WriteLine("f is equal to g");
        }
    }

    
    
}
