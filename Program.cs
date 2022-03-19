namespace modul4_1302204051;

public class MainClass
{
    public static void Main(string[] args)
    {
        // NIM = 1302204051
        SimpleDataBase<float> objData1 = new SimpleDataBase<float>();
        objData1.AddNewData(13f);
        objData1.AddNewData(02f);
        objData1.AddNewData(20f);
        objData1.PrintAllData();
    }
}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T databaru)
    {
        storedData.Add(databaru);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + " berisi : " + storedData[i] + " yang disimpan pada waktu UTC : " + inputDates[i] + " AM");
        }
    }
}