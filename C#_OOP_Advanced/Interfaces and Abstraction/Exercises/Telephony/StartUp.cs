using System;

public class StartUp
{
    static void Main(string[] args)
    {
        var callNumbers = Console.ReadLine().Split(' ');
        var urlAddresses = Console.ReadLine().Split(' ');

        Smartphone phone = new Smartphone();

        foreach (var number in callNumbers)
        {
            Console.WriteLine(phone.Call(number));
        }

        foreach (var url in urlAddresses)
        {
            Console.WriteLine(phone.Browse(url));
        }
    }
}

