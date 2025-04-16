using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json;
class bankTransferConfig
{
    public bankTransferConfig()
    {
        LoadConfig();
    }
    public transfer config;
    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "bankTransferConfig.json");
    public void  LoadConfig()
    {
        String configJsonData = File.ReadAllText("D:\\New folder\\ConsoleApp1\\bank_transfer_config.json");
        config = JsonSerializer.Deserialize<transfer>(configJsonData);
        
    }

}

class transfer
{
    public string lang { get; set; }
    public string low_fee { get; set; }
    public string high_fee { get; set; }
    public string methods { get; set; }
    public string en { get; set; }
    public string id { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        bankTransferConfig bankTransfer = new bankTransferConfig();
        Console.WriteLine("CONFIG1: " + bankTransfer.config.lang);
        Console.WriteLine("CONFIG2: " + bankTransfer.config.low_fee);
        Console.WriteLine("CONFIG3: " + bankTransfer.config.high_fee);
        Console.WriteLine("CONFIG4: " + bankTransfer.config.methods);
        Console.WriteLine("CONFIG5: " + bankTransfer.config.en);
        Console.WriteLine("CONFIG6: " + bankTransfer.config.id);

        Console.WriteLine("Pilih bahasa: (en/id)");
        Console.ReadLine();

        if (bankTransfer.config.lang == "en")
        {
            Console.WriteLine("Bahasa yang dipilih: " + bankTransfer.config.en);
        }
        else if (bankTransfer.config.lang == "id")
        {
            Console.WriteLine("Bahasa yang dipilih: " + bankTransfer.config.id);
        }
        else
        {
            Console.WriteLine("Bahasa tidak valid");
        }
    } 
    if bankTransfer.config.transfer_methods == "low_fee"
    {
        Console.WriteLine("Transfer method: " + bankTransfer.config.low_fee);
    }
    else if (bankTransfer.config.transfer_methods == "high_fee")
{
    Console.WriteLine("Transfer method: " + bankTransfer.config.high_fee);
}
else
{
    Console.WriteLine("Transfer method tidak valid");
}
}
