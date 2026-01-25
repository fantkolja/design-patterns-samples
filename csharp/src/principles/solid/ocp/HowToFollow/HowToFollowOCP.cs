namespace ProgrammingPrinciples.SOLID;

/*
 * Через поліморфізм
 */


// Погано: порушення OCP
public class PaymentProcessor
{
    public void ProcessPayment(string type, decimal amount)
    {
        if (type == "credit")
        {
            // логіка для кредитної картки
        }
        else if (type == "paypal")
        {
            // логіка для PayPal
        }
        // Для додавання нового методу треба змінювати клас
    }
}



// Добре: дотримання OCP
public interface IPaymentMethod
{
    void Process(decimal amount);
}

public class CreditCardPayment : IPaymentMethod
{
    public void Process(decimal amount)
    {
        // логіка кредитної картки
        Console.WriteLine($"Processing credit card payment: {amount}");
    }
}

public class PayPalPayment : IPaymentMethod
{
    public void Process(decimal amount)
    {
        // логіка PayPal
        Console.WriteLine($"Processing PayPal payment: {amount}");
    }
}

// public class PaymentProcessor
// {
//     public void ProcessPayment(IPaymentMethod method, decimal amount)
//     {
//         method.Process(amount);
//     }
// }




/*
 * Через патерн Стратегія
 */

 public interface IValidationStrategy
{
    bool Validate(object data);
}

public class EmailValidator : IValidationStrategy
{
    public bool Validate(object data)
    {
        if (data is string email)
        {
            return System.Text.RegularExpressions.Regex
                .IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$");
        }
        return false;
    }
}

public class PhoneValidator : IValidationStrategy
{
    public bool Validate(object data)
    {
        if (data is string phone)
        {
            return System.Text.RegularExpressions.Regex
                .IsMatch(phone, @"^\+?[\d\s\-()]+$");
        }
        return false;
    }
}

public class Validator
{
    private readonly IValidationStrategy _strategy;
    
    public Validator(IValidationStrategy strategy)
    {
        _strategy = strategy;
    }
    
    public bool Validate(object data)
    {
        return _strategy.Validate(data);
    }
}




/*
 * Через патерн Шаблонний Метод
 */

public abstract class Report
{
    public void Generate()
    {
        CollectData();
        FormatData();
        Export();
    }
    
    protected abstract void CollectData();
    protected abstract void FormatData();
    protected abstract void Export();
}

public class PdfReport : Report
{
    protected override void CollectData()
    {
        Console.WriteLine("Collecting data for PDF");
    }
    
    protected override void FormatData()
    {
        Console.WriteLine("Formatting data for PDF");
    }
    
    protected override void Export()
    {
        Console.WriteLine("Exporting to PDF");
    }
}

public class ExcelReport : Report
{
    protected override void CollectData()
    {
        Console.WriteLine("Collecting data for Excel");
    }
    
    protected override void FormatData()
    {
        Console.WriteLine("Formatting data for Excel");
    }
    
    protected override void Export()
    {
        Console.WriteLine("Exporting to Excel");
    }
}



/*
 * Через систему плагінів
 */

public interface IPlugin
{
    void Execute();
}

public class EmailPlugin : IPlugin
{
    public void Execute()
    {
        Console.WriteLine("Email plugin executed");
    }
}

public class AnalyticsPlugin : IPlugin
{
    public void Execute()
    {
        Console.WriteLine("Analytics plugin executed");
    }
}

public class Application
{
    private readonly List<IPlugin> _plugins = new List<IPlugin>();
    
    public Application Use(IPlugin plugin)
    {
        _plugins.Add(plugin);
        return this;
    }
    
    public void Run()
    {
        foreach (var plugin in _plugins)
        {
            plugin.Execute();
        }
    }
}

// Використання

// var app = new Application()
//     .Use(new EmailPlugin())
//     .Use(new AnalyticsPlugin());
    
// app.Run();



