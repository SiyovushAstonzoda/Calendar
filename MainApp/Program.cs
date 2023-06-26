using Domain.Models;
using Infrastructure.Services;

var dateList = new List<Date>();

while (true)
{
    var date = new Date();
    int i = 0;
    ++i;

    Console.WriteLine($"Date #{i}");

    Console.Write("Enter Month: ");
    date.setMonth = Convert.ToInt32(Console.ReadLine());
    if (date.getMonth < 1 || date.getMonth > 12) { Console.WriteLine("Month cannot be less than 1 or more than 12!"); Environment.Exit(0); }

    Console.Write("Enter Day: ");
    date.setDay = Convert.ToInt32(Console.ReadLine());
    if (date.getDay < 1 || date.getDay > 31) { Console.WriteLine("Day cannot be less than 1 or more than 31!"); Environment.Exit(0); }

    Console.Write("Enter Year: ");
    date.setYear = Convert.ToInt32(Console.ReadLine());
    if (date.getYear < 1000 || date.getYear > 9999) { Console.WriteLine("Year cannot be less than 1000 or more than 9999!"); Environment.Exit(0); }

    dateList.Add(date);

    Console.Write($"{Environment.NewLine}Please enter 'exit' or 'Exit' to stop the program or '-' to continue it: ");
    var stop = Console.ReadLine();
    if (stop == "exit" || stop == "Exit")
    {
        break;
    }
}

foreach (var date in dateList)
{
    var dateService = new DateService(date);
    Console.WriteLine($"{Environment.NewLine}Before Increasing: {dateService.toString()}");
    dateService.nextDay();
    Console.WriteLine($"{Environment.NewLine}After Increasing: {dateService.toString()}");
}