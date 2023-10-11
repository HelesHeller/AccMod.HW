using System;

class Website
{
    private string websiteName;
    private string websitePath;
    private string ipAddress;

    // Метод для введення даних про веб-сайт
    public void InputData()
    {
        Console.WriteLine("Введіть назву веб-сайту:");
        websiteName = Console.ReadLine();

        Console.WriteLine("Введіть шлях до веб-сайту:");
        websitePath = Console.ReadLine();

        Console.WriteLine("Введіть IP-адресу веб-сайту:");
        ipAddress = Console.ReadLine();
    }

    // Метод для виведення даних про веб-сайт
    public void DisplayData()
    {
        Console.WriteLine($"Назва веб-сайту: {websiteName}");
        Console.WriteLine($"Шлях до веб-сайту: {websitePath}");
        Console.WriteLine($"IP-адреса веб-сайту: {ipAddress}");
    }

    // Методи для доступу до окремих полів через методи класу
    public string GetWebsiteName()
    {
        return websiteName;
    }

    public string GetWebsitePath()
    {
        return websitePath;
    }

    public string GetIpAddress()
    {
        return ipAddress;
    }
}

class Magazine
{
    private string magazineName;
    private int foundingYear;
    private string description;
    private string contactPhone;
    private string email;

    // Метод для введення даних про журнал
    public void InputData()
    {
        Console.WriteLine("Введіть назву журналу:");
        magazineName = Console.ReadLine();

        Console.WriteLine("Введіть рік заснування журналу:");
        foundingYear = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть опис журналу:");
        description = Console.ReadLine();

        Console.WriteLine("Введіть контактний телефон:");
        contactPhone = Console.ReadLine();

        Console.WriteLine("Введіть email:");
        email = Console.ReadLine();
    }

    // Метод для виведення даних про журнал
    public void DisplayData()
    {
        Console.WriteLine($"Назва журналу: {magazineName}");
        Console.WriteLine($"Рік заснування: {foundingYear}");
        Console.WriteLine($"Опис журналу: {description}");
        Console.WriteLine($"Контактний телефон: {contactPhone}");
        Console.WriteLine($"Email: {email}");
    }

    // Методи для доступу до окремих полів через методи класу
    public string GetMagazineName()
    {
        return magazineName;
    }

    public int GetFoundingYear()
    {
        return foundingYear;
    }

    public string GetDescription()
    {
        return description;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public string GetEmail()
    {
        return email;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання класу "Веб-сайт"
        Website website = new Website();
        website.InputData();
        website.DisplayData();

        // Приклад використання класу "Журнал"
        Magazine magazine = new Magazine();
        magazine.InputData();
        magazine.DisplayData();
    }
}
