class Abtomobil
{
    public string _avtoName { get; set; }
    public string _avtoBrand { get; set; }
    public decimal _avtoPrice { get; set; }

    public Abtomobil(string name, string brand, decimal price)
    {
        _avtoName = name;
        _avtoBrand = brand;
        _avtoPrice = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Model: {_avtoPrice}, Marka: {_avtoBrand}, Narx: {_avtoPrice:C}");
    }
}