namespace uke1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int heiltall = 250;
        Console.WriteLine(heiltall);
        string tekst = "uke1";
        Console.WriteLine(tekst);
        double dtall = 250.14159;
        Console.WriteLine(dtall);
        char bokstav = 'r';
        Console.WriteLine(bokstav);
        string[] tall = {"0","1","2","3","4"};
        Console.WriteLine(tall.Length);
        for (int i = 0; i < tall.Length; i++)
        {
         Console.WriteLine(tall[i]);

        }
        foreach (string item in tall)
        {
         Console.WriteLine(item); 
        }
    }
}
