using System;

public class Program
{
    public static void Main()
    {
        KodePos kodePos = new KodePos();

        Console.WriteLine("Kode pos Maleer: " + kodePos.GetKodePos("Maleer"));
        Console.WriteLine("Kode pos Sekejati: " + kodePos.GetKodePos("Sekejati"));
        Console.WriteLine("Kode pos Xyz: " + kodePos.GetKodePos("Xyz")); // yang tidak ada
    }
}
