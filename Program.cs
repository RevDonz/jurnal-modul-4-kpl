namespace modul4_1302204051;

public class MainClass
{
    public static void Main(string[] args)
    {
        // NIM = 1302204051
        Penjumlahan.JumlahTigaAngka<float>(12.0f, 02.0f, 20.0f);
    }
}
public class Penjumlahan
{
    public static void JumlahTigaAngka<T>(T data1, T data2, T data3)
    {
        dynamic angka1 = data1;
        dynamic angka2 = data2;
        dynamic angka3 = data3;

        Console.WriteLine(angka1 + angka2 + angka3); 
    }
}