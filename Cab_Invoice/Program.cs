// See https://aka.ms/new-console-template for more information
using Cab_Invoice;

Console.WriteLine("Hello, Welcome to Cab Invoice Generator!");
InvoiceGenerator uc1 = new();
double fare1 = uc1.CalculateFare();
Console.WriteLine("Total Fare for your Journey is :"+fare1);
