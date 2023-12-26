using HL_26_12_2023;
using HL_26_12_2023.Entities;

var database = new DataBase();

database.LoadToFile();

foreach (var item in database.GetFeedbacksByUserName("benotar"))
{
    Console.WriteLine(item);
}

User us = database.GetUserByFeedbackID(Guid.Parse("48a1c912-0e11-4731-a7ba-c0d282c15ad7"));
Console.WriteLine(us);