using System.Linq;

public class Smartphone : ICall, IBrowse
{
    public string Browse(string urlAddress)
    {
        return ValidUrlAddress(urlAddress)
            ? "Invalid URL!"
            : $"Browsing: {urlAddress}!";
    }

    public string Call(string callNumber)
    {
        return ValidCallNumber(callNumber)
            ? $"Calling... {callNumber}"
            : "Invalid number!";
    }

    private bool ValidUrlAddress(string urlAddress)
    {
        bool containsDigit = urlAddress.Any(char.IsDigit);
        return containsDigit;
    }

    private bool ValidCallNumber(string callNumber)
    {
        bool containsOnlyDigit = callNumber.All(char.IsDigit);
        return containsOnlyDigit;
    }
}

