using System.Globalization;

Console.Write("Start time:");
string inputStartTime = Console.ReadLine();

Console.Write("End time:");
string inputEndTime = Console.ReadLine();

DateTime dateFromStart = DateTime.Parse(inputStartTime, CultureInfo.InvariantCulture);

DateTime dateFromEnd = DateTime.Parse(inputEndTime, CultureInfo.InvariantCulture);

DateTime start = dateFromStart;
DateTime end = dateFromEnd;

double totalPoisa = 0;
var peakhourstart = new DateTime(dateFromStart.Year, dateFromStart.Month, dateFromStart.Day, 9, 0, 0);
var peakhourend = new DateTime(dateFromStart.Year, dateFromStart.Month, dateFromStart.Day, 22, 59, 59);
var firstOffPeakhourStart = new DateTime(dateFromStart.Year, dateFromStart.Month, dateFromStart.Day, 23, 0, 0);
var firstOffPeakhourEnd = new DateTime(dateFromStart.Year, dateFromStart.Month, dateFromStart.Day, 23, 59, 59);
var secondtOffPeakhourStart = new DateTime(dateFromStart.Year, dateFromStart.Month, dateFromStart.Day, 0, 0, 59);
var secondtOffPeakhourEnd = new DateTime(dateFromStart.Year, dateFromStart.Month, dateFromStart.Day, 8, 59, 59);
while (end > start)
{
    start = start.AddSeconds(20);
    if (start >= peakhourstart && start <= peakhourend) totalPoisa += 30;
    if (start >= firstOffPeakhourStart && start <= firstOffPeakhourEnd) totalPoisa += 20;
    if (start >= secondtOffPeakhourStart && start <= secondtOffPeakhourEnd) totalPoisa += 20;
}

Console.WriteLine($"{Convert.ToDouble(totalPoisa / 100)} taka");

Console.ReadKey();